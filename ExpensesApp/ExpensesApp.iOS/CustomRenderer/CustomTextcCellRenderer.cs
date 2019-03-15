using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpensesApp.iOS.CustomRenderer;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TextCellRenderer), typeof(CustomTextcCellRenderer))]

namespace ExpensesApp.iOS.CustomRenderer
{
	
	public class CustomTextcCellRenderer:TextCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell= base.GetCell(item, reusableCell, tv);
			switch(item.StyleId)
			{
				case "none":
					cell.Accessory = UITableViewCellAccessory.None;
					break;
				case
					"checkmark":
					cell.Accessory = UITableViewCellAccessory.Checkmark;
					break;
				case
					"detail-button":
					
					break;
				case
					"detail-disclosure-button":

					
					break;

				case
					"disclosure":
					
					break;
				default:
					break;
			}
			return cell;
		}
	}
}