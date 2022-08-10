using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace App04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button myButton = new Button();

            myButton.Text = "Eu sou diferente!";
            myButton.TextColor = Color.DarkViolet;

            Container.Children.Add(myButton);
        }
    }
}
