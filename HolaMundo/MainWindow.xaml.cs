using System.Windows;
using System.Windows.Media;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SaludarButton_Click(object sender, RoutedEventArgs e)
        {
            MensajeTextBlock.Text = "Hola " + NombreTextBox.Text + "!";
            MensajeTextBlock.Foreground = Brushes.Black;
        }
    }
}
