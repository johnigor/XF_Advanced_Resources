﻿using System;
using Xamarin.Forms;

namespace App01.Lib
{
    public class EmailValidoTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.Text.Contains("@"))
            {
                sender.TextColor = Color.Green;
            }
            else
            {
                sender.TextColor = Color.Red;
            }
        }
    }
}
