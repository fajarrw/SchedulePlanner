using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SchedulePlanner3.Repository;
using SchedulePlanner3.Model;

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
            Member newMember = new Member{ name = etyName.ToString(), email = etyEmail.ToString(), password = etyPassword.ToString() };
            int rowsAdded = App.memberRepository.AddMember(newMember);
            App.Current.MainPage.DisplayAlert("Succes", "New" + rowsAdded + "member(s) successfully added", "OK");
            Navigation.PopModalAsync();
            Navigation.PopModalAsync();
        }
    }
}
