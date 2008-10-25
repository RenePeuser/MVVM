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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DotNetGui.MVVMDemo.Lib.Database;
using DotNetGui.MVVMDemo.PeopleList.ViewModel;
using DotNetGui.MVVMDemo.Lib.Data;

namespace DotNetGui.MVVMDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonListViewModel _personListViewModel = null;

        public MainWindow()
        {
            InitializeComponent();

            Person[] people = Database.GetCompletePeople();
            _personListViewModel = new PersonListViewModel(people);
            this.DataContext = _personListViewModel;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _personListViewModel.Edit.Execute(null);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
