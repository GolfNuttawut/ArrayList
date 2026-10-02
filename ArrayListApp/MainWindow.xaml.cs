using System.Collections;
using System.Windows;

namespace ArrayListApp
{
    public partial class MainWindow : Window
    {
        ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int number))
            {
                arrayList.Add(number);
                txtInput.Clear();
                txtInput.Focus();
                MessageBox.Show("Add: " + number);
            }
            else
            {
                MessageBox.Show("Invalid Value");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int number))
            {
                if (arrayList.Contains(number))
                {
                    arrayList.Remove(number);
                    MessageBox.Show("Removed: " + number);
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                MessageBox.Show("Invalid Value");
            }
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            if (arrayList.Count == 0)
            {
                MessageBox.Show("null");
                return;
            }

            string result = "";
            foreach (int data in arrayList)
            {
                result += data + "\n";
            }
            MessageBox.Show(result + "Count: " + arrayList.Count);
        }
    }
}