   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Emulate.views.administrationEmulate.views.administration  5      k:clr-namespace:Emulate.views.usercontrols.usercontrolsAdmin,Emulate.views.usercontrols.usercontrolsAdmin  5      i9clr-namespace:Emulate.views.usercontrols.listusercontrols+Emulate.views.usercontrols.listusercontrols  5      .    (Emulate.views.administration.ItemsAdminV   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Emulate.views.administration     5      IUC:clr-namespace:Emulate.views.usercontrols.usercontrolsAdmin     5      ILUC9clr-namespace:Emulate.views.usercontrols.listusercontrols     5        N� Title$  ItemsAdminV��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��40* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Tb��5      $��0��6    $��0��6-   $��2��6=   $��5��6Q   �� 5   
   $��Stretch=�6   $��Stretch=�6/   .+�5      �� $/��)/Emulate;component/imageEmulate/chill.png��6   $��UniformToFill=�6G   ��6_   �� *ActualHeight+ �� ElementName$ Tb����6�   �� *ActualWidth+$ Tb��5      9   3Emulate.views.usercontrols.usercontrolsAdmin.ItemUC  5   
   -   5          Name$ UCItems��5      $��0��6%   $��3��62   $��1��6C   F   @Emulate.views.usercontrols.listusercontrols.ListItemsUserControl  5   
   -   5          Name$ LUCItems��5   #   $��0��65   $��4��6B   $��0��6S   �� 5   
   $��3��6   $��1��6"   $��Center=�62   .+�5      �� -   5         ��Name$ 
btnNouveau��5      $��Nouveau��6)   
�������
������ 6T   �� 5      -   5        $ btnMettreAjour��5      $	��Maj��6-   
�������
������ 6T   �� 5       -   5        $ btnSupprimer��5       $��	Supprimer��6+   
�������
������ 6T   5!      5"      5#      