   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FinalAssignment.ViewsFinalAssignment.Views  5   	   (    "FinalAssignment.Views.NewOrderView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FinalAssignment.Views     5   	   $	��394��5      $��534.667��6'   .��5	      � 
��� ��.+�5
   
   ��   �� Orientation$  
Horizontal=�6   .+�5      �� $��165,60,0,313.6q�6   $��85��60    J� RenderTransformOrigin$ 0.664,0.935&�6;   �� 6`   $�Order Number:��6d   6|   �� 5       �� 	MaxLength$ 8��69   $	��120��6G   $��2,60,0,313.6q�6S   $ 0.935,-2.073&�6i   ��6   ��  �� Path$ UOrderNumber�6i   5      �� 5   
   $  
Horizontal=�6   .+�5      �� $��165,80,0,293.6q�6   $��85��60   $ 0.664,0.935&�6;   �� 6`   $�Purchase Date:��6d   6}   �� 5      $	��120��6:   $��2,80,0,293.6q�6F   $ 0.935,-2.073&�6\   ��6   �� $ UPurchaseDate�6\   5      �� 5   
   $  
Horizontal=�6   .+�5      �� $��165,100,0,273.6q�6   $��85��61   $ 0.664,0.935&�6<   �� 6a   $�
Purchaser:��6e   6z   �� 5      $ 38��67   $	��120��6F   $��2,100,0,273.6q�6R   $ 0.935,-2.073&�6i   ��6   �� $ 
UPurchaser�6i   5      �� 5   
   $  
Horizontal=�6   .+�5      �� $��165,120,0,253.6q�6   $��85��61   $ 0.664,0.935&�6<   �� 6a   $�Order Total:��6e   6|   �� 5      $	��120��68   $��2,120,0,253.6q�6D   $ 0.935,-2.073&�6[   ��6   �� $ UOrderTotal�6[   5      �� 5   
   $  
Horizontal=�6   .+�5      �� $��12,152,0,223.6q�6   $	��168��60   $ 0.664,0.935&�6<   �� 6a   $�Order Items��6e   6{   5      �� 5   
   $  
Horizontal=�6   .+�5      �� $��20(�6   $
��Bold"�6&   $��175,10,10,355.6q�68   $	��511��6Q   $ 0.664,0.935&�6]   �� 6�   $�Create New Order��6�   6�   5      �� 5    
   -   5         ��Name$ OrdersB��5       $��Orders��6"   $
��Left=�63   $��
20,433,0,0q�6N   $	��Top=�6b   $	��115��6z   6�   �� 5!   
   -   5        $ 
InventoryB��5!      $��	Inventory��6%   $��Center=�69   $��215,433,199,0q�6V   $	��Top=�6m   $	��103��6�   6�   �� 5"   
   -   5        $ 
NewOrdersB��5"      $��
New Orders��6%   $��Right=�6:   $��
0,433,10,0q�6V   $	��Top=�6j   $	��103��6�   6�   �� 5#   
   -   5         ��Name$ OrdersViewList��5#      $
��Left=�6+   $	��172��6F   $��
10,175,0,0q�6S   $	��Top=�6g   $	��514��6    �� SelectedItem 6�   �� $ SelectedItem� �� Mode$ TwoWay=���6�   �� $ AllItems� �� View 5$      �� 5%      	 �� ColumnHeaderStringFormat$	  ��6   .P�5&      �� 
 �� Width$	
 100��6%   $��Order Number��61    �� DisplayMemberBinding 5'   %   �� $ OrderItemNumber��� 5(      $	
 125��6%   $��Quantity��61    5)   %   �� $ Quantity��� 5*      $	
 150��6%   $��Cost Per Item��61    5+   %   �� $ ItemCost��� 5,      $	
 150��6%   $
��Item��61    5-   %   �� $ 	Item.Name�5.      50      �� 51   
   -   5        $ SaveBtn��51   r   
�������
��� d �$
��Bold"�6_   $��
Save Order��6�   $
��Left=�6�   $��
10,352,0,0q�6�   $	��Top=�6�   $	��514��6�   $��32��6�   ��6   �� $ 
SaveOrderB�6�   53      54      