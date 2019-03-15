using ExpensesApp.Client;
using ExpensesApp.Model;
using ExpensesApp.Views;
using ExpensesApp.Vm;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XF.Material.Forms.UI.Dialogs;

namespace ExpensesApp.Command
{
   public class SaveExpensesComand:ICommand
    {
        public NavigateVM navigateVM { get; set; }
        //protected IUserDialogs Dialogs { get; }
        //private IUserDialogs Dialogs = UserDialogs.Instance;
        public SaveExpensesComand(ExpensesAddVM expensesAddVM)
        {
            this.navigateVM = navigateVM;
            // this.Dialogs = UserDialogs.Instance;

        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {


            return true;
        }

        public async void Execute(object parameter)
        {
            var expenses = (Expenses)parameter;

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);

           var loadingDialog = await MaterialDialog.Instance.LoadingDialogAsync(message: "Saving");
            conn.CreateTable<Expenses>(); //create table and insert
            int rows = conn.Insert(expenses); //it returns new rows inserted
            conn.Close();  //it is import

            await loadingDialog.DismissAsync();
            await App.Current.MainPage.Navigation.PushAsync(new MainPage());

            //// RestClient restClient = new RestClient();
            ////await  restClient.SaveExpenses(expenses);



        }
    }
}
