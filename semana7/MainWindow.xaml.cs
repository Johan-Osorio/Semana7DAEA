using Business;
using Entity;
using System.Data;
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

namespace semana7
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
            List<Customers> customers = new List<Customers>();
            CustomersBusiness listpeople = new CustomersBusiness();
            customers = listpeople.GetCustomers();

            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Phone", typeof(string));

            foreach (var customers1 in customers)
            {
                dt.Rows.Add(customers1.customer_id, customers1.name, customers1.address, customers1.phone);
            }

            a.ItemsSource = dt.DefaultView;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}