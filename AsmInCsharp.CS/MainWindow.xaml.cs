using System;
using System.Windows;

namespace AsmInCsharp.CS
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			long expectedDataDec = Convert.ToInt64("0123456789abcdef", 16);
			string expectedDataString = expectedDataDec.ToString();

			ExpectedValueBlock.Text += $"\n{expectedDataString}";
		}

		private void RunAsmButton_Click(object sender, RoutedEventArgs e)
		{
			var data = new ulong[4] { 0, 0, 0, 0 };

			Algorithms.Example(data);

			string actualValueString = data[0].ToString();

			ResultBlock.Text = $"actualValueString = {actualValueString}";
		}
	}
}