   M S B A M L   `   `   `  ����K  GModeEthiqueEtafy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ModeEthiqueEtafy.ViewModeEthiqueEtafy.View  5   	   -    'ModeEthiqueEtafy.View.InscriptionWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ModeEthiqueEtafy.View     5   	   -   5        $��inscriptionWindow��5   $     � Title$  InscriptionWindow��6	   $	��450��6=   $	��800��6J   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      $	��600 �6   6-   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $	��435 �6    .+�5      �� $;��5C:\Users\rojoa\OneDrive\Documents\Images/Saryrose.jpg��6   $
��Fill=�6S   6d   �� 5       �� Orientation$ Vertical=�6   $��0,0,0,0q�60   .+�5      � .+�5      �� -   5         ��Name$! InscrireEnTantVendeurButton��5      $$��S'inscrire en tant que Vendeur��5      $��Center=�5      $��Center=�5      $��-250,10,5,0q�5      
�������
������ 
������ $��15(�5      �� 5      -   5        $" InscrireEnTantAcheteurButton��5      $$��S'inscrire en tant qu'Acheteur��5       $
��Left=�5!      $	��Top=�5"      $��
306,10,0,0q�5#      
�������
������ 
������ $��15(�5'       J� RenderTransformOrigin$ 0.574,1.295&�6'   $��66��6K   5(      5)      5*      � 5+   
   $��0��6   6   � 5,   
   $��0��6   
�������$��0,0,0,0q�61   .+�5-      �� $8��2C:/Users/rojoa/OneDrive/Documents/Images/logo2.png��6   $��0,131,10,172q�6P   �� 5/      -   5        $ Annuler��5/      $��0q�50      $��Annuler��51      ���#753422$��12(�53      $��
Montserrat)�54      $
��Bold"�55   "    � Cursor$
 Hand��56      $��	0,344,0,5q�6+   ��57      �� 58       �� 
TargetType" ��6   .�59      ��  �� Property � ��	 �� Value	 �	#FFFBD0D067   
 �� Triggers
 5:      P� 5;       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5<   "   ��  � ��	 �#28AEED6?   5=      5?      ��5A      �� 5B       �� 
TargetType" ��6&   .R�5C      �� $	��100��6!   $��30��6-    �� CornerRadius$ 20��5D   )   #��z��5E   )   ._�5F      �� $��Center=�6/   $��Center=�5G   7   5H      5I      5K      5M      5O      5Q      