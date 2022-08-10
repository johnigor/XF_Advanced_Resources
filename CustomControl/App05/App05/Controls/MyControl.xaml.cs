using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyControl : ContentView
    {
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(
            propertyName: "Titulo",
            returnType: typeof(string),
            declaringType: typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloPropertyChanged
            );

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        private static void TituloPropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {

        }
        public MyControl()
        {
            InitializeComponent();
        }
    }
}