using App3.TabbedSlider;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.Views
{
  public  class MyCoruselPages:CarouselPage
    {
        public MyCoruselPages()
        {
            Children.Add(new Ikinci());
            Children.Add(new Ucuncu());
            Children.Add(new Dorduncu());
        }
    }
}
