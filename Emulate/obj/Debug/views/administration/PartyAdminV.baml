   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Emulate.views.administrationEmulate.views.administration  5      k:clr-namespace:Emulate.views.usercontrols.usercontrolsAdmin,Emulate.views.usercontrols.usercontrolsAdmin  5      i9clr-namespace:Emulate.views.usercontrols.listusercontrols+Emulate.views.usercontrols.listusercontrols  5      .    (Emulate.views.administration.PartyAdminV   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Emulate.views.administration     5      IUC:clr-namespace:Emulate.views.usercontrols.usercontrolsAdmin     5      ILUC9clr-namespace:Emulate.views.usercontrols.listusercontrols     5        N� Title$  PartyAdminV��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��40* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Tb��5      $��0��6    $��0��6-   $��2��6=   $��5��6Q   �� 5   
   $��Stretch=�6   $��Stretch=�6/   .+�5      �� $/��)/Emulate;component/imageEmulate/chill.png��6   $��UniformToFill=�6G   ��6_   �� *ActualHeight+ �� ElementName$ Tb����6�   �� *ActualWidth+$ Tb��5      :   4Emulate.views.usercontrols.usercontrolsAdmin.PartyUC  5   
   -   5          Name$ UCParty��5      $��0��6&   $��3��63   $��1��6D   F   @Emulate.views.usercontrols.listusercontrols.ListPartyUserControl  5   
   -   5          Name$ LUCParty��5   #   $��0��65   $��0��6E   $��4��6R   �� 5   
   $��3��6   $��1��6"   $��Center=�62   .+�5      �� -   5         ��Name$ 	btnUpdate��5      $
��Save��6)   
�������
������ 6O   �� 5       -   5        $ btnNew��5       $	��New��6)   
�������
������ 6O   �� 5!      -   5        $ 	btnDelete��5!      $��Delete��6)   
�������
������ 6O   5"      5#      5$      