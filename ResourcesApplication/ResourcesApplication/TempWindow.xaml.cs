using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

using ResourcesApplication.Beans;

namespace ResourcesApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TempWindow : Window
    {
        private string CURRENT_MAP;
        /*
         *  WORLD
         *  AMERICA
         *  EUROPE
         *  ASIA
         */
        private ObservableCollection<Resource> resources;
        public ObservableCollection<Resource> Resources
        {
            get { return resources; }
            set
            {
                if (value != resources)
                {
                    resources = value;
                    OnPropertyChanged("Resources");
                }
            }
        }

        private ObservableCollection<ResourceType> resourcesType;
        public ObservableCollection<ResourceType> ResourcesType
        {
            get { return resourcesType; }
            set
            {
                if (value != resourcesType)
                {
                    resourcesType = value;
                    OnPropertyChanged("ResourcesType");
                }
            }
        }

        private Resource ClickedResource;
        public TempWindow(string map)
        {
            InitializeComponent();
            Database.loadData();
            CURRENT_MAP = map;

            DataContext = this;
            Resources = Database.getInstance().Resources;
            ResourcesType = Database.getInstance().Types;
        }

        private void AddResource_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AddResource addResource = new AddResource();
            addResource.Show();
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



        private void ShowResources_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ShowResources showResources = new ShowResources();
            showResources.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}