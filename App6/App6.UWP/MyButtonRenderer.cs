using App6.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using App6;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]

namespace App6.UWP
{
    public class MyButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {


            base.OnElementChanged(e);
            //if(Control != null)
            //{
            //    Control.BorderRadius = Element.CornerRadius;
            //}

        }
        //protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == "BorderRadius")
        //    {
        //        if (Control.BorderRadius >= 0)
        //        {
        //            base.OnElementPropertyChanged(sender, e);
        //        }
        //    }

        //}
    }
}
