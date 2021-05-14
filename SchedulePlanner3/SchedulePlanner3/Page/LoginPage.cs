using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    public class LoginPage : ContentPage
    {
        Entry etyEmail;
        Entry etyPassword;
        Button btnLogin;
        Button btnRegister;
        public LoginPage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "Please log in" });
            layout.Children.Add(new Label { Text = "Enter your email" });
            layout.Children.Add(etyEmail = new Entry());
            layout.Children.Add(new Label { Text = "Enter your password" });
            layout.Children.Add(etyPassword = new Entry());
            layout.Children.Add(btnLogin = new Button { Text = "Log In" });
            layout.Children.Add(new Label { Text = "If you don't have an account, please register" });
            layout.Children.Add(btnRegister = new Button { Text = "Register" });
            
            btnLogin.Clicked += OnLogin;
            btnRegister.Clicked += OnRegister;

            this.Content = layout;
        }

        public void OnLogin(object sender,EventArgs e)
        {
            //Cek di database
            //if true:
            Navigation.PopModalAsync();
            //else Display.Alert, ulangi masukan lagi
        }

        public void OnRegister(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
