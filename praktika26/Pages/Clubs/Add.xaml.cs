using praktika26.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace praktika26.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        Main Main;
        Models.Clubs Club;
        public Add(Main Main, Models.Clubs Club = null)
        {
            this.Main = Main;
            if (Club != null)
            {
                this.Club=Club;
                this.Name.Text = Club.Name;
                this.Address.Text = Club.Address;
                this.WorkTime.Text = Club.WorkTime;
                BtnAdd.Content = "Изменить";
            }
            InitializeComponent();
        }

        private void AddClub(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.Club == null)
            {
                Club = new Models.Clubs();
                Club.Name = this.Name.Text;
                Club.Address = this.Address.Text;
                Club.WorkTime = this.WorkTime.Text;
                this.Main.AllClub.Clubs.Add(this.Club);
            }
            else
            {
                Club.Name = this.Name.Text;
                Club.Address = this.Address.Text;
                Club.WorkTime = this.WorkTime.Text;
            }
            this.Main.AllClub.SaveChanges();
            MainWindow.init.OpenPages(new Pages.Clubs.Main());
        }
    }
   
}
