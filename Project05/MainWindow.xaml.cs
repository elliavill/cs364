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

namespace Project05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bank newBank = new Bank("DigiBank", "123 Rainbow Lane", "850-292-2385");
        Customer newCustomer = new Customer("Aurel", "256 Brent Lane", "123-345-6789");

        public MainWindow()
        {
            InitializeComponent();
        }

      private void cmbCustomerList_Loaded(object sender, SelectionChangedEventArgs e)
      {
         /*List<Customer> addCustomer = new List<Customer>();
         addCustomer.Add(new Customer("Aurel", "250 Brent Lane",   "8502922385"));
         addCustomer.Add(new Customer("Lulu",  "123 Brexly Trail", "8502922385"));*/
         /*foreach (Customer c in addCustomer)
         {
            cmbCustomerList.Items.Add(c);
         }*/
         List<string> data = new List<string>();
         data.Add("Aurel");
         data.Add("Erich");
         data.Add("Florina");
         //cmbCustomerList.DataContext = addCustomer;

         var comboBox = sender as ComboBox;
         comboBox.ItemsSource = data;
         comboBox.SelectedItem = 0;
      }

      private void cmbCustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         var selectedComboItem = sender as ComboBox;
         string name = selectedComboItem.SelectedItem as string;
         //txtboxCustomerInfo.Text = name;
         MessageBox.Show(name);
      }

      private void btnEndCheck_Click(object sender, RoutedEventArgs e)
      {

      }

      private void btnDeposit_Click(object sender, RoutedEventArgs e)
      {

      }

      private void btnWithdrawal_Click(object sender, RoutedEventArgs e)
      {

      }

      private void btnPayment_Click(object sender, RoutedEventArgs e)
      {

      }
   }
}
