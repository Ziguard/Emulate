   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Emulate.views.usercontrolsEmulate.views.usercontrols  5      ?$clr-namespace:Emulate.entities.enumsEmulate.entities.enums  5      9    3Emulate.views.usercontrols.usercontrolsAdmin.ItemUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Emulate.views.usercontrols     5      6enums$clr-namespace:Emulate.entities.enums     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��11* �6   �� 5      $	��64* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ lblName��5      $
��Name��6!   $��0��60   $��0��6@   $��2��6M   $��Center=�6b   $��	0,0,221,0q�6}   
�������6�   �� 5   
   -   5         ��Name$ txtBName��5       �� TextWrapping$
 Wrap=�6M   $��1��6a   $��0��6q   $	��110��6~   $��30��6�   ��6$   �� *
Items.Name+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ lblIlvl��5      $
��Ilvl��6!   $��0��60   $��1��6@   $��2��6M   $��Center=�6a   $��	0,0,221,0q�6|   
�������6�   �� 5   
   -   5        $ txtIlvl��5      $
 Wrap=�6L   $��1��6`   $��1��6p   $	��110��6}   $��30��6�   ��6#   �� *
Items.Ilvl+$ TwoWay=�6�   �� 5   
   -   5        $ lblEmplacement��5      $��Emplacement��6(   $��0��6>   $��2��6N   $��2��6[   $��Center=�6o   $��	0,0,221,0q�6�   
�������6�   �� 5   
   -   5         ��Name$ emplacement��5      $��1��6�   $��2��6�   $��20��6�   $	��110��6�    �� Text 6(   �� *Items.Emplacement+$ TwoWay=���6Y   ��  �� Source 7   1Emulate.entities.enums.EnumBindingSourceExtension  *M� *enums:Emplacement++6�   5      5       