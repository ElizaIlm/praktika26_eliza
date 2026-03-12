using praktika26.Classes;
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
using System.Xml.Linq;

namespace praktika26.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        // <summary> Получаем контекст данных для клубов
        public ClubsContext AllClub = new ClubsContext();
        public Main()
                {
                    InitializeComponent();
                    // Перебираем клубы
                    foreach (Models.Clubs Club in AllClub.Clubs)
                    {
                        // Выводим на экран через пользовательский элемент
                        Parent.Children.Add(new Elements.Item(Club));
                    }
                }
        private void AddClub(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Add(this));

        
    }
}
