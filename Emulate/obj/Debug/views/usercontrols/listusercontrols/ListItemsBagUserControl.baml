   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Emulate.views.usercontrols.listusercontrols+Emulate.views.usercontrols.listusercontrols  5      I    CEmulate.views.usercontrols.listusercontrols.ListItemsBagUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:Emulate.views.usercontrols.listusercontrols     5      .��5	      � .+�5
   
   �� -   5          ��Name$  itemList��5
      $��Disabled=�6%   $
��Auto=�6[   
������ 
���������5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   5      ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $��1* �6/   �� 5      $��1* �6/   �� 5      $��1* �6/   �� 5      $��2* �6/    � RowDefinitions 5      �� 5      $��1* �6,   �� 5      $��1* �6,   .+�5      ��  ��Name$ 	lblidLoot��6    $��IdLoot��63   $��0��6D   $��0��6T   
�������6a   �� 5        ��Name$ 	txtIdLoot��6$   $
��Wrap=�67   $��0��6l   $��1��6|   $��Center=�6�   
���������6K   �� *Id+ �� Mode$ TwoWay=�6�   �� 5"      $ 
lblIdItems��6    $��IdItems��64   $��1��6F   $��0��6V   
�������6c   �� 5#      $ 
txtIdItems��6$   $
��Wrap=�68   $��1��6r   $��1��6�   $��Center=�6�   
���������6L   �� *	ItemsId+$ TwoWay=�6�   �� 5%      $ 
lblIdParty��6    $��IdParty��64   $��2��6F   $��0��6V   
�������6c   �� 5&      $ 
txtIdParty��6$   $
��Wrap=�68   $��2��6s   $��1��6�   $��Center=�6�   
���������6L   �� *
Party.Id+$ TwoWay=�6�   �� 5(      $ 	lblIdChar��6    $��IdPersonnage��63   $��3��6J   $��0��6Z   
�������6g   �� 5)      $ 	txtIdChar��6$   $
��Wrap=�67   $��3��6v   $��1��6�   $��Center=�6�   
���������6K   �� *Character.Id+$ TwoWay=�6�   5*      5+      5-      5.      5/      