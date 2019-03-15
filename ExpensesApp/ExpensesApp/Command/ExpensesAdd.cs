using ExpensesApp.Views;
using ExpensesApp.Vm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ExpensesApp.Command
{
   public class ExpensesAdd :ICommand
    {
        public NavigateVM navigateVM { get; set; }
        public ExpensesList expensesList { get; set; }
        //protected IUserDialogs Dialogs { get; }
        //private IUserDialogs Dialogs = UserDialogs.Instance;
        public ExpensesAdd(NavigateVM navigateVM)
        {
            this.navigateVM= navigateVM;
           
            // this.Dialogs = UserDialogs.Instance;

        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
           
            
            return true;
        }

        public async void Execute(object parameter)
        {




          await  App.Current.MainPage.Navigation.PushAsync(new ExpensesAddPage());




        }
    }

}
