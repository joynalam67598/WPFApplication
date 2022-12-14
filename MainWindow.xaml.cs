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

namespace WPFTestProect
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.ACheckBox.IsChecked = this.BCheckBox.IsChecked = this.CCheckBox.IsChecked = this.DCheckBox.IsChecked
                = this.ECheckBox.IsChecked = this.FCheckBox.IsChecked = this.GCheckBox.IsChecked
                = this.HCheckBox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LenghtTextBox.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdow_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if(this.NoteTextBox == null)
            {
                return;
            }
            this.NoteTextBox.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdow_SelectionChange(this.FinishDropdown, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.SupplierCodeText.Text = this.SupplierNameText.Text;
        }
    }
}
