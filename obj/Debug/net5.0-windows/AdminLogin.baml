   M S B A M L   `   `   `  ����I  EVendingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VendingMachineVendingMachine  5   	       VendingMachine.AdminLogin   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:VendingMachine     5   	     � Title$;  5Вход в панель администратора��5   	    � SizeToContent$ WidthAndHeight=�6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��
Логин��6   $��0��6    $��0��6-   �� 5   
   -   5         ��Name$ login��5      $��0��6!   $��1��6.   $	��150��6>   $��5q�6J   �� 5   
   $��Пароль��6   $��1��6!   $��0��6.   G� 5   
   -   5         G�Name$ password��5      $��1��6(   $��1��65   $	��150��6E   $��5q�6Q    G� PasswordChar$ *��6\   �� 5   
   -   5         ��Name$ cancel��5      $��Отмена��6!   
���  ��$��2��6C   $��0��6P   $	��100��6`   $��5q�6�   �� 5   
   -   5        $ enter��5      $��
Войти��6    
��� � �$��2��6C   $��1��6P   $	��100��6`   $��Right=�6l   $��5q�6�   5      5      