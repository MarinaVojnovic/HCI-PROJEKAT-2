   M S B A M L   `   `   `  ����O  KResourcesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ResourcesApplicationResourcesApplication  5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5   	   Q-clr-namespace:ResourcesApplication.ValidationResourcesApplication.Validation  5   	   p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5	   
   '    !ResourcesApplication.EditResource   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ResourcesApplication     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	   D
validation-clr-namespace:ResourcesApplication.Validation     5   	   htoolkitTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5	   
     � Title$  Izmena resursa��5   	   $	��550��6    $	��800��6-   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��227* �6   �� 5      $
��254* �6   �� 5      $
��Auto �6   $��38��6*    � ColumnDefinitions 5   
   �� 5      �� 5      $	��179 �6   .+�5   
   � $��0��6   $��0��6   $��2��6,    5      �� 5      $	��120��6#   �� 5      $��* �6#    5      �� 5      $��30 �6    �� 5      $��30 �6    �� 5       $��31 �6    �� 5!      $��71 �6    �� 5"      $��48 �6    �� 5#      $��30 �6    �� 5$      $��30 �6    �� 5%      $��30 �6    �� 5&      $��30 �6    �� 5'      $��30 �6    �� 5(      $��30 �6    �� 5)      $��30 �6    �� 5*      $��0* �6    .+�5/      �� $��0��6   $��0��6$   $	��Id:��61   �� 50      -   5        $��	textBoxId��50       �� 	MaxLength$ 55��6'    � ToolTip$ Unos oznake resursa��6}   $��1��6�   $��0��6�   $��Center=�6�   $��3q�6�   .��6�   ��51      �� 52       �� Path$ Id�6    �� UpdateSourceTrigger$ 	LostFocus=�6(    �� NotifyOnValidationError .  �� ValidationRules 53      6   0ResourcesApplication.Validation.LengthValidation  54      ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�6:   

   Min$
 3��6\   
   Max$ 50��6d   7  1ResourcesApplication.Validation.ContentValidation  55      $	 RawProposedValue=�6;   58      .��59        =� ErrorTemplate 5:      �� 5;      .R�5<      �  5=      �� 5>   "    5@      �� 5A   "   �� 5B   "   $	��200 �63   .+�5E      ��  ��Name$ textBox��6U   $��0��68   $��0��6H   6U   �� 5F      $
��Wrap=�6(   $��1��6<   $��0��6L   
���  ����6Y   �� *[0].ErrorContent+6{   5G      5H      .��5I   ,   5J      �� 5L      $��0��6   $��1��6$   $��Cena:��61   �� 5M      -   5        $��textBoxPrice��5M      $ 55��6P   $( "Unos cene resursa po jedinici mere��6�   $��1��6�   $��1��6�   $��Center=�6�   $��3q�6�   .��6�   ��5N      �� 5O      $ Price�6   $ 	LostFocus=�6+    .  5P      6   0ResourcesApplication.Validation.NumberValidation  5R      $	 RawProposedValue=�6:   5T      .��5U        5X      �� 5Y      .R�5Z      �  5[      �� 5\   "    5^      �� 5_   "   �� 5`   "   $	��200 �63   .+�5c      �� $ textBox��6U   $��0��68   $��0��6H   6U   �� 5d      $
��Wrap=�6(   $��1��6<   $��1��6L   
���  ����6Y   �� *[0].ErrorContent+6{   5e      5f      .��5g   ,   5j      �� 5l      $��0��6   $��2��6$   $
��Ime:��61   �� 5m      -   5        $��textBoxName��5m      $ 55��6)   $ Unos imena resursa��6^   $��1��6{   $��2��6�   $��Center=�6�   $��3q�6�   .��6�   ��5n      �� 5o      $
 Name�6   $ 	LostFocus=�6*    .  5p        5q      $	 RawProposedValue=�6:   $
 3��6\   $ 50��6d   5s      .��5t        5u      �� 5v      .R�5w      �  5x      �� 5y   "    5{      �� 5|   "   �� 5}   "   $	��200 �63   .+�5�      �� $ textBoxName��6U   $��0��68   $��2��6H   6U   �� 5�      $
��Wrap=�6(   $��1��6<   $��2��6L   
���  ����6Y   �� *[0].ErrorContent+6{   5�      5�      .��5�   ,   5�      �� 5�      $��0��6   $��3��6$   $��Opis:��61   �� 5�      -   5        $��textBoxDescription��5�      $
 1100��60   $ Unos opisa resursa��6n   $��3��6�    �� TextWrapping$
 Wrap=�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   $��0,2,6,10q�6�   $��1��6�   .��6�   ��5�      �� 5�      $ Description�6   $ 	LostFocus=�61    .  5�        5�      $	 RawProposedValue=�6:   $
 0��6\   $
 1000��6d   5�      .��5�        5�      �� 5�      .R�5�      �  5�      �� 5�   "    5�      �� 5�   "   �� 5�   "   $	��200 �63   .+�5�      �� $ textBoxName��6U   $��0��68   $��3��6H   6U   �� 5�      $
��Wrap=�6(   $��1��6<   $��3��6L   
���  ����6Y   �� *[0].ErrorContent+6{   5�      5�      .��5�   ,   5�      �� 5�      $��0��6   $��4��6$   $��Datum otkrivanja:��61   (  "System.Windows.Controls.DatePicker  5�      -   5        $��
datePicker��5�      $$ Unos datuma otkrivanja resursa��6s   $��1��6�   $��4��6�   $��Center=�6�   $��	3,14,3,10q�6�   $��24��6�      SelectedDate 6+   �� $
 Date�$ PropertyChanged=�6�   �� 5�      $��0��6   $��5��6$   $��Tip resursa:��61   � 5�      $��1��6   $��5��6#    5�      �� 5�      $��* �6'   �� 5�      $	��100 �6'   .+�5�      -  'System.Windows.Controls.AutoCompleteBox  -   5        $��autoCompleteBoxTypes��5�   *      IsTextCompletionEnabled .    
FilterMode$ 
StartsWith=�6�      ValueMemberPath$ Id��6$  $��3,3,2,3q�69     ItemsSource 6�   �� $ Types�$ PropertyChanged=�   ItemTemplate 5�      �� 5�      .R�5�      �� ��6(   �� *Id+6?   5�      5�      �� 5�      -   5        $��buttonAddNewType��5�      $" Dodaj novi tip manifestacije��6P   $��1��6w   $��0��6�   $��3q�6�   $
��10,0q�6�   .��5�      ��  �� Orientation$ 
Horizontal=�6!   .+�5�      �� $��Dodaj��6$   $��Center=�61   $��Right=�6L    �� Padding$ 3q�6h   5�      5�      5�      �� 5�      $��0��6   $��6��6$   $��Etikete:��61   � 5�      $��1��6   $��6��6#    5�      �� 5�      $
��173* �6'   �� 5�      $
��101* �6'   �� 5�      $	��100 �6'   .+�5�        -   5        $��autoCompleteBoxTags��5�   *   $  Polje za dodavanje etiketa��6E      IsDropDownOpen . $ 
StartsWith=�6�   $ Id��6  $��3,3,0,3q�6'  $��2��68   6�   �� $
 Tags�$ PropertyChanged=� 5�      �� 5�      .R�5�      �� ��6(   �� *Id+6>   5�      5�      �� 5�      -	   5        $��buttonAddNewTag��5�      $ Dodaj novu etiketu��6N   $��2��6k   $��0��6{   $��3q�6�   $
��20,0q�6�   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $��Dodaj��6$   $��Center=�61   $��Right=�6L   $ 3q�6h   5�      5�      %  Xceed.Wpf.Toolkit.CheckComboBox  5�      -
   5        $��comboBoxTags��5�   H   $ Lista etiketa resursa��6(    �� DisplayMemberPath$ Id��5�   $      MaxDropDownHeight$	 100Q�5�   $   $��
3,37,3,-31q�5�   $   $��3��68   ��5�   $   �� *Manifestation.Tags++  %Xceed.Wpf.Toolkit.Primitives.Selector   SelectedItemsOverride 5�   $   �� *SelectedTags+5�   8   5�      �� 5�      $��0��6   $��7��6$   $��Ikonica:��61   � 5�      $��1��6   $��7��6#    5�      �� 5�      $��* �6'   �� 5�      $	��100 �6'   .+�5�      �� -   5        $��textBoxIconPath��5�      $0 *Polje koje sadrži adresu lokacije ikonice��61    �� 
IsReadOnly . $��Center=�6�   $��3,3,2,3q�6�   {�.  ��6w   �� $ IconPath�$ PropertyChanged=�6�   �� 5�      -   5        $��loadIcon��5�      $��1��6)   $A ;Kliknite da biste dodali novu ikonicu koja označava resurs��69   $��0��6~   $��2q�6�   $
��15,0q�6�   .��5�      �� $ 
Horizontal=�6!   $��74��6:   .+�5�      �� $��	Pretraži��6$   $��Center=�64   $��Right=�6O   $ 3q�6k   5�      5�      5�      �� 5�      $��0��6   $��8��6$   $��Jedinica mere:��61   �� 5�      -   5        $��comboBoxMeasurementUnit��5�      $ Enter measurement unit��6�   $��1��6�   $��8��6�   $��Center=�6�   $	��3,4q�6�   $��22��6�    �� Text 66   �� $ MeasurementUnit�$ PropertyChanged=�.@�5�      �� .��6   Merica6'   �� 5�      .��6   Barrel6'   �� 5�      .��6   Ton6$   �� 5�      .��6   	Kilograme6*   5�      �� 5�      $��0��6   $��9��6$   $ ��Frekvencija pojavljivanja:��61   �� 5�      -   5        $��comboBoxFrequency��5�      $ Enter frequency��6v   $��1��6�   $��9��6�   $��Center=�6�   $	��3,4q�6�   $��22��6�    61   �� $ 	Frequency�$ PropertyChanged=�.@�5�      �� .��6   Redak6&   �� 5�      .��6   Cest6%   �� 5�      .��6   Univerzalan6,   5�      �� 5�      -   5        $��	Obnovljiv��5�   H   $��0��6   $��10��6'   $��	0,5,10,10q�65   $  Da li je resurs obnovljiv?��6�   $��	Renewable��6�    d� 	IsChecked 6Y   �� $ 	Renewable�$ PropertyChanged=�6�   �� 5�      -   5        $��
Importance��5�   H   $��0��6   $��11��6'   $��	0,5,10,10q�65   $, &Da li je resurs od strateske vaznosti?��6�   $��
Importance��6�    6Z   �� $ 
Importance�$ PropertyChanged=�6�   �� 5�      -   5        $��AbleToExploate��5�   I   $��0��6   $��12��6'   $��
0,5,10,-53q�65   $4 .Da li postoji mogucnost eksploatacije resursa?��6�   $��AbleToExploate��6�    6_   �� $ AbleToExploate�$ PropertyChanged=�6�   5�      �� 5�   
   -   5        $��
buttonSave��5�   )   
������$��465,230,10,24q�6;   {�. $ Čuvanje izmena��6c   $��Sačuvaj��6|   $
��20,5q�6�   $��1��6�   $��2��6�   �� 5   
   -   5        $��buttonCancel��5   )   
�������$��10,230,38,24q�6=   $ Odustajanje od izmena��6S   $��Odustani��6s   $
��20,5q�6�    J� RenderTransformOrigin$ 1.361,2.548&�6�   $��1��6�   $��2��6�   $��1��6�   �� 5  
   -   5          ��Name$  textBoxTypeError��5     $��1��6.   $
��Left=�6>   $
��Wrap=�6Y   $	��200��6m   $y�Hidden=�6y   $L��FMolimo da unesite naziv postojećeg ili dodajte novi tip manifestacije��6�   
���  ��$	��Top=�6�   $��
5,16,-26,0q�6  $��1��6  $��32��6$  5     5     