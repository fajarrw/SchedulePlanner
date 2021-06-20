using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SchedulePlanner3.Model;

namespace SchedulePlanner3
{
    public class ProfilePage : ContentPage
    {
        Button btnUpdateMember;
        Button btnDeleteMember;
        Button btnLogout;
        public ProfilePage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "Nama: " + $"{Member.getName()}" }); 
            layout.Children.Add(new Label { Text = "Email: " + $"{Member.getEmail()}" }); 
            layout.Children.Add(btnUpdateMember = new Button { Text = "Edit Profile" });
            layout.Children.Add(btnDeleteMember = new Button { Text = "Delete Account" });
            layout.Children.Add(btnLogout = new Button { Text = "Logout" });

            btnUpdateMember.Clicked += OnUpdateMember;
            btnDeleteMember.Clicked += OnDeleteMember;
            btnLogout.Clicked += OnLogout;

            this.Content = layout;
        }

        public void OnUpdateMember(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdateMemberPage());
        }

        public void OnDeleteMember(object sender, EventArgs e)
        {
            //cara hapusnya gimana
        }

        public void OnLogout(object sender, EventArgs e)
        {
            //kalau nanti pakai memberID dari LoginPage, jangan lupa memberID nya di-set jadi null.
            Navigation.PopAsync();
            Navigation.PopAsync();
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}
