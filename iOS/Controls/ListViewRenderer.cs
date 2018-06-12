using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ListView), typeof(ListViewRefreshExample.iOS.Controls.ListViewRenderer))]
namespace ListViewRefreshExample.iOS.Controls
{
    class ListViewRenderer : Xamarin.Forms.Platform.iOS.ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                this.Control.IsAccessibilityElement = false;
            }
        }
    }
}