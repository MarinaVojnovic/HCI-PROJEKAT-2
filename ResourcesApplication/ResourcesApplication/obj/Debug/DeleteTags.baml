   M S B A M L   `   `   `  ����O  KResourcesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ResourcesApplicationResourcesApplication  5   	   %    ResourcesApplication.DeleteTags   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ResourcesApplication     5   	     � Title$  Brisanje etiketa��5   	   $	��450��6"   $	��800��6/   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��tagsGrid��5         AutoGenerateColumns .  $��
0,12,0,125q�6�      
IsReadOnly . $��0��6  $��7��6  $��2��6Q   �� SelectedItem 6l   ��  �� Path$ SelectedTag� �� UpdateSourceTrigger$ PropertyChanged=���6�   �� $
 Tags�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Oznaka etikete��6%   
   MinWidth$	
 100Q�6=      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6V   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Boja etikete��6)      CellTemplate 5      �� 5       .R�5!      �� $��30��6J   $��5q�6X   ��6(   �� $ Color�6X   5"      5$        5%      $	 Opis etikete��6%   $	
 100Q�6=   $ * 6L    6V   �� *Description+5'      �� 5)   
   -   5        $��buttonDelete��5)       � ToolTip$ Obrisi odabranu etiketu��6%   $��6��6G   $��Center=�6T   $��271,75,323,34q�6o   {�.  $��30��6�   .��5*      ��  �� Orientation$ 
Horizontal=�6   .+�5+      �� $��Obrisi��6   $��Center=�6*   $��Right=�6E    �� Padding$ 3q�6a    J� RenderTransformOrigin$ 0.674,4.002&�6m   5,      5-      �� 5.   
   -   5        $��Opozovi brisanje��5.      $  Opozovi prethodno brisanje��6-   $
��Left=�6R   $��
413,75,0,0q�6m   $��6��6�   $	��Top=�6�   $��98��6�   $��28��6�   50      51      