   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Emulate.views.gameEmulate.views.game  5      a5clr-namespace:Emulate.views.usercontrols.usercontrols'Emulate.views.usercontrols.usercontrols  5      i9clr-namespace:Emulate.views.usercontrols.listusercontrols+Emulate.views.usercontrols.listusercontrols  5      )    #Emulate.views.game.DonjonStartViews   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Emulate.views.game     5      DUC5clr-namespace:Emulate.views.usercontrols.usercontrols     5      ILUC9clr-namespace:Emulate.views.usercontrols.listusercontrols     5        N� Title$  DonjonStartViews��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��22* �6   �� 5      $	��62* �6   �� 5      $	��22* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Tb��5      $��0��6    $��0��6-   $��5��6=   $��3��6N   �� 5   
   $��Stretch=�6   $��Stretch=�6/   .+�5      �� $0��*/Emulate;component/imageEmulate/donjon.jpg��6   $��UniformToFill=�6H   ��6`   �� *ActualHeight+ �� ElementName$ Tb����6�   �� *ActualWidth+$ Tb��5      E   ?Emulate.views.usercontrols.listusercontrols.ListBossUserControl  5   
   -   5          Name$ 
UCListBoss��5   "   $��0��66   $��0��6F   $��4��6S    J� Opacity$	 0.5Q�6d   �� 5   
   -   5         ��Name$ btnLancerQuete��5      $��Demarrer le Donjon��6)   $��1��6F   $��0��6V   $��Center=�6c   $��Center=�6�   $
��Bold"�6�   
�������
������ $��30��6�   �� 5    
   -   5         ��Name$ lblTimeDonjon��5       $��1��6`   $��1��6p   $��Center=�6}   $��Center=�6�   
���������6*   �� *Donjon.TempsDonjon+	 �� Mode$	 TwoWay=�6�   �� 5!   
   -   5        $ ilvlRecommande��5!      $��1��6`   $��2��6p   $��Center=�6}   $��Center=�6�   
���������6*   �� *Donjon.ilvlLuck+$	 TwoWay=�6�   �� 5"   
   -   5        $ 	btnCancel��5"      $��Précédent��6$   $��1��68   $��3��6H   $��Center=�6U   $��Center=�6r   $
��Bold"�6�   
������ 
�������$��30��6�   $	��110��6�   �� 5$   
   -   5        $ LabelListItem��5$      $��
Liste Loot��6'   $��3��6<   $��0��6L   $��Center=�6Y   $��Center=�6v   $	 0.5Q�6�   F   @Emulate.views.usercontrols.listusercontrols.ListItemsUserControl  5%   
   -   5        
  Name$
 
UCListLoot��5%   #   $��3��67   $��1��6G   $��4��6T   $	 0.5Q�6e   5&      5'      