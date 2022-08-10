using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyControl : ContentView
    {
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        public Color TituloCor
        {
            get { return (Color)GetValue(TituloCorProperty); }
            set { SetValue(TituloCorProperty, value); }
        }

        //Title
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(
            propertyName: "Titulo",
            returnType: typeof(string),
            declaringType: typeof(MyControl),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloPropertyChanged
            );

        private static void TituloPropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var myControl = (MyControl)bindable;

            myControl.titulo.Text = (string)newValue;

        }

        //Title Color
        public static readonly BindableProperty TituloCorProperty = BindableProperty.Create(
            propertyName: "TituloCor",
            returnType: typeof(Color),
            declaringType: typeof(MyControl),
            defaultValue: Color.Black,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TituloCorPropertyChanged
            );

        private static void TituloCorPropertyChanged(BindableObject bindable, Object oldValue, Object newValue)
        {
            var myControl = (MyControl)bindable;

            myControl.titulo.TextColor = (Color)newValue;
        }

        public MyControl()
        {
            InitializeComponent();
        }
    }
}