   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Emulate.views.gameEmulate.views.game  5      a5clr-namespace:Emulate.views.usercontrols.usercontrols'Emulate.views.usercontrols.usercontrols  5      i9clr-namespace:Emulate.views.usercontrols.listusercontrols+Emulate.views.usercontrols.listusercontrols  5      "    Emulate.views.game.PlayViews   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Emulate.views.game     5      DUC5clr-namespace:Emulate.views.usercontrols.usercontrols     5      ILUC9clr-namespace:Emulate.views.usercontrols.listusercontrols     5        N� Title$  	PlayViews��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��11* �6   �� 5      $	��22* �6   �� 5      $	��22* �6   �� 5      $	��22* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Tb��5      $��0��6    $��0��6-   $��5��6=   $��4��6N   �� 5   
   $��Stretch=�6   $��Stretch=�6/   .+�5      �� $0��*/Emulate;component/imageEmulate/forest.jpg��6   $��UniformToFill=�6H   ��6`   �� *ActualHeight+ �� ElementName$ Tb����6�   �� *ActualWidth+$ Tb��5      �� 5   
   -   5         ��Name$ 	btnDonjon��5      $��Lancer Donjon��6$   $��0��6<   $��0��6L   $��Center=�6Y   $��Center=�6v   $
��Bold"�6�   
������ 
�������6�   �� 5   
   -   5         ��Name$ lblGestionPersonnage��5      $��Gestion Personnage��6.   $��1��6K   $��0��6[   $��Center=�6h   $��Center=�6�   
�������6�   G   AEmulate.views.usercontrols.listusercontrols.ListDonjonUserControl  5!   
   -   5          Name$ UCListDonjon��5!   $   $��0��6:   $��1��6J   $��3��6W   C   =Emulate.views.usercontrols.usercontrols.PersonnageUserControl  5#   
   -   5          Name$ UCPersonnage��5#   #   $��1��69   $��1��6I   $��3��6V   I   CEmulate.views.usercontrols.listusercontrols.ListItemsBagUserControl  5%   
   -   5        	  Name$	 UCListLootSac��5%   &   $��2��6=   $��1��6M   $��3��6Z   K   EEmulate.views.usercontrols.listusercontrols.ListPersonnageUserControl  5'   
   -   5        
  Name$
 UCListPersonnage��5'   (   $��4��6B   $��1��6R   $��3��6_   5)      5*      