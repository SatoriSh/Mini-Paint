   M S B A M L   `   `   `  ���� E  AMini Paint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mini_Paint
Mini_Paint      Mini_Paint.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Mini_Paint       � Title$  
Mini Paint��$
��1080��$
��1920�� � WindowStartupLocation$ CenterOwner=�.���  � ColumnDefinitions �� $��* ��� $
��0.1* � � RowDefinitions �� $	��35* ��� $	��55* ��� $	��55* ��� $	��55* ��� $
��200* �.+��� $	��Top=�$��Stretch=�$��5��.@��� -    ��Name$ tabItem1��$��Canvas��.���� -    ��Name$ canvas��$��4��$��1��$��Stretch=�$��Stretch=� �� 
Background
 �����$
��1920��$
��1080��$��3,3,3,3q��� -   $ tabItem2��$��Settings��.��R� .@�Q� -    Q�Name$ backgroundCanvas��$��Background canvas color��.@�Q� -   $ bcYellow��$��Yellow��Q� -   $ bcWhite��$��White��Q� -   $ bcGreen��$��Green��Q� -   $ bcBlue��$
��Blue��Q� -	   $ bcRed��$	��Red��Q� -
   $ language��$��Language��.@�Q� -   $��English��Q� -   $��Русский���� -    ��Name$ saveProj��$��70��$��1��$��1��$��Center=�$��Center=�$��2��$
��Save��$��20(�$��31���� -   $ loadProj��$��70��$��2��$��1��$��Center=�$��Center=�$��2��$
��Load��$��20(�$��31���� -   $ 	clearProj��$��70��$��3��$��1��$��Center=�$��Center=�$��2��$��Clear��$��20(�$��31��