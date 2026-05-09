using Lab1.Views;
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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text.Trim();
            string haslo = PasswordBox.Password.Trim();

            // Walidacja pustych pól 
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo))
            {
                MessageBox.Show(
                    "Wprowadź login i hasło.",
                    "Brak danych",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );

                // Czyszczenie pól 
                LoginBox.Clear();
                PasswordBox.Clear();
                LoginBox.Focus();

                return;
            }

            // Sprawdzenie danych logowania 
            if (login == "admin" && haslo == "admin123")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Nieprawidłowy login lub hasło.",
                    "Błąd logowania",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );

                LoginBox.Clear();
                PasswordBox.Clear();
                LoginBox.Focus();

            }
        }
    }
}