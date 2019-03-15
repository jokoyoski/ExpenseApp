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
	public partial class MainPage : TabbedPage
	{
        public NavigateVM navigateVM { get; set; }
		public MainPage ()
		{
            navigateVM = new NavigateVM();
            BindingContext = navigateVM;
			InitializeComponent ();
		}
	}
}