   M S B A M L   `   `   `  ���� F  BKursach_2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Kursach_2._0Kursach_2._0      Kursach_2._0.AddGames   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:Kursach_2._0       N� Title$  AddGames��.���  � ColumnDefinitions �� $
��200* ��� $
��400* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Название��$��20(�
�������$��Center=�$��Center=��� $��Жанр��$��20(�
�������$��1��$��Center=�$��Center=��� $-��'Системные требования��$��20(�
�������$��2��$��Center=�$��Center=���  �� 	MaxLength$	 100��$��27(�$��1��$��60��$	��500������ *Name+�� -    ��Name$ 
ComboGenre��$��1��$��1��$��27(� �� DisplayMemberPath$ 
NameGrenre��$��60��$	��500�� �� SelectedItem �� *Grenre+�� -   $ ComboSystem��$��2��$��1��$
 Name��$��27(�$��60��$	��500�� �� *System_requiremenst+�� -    ��Name$
 Save��$��Сохранить��$��2��$��6��$��27(�$��40��$	��220���� $/��)Рейтинг пользователей��$��20(�
�������$��3��$��Center=�$��Center=��� $	 100��$��27(�$��1��$��3��$��40��$	��500������ *User_rating+�� $%��Рейтинг критиков��$��20(�
�������$��4��$��Center=�$��Center=��� $	 100��$��27(�$��1��$��4��$��40��$	��500������ *Critics_rating+�� $��Цена��$��20(�
�������$��5��$��Center=�$��Center=��� $	 100��$��27(�$��1��$��5��$��40��$	��500������ *Price+