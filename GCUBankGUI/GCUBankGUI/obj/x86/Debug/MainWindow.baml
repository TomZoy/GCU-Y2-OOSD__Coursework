   M S B A M L   `   `   `  ����  
GCUBankGUI    GCUBankGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��400��6)   .��5      � $��3,3,10,3q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5	      $
��Auto �6   6,   �� 5
      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6!   $��3q�61   $��Center=�6<   $
��Left=�6W   $��Account No: ��6r   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtAccountNumber��5   r   $��0��6   $��1��6!   $��3q�61   $��Center=�6<   $
��Left=�6W   $��14(�6�   $
��Bold"�6�   ��6�   ��  �� Path$ AccountNumber� �� Mode$ OneTime=��� 5   
   -   5        $ 
txtBalance��5   h   $��0��6   $��1��6!   $��Center=�61   $��Right=�6L   $��14(�6|   $
��Bold"�6�   $��5q�6�   �� 5    
   $��2��6   $��0��6!   $��Center=�61   $��Transaction amount: ��6L   $��5q�6h   �� 5!   
   -   5         ��Name$ 	txtAmount��5!   K   $��2��6   $��1��6   $��Center=�60   $��5q�6^   �� 5"   
   $��1��6   $��0��6!   $��3q�61   $��Transaction type: ��6<   $��Center=�6W   �� 5#   
   -   5        $��cmbType��5#   L   $��1��6   $��1��6    $��Center=�61   $��5q�6[    �� SelectedIndex$ 0��6~   ��6f   �� .@�5$      �� $��Credit��6   �� 5%      $��
Withdrawal��6   5&      �� 5'   
   -   5         ��Name$ btnSave��5'   .   $��3��6   $��0��6   $��5q�6@   .��6a   Save Transaction6s   �� 5*   
   $��4��6   $��0��6!   $��3q�61   $	��Top=�6<   $��Transactions: ��6T   �� 5,      -   5        	 ��Name$	 lstTransactions��5,   n   $��4��6   $��1��6#   $��Stretch=�64   $��Stretch=�6P   $��5q�6�   5/      50      