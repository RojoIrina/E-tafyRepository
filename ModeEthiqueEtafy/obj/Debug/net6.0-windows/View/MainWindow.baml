   M S B A M L   `   `   `  ����K  GModeEthiqueEtafy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ModeEthiqueEtafyModeEthiqueEtafy  5   	   !    ModeEthiqueEtafy.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   *localclr-namespace:ModeEthiqueEtafy  5   	   -   5        $��
mainWindow��5
      $	��450��6   $	��700��6,     � WindowStyle$  SingleBorderWindow=�5   	    � 
ResizeMode$ NoResize=�6*      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   ���	#FFFBD0D0.+�5      �� -   5         ��Name$ InscrireBouton��5      $��
S'inscrire��6-   $	��111��6B   
����������#9D5353$
��Bold"�6v   $��	450,0,0,0q�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value	 �#9D535367   
 �� Triggers
 5       P� 5!       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5"   "   ��  � ��	 �#28AEED6?   5#      5%      ��5'      �� 5(       �� 
TargetType" ��6&   .R�5)      �� $	��100��6!   $��30��6-    �� CornerRadius$ 20��5*   )   #��z��5+   )   ._�5,      �� $��Center=�6/   $��Center=�5-   7   5.      5/      51      �� 52      -   5        $ SeConnecterButton��52      $��Se connecter��60   $��Center=�6G   $	��109��6b   $��
0,10,10,10q�6n   
����������#9D5353$
��Bold"�53      ��54      �� 55      " ��6   .�56      ��  � ��	 �#75342267   
 57      P� 58       �@J�IsMouseOver$
 True��6=   . �59   "   ��  � ��	 �#28AEED6?   5:      5<      ��5>      �� 5?      " ��6&   .R�5@      �� $	��100��6!   $��30��6-   $ 20��5A   )   #��z��5B   )   ._�5C      �� $��Center=�6/   $��Center=�5D   7   5E      5F      5H      5K      �� 5L   
   $��1��6   
�������.+�5M      �� $	��402��6   ���	#FFFBD0D0$ 	0,0,12,12��6:   ._�5O      �� $ 10��6   $��2q�5P       J� Opacity$
 0.95Q�5Q       J� RenderTransformOrigin$ 0.488,0.477&�6   $	��420��6@   
�������$��0,0,0,82q�6_   ._�5R      � $��	0,55,0,38q�6   .+�5T      �� $	��800��5U      $ Vertical=�5V      $��
98,0,98,10q�5W      $��Center=�5X      $��Center=�5Y      .+�5[      �� $��	Bienvenue��6(   $��Center=�5\       ���#9D5353$��45(�5^       $��Medium"�5_       $��
Montserrat)�5`       $��46��68   �� 5b      $	��sur��6(   $��Center=�5c       ���#9D5353$��40(�5e       $��Medium"�5f       $��
Montserrat)�5g       $��47��68   �� 5j      $8��2C:/Users/rojoa/OneDrive/Documents/Images/logo2.png��6$   $	��220��5k      $��90��6(   �� 5o      $�� ''Stylé et engagé ''��6$   $��15(�6D   $��20,0,0,0q�6R   $	��161��6d   �� 5q      ��6.   �� *SelectedView+5r      5u      5w      5y      5�      5�      5�      