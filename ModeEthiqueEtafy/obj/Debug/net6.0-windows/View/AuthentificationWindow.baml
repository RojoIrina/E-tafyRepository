   M S B A M L   `   `   `  ����K  GModeEthiqueEtafy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ModeEthiqueEtafy.ViewModeEthiqueEtafy.View  5   	   2    ,ModeEthiqueEtafy.View.AuthentificationWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ModeEthiqueEtafy.View     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��authentificationWindow��5	   	   $	��450��6'   $	��700��64     � WindowStartupLocation$  CenterScreen=�5
   	   
������ $��15(�5   	      MaterialDesignFont#���   5   	    � 
ResizeMode$ NoResize=�5   
    � WindowStyle$ SingleBorderWindow=�6    .��5      � ���	#FFFBD0D0 � ColumnDefinitions 5   
   �� 5      $	��200 �6   6.   �� 5      6"   .+�5   
   � 
�������.+�5      �� $8��2C:/Users/rojoa/OneDrive/Documents/Images/logo2.png��6   $	��220��5      $��90��6(   5      �� 5   
   $��1��6   ���	#FFFBD0D0$	��300��5       �� Orientation$ Vertical=�5      $��Center=�5      $��Center=�5      $	��335��68   .+�5$      �� $��40(�6   $	��198��6&   $��47��62   $��Light"�5%      
�������$��	Connexion��5&      �� 5+       % !MaterialDesignFloatingHintTextBox#��[ 6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ E-mail��5-         FloatingOffset$ 0, -20&�5.      
�������$��	0 0 0 1.5q�50      $
��0 10q�51      ��5,      �� *LoginConnex+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��51   ,   54      G� 55      -   5         ) %MaterialDesignFloatingHintPasswordBox#��[ 55      $ Mot de passe��56      $ 0, -20&�57      
�������$��	0 0 0 1.5q�59      $
��0 20q�5:      5;   N   �� 5<      $ 
Horizontal=�6   $��Center=�5=   !   $��0,30,0,0q�5>   !   �� 5?      -   5        	 ��Name$	 LoginButton��5?      $��0q�5@      $�� Se connecter��5A      ���#753422$��12(�5C      $��
Montserrat)�5D      $
��Bold"�5E      
 � Cursor$

 Hand��5F      ��5G      �� *SeConnecter+$ PropertyChanged=�$ TwoWay=���5H      �� 5I       �� 
TargetType" ��6   .�5J      ��  �� Property � �� �� Value
 �����67    �� Triggers 5K      P� 5L       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5M   "   ��  � �� �#28AEED6?   5N      5P      ��5R      �� 5S       �� 
TargetType" ��6&   .R�5T      �� $	��100��6!   $��30��6-    �� CornerRadius$ 20��5U   )   #��z��5V   )   ._�5W      �� $��Center=�6/   $��Center=�5X   7   5Y      5Z      5\      �� 5]      -   5        $	 Annuler��5]      $��0q�5^      $��Annuler��5_      ���#753422$��12(�5a      $��
Montserrat)�5b      $
��Bold"�5c   "   $

 Hand��5d      $��0,12,0,5q�6+   ��5e      �� 5f      " ��6   .�5g      ��  � ��
 �����67    5h      P� 5i       �@J�IsMouseOver$
 True��6=   . �5j   "   ��  � �� �#28AEED6?   5k      5m      ��5o      �� 5p      " ��6&   .R�5q      �� $	��100��6!   $��30��6-   $ 20��5r   )   #��z��5s   )   ._�5t      �� $��Center=�6/   $��Center=�5u   7   5v      5w      5y      5z      5}      5~      