   M S B A M L   `   `   `  ����E  ACherryCalc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CherryCalc
CherryCalc  5   	       CherryCalc.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CherryCalc     5   	     � Title$  Simple Calculator��5   	   $	��620��6#   $	��400��60    � Icon$ /Calculator-icon.png��6<    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � �� �#1E202A6=   �� 5       � �� �#f9ff006=   �� 5       � ��$ 2q�60   6<   �� 5       � �� �#0006;   �� 5       � ��$ 20(�6)   66   5      5      .��5      � -   5        $��MainGrid��5       � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��
InOutField��5   e   $��0��6   $��35(�6!    �� TextAlignment$ Right=�6/    �� Padding$ 20q�6E   ���#fff��5       �� 5!      	 �� 
StartPoint$	 0.5,0&�6'   
 �� EndPoint$
 0.5,1&�6:   .��5"      �  � Color$ #000000��6#    � Offset$	 0.4Q�63   � 5$      $ #929500��6#   $	 0.9Q�64   5%      5'      �� 5)   
   -   5        $��Execute��5)      $��30(�6#   $
��Bold"�61   $��2��6C   
���   �$��2q�6d   ���#f9ff006�   5,      5-      