using System;
using System.Collections.Generic;
using Xamarin.Forms;

using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace ClockApp
{
    public partial class ClockHands : ContentView
    {
        SKPaint backgroundBrush = new SKPaint()
        {
            Style = SKPaintStyle.Fill,
            Color = Color.Red.ToSKColor()
        };

        public ClockHands()
        {
            InitializeComponent();
            StartClock();
        }

        private void StartClock()
        {

        }

        private void ClockHandsCanvas_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            // get density
            float density = info.Size.Width / (float)Width;

            var clockView = view

            canvas.DrawRect(new SKRect(0, 0, 100, 100), backgroundBrush);
            
        }
    }
}
