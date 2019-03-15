using ExpensesApp.Command;
using ExpensesApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Vm
{
    public class ExpensesAddVM : INotifyPropertyChanged
    {

       // public ObservableCollection<ExpenseType> ExpensesTypeList { get; set; }
        public SaveExpensesComand saveExpensesComand { get; set; }
        public ExpensesAdd expensesAdd { get; set; }
		

		public ExpensesAddVM( )
        {
            Date = DateTime.Now;
            //ExpensesTypeList = new ObservableCollection<ExpenseType>();
            saveExpensesComand = new SaveExpensesComand(this);
			this.expenseTotal = new List<Expenses>();

        }
		public List<Expenses> expenseTotal { get; set; }

		public List<ExpenseType> expenseTypesList { get; set; }
        private Expenses expenses;

        public Expenses Expenses
        {
            get { return expenses; }
            set
            {
                expenses = value;


                OnPropertyChanged("Expenses");
            }
        }




        private string expensesName;

        public string ExpensesName
        {
            get { return expensesName; }
            set
            {
                expensesName = value;
               expenses = new Expenses
                {
                    Amount=this.Amount,
                    ExpensesName=this.ExpensesName,
                    ShortDescription=this.ShortDescription,
                    date=this.date

                };
                OnPropertyChanged("ExpensesName");
            }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                var Expenses = new Expenses
                {
                    Amount = this.Amount,
                    ExpensesName = this.ExpensesName,
                    ShortDescription = this.ShortDescription,
                    date = this.date

                };
                OnPropertyChanged("Amount");
            }
        }


        private string shortDescription;

        public string ShortDescription
        {
            get { return shortDescription; }
            set
            {
                shortDescription = value;
                 Expenses = new Expenses
                {
                    Amount = this.Amount,
                    ExpensesName = this.ExpensesName,
                    ShortDescription = this.ShortDescription,
                    date = this.date

                };
                OnPropertyChanged("Amount");
            }
        }


        private ExpenseType expenseType;

        public ExpenseType ExpenseType
        {
            get { return expenseType; }
            set
            {
                expenseType = value;
                Expenses = new Expenses
                {
                    Amount = this.Amount,
                    ExpensesName = this.ExpensesName,
                    ShortDescription = this.ShortDescription,
                    date = this.date,
                    ExpensesType = this.ExpenseType.Type,
                    

                };
                OnPropertyChanged("ExpenseType");
            }
        }


        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                Expenses = new Expenses
                {
                    Amount = this.Amount,
                    ExpensesName = this.ExpensesName,
                    ShortDescription = this.ShortDescription,
                    date = this.date

                };
                OnPropertyChanged("Date");
            }
        }




        public  async Task<List<ExpenseType>> Display()
        {
            List<ExpenseType> list = new List<ExpenseType>();
            List<ExpenseType> expenseTypes = new List<ExpenseType>();
            list.Add(new ExpenseType
            {
                Id = 2,
                Type = "Data"
            });
            list.Add(new ExpenseType
            {
                Id = 4,
                Type = "Food"
            });
            list.Add(new ExpenseType
            {
                Id = 45,
                Type = "Clothing"
            });
            list.Add(new ExpenseType
            {
                Id = 44,
                Type = "Logistics"
            });

           

            return list;



            
        }
    
    public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }




    }
}
