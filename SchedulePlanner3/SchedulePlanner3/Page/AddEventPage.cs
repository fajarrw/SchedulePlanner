using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    public class AddEventPage : ContentPage
    {
        Entry etyName;
        Entry etyCategory;
        DatePicker dprStartEvent;
        TimePicker tprStartEvent;
        DatePicker dprFinishEvent;
        TimePicker tprFinishEvent;
        Button btnAddEvent;
        public AddEventPage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "Name: " });
            layout.Children.Add(etyName = new Entry());
            layout.Children.Add(new Label { Text = "Category: " });
            layout.Children.Add(etyCategory = new Entry());
            layout.Children.Add(new Label { Text = "Start:  " });
            layout.Children.Add(dprStartEvent = new DatePicker());
            layout.Children.Add(tprStartEvent = new TimePicker());
            layout.Children.Add(new Label { Text = "Finish: " });
            layout.Children.Add(dprFinishEvent = new DatePicker());
            layout.Children.Add(tprFinishEvent = new TimePicker());
            layout.Children.Add(btnAddEvent = new Button { Text = "Add Event" });

            btnAddEvent.Clicked += OnAddEvent;

            this.Content = layout;
        }

        public void OnAddEvent(object sender, EventArgs e)
        {
            //simpan entry, datepicker, timepicker ke database
        }
    }
}
