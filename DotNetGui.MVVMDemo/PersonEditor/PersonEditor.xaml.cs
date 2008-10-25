using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DotNetGui.MVVMDemo.PersonEditor
{
    /// <summary>
    /// Interaction logic for PersonEditor.xaml
    /// </summary>
    public partial class PersonEditor : Window
    {
        public PersonEditor()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
