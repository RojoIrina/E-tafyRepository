   M S B A M L   `   `   `  ����K  GModeEthiqueEtafy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ModeEthiqueEtafy.ViewModeEthiqueEtafy.View  5   	   -    'ModeEthiqueEtafy.View.FormulaireVendeur   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ModeEthiqueEtafy.View     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��formulaireVendeur��5	   3     � 
ResizeMode$  NoResize=�6L   .��5      � $��5q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�5         Opacity$	 0.4Q�5       � ColumnDefinitions 5   
   �� 5      $��9* �6   �� 5      $
��315* �6   �� 5      $
��566* �6   �� 5      $��0* �6   .+�5   
   �� 
������� �� CornerRadius$ 	15,0,0,15��6#   $
}�True��6<   $��2��6P   $��0,0,10,0q�6d    J� Clip 5      �� 5       �� Rect$ 0,0,400,645�6$   	 �� RadiusX$	 10Q�67   
 �� RadiusY$
 10Q�5   $   5!      �� 5#   
   $��	0,163,0,0q�6   $	��Top=�6(   $��2��6@   $	��257��6T   .+�5$      � $��63��6   .+�5%      �� $��75��6   $��80��6$   
������ $��0q�6I   �� 5&      -   5         ��Name$ Annuler��5&      $��0q�5'      $��Annuler��5(      ���#753422$��12(�5*      $��
Montserrat)�5+      $
��Bold"�5,   "    � Cursor$
 Hand��5-      $��-4,191,4,-183q�6+    J� RenderTransformOrigin$ 0.5,0.5&�6X   z�5.      V� 5/      .~�50      �� �� 51       �� AngleX$ 1.839Q�6,   �� 52      T� 53       T� X$ 5.057Q�61   54      ��56      �� 57       �� 
TargetType" ��6    .�58      ��  �� Property � �� �� Value �	#FFFBD0D06;    �� Triggers 59      P� 5:   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5;   &   ��  � �� �#28AEED6C   5<   #   5>      ��5@      �� 5A       �� 
TargetType" ��6*   .R�5B      �� $	��150��6%   $��40��61   $ 20��5C   )   #��z��5D   )   ._�5E   "   �� $��Center=�63   $��Center=�5F   7   5G      5H      5J      �� 5L      $8��2C:/Users/rojoa/OneDrive/Documents/Images/logo2.png��6   $��
8,0,35,-39q�6T   5N      5O      �� 5R   
   $��2��6   ���	#FFFBD0D0$ 	0,15,15,0��5T      $��26,0,0,0q�6*   ._�5U      � .+�5V      �� 
������ $��	0,0,-29,0q�62   $��Right=�5W      $	��Top=�65   $��0q�5X      $��56��6-   $	��109��69   �� 5\      $��Center=�6   $
��70 0q�5]      .+�5^      ��  %  !MaterialDesignFloatingHintTextBox#��[  6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom Magasin��5`         FloatingOffset$ 0, -20&�5a      
�������$��	0 0 0 1.5q�5c      ��5_      �� *
NomVendeur+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5c      �� 5d      #��[  6   $ Login��5f      $ 0, -20&�5g      
�������$��	0 0 0 1.5q�5i      $
��0 10q�5j      ��5e      �� *Login+$ TwoWay=�$ PropertyChanged=�5j      �� 5k      #��[  6   $ Contact��5m      $ 0, -20&�5n      
�������$��	0 0 0 1.5q�5p      $
��0 10q�5q      ��5l      �� *	Contact+$ TwoWay=�$ PropertyChanged=�5q      �� 5r      #��[  6   $ 	NIFF/STAT��5t      $ 0, -20&�5u      
�������$��	0 0 0 1.5q�5w      $
��0 10q�5x      ��5s      �� *
NiffStat+$ TwoWay=�$ PropertyChanged=�5x      �� 5y      #��[  6   $# Certification (label ethique)��5{      $ 0, -20&�5|      
�������$��	0 0 0 1.5q�5~      $
��0 10q�5      ��5z      �� *Label+$ TwoWay=�$ PropertyChanged=�5      �� 5�      #��[  6   $ Adresse��5�      $ 0, -20&�5�      
�������$��	0 0 0 1.5q�5�      $
��0 10q�5�      ��5�      �� *	Adresse+$ TwoWay=�$ PropertyChanged=�5�      G� 5�      -   5         G�Name$ 
motDePasse��5�   "    ) %MaterialDesignFloatingHintPasswordBox#��[ 66   $ Mot de passe��5�      $ 0, -20&�5�      
�������$��	0 0 0 1.5q�5�      $
��0 10q�5�      6,   G� 5�      -   5        $ confirmationMotDePasse��5�   "   #��[ 6B   $ Confirmer le mot de passe��5�      $ 0, -20&�5�      
�������$��	0 0 0 1.5q�5�      $
��0 10q�5�      6,   �� 5�      -   5        $ SinscrireBouton��5�      $��
S'inscrire��5�      $	��168��62   
����������#753422$
��Bold"�6f   $��50,30,10,10q�6x   $��70��6�   ��5�      �� *InscriptionVendeurCommand+��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �	#FFFBD0D06?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $ 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      5�      5�      5�      5�      