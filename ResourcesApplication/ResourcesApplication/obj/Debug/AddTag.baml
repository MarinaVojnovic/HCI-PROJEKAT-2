   M S B A M L   `   `   `  ����O  KResourcesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ResourcesApplication.ValidationResourcesApplication.Validation  5   	   ;"clr-namespace:ResourcesApplicationResourcesApplication  5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5	   
   !    ResourcesApplication.AddTag   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   D
validation-clr-namespace:ResourcesApplication.Validation     5   	   4local"clr-namespace:ResourcesApplication     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5	   
     � Title$  AddTag��5
   	   $	��400��6   $	��800��6%   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $
��Auto �6   6,   .+�5   
   � $��0��6   $��0��6    � ColumnDefinitions 5      �� 5      $��75��6#   63   �� 5      $��* �6#   6/   �� 5      $	��150��6#   64    5      �� 5      $��30 �6    6.   �� 5      $��30 �6    6.   �� 5      $��* �6    6-   .+�5      �� $��0��6   $��0��6$   $	��Id:��61   �� 5      -   5        $��	textBoxId��5       �� 	MaxLength$ 55��6'    � ToolTip$  Unos etikete manifestacija��6}   $��1��6�   $��0��6�   $��Center=�6�   $��3q�6�   .��6�   ��5      �� 5       �� Path$ Id�6    �� UpdateSourceTrigger$ 	LostFocus=�6(    �� NotifyOnValidationError .  �� ValidationRules 5       6   0ResourcesApplication.Validation.LengthValidation  5!      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6:   

   Min$
 3��6\   
   Max$ 50��6d   7  1ResourcesApplication.Validation.ContentValidation  5"      $	 RawProposedValue=�6;   5   /ResourcesApplication.Validation.TagIdValidation  5#      $	 RawProposedValue=�69   5%      .��5&        =� ErrorTemplate 5'      �� 5(      .R�5)      �  5*      �� 5+   "    5-      �� 5.   "   �� 5/   "   $	��175 �63   .+�52      ��  ��Name$ textBox��6U   $��0��68   $��0��6H   6U   �� 53      $
��Wrap=�6(   $��1��6<   $��0��6L   
���  ����6Y   �� *[0].ErrorContent+6{   54      55      .��56   ,   57      �� 58      $��0��6   $��1��6$   $��Boja:��61   #  Xceed.Wpf.Toolkit.ColorPicker  59      -   5        $��ColorPicker��59   "   $ Odabir boje etikete��66   $��1��6�   $��1��6�   $��Center=�6�   $��3q�6�   �� 5;      $��0��6   $��2��6$   $��Opis:��61   �� 5<      -   5        $��textBoxDescription��5<      $
 1100��60    �� TextWrapping$
 Wrap=�6o    �� AcceptsReturn . $��1��6�   $��2��6�   $ Opis etikete��6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   $��3,3,3,10q�6�   .��6  ��5=      �� 5>      $ Description�6   $ 	LostFocus=�61    5?        5@      $	 RawProposedValue=�6:   $
 0��6\   $
 1000��6d   5B      .��5C        5D      �� 5E      .R�5F      �  5G      �� 5H   "    5J      �� 5K   "   �� 5L   "   $	��150 �63   .+�5O      �� $ textBox��6U   $��0��68   $��2��6H   6U   �� 5P      $
��Wrap=�6(   $��1��6<   $��2��6L   
���  ����6Y   �� *[0].ErrorContent+6{   5Q      5R      .��5S   ,   5U      5X      �� 5Z   
   $��0��6   $��1��6%    �� Orientation$ 
Horizontal=�62   
�������.+�5[      �� -   5        $��
buttonSave��5[      {�.  $��Sačuvaj��6R   $��280,10,10,10q�6d   $
��20,5q�6z   �� 5\      -   5        $��buttonCancel��5\      $# Odustajanje od unosa podataka��6)   $��Odustani��6R   $��10q�6e   $
��20,5q�6q   5]      5`      5a      