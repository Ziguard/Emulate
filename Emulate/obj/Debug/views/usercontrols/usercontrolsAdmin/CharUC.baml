   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Emulate.views.usercontrolsEmulate.views.usercontrols  5      ?$clr-namespace:Emulate.entities.enumsEmulate.entities.enums  5      9    3Emulate.views.usercontrols.usercontrolsAdmin.CharUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Emulate.views.usercontrols     5      6enums$clr-namespace:Emulate.entities.enums     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ lblName��5      $
��Name��6!   $��0��60   $��0��6@   $��2��6M   $
��Left=�6a   $��Center=�6|   
�������6�   �� 5   
   -   5         ��Name$ txtBName��5       �� TextWrapping$
 Wrap=�6Q   $��0��6e   $��1��6r   $��Center=�6�   $��30��6�   $	��110��6�   ��6$   �� *Character.Name+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ lblIlvl��5      $
��Ilvl��6!   $��0��60   $��1��6@   $��2��6M   $
��Left=�6a   $��Center=�6|   
�������6�   �� 5   
   -   5        $ txtIlvl��5      $
 Wrap=�6P   $��1��6d   $��1��6q   $��Center=�6�   $��30��6�   $	��110��6�   ��6#   �� *Character.Ilvl+$ TwoWay=�6�   �� 5   
   -   5        $ 	lblClasse��5      $��Classes��6#   $��0��65   $��2��6E   $��2��6R   $
��Left=�6f   $��Center=�6�   
�������6�   �� 5   
   -   5         ��Name$ 	cmbClasse��5      $��2��6w   $��1��6�   $��Center=�6�   $��30��6�   $	��110��6�   ��6&   ��  �� Source 7   1Emulate.entities.enums.EnumBindingSourceExtension  *M� *enums:Classes++6�   �� 5   
   -   5        $ lblLoot��5      $
��Loot��6!   $��0��60   $��3��6@   $��2��6M   $
��Left=�6a   $��Center=�6|   
�������6�   �� 5   
   -   5         ��Name$ btnLoot��5      $��1��6"   $��3��62   $��Center=�6?   $��Center=�6\   $��Voir Les Loots��6w   $��30��6�   $	��110��6�   5       5!      