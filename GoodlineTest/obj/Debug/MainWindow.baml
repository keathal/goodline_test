   M S B A M L   `   `   `  ����G  CGoodlineTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GoodlineTestGoodlineTest  5   	       GoodlineTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GoodlineTest     5   	     � Title$  GoodlineTest��5   	   $	��450��6   $	��450��6+   .��5	      � 
�������.+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dgMain��5
   )   
����� �$��10,36,10,55q�67      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� 	 �� Path$	 id�6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Avatar��6)   $ 70 69   
   CellTemplate
 5      �� 5      .R�5      �� $��70��6$   ��6/   �� $	 avatar�6P   5      5        5      $
 Name��6%   $ 1* 6W    63   �� $	 
first_name�6d     5      $ Surname��6%   $ 1* 6Y    66   �� $	 	last_name�6f   5      �� 5   
   -   5        $��b_next��5   <   
����ح�$��	Next page��6(   $��Right=�6J   $��10q�6f   $��Bottom=�6r   $��90��6�   $��30��6�   6�   �� 5   
   -   5        $��b_prev��5   @   
����ح�$��Previous page��6(   $��Right=�6N   $��
0,0,105,10q�6j   $��Bottom=�6~   $��90��6�   $��30��6�   6�   �� 5   
   -   5        $��t_status��5      $��Downloading...��6    $��Right=�69   $��10q�6U   $	��Top=�6a   $	��150��6y   5      5      