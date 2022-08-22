using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App06.Controls
{
    internal class CustomBoxView : BoxView
    {
        public static readonly BindableProperty espessuraProperty = BindableProperty.Create<CustomBoxView, double>(
            p => p.Espessura, default(double)
            );

        public double Espessura 
        {
            get { return (double)GetValue(espessuraProperty); }
            set { SetValue(espessuraProperty, value); }
        }
    }
}
