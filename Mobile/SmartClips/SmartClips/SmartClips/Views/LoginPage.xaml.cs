﻿using System;
using SkiaSharp.Views.Forms;
using SmartClips.Animations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartClips.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        readonly HighlightForm _highlightForm;

        public LoginPage()
        {
            InitializeComponent();

            var settings = new HighlightSettings()
            {
                StrokeWidth = 6,
                StrokeStartColor = Color.FromHex("#FF4600"),
                StrokeEndColor = Color.FromHex("#CC00AF"),
                AnimationDuration = TimeSpan.FromMilliseconds(900),
                AnimationEasing = Easing.CubicInOut,
            };

            _highlightForm = new HighlightForm(settings);
        }

        void EntryFocused(object sender, FocusEventArgs e)
        {
            _highlightForm.HighlightElement((View)sender, _skCanvasView, _formLayout);
        }

        void ButtonClicked(object sender, EventArgs e)
        {
            _highlightForm.HighlightElement((View)sender, _skCanvasView, _formLayout);
        }

        void SkCanvasViewPaintSurfaceRequested(object sender, SKPaintSurfaceEventArgs e)
        {
            _highlightForm.Draw(_skCanvasView, e.Surface.Canvas);
        }

        void SkCanvasViewSizeChanged(object sender, EventArgs e)
        {
            _highlightForm.Invalidate(_skCanvasView, _formLayout);
        }
    }
}
