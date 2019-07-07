using App3.Maste;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.Views
{
   public class MyDetaylPage:MasterDetailPage
    {
        public MyDetaylPage()
        {
            Master = new MyMenu();
            Detail = new MyDetayl();
        }
    }
}
