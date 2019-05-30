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

namespace ResourcesApplication
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
            AddTag addTag = new AddTag();
            addTag.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddResourceType type = new AddResourceType();
            type.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddResource type = new AddResource();
            type.Show();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
        private void ShowTypes_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ShowTypes showTypes = new ShowTypes();
            showTypes.Show();
        }

        private void AddTag_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AddTag addTag = new AddTag();
            addTag.Show();
        }
        private void ShowTags_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ShowTags showTags = new ShowTags();
            showTags.Show();
        }

        private void AddType_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AddType addType = new AddType();
            addType.Show();
        }
    }
}
