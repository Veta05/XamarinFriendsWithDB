using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFriends.Models;
using XamarinFriends.Views;

namespace XamarinFriends
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friend.db";
        public static FriendRepository database;
        public static FriendRepository DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new FriendRepository
                        (Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));

                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DBListPage());
            //MainPage = new NavigationPage(new FriendsListPage());
        }
    }
}
