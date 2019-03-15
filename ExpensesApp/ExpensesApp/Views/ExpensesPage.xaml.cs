using ExpensesApp.Client;
using ExpensesApp.Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpensesApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExpensesPage : ContentPage
	{

        
        public ExpensesList expensesList { get; set; }
        public ExpensesPage ()
		{
            expensesList = new ExpensesList();
            BindingContext = expensesList;
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           
            BindingContext = new ExpensesList
            {
                ExpenseTotal = expensesList.Display()

            };
           
        }
    }
}