   M S B A M L   `   `   `  ����L  H24 (FlyBodyInSky), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FlyBodyInSkyFlyBodyInSky  5          FlyBodyInSky.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ,localclr-namespace:FlyBodyInSky     5      -   5          � Title$L  FМоделирование траектории полёта мяча ��5	      $	��390��5
      $	��670��5      $	��390��5      $	��390��5      $	��670��5      $	��670��5      .��5      � $��0,0,0.2,-4.4q�6    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��5* �5      �� 5      $	��39* �5      .+�5   
   �� -   5         ��Name$ Canvas1��5       $��20,5.4,20,19.6q�5!      ���#808080$��1��5$      �� 5&   
   -   5         ��Name$ label1��5'      $��Угол: ?��5(      $
��Left=�5)      $��27,9,0,0q�5*      $	��Top=�5+       J� RenderTransformOrigin$ 0.491,0.744&�5,      $��26��61   $��95��6=   �� 5.   
   -   5        $ label2��5/      $��Скорость: ?��50      $
��Left=�51      $��	121,9,0,0q�52      $	��Top=�53      $��26��6%   $	��118��61   $ 
0.45,0.738&�6=   �� 55   
   -   5        $ label3��56      $��Дистанция: ?��57      $
��Left=�58      $��	238,9,0,0q�59      $	��Top=�5:      $��26��6%   $	��135��61   �� 5<   
   -   5        $ label4��5=      $ ��Время полёта: ?��5>      $
��Left=�5?      $��	372,9,0,0q�5@      $	��Top=�5A      $��26��6%   $	��148��61   5C      5D      