   M S B A M L   `   `   `  ����O  KResourcesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ResourcesApplication.CommandsResourcesApplication.Commands  5   	   ;"clr-namespace:ResourcesApplicationResourcesApplication  5   	   %    ResourcesApplication.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;cmd+clr-namespace:ResourcesApplication.Commands     5   	   4local"clr-namespace:ResourcesApplication     5   	     � Title$
  Maps��5	   	   $	��650��6   $
��1050��6#   .��5
      ]� .+�5   
   �  J� RenderTransformOrigin$ 0.501,0.492&�6   ��5      �� 5       j� Stretch$
 None=�6    �� ImageSource$ Maps/background.jpg��6,    j� 
AlignmentY$	 Top=�6N    j� 
AlignmentX$ Center=�6_    � RowDefinitions 5      �� 5      $��30 �6    �� 5      $	��230 �6    �� 5      $��30 �6    �� 5      $	��230 �6    �� 5      $��30 �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��320 �6#   �� 5      $��* �6#   �� 5      $	��320 �6#   �� 5      $��* �6#   .+�5      �� -   5        $��worldButton��5       � ToolTip$ Prikaz mape sveta��6(   $��1��6D   $��1��6T   
������ $��0q�6z   .��5       �� .+�5!      �� -   5        $��World��5!      $	��230��6)   $	��320��66   $��Maps/world_map.png��6B   5"      5#      �� 5%      -   5        $��southAmericaButton��5%      $! Prikaz mape Severne Amerike��6/   $��3��6U   $��1��6e   
������ $��0q�6�   .��5&      �� .+�5'      �� -   5        $��SouthAmerica��5'      $	��230��60   $	��320��6=   $ ��Maps/south_america_map.jpg��6I   5(      5)      �� 5+      -   5        $��europeButton��5+      $ Prikaz mape Evrope��6)   $��1��6F   $��3��6V   
������ $��0q�6|   .��5,      �� .+�5-      �� -   5        $��Europe��5-      $	��230��6*   $	��320��67   $��Maps/europe_map.jpg��6C   5.      5/      �� 51      -   5        $��
asiaButton��51      $ Prikaz mape sveta��6'   $��3��6C   $��3��6S   
������ $��0q�6y   .��52      �� .+�53      �� -   5        $��Africa��53      $	��230��6*   $	��320��67   $��Maps/asia_map.jpg��6C   54      55      �� 57      $��
Mapa sveta��6   $��1��6)   $��2��69   $��Center=�6F   $
��Bold"�6c   �� 58      $��Mapa Severne Amerike��6   $��3��63   $��2��6C   $��Center=�6P   $
��Bold"�6m   �� 59      $��Mapa Evrope��6   $��1��6*   $��4��6:   $��Center=�6G   $
��Bold"�6d   �� 5:      $��
Mapa Azije��6   $��3��6)   $��4��69   $��Center=�6F   $
��Bold"�6c   5;      5<      5=      