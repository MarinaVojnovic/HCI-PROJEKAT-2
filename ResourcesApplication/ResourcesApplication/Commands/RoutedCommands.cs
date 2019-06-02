﻿using System;
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

        public static readonly RoutedUICommand WorldMap = new RoutedUICommand(
            "World Map",
            "WorldMap",
            typeof(RoutedCommand),
            new InputGestureCollection()
            {
        new KeyGesture(Key.T, ModifierKeys.Alt)
            }
            );


    }





}
