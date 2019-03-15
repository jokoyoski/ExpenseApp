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
	public partial class CategoriesPage : ContentPage
	{
		public CategoriesVM categoriesVM { get; set; }
		public CategoriesPage ()
		{
			categoriesVM = new CategoriesVM();
			BindingContext = categoriesVM;
			InitializeComponent ();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			var category = new CategoriesVM();
			BindingContext = new CategoriesVM
			{
				ExpensesLists = categoriesVM.Display()
		};
			
		}
	}
}