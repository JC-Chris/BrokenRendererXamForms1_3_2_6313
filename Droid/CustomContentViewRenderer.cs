using System;
using Xamarin.Forms;
using BrokenRendererXamForms1_3_2_6313;
using BrokenRendererXamForms1_3_2_6313.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomContentView), typeof(CustomContentViewRenderer))]
namespace BrokenRendererXamForms1_3_2_6313.Droid
{
    public class CustomContentViewRenderer : ViewRenderer
    {
        public CustomContentViewRenderer()
        {
        }
    }
}

