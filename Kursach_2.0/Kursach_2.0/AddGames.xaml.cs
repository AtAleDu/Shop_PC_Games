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
    /// Логика взаимодействия для AddGames.xaml
    /// </summary>
    public partial class AddGames : Page
    {
        private Games _currentGames = new Games();//будет хранить в себе экземпляр добавляемой игры  
        public AddGames(Games selectedGames)
        {
            InitializeComponent();

            if (selectedGames != null)
                _currentGames = selectedGames;

            
            DataContext = _currentGames;
            ComboGenre.ItemsSource = PlanetShoppEntities.GetContext().Grenre.ToList();
            ComboSystem.ItemsSource = PlanetShoppEntities.GetContext().System_requiremenst.ToList();
        }

       
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на заполненость 
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentGames.Name))
              errors.AppendLine("Укажите название игры");
            if (_currentGames.Grenre == null)
                errors.AppendLine("Выберите жанр игры");
            if (_currentGames.System_requiremenst == null)
                errors.AppendLine("Выберите системные требования игры");
            if (_currentGames.User_rating == null)
                errors.AppendLine("Укажите оценку пользователя");
            if (_currentGames.User_rating<1 || _currentGames.User_rating>10)
                errors.AppendLine("Укажите оценку пользователя игры - от 1 до 10");
            if (_currentGames.Critics_rating == null)
                errors.AppendLine("Укажите оценку критика");
            if (_currentGames.Critics_rating < 1 || _currentGames.Critics_rating > 10)
                errors.AppendLine("Укажите оценку критика игры - от 1 до 10");
            if (_currentGames.Price == null)
                errors.AppendLine("Укажите цену");
            if (_currentGames.Price < 0)
                errors.AppendLine("Укажите цену не меньше 0");
            // если есть ошибки выводит сообшениие 
            if (errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentGames.Id_Games == 0)
                PlanetShoppEntities.GetContext().Games.Add(_currentGames);
            // еслии все хорошо то при нажатию на кнопку инфа сохранятся
            try
            {
                PlanetShoppEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }


        }

      
    }
}
