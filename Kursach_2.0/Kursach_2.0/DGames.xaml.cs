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
    /// Логика взаимодействия для DGames.xaml
    /// </summary>
    public partial class DGames : Page
    {
        public DGames()
        {
            InitializeComponent();
            //DGridGames.ItemsSource = PlanetShoppEntities.GetContext().Games.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddGames(null));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        { 
            //Кнопка на удаление, проверка хочет ли пользватель удалить данные
            var gamesForRemoving = DGridGames.SelectedItems.Cast<Games>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {gamesForRemoving.Count()} элементов?","Внимание",MessageBoxButton.YesNo,MessageBoxImage.Question)== MessageBoxResult.Yes)
            {
                try
                {
                    PlanetShoppEntities.GetContext().Games.RemoveRange(gamesForRemoving);
                    PlanetShoppEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    DGridGames.ItemsSource = PlanetShoppEntities.GetContext().Games.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //Этот участок кода отвечает за обновление информации в таблице, после того как информациия была изменина
            if (Visibility == Visibility.Visible)
            {
                PlanetShoppEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridGames.ItemsSource = PlanetShoppEntities.GetContext().Games.ToList();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.Navigate(new AddGames((sender as Button).DataContext as Games));
        }
    }
}
