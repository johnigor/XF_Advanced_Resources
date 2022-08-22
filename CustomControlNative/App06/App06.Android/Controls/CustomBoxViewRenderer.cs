using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using App06.Controls;
using System.ComponentModel;
using Rect = Android.Graphics.Rect;

[assembly:ExportRenderer(typeof(CustomBoxView), typeof(App06.Droid.Controls.CustomBoxViewRenderer))]
namespace App06.Droid.Controls
{
    public class CustomBoxViewRenderer : BoxRenderer
    {
        public CustomBoxViewRenderer()
        {
            SetWillNotDraw(false);
        }
        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);

            CustomBoxView control = (CustomBoxView)Element;

            Paint paint = new Paint();
            paint.StrokeWidth = (float)control.Espessura;
            paint.Color = Android.Graphics.Color.Black;
            paint.SetStyle(Paint.Style.Stroke);

            Rect rect = new Rect(0, 0, 200, 200);

            canvas.DrawLine(100, 0, 100, 200, paint);

            canvas.DrawLine(0, 100, 200, 100, paint);

            canvas.DrawRect(rect, paint);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Invalidate();
        }
    }
}