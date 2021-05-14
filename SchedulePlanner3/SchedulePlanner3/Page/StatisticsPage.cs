using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    public class StatisticsPage : ContentPage
    {
        public StatisticsPage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "This is StatisticsPage" });

            this.Content = layout;
        }
    }
}
