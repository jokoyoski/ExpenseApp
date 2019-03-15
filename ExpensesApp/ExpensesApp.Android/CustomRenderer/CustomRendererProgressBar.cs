using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ExpensesApp.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ProgressBar = Xamarin.Forms.ProgressBar;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(CustomRendererProgressBar))]
namespace ExpensesApp.Droid.CustomRenderer
{
	public class CustomRendererProgressBar: ProgressBarRenderer
	{
		public CustomRendererProgressBar(Context context):base(context)
		{

		}

		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
		{
			
			base.OnElementChanged(e);

			if (double.IsNaN(e.NewElement.Progress))
				Control.ProgressDrawable.SetTint( Color.FromHex("##d4ff00").ToAndroid());
			else if (e.NewElement.Progress < 0.3)
				Control.ProgressDrawable.SetTint(Color.FromHex("#FF6A00").ToAndroid());
			else if (e.NewElement.Progress < 0.5)
				Control.ProgressDrawable.SetTint(Color.FromHex("#5C6BC0").ToAndroid());
			else if (e.NewElement.Progress < 0.7)
				Control.ProgressDrawable.SetTint(Color.FromHex("#2F440E").ToAndroid());
			else if (e.NewElement.Progress < 0.9)
				Control.ProgressDrawable.SetTint(Color.FromHex("#0E2F44").ToAndroid());
            else if (e.NewElement.Progress ==1)
                Control.ProgressDrawable.SetTint(Color.FromHex("#D4FF00").ToAndroid());
            else
				Control.ProgressDrawable.SetTint(Color.FromHex("#d4ff00").ToAndroid());
			Control.ScaleY = 4.0f;
			
		}
	}
}