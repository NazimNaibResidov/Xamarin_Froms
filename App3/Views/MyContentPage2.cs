using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.Views
{
  public  class MyContentPage2:ContentPage
    {
        public MyContentPage2()
        {
            Label label = new Label
            {
                Text = "Xamarin Salamlar",
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Content = label;
        }
    }
}
