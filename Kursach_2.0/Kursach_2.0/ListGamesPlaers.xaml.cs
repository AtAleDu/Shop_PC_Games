using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursach_2._0
{
    /// <summary>
    /// Логика взаимодействия для ListGamesPlaers.xaml
    /// </summary>
    public partial class ListGamesPlaers : Page
    {
        public ListGamesPlaers()
        {
            InitializeComponent();
            UpdateGames();
        }

        private void UpdateGames()//Реализация функции 
        {
            var currentGames = PlanetShoppEntities.GetContext().Games.ToList();

            currentGames = currentGames.Where(p => p.Name.ToLower().Contains(BoxSearch.Text.ToLower())).ToList();//Реализован поиск данных
            ListPlayers.ItemsSource= currentGames.ToList();//Вывод данных в лист



        }

        private void BoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateGames();
        }

      
    }
}
