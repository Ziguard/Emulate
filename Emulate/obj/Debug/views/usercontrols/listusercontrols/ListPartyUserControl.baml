   M S B A M L   `   `   `  ����B  >Emulate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Emulate.views.usercontrols.listusercontrols+Emulate.views.usercontrols.listusercontrols  5      F    @Emulate.views.usercontrols.listusercontrols.ListPartyUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:Emulate.views.usercontrols.listusercontrols     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��10* �6   �� 5      $	��40* �6   .+�5   
   �� -   5         ��Name$ lblListeParty��5      $��Liste Parties��6'   $��0��6?   $��0��6O   $��Center=�6\   $��Center=�6z   $
��Bold"�6�   
������ 
�������$��20(�6�   �� 5   
   -   5         ��Name$ itemList��5      $��0��6%   $��1��65   
������ 
�������$��Disabled=�5      $
��Auto=�5      ��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   5      ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $��2* �6/   �� 5      $��4* �6/     5      �� 5      $��1* �6,   �� 5       $��1* �6,   �� 5!      $��1* �6,   �� 5"      $��1* �6,   .+�5$      �� $ lblNameParty��6    $��0��66   $��0��6F   �� 5%       ��Name$ txtNameParty��6$   $
��Wrap=�6:   $��1��6q   $��0��6�   ��6N   �� *Name+ �� Mode$ TwoWay=�6�   5&      5'      5)      5*      5+      