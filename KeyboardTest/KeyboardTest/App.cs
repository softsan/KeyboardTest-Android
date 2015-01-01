using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KeyboardTest
{
    using System.Linq.Expressions;

    public class App
    {
        public static Page GetMainPage()
        {
            var t1 = new MyEntry();
            var t2 = new MyEntry();
           //  t1.Completed += (sender, args) => t2.Focus();
            var layout = new StackLayout() { Children = { t1, t2 } };

            return new ContentPage
            {
                Content = layout
            };
        }
    }

    public class MyEntry : Entry
    {
    }
}
