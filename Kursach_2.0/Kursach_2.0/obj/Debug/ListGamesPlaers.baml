   M S B A M L   `   `   `  ����F  BKursach_2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Kursach_2._0Kursach_2._0  5      "    Kursach_2._0.ListGamesPlaers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Kursach_2._0     5        N� Title$  ListGamesPlaers��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��255��6   $��25��6(   $��17(�64   $9��3Введите название для поиска��6B    �� TextAlignment$ Right=�6e   $
��Bold"�6{   $��Comic Sans MS)�6�   6�   �� 5      -   5         ��Name$ 	BoxSearch��5   @   $	��225��6   $��25��6&   $��17(�62   6y   5      5      �� 5   
   -   5         ��Name$ ListPlayers��5       $��1��6   $��Disabled=�65   $��Center=�6k   ��5      �� 5      .R�5      � $ 
Horizontal=�6    $��Center=�69   6X   5      ��5       �� 5!      .R�5"      � $��20q�6   $	��400��6'    5#      �� 5$      $��70 �6,   6:   �� 5%      $	��310 �6,   6;   �� 5&      $
��auto �6,   6<   �� 5'      $
��auto �6,   6<   .+�5)      �� $	��400��6    $��1��6,   $��Center=�6:   $��5q�6W   ��5*      �� 5+   "    �� Path$ image�6*    �� TargetNullValue 5,   &   ��5-   *   Resources/picture.jpg��6M   5/   #   51      �� 52      $��Comic Sans MS)�6$   $��Center=�6U   $ Center=�6p   $	��390��6�   $
��Wrap=�6�   $��Center=�6�   $	��5 5q�6�   $��26(�6�   $��0��6�   ��6?   �� *Name+6�   �� 53      $��Comic Sans MS)�6$   $��2��6q   $��5 5 5 15q�6~   $��Center=�6�   $��26(�6�   $
��Bold"�6�   ��6?   �� *Price+	 �� StringFormat$	 {0:N2} РУБ��6�   �� 55      $��Comic Sans MS)�6$   $��3��6b   $��26(�6o   $��
140 5 5 15q�6}   $
��Bold"�6�   ��6?   �� *Grenre.NameGrenre+6�   57      58      5:      5<      5=      