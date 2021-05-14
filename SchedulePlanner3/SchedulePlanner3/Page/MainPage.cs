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
        public MainPage()
        {
            //jika user belum masuk
            Navigation.PushModalAsync(new LoginPage());
            //else: tetap di mainpage

            //UI 
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "This is MainPage" });
            layout.Children.Add(btnMoveToAddEvent = new Button { Text = "Add Event" });
            layout.Children.Add(btnMoveToStatistics = new Button { Text = "Statistics" });
            layout.Children.Add(btnMoveToProfile = new Button { Text = "Profile" });

            //button.clicked
            btnMoveToAddEvent.Clicked += OnMoveToAddEvent;
            btnMoveToStatistics.Clicked += OnMoveToStatistics;
            btnMoveToProfile.Clicked += OnMoveToProfile;

            //this.Content???
            this.Content = layout;
        }

        public void OnMoveToAddEvent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddEventPage());
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
