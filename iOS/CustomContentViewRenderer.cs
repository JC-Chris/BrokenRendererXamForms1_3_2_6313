using System;
using Xamarin.Forms;
using BrokenRendererXamForms1_3_2_6313;
using BrokenRendererXamForms1_3_2_6313.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomContentView), typeof(CustomContentViewRenderer))]
namespace BrokenRendererXamForms1_3_2_6313.iOS
{
    public class CustomContentViewRenderer : ViewRenderer
    {
        public CustomContentViewRenderer()
        {
        }
    }
}

