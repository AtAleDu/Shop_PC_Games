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
    /// Логика взаимодействия для Enture.xaml
    /// </summary>
    public partial class Enture : Page
    {
        public Enture()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, RoutedEventArgs e)
        {
            string login = "Admin";//Логин, который есть только у админа 
            string passwor = "Admin123"; //Пароль, который есть только у админа 
            //if ()
            {


                if (Login.Text.Length > 0)// проверяем введён ли логин
                {

                    if (Passw.Password.Length > 0)// проверяем введён ли пароль
                    {
                        if (Login.Text == login)
                        {
                            if (Passw.Password == passwor)
                            {
                                Manager.MainFrame.Navigate(new DGames());//Переход на страницу редоктирования 
                            }
                            else
                            {
                                MessageBox.Show("Не верный логин или пароль!!!");//Выводит предупреждение
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не верный логин или пароль!!!");//Выводит предупреждение
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите пароль!!!");//Выводит предупреждение
                    }
                }
                else
                {
                    MessageBox.Show("Введите логин!!!");//Выводит предупреждение
                }
            }
        }

        private void GO_user_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ListGamesPlaers());
        }

        private void GO_KeyDown(object sender, KeyEventArgs e)
        {
           // if (e.Key == Key.Enter)
            //{
              //  MessageBox.Show("ssdadadad");
            //}
        }
    }
}
