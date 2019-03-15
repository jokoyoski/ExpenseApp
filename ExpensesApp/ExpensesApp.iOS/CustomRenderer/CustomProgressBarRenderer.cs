using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using ExpensesApp.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(ProgressBar),typeof(CustomProgressBarRenderer))]
namespace ExpensesApp.iOS
{
	
	public class CustomProgressBarRenderer:ProgressBarRenderer
	{
		//custom renderer for ios
		protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
		{
			base.OnElementChanged(e);

			if (double.IsNaN(e.NewElement.Progress))
				Control.ProgressTintColor = Color.FromHex("#00B9AE").ToUIColor();
			else if (e.NewElement.Progress < 0.3)
				Control.ProgressTintColor = Color.FromHex("#008dd5").ToUIColor();
			else
				Control.ProgressTintColor = Color.FromHex("#e01a4f").ToUIColor();
			LayoutSubviews();
		}
		public override void LayoutSubviews()
		{

			base.LayoutSubviews();
			float x = 1.0f;
			float y = 4.0f;

			CGAffineTransform transform = CGAffineTransform.MakeScale(x, y);
			Transform = transform;
			base.LayoutSubviews();
		}
	}
}