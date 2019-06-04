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
using Xceed.Wpf.Toolkit;
using ResourcesApplication.Beans;
using Microsoft.Win32;

namespace ResourcesApplication
{
    /// <summary>
    /// Interaction logic for EditResource.xaml
    /// </summary>
    public partial class EditResource : Window
    {

        private Resource resource;
        public Resource Resource
        {
            get { return resource; }
            set
            {
                if (value != resource)
                {
                    resource = value;
                    OnPropertyChanged("Resource");
                }
            }
        }

        private ObservableCollection<ResourceTag> selectedTags;
        public ObservableCollection<ResourceTag> SelectedTags
        {
            get { return selectedTags; }
            set
            {
                if (value != selectedTags)
                {
                    selectedTags = value;
                    OnPropertyChanged("Tags");
                }
            }
        }

        private string oldId;

        private bool idError;
        private bool nameError;
        private bool descriptionError;
        private bool publicError;
        public EditResource(string resourceId)
        {



            InitializeComponent();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            oldId = resourceId;
            Resource = new Resource(Database.GetResource(resourceId));
            DataContext = Resource;

            autoCompleteBoxTypes.DataContext = Database.getInstance();
            autoCompleteBoxTags.DataContext = Database.getInstance().Tags;
            Database d = Database.getInstance();
            SelectedTags = new ObservableCollection<ResourceTag>();

            comboBoxTags.DataContext = this;

            foreach (var tag in Resource.Tags)
            {
                SelectedTags.Add(tag);
            }

            foreach (var typeDatabase in Database.getInstance().Types)
            {
                if (Resource.Type.Id != null)
                {
                    if (Resource.Type.Id.Equals(typeDatabase.Id))
                    {
                        autoCompleteBoxTypes.Text = typeDatabase.Id;
                    }
                }
            }

            idError = false;
            nameError = false;
            descriptionError = false;
            publicError = false;


        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            idError = false; nameError = false; descriptionError = false; publicError = false;
            textBoxId.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            textBoxName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            textBoxDescription.GetBindingExpression(TextBox.TextProperty).UpdateSource();


            // Type validation
            if (string.IsNullOrWhiteSpace(autoCompleteBoxTypes.Text)
                || Database.GetType(autoCompleteBoxTypes.Text) == null)
            {
                textBoxTypeError.Visibility = System.Windows.Visibility.Visible;
                autoCompleteBoxTypes.Text = "";
                autoCompleteBoxTypes.Focus();
                return;
            }

            if (idError == false &&
                nameError == false &&
                descriptionError == false &&
                publicError == false)
            {
                resource.Type = Database.GetType(autoCompleteBoxTypes.Text);

                // Set the default type icon
                if (string.IsNullOrEmpty(textBoxIconPath.Text) || string.IsNullOrWhiteSpace(textBoxIconPath.Text))
                {
                    resource.IconPath = resource.Type.IconPath;
                }

                Resource.Tags = new ObservableCollection<ResourceTag>(SelectedTags);
                Database.UpdateResource(oldId, resource);
                Close();
            }

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void loadIcon_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png;*.jpg,*.ico)|*.ico;*.png;*.jpg";
            if (dialog.ShowDialog() == true)
            {
                textBoxIconPath.Text = dialog.FileName;
            }
        }

        private void autoCompleteBoxTag_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                buttonAddNewTag_Click(null, null);
            }
        }

        private void buttonAddNewTag_Click(object sender, RoutedEventArgs e)
        {

        }
        private void buttonAddNewType_Click(object sender, RoutedEventArgs e)
        {

            AddType addType = new AddType(autoCompleteBoxTypes.Text);
            addType.ShowDialog();

            /*
            if (Database.GetResource(autoCompleteBoxTypes.Text) == null)
            {
                AddType addType = new AddType(autoCompleteBoxTypes.Text);
                addType.ShowDialog();
            }
            else
            {
                AddType addType = new AddType();
                addType.ShowDialog();
            }
            */
        }

        private void autoCompleteBoxType_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Database.GetType(autoCompleteBoxTypes.Text) == null)
                {
                    buttonAddNewType_Click(null, null);
                }
            }
        }

        private void autoCompleteBoxTypes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(autoCompleteBoxTypes.Text)
                || Database.GetType(autoCompleteBoxTypes.Text) == null)
            {
                // textBoxTypeError.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                //textBoxTypeError.Visibility = System.Windows.Visibility.Hidden;
            }
        }
        private void textBoxDescription_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                descriptionError = true;
        }
        private void textBoxName_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                nameError = true;
        }
        private void textBoxId_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                idError = true;
        }

        private void textBoxId_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            if (textBoxId.Text.Length > 0)
                //buttonSave.IsEnabled = true;
            else
                //buttonSave.IsEnabled = false;

    */
        }

        private void textBoxPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            if (textBoxId.Text.Length > 0)
                //buttonSave.IsEnabled = true;
            else
                //buttonSave.IsEnabled = false;

    */
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
