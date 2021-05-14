using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SchedulePlanner3
{
    public class UpdateMemberPage : ContentPage
    {
        Entry etyName;
        Entry etyEmail;
        Entry etyPassword;
        Button btnUpdateMember;
        public UpdateMemberPage()
        {
            StackLayout layout = new StackLayout();

            layout.Children.Add(new Label { Text = "Name: " });
            layout.Children.Add(etyName = new Entry { Text = $"{Model.Member.getName()}" });
            layout.Children.Add(new Label { Text = "Email: " });
            layout.Children.Add(etyEmail = new Entry { Text = $"{Model.Member.getEmail()}" });
            layout.Children.Add(new Label { Text = "Password: " });
            layout.Children.Add(etyPassword = new Entry());
            layout.Children.Add(btnUpdateMember = new Button { Text = "Edit" });

            btnUpdateMember.Clicked += OnUpdateMember;

            this.Content = layout;
        }

        public void OnUpdateMember(object sender, EventArgs e)
        {
            //cek mana entry yang null dan yang tidak
            //yang ada isinya disimpan ke database
            //Display.Alert: Update Succeed
        }
    }
}
