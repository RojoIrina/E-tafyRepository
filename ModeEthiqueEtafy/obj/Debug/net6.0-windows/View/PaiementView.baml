   M S B A M L   `   `   `  ����K  GModeEthiqueEtafy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ModeEthiqueEtafy.ViewModeEthiqueEtafy.View  5      (    "ModeEthiqueEtafy.View.PaiementView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      /local#clr-namespace:ModeEthiqueEtafy.View  5      -   5        $��paiementView��5	   /   $	��701��6#   .��5
      �   � RowDefinitions  5   
   �� 5      $��50 �6   6*   �� 5      6   �� 5      $��80 �6   6*   .+�5   
   � ���	#FFFEFEFE$��0,40,0,0q�6&   $��3��68    � ColumnDefinitions 5      �� 5      $
��336* �6#   62   �� 5      $��0* �6#   �� 5      $
��365* �6#   62   .+�5      � $��0��6   $��0,0,176,229q�6#   � 5      $��2��6   $��
0,-10,10,0q�6#    5      �� 5      6)   �� 5      6)     5      �� 5      $��2* �6$   62   �� 5       $��91.144 �6$   66   �� 5!      $	��47* �6$   63   �� 5"      $	��47* �6$   63   �� 5#      $	��25* �6$   63   �� 5$      $	��21* �6$   �� 5%      $	��47* �6$   63   .+�5'      �� -   5         ��Name$ ComptePaiementLabel��5)      $��1��5'      $��1��6(   $��Compte��5(      $
��Bold"�5*      $��15(�5+      $��Center=�5,      ���#753422$��	0,10,0,48q�5-   -   $	��151��6@    J� RenderTransformOrigin$ 0.5,0.5&�6L   z�5.      V� 5/      .~�50      �� �� 51      �� 52       �� Angle$ -0.838Q�6.   T� 53      54      56      �� 57      -   5        $" NumeroTelephonePaiementLabel��59      $��1��57      $��1��6(   $;��5032 56 855 96 / 034 45 888 52 


117 6854 2485 858��58      $��Normal$�5:      ���#753422$
��Bold"�5<      $��0,43,0,2q�6*   5=      �� 5@      -   5        $ NumCompteBancaireLabel��5B      $��1��5@      $��1��6(   $��117 6854 2485 858��5A      $��Normal$�5C      ���#753422$
��Bold"�5E      $��	0,69,0,10q�6*   $��2��6=   �� 5F      $��1��6   $��1��6*    %  !MaterialDesignFloatingHintTextBox#��[  5G      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$" Votre réference de paiement��5H         FloatingOffset$ 0, 10&�5I      
�������$��0 0 0 2q�5K      $��
8,89,28,10q�67   $��2��6K   6^   �� 5M      -   5        $ TelephonePaimentLabel��5O      $��0��5M      $��1��6(   $��Téléphone��5N      $��Normal$�5P      ���#753422$
��Bold"�5R      $��0,43,171,10q�6*   $��2��6?   �� 5T      -   5        $ NumeroComptePaiementLabel��5V      $��0��5T      $��1��6(   $��Numero Compte Bancaire��5U      $��Normal$�5W      ���#753422$
��Bold"�5Y      $��0,69,5,2q�6*   $��2��6<   �� 5[      -   5        $ ReferenceLabel��5]      $��0��5[      $��2��6(   $��	Reference��5\      ���#753422$��Normal$�5_      $
��Bold"�5`      $��	0,12,6,10q�6*   5a      5b      � 5d   
   ���	#FFFBD0D0$��50��6&   $��Center=�62   .+�5e      �� $��Paiement hebergement��6   $
��Left=�5f      $��Center=�5g      $
��Bold"�5h      $��	Condensed&�5i      ���#753422$��17(�5k      5l      5m      �� 5n   
   $��2��6   ���	#FFFBD0D0 �� Orientation$ 
Horizontal=�69   $	��701��6R   $ 0.492,-0.084&�6^   $��Center=�6�   $��80��6�   $��Center=�6�   .+�5o      �� -   5         ��Name$ AnnulerPaiementButton��5o      $��98��5p      $��	170,0,0,0q�5q      $��Annuler��5r      
����������#753422  MaterialDesignRaisedButton#��[ 5v      +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 20��5w      6C   �� 5x      -	   5        $ ValiderPaiementButton��5x      $	��100��5y      $
��Left=�5z      $��	270,0,0,0q�5{      $��Valider��5|      
����������#753422#��[ 5�      $	 20��5�      5�      5�      �� 5�   
   $��1��6   $��0��6    $7��1C:/Users/rojoa/OneDrive/Documents/Images/rojo.jpg��61   $��	0,0,429,2q�6l   5�      5�      