   M S B A M L   `   `   `  ����K  GModeEthiqueEtafy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ModeEthiqueEtafy.ViewModeEthiqueEtafy.View  5      4    .ModeEthiqueEtafy.View.VendeurInscriptionWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   /local#clr-namespace:ModeEthiqueEtafy.View  5      .��5
      � $��5q�6     J� Effect  5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6      ShadowDepth$ 1Q�5         Opacity$	 0.4Q�5       � ColumnDefinitions 5   
   �� 5      $
��162* �6   �� 5      $
��170* �6   �� 5      $
��113* �6   .+�5   
   �� ���#753422 �� CornerRadius$ 	15,0,0,15��6&   $
}�True��6?   $��2��6S   $��	0,0,340,0q�6g    J� Clip 5      �� 5       �� Rect$ 0,0,400,645�6$    �� RadiusX$ 10Q�67   	 �� RadiusY$	 10Q�5   $   5      �� 5!   
   $��0,505,340,0q�6   $	��Top=�6*   $��2��6B   .+�5#      �� $��20(�6   $	��240��6&   $��Light"�5$      
�������$!��Vous avez déjà un compte?��5%      �� 5&      $��10(�6   $	��240��6&   $��Light"�5'      
�������$7��1Connectez-vous pour profiter de notre application��5(      � 5)      .+�5*      �� $��75��6   $��80��6$   
������ $��0q�6I   .��5+      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Login=�6.   $��60��5,   *   $��60��5-   *   $��Center=�5.   *   $��Center=�5/   *    J� Opacity$	 0.7Q�50   *   ���#FFEBC951   *   53      56      57      �� 5:   
   $��1��6   ���#FFEBC9$ 	0,15,15,0��5<      $��2��6*   ._�5=      � .+�5>      �� 
������ $��	0,0,-29,0q�62   $��Right=�5?      $	��Top=�65   $��0q�5@      $��56��6-   $	��109��69   .��5B        $
 Close=�6.   $��Right=�5C   *   $	 0.5Q�5D   *   
���\\��$��32��5E   A   $��38��6M   5G      �� 5K      $��Center=�6   $
��70 0q�5L      .+�5M      ��  %  !MaterialDesignFloatingHintTextBox#��[  6   $�� ��5N      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nom Magasin��5O         FloatingOffset$ 0, -20&�5P      
�������$��	0 0 0 1.5q�5R      �� 5S      #��[  6   $�� ��5T      $ Login��5U      $ 0, -20&�5V      
�������$��	0 0 0 1.5q�5X      $
��0 27q�5Y      �� 5Z      #��[  6   $�� ��5[      $ Contact��5\      $ 0, -20&�5]      
�������$��	0 0 0 1.5q�5_      $
��0 10q�5`      �� 5a      #��[  6   $�� ��5b      $ 	NIFF/STAT��5c      $ 0, -20&�5d      
�������$��	0 0 0 1.5q�5f      �� 5g      #��[  6   $�� ��5h      $# Certification (label ethique)��5i      $ 0, -20&�5j      
�������$��	0 0 0 1.5q�5l      G� 5m       ) %MaterialDesignFloatingHintPasswordBox#��[ 6"   $ Mot de passe��5o      $ 0, -20&�5p      
�������$��	0 0 0 1.5q�5r      $
��0 20q�5s      G� 5t      #��[ 6"   $ Confirmer le mot de passe��5v      $ 0, -20&�5w      
�������$��	0 0 0 1.5q�5y      $
��0 20q�5z      �� 5|      $��
0 40 0 20 q�6   $��16(�5}      .��5~      �� �� 5      
�������.�65   /-En vous inscrivant, vous vous engagez à ....6c   5�      5�      �� 5�      $��
S'inscrire��6   ���#753422
�������$	��100��5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5�        MaterialDesignFlatButton#��[ 5�      6Q   5�      5�      5�      5�      5�      