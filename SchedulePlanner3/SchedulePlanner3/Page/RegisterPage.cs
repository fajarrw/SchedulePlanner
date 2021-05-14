using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    public class RegisterPage : ContentPage
    {
        Entry etyName;
        Entry etyEmail;
        Entry etyPassword;
        Button btnCreateMember;

        public RegisterPage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "Please enter your name: " });
            layout.Children.Add(etyName = new Entry());
            layout.Children.Add(new Label { Text = "Please enter your email: " });
            layout.Children.Add(etyEmail = new Entry());
            layout.Children.Add(new Label { Text = "Please enter a password: " });
            layout.Children.Add(etyPassword = new Entry());
            layout.Children.Add(btnCreateMember = new Button { Text = "Create Account"  });

            btnCreateMember.Clicked += OnCreateMember;

            this.Content = layout;
        }

        public void OnCreateMember(object sender, EventArgs e)
        {
            //simpan masukan ke database
            //Display.Alert: Registration Succeed
            Navigation.PopModalAsync();
            Navigation.PopModalAsync();
        }
    }
}
