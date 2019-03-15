using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpensesApp.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Joko")]
[assembly: ExportEffect(typeof(SelectedEffect), "SelectedEffect")]
namespace ExpensesApp.iOS.Effects
{

        public class SelectedEffect : PlatformEffect
        {
            public SelectedEffect()
            {

            }
            protected override void OnAttached()
            {

            }

            protected override void OnDetached()
            {
                throw new NotImplementedException();
            }


        }
    }
