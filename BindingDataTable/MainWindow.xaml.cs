using System;
using System.Collections.Generic;
using System.Data;
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

namespace BindingDataTable
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
    }

    public class Model
    {
        public string Month { get; set; }

        public double Value { get; set; }

        public string Description { get; set; }
    }

    public class ViewModel
    {

        public ViewModel()
        {
            DataModel = GetData();
        }
        public DataTable DataModel
        {
            get;
            set;
        }
        public DataTable GetData()
        {
            DataTable data = new DataTable();
            //Add Columns
            data.Columns.Add("Value", typeof(int));
            data.Columns.Add("Month", typeof(string));
            data.Columns.Add("Description", typeof(string));
            //Add Rows
            data.Rows.Add(250, "April", "Very Low");
            data.Rows.Add(750, "May", "Low");
            data.Rows.Add(7500, "June", "Very High");
            data.Rows.Add(3650, "July", "High");
            data.Rows.Add(2250, "August", "Intermediate");

            //return data
            return data;
        }
    }
}
