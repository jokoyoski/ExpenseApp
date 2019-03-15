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
   public  class CategoriesVM
    {
        public List<Category> ExpensesLists { get; set; }


        public CategoriesVM()
        {
            ExpensesLists = new List<Category>();


        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
		public List<Category> Display()
		{
			//using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
			//{


			List<Category> posts = new List<Category>();
			List<Dictionary<string, double>> listo = new List<Dictionary<string, double>>();

			//RestClient rest = new RestClient();
			//var  post =  rest.ListExpenses();
			using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
			{

				conn.CreateTable<Expenses>();// get the table
				if (ExpensesLists != null)
				{                      // clearing the list
					ExpensesLists.Clear();
				}
				var post = conn.Table<Expenses>().ToList();   //return list of  info from db



				foreach (var j in post)
				{
					Dictionary<string, double> dico = new Dictionary<string, double>();
					{
						dico.Add(j.ExpensesType, j.Amount);

					};
					listo.Add(dico);

				}

				List<Category> Lists = new List<Category>();
				double DataAmount = 0.0;
				double FoodAmount = 0.0;
				double LogisticsAmount = 0.0;
				double ClothingAmount = 0.0;
				foreach (var s in listo)
				{

					if(s.ContainsKey("Data"))
					{
						DataAmount = +s["Data"];
					}

					if (s.ContainsKey("Food"))
					{
						FoodAmount = +s["Food"];
					}

					if (s.ContainsKey("Logistics"))
					{
						LogisticsAmount = +s["Logistics"];
					}


					if (s.ContainsKey("Clothing"))
					{
						ClothingAmount = +s["Clothing"];
					}

					



				}
                Lists.Add(new Category
                {

                    CategoryType = "Data",
                    percentage = DataAmount / 1000,
                   
                    
				});

				Lists.Add(new Category
				{

					CategoryType = "Food", 
					percentage = FoodAmount / 1000 ,
				});
				Lists.Add(new Category
				{

					CategoryType = "Logistics",
					percentage = LogisticsAmount / 1000,
				});

				Lists.Add(new Category
				{

					CategoryType = "Clothing",
					percentage = ClothingAmount / 100 *0.1,
				});



				//if(j.ExpensesType=="Data")
				//{
				//    var total =+j.Amount;
				//}

				//if (j.ExpensesType == "Biscuit")
				//{
				//    var total = +j.Amount;
				//}

				//if (j.ExpensesType == "Biscuit")
				//{
				//    var total = +j.Amount;
				//}
				//if (j.ExpensesType == "Logistics")
				//{
				//    var total = +j.Amount;
				//}






				return Lists;

			}
		}



    }
}
