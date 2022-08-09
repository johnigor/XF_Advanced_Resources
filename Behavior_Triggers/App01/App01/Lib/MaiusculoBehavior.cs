using System;
using Xamarin.Forms;

namespace App01.Lib
{
    public class MaiusculoBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += ConverterParaMaiusculo;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= ConverterParaMaiusculo;
        }

        private void ConverterParaMaiusculo(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrEmpty(args.NewTextValue))
            {
                ((Entry)sender).Text = args.NewTextValue.ToUpper();
            }
        }
    }
}
