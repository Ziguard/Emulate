   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Emulate.views.usercontrolsEmulate.views.usercontrols  5      9    3Emulate.views.usercontrols.usercontrolsAdmin.LootUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Emulate.views.usercontrols     5        � 	Resources  5	      ��%    5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ lblParty��5      $��PartyID��6"   $��0��64   $��0��6D   $��2��6Q   $
��Left=�6f   $��Center=�6�   
�������6�   �� 5   
   -   5         ��Name$ txtParty��5      $��1��6Q   $��0��6a   $��30��6n   $	��110��6z   ��6$   �� *Loot.Party.Id+ �� Mode$ TwoWay=�6z   �� 5   
   -   5        $ lblChar��5      $��CharacterID��6!   $��0��67   $��1��6G   $��2��6T   $
��Left=�6h   $��Center=�6�   
�������6�   �� 5   
   -   5        $ txtCharacter��5      $��1��6Z   $��1��6j   $��30��6w   $	��110��6�   ��6(   �� *Loot.Character.Id+$ TwoWay=�6�   �� 5   
   -   5        $ lblItem��5      $��ItemID��6!   $��0��62   $��2��6B   $��2��6O   $
��Left=�6c   $��Center=�6~   
�������6�   �� 5   
   -   5        $ txtbItem��5      $��1��6$   $��2��6`   $��30��6m   $	��110��6y   ��64   �� *Loot.ItemsId+$ TwoWay=�6y   5      5      