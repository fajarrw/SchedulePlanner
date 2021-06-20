using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchedulePlanner3.Repository;

namespace SchedulePlanner3
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("SchedulePlanner.db3");
        public static MemberRepository memberRepository { get; private set; }
        public static EventRepository eventRepository { get; private set; }
        public App()
        {
            InitializeComponent();
            memberRepository = new MemberRepository(dbPath);
            eventRepository = new EventRepository(dbPath);

            MainPage = new NavigationPage(new SchedulePlanner3.MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
