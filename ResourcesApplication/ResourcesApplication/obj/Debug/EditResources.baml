   M S B A M L   `   `   `  ����O  KResourcesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ResourcesApplicationResourcesApplication  5   	   (    "ResourcesApplication.EditResources   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ResourcesApplication     5   	     � Title$  Izmena resursa��5   	   $	��450��6    $	��800��6-   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��resourcesGrid��5         AutoGenerateColumns .  $��	0,12,0,97q�6�      
IsReadOnly . $��0��6  $��7��6&   �� SelectedItem 6v   ��  �� Path$ SelectedResource� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� $ 	Resources�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Oznaka resursa��6%   
   MinWidth$	
 100Q�6=      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6V   �� *Id+  5      $	 Naziv resursa��6%   $	
 100Q�6=   $ * 6L    6V   �� *Name+  5      $	 Tip resursa��6%   $	
 100Q�6<   $ * 6K    6U   �� *	Type.Id+  5      $	 Zastupljenost��6%   $	
 100Q�6>   $ * 6M    6W   �� *	Frequency+  5      $	 Strateska vaznost��6%   $	
 100Q�6B   $ * 6Q    6[   �� *
Importance+  5       $	 Eksploatacija��6%   $	
 100Q�6>   $ * 6M    6W   �� *AbleToExploate+  5!      $	 Jedinica mere��6%   $	
 100Q�6>   $ * 6M    6W   �� *MeasurementUnit+  5"      $	 	Obnovljiv��6%   $	
 100Q�6:   $ * 6I    6S   �� *	Renewable+  5#      $
	 Cena��6%   $	
 100Q�65   $ * 6D    6N   �� *Price+  5$      $	 Datum��6%   $	
 100Q�66   $ * 6E    6O   �� *Date+5&      �� 5(   
   -   5        $��
buttonEdit��5(   :   $��Izmeni��6   
������ � ToolTip$ Izmena odabranog resursa��6L   $��6��6o   $��263,94,426,15q�6}   {�.  6�   �� 5+   
   -   5        
�������$��Opozovi��5+   )   $��6��6;   $ Opozovi prethodnu izmenu��6H   $��459,94,231,15q�6l   $��30��6�   6�   5,      5-      