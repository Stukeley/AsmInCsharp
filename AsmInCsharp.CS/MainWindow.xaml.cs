using System.Windows;

namespace AsmInCsharp.CS
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void RunAsmButton_Click(object sender, RoutedEventArgs e)
		{
			var data = new ulong[4] { 0, 0, 0, 0 };

			Algorithms.Example(data);

			string newDataString = data[0].ToString();


			ResultBlock.Text = $"newDataString = {newDataString}";
		}
	}
}