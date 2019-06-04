using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ResourcesApplication.Commands
{
    class RoutedCommands
    {

        public static readonly RoutedUICommand AddTag = new RoutedUICommand(
            "Add Tag",
            "AddTag",
            typeof(RoutedCommand),
            new InputGestureCollection()
            {
            new KeyGesture(Key.M, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand ShowTags = new RoutedUICommand(
           "Show Tags",
           "ShowTags",
           typeof(RoutedCommand),
           new InputGestureCollection()
           {
            new KeyGesture(Key.M, ModifierKeys.Control)
           }
           );

        public static readonly RoutedUICommand AddType = new RoutedUICommand(
           "Add Type",
           "AddType",
           typeof(RoutedCommand),
           new InputGestureCollection()
           {
            new KeyGesture(Key.M, ModifierKeys.Control)
           }
           );
        public static readonly RoutedUICommand ShowTypes = new RoutedUICommand(
                   "Show Types",
                   "ShowTypes",
                   typeof(RoutedCommand),
                   new InputGestureCollection()
                   {
                new KeyGesture(Key.T, ModifierKeys.Alt)
                   }
                   );

        public static readonly RoutedUICommand AddResource = new RoutedUICommand(
                  "Add Resource",
                  "AddResource",
                  typeof(RoutedCommand),
                  new InputGestureCollection()
                  {
                new KeyGesture(Key.T, ModifierKeys.Alt)
                  }
                  );

        public static readonly RoutedUICommand ShowResources = new RoutedUICommand(
                  "Show Resources",
                  "ShowResources",
                  typeof(RoutedCommand),
                  new InputGestureCollection()
                  {
                new KeyGesture(Key.T, ModifierKeys.Alt)
                  }
                  );
        public static readonly RoutedUICommand EditResources = new RoutedUICommand(
              "Edit Resources",
              "EditResources",
              typeof(RoutedCommand),
              new InputGestureCollection()
              {
                new KeyGesture(Key.T, ModifierKeys.Alt)
              }
              );

        public static readonly RoutedUICommand DeleteResources = new RoutedUICommand(
                 "Delete Resources",
                 "DeleteResources",
                 typeof(RoutedCommand),
                 new InputGestureCollection()
                 {
                new KeyGesture(Key.T, ModifierKeys.Alt)
                 }
                 );

        public static readonly RoutedUICommand EditTypes = new RoutedUICommand(
               "Edit Types",
               "EditTypes",
               typeof(RoutedCommand),
               new InputGestureCollection()
               {
                new KeyGesture(Key.T, ModifierKeys.Alt)
               }
               );

        public static readonly RoutedUICommand DeleteTypes = new RoutedUICommand(
               "Delete Types",
               "DeleteTypes",
               typeof(RoutedCommand),
               new InputGestureCollection()
               {
                new KeyGesture(Key.T, ModifierKeys.Alt)
               }
               );

        public static readonly RoutedUICommand EditTags = new RoutedUICommand(
              "Edit Tags",
              "EditTags",
              typeof(RoutedCommand),
              new InputGestureCollection()
              {
                new KeyGesture(Key.T, ModifierKeys.Alt)
              }
              );
        public static readonly RoutedUICommand DeleteTags = new RoutedUICommand(
              "Delete Tags",
              "DeleteTags",
              typeof(RoutedCommand),
              new InputGestureCollection()
              {
                new KeyGesture(Key.T, ModifierKeys.Alt)
              }
              );



    }





}
