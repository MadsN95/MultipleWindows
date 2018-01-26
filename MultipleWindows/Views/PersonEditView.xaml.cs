using System;
using MultipleWindows.ViewModels;
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
using System.Windows.Shapes;

namespace MultipleWindows.Views
{
    /// <summary>
    /// Interaction logic for PersonEditView.xaml
    /// </summary>
    public partial class PersonEditView : Window
    {
        public PersonEditView()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                Button btn = sender as Button;
                if (!btn.IsCancel)
                {
                    textbox_firstName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                    textbox_lastName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                }
            }
            Close();
        }
    }
}
