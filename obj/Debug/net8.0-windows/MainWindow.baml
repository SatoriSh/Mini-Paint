   M S B A M L   `   `   `  ����E  AMini Paint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mini_Paint
Mini_Paint  5   	       Mini_Paint.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mini_Paint     5   	     � Title$  
Mini Paint��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $
��0.1* �6   6.   .+�5   
   �� $	��Top=�6   .@�5      �� -   5         ��Name$ tabItem1��5      $��Canvas��6)   .��5      �� -   5         ��Name$ canvas��5   /    �� 
Background
 �����$	��405��6?   $��0,0,-3,0q�6L   5      5      �� 5      -   5        $ tabItem2��5      $��Settings��6(   .��5      R� .@�5      Q� -   5         Q�Name$ backgroundCanvas��5   #   $��Background canvas color��6=   .@�5      Q� -   5        $ bcYellow��5   '   $��Yellow��69   6j   Q� 5      -   5        $ bcWhite��5   '   $��White��68   6g   Q� 5      -   5        $ bcGreen��5   '   $��Green��68   6g   Q� 5      -   5        $ bcBlue��5   '   $
��Blue��67   6d   Q� 5      -	   5        $ bcRed��5   '   $	��Red��66   6a   5      Q� 5!      -
   5        $ language��5!   #   $��Language��65   .@�5"      Q� -   5        $��English��5"   '   6`   Q� 5#      -   5        $��Русский��5#   '   6`   5$      5&      5'      5(      �� 5*   
   -   5         ��Name$ saveProj��5*   k   $��727,22,0,361q�6$   $��2��6:   $
��Save��6N   $��20(�6]   6k   �� 5+   
   -   5        $ loadProj��5+   k   $��727,73,0,307q�6$   $��2��6:   $
��Load��6N   $��20(�6]   6k   �� 5,   
   -   5        $ 	clearProj��5,   n   $��727,127,0,253q�6%   $��2��6<   $��Clear��6P   $��20(�6`   6n   5.      5/      