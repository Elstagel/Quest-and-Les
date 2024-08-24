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

namespace урок_24._08._24
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

			if (BarbosaTextBox.Text == "Барбоса")
			{ 
			BarbosaTextBox.Background = Brushes.LightGreen;
			}
			else BarbosaTextBox.Background = Brushes.Red;

			if (DogTextBox.Text == "овчарок")
			{
				DogTextBox.Background = Brushes.LightGreen;
			}
			else DogTextBox.Background = Brushes.Red;

			if (LisenTextBox.Text == "слухом")
			{
				LisenTextBox.Background = Brushes.LightGreen;
			}
			else LisenTextBox.Background = Brushes.Red;


			
		}
	}
}