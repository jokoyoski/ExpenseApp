using ExpensesApp.Client;
using ExpensesApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ExpensesApp.Vm
{
    public class ExpensesList : INotifyPropertyChanged
    {
        public ObservableCollection<Expenses> ExpensesLists { get; set; }

        public List<Expenses> ExpenseTotal { get; set; }
        public ExpensesList( )
        {
            ExpensesLists = new ObservableCollection<Expenses>();


        }
        //public List<Profile> ProfileList { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public List<Expenses>   Display()
        {
            ////using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            ////{



            ////RestClient rest = new RestClient();
            //var post = await rest.ListExpenses();

            

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {

                conn.CreateTable<Expenses>();// get the table
                if (ExpensesLists != null)
                {                      // clearing the list
                    ExpensesLists.Clear();
                }
                var post = conn.Table<Expenses>().ToList();   //return list of  info from db


                return post;
                ////adding the list to observable
                //foreach (var j in post)
                //    ExpensesLists.Add(j);
            }

            
        }
    }
}
    