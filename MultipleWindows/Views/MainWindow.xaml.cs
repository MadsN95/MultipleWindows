using MultipleWindows.ViewModels;
using System.Windows;

namespace MultipleWindows.Views
{
    public partial class MainWindow : Window
    {
        private MainViewModel mvm = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Window popup = new PersonEditView();
            popup.DataContext = mvm.CurrentPerson;
            popup.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            mvm.AddNewPerson();
            listbox_PersonsList.Items.Refresh();
        }
    }
}
