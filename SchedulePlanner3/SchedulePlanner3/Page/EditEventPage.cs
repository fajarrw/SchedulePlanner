using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    class EditEventPage : ContentPage
    {
        public EditEventPage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "This is EditEventPage" });

            this.Content = layout;
        }
        
    }
}
