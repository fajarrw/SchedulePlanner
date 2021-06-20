using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SchedulePlanner3.Model;

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
            bool isAuthentic = false;
            isAuthentic = App.memberRepository.Authenticate(etyEmail.ToString(), etyPassword.ToString());

            //if true:
            if (isAuthentic==false)
                Navigation.PopModalAsync();
            //else Display.Alert, ulangi masukan lagi
            else
                App.Current.MainPage.DisplayAlert("Login Failed", "Please try again", "OK");
        }

        public void OnRegister(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
