using System.Windows;
using System.Collections;
using System;

namespace ArraylistUse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            if (arrayList is null)
            {
                arrayList = new ArrayList(10);
            }
            int size = arrayList.Capacity;
            arrayList.Add(txtname.Text);
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add("sathishm");
            size = arrayList.Capacity;
            int countitem = arrayList.Count;

            lstitem.ItemsSource = null;
            lstitem.ItemsSource = arrayList;
            MessageBox.Show("save Success");



            //// some value in txtname.Text and how to add(+)
            //string[] value = txtname.Text.Split(',');
            //int result =1; 
            //foreach (string num in value)          
            //{
            //    result = result * Convert.ToInt32(num);
            //    MessageBox.Show(result.ToString());
            //}

            ////same somevalue in txtbox and how many char in visible or how to count
            //string value = txtname.Text;
            //int cont=value.Length;
            //MessageBox.Show(cont.ToString());

        }

        private void btnremove_Click(object sender, RoutedEventArgs e)
        {
            if(arrayList.Contains(txtname.Text))
            {             
                arrayList.Remove(txtname.Text);
                MessageBox.Show("Remove Success");
                lstitem.ItemsSource = null;
                lstitem.ItemsSource = arrayList;
            }
        }
    }
}
