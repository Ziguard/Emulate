   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Emulate.views.gameEmulate.views.game  5      )    #Emulate.views.game.CreatePartyViews   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Emulate.views.game     5        N� Title$  
PartyAdmin��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Tb��5      $��0��6    $��0��60   $��4��6=   �� 5   
   $��Stretch=�6   $��Stretch=�6/   .+�5      �� $/��)/Emulate;component/imageEmulate/chill.png��6   $��UniformToFill=�6G   ��6_   �� *ActualHeight+ �� ElementName$ Tb����6�   �� *ActualWidth+$ Tb��5      �� 5   
   -   5         ��Name$ lblNameParty��5      $#��Choisisez le Nom de la Partie��6&   $��Center=�6N   $��Center=�6k   $
��Bold"�6�   $��0��6�   $��0��6�   
�������6�   �� 5   
   -   5         ��Name$ txtBPartyName��5       �� TextWrapping$
 Wrap=�6R   $��0��6f   $��1��6v   $	��110��6�   $��30��6�   ��6)   �� *
Party.Name+ �� Mode$ TwoWay=�6�   �� 5   
   -   5         ��Name$ btnValidate��5      $
��Save��6&   $��0��65   $��2��6E   $��Center=�6R   $��Center=�6m   $	��110��6�   $��30��6�   
������ 6�   5      5      