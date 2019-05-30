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
using System.Windows.Shapes;
using ResourcesApplication.Beans;

namespace ResourcesApplication
{
    /// <summary>
    /// Interaction logic for EditTag.xaml
    /// </summary>
    public partial class EditTag : Window
    {

       
        private ResourceTag tag;
        public ResourceTag Tagg
        {
            get { return tag; }
            set { tag = value; }
        }

        private string oldId;
        private bool idError;
        private bool descriptionError;
        public EditTag()
        {
            InitializeComponent();
        }


        public EditTag(string tagId)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            oldId = tagId;

            Tagg = new ResourceTag(Database.GetTag(tagId));
            if (Tagg.Color != null)
                ColorPicker.SelectedColor = (Color)ColorConverter.ConvertFromString(tag.Color);
            DataContext = tag;

            idError = false;
            descriptionError = false;
        }

        private void textBoxId_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                idError = true;
        }

        private void textBoxDescription_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                descriptionError = true;
        }
        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            tag.Color = ColorPicker.SelectedColor.ToString();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            idError = false; descriptionError = false;
            textBoxId.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            textBoxDescription.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (idError == false && descriptionError == false)
            {
                Database.UpdateTag(oldId, Tagg);
             
                Close();
            }
        }

       

    }
}
