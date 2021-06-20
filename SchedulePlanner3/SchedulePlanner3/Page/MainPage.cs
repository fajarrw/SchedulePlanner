using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    public class MainPage : ContentPage
    {
        Button btnMoveToAddEvent;
        Button btnMoveToStatistics;
        Button btnMoveToProfile;
        Button btnMoveToEditEvent;
        public MainPage()
        {
            //jika user belum masuk
            Navigation.PushModalAsync(new LoginPage());
            //else: tetap di mainpage

            //UI 
            StackLayout layout = new StackLayout();
            ListView listview = new ListView();

            layout.Children.Add(new Label { Text = "This is MainPage" });
            layout.Children.Add(btnMoveToAddEvent = new Button { Text = "Add Event" });
            layout.Children.Add(btnMoveToEditEvent = new Button { Text = "Edit Event" });
            layout.Children.Add(btnMoveToStatistics = new Button { Text = "Statistics" });
            layout.Children.Add(btnMoveToProfile = new Button { Text = "Profile" });
            layout.Children.Add(listview);

            //button.clicked
            btnMoveToAddEvent.Clicked += OnMoveToAddEvent;
            btnMoveToEditEvent.Clicked += OnMoveToEditEvent;
            btnMoveToStatistics.Clicked += OnMoveToStatistics;
            btnMoveToProfile.Clicked += OnMoveToProfile;

            //this.Content
            this.Content = layout;
        }

        public void OnMoveToAddEvent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddEventPage());
        }
        public void OnMoveToEditEvent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditEventPage());
        }
        public void OnMoveToStatistics(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StatisticsPage());
        }
        public void OnMoveToProfile(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }
    }
}
