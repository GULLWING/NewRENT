using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfRent.Models;

namespace WpfRent
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
       public static WpfRenttEntities context = new WpfRenttEntities();
        public static Users enteredUser;
        public static Announcement filtrAnnouncement;
    }
}
