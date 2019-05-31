using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using ResourcesApplication.Beans;
namespace ResourcesApplication
{
    /// <summary>
    /// Interaction logic for ShowResources.xaml
    /// </summary>
    public partial class ShowResources : Window
    {
       
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

        public Resource SelectedResource { get; set; }
        public ShowResources()
        {
            InitializeComponent();
           
            SelectedResource = null;
            DataContext = this;
            
            Resources = Database.getInstance().Resources;
        }

        private void resourcesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            if (SelectedManifestation != null)
            {
                buttonEdit.IsEnabled = true;
                buttonDelete.IsEnabled = true;
            }
            */
        }

        private void resourcesGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //buttonEdit_Click(null, null);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
