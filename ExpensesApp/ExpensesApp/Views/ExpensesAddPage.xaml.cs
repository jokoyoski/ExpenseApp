using ExpensesApp.Model;
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
	public partial class ExpensesAddPage : ContentPage
	{
        public ExpensesAddVM expensesAddVM { get; set; }
        public ExpensesAddPage()
        {
            expensesAddVM = new ExpensesAddVM();
            BindingContext = expensesAddVM;
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

			ExpensesList expensesList = new ExpensesList();
            BindingContext = new ExpensesAddVM
            {
                expenseTypesList =await expensesAddVM.Display()
            };


        }



        

    }
}
	