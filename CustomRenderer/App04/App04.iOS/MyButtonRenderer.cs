using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(App04.Customs.MyButton), typeof(App04.iOS.MyButtonRenderer))]
namespace App04.iOS
{
    internal class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.CornerRadius = 10;
                Control.ClipsToBounds = true;
                Control.BackgroundColor = UIColor.Magenta;
            }
        }
    }
}
