   M S B A M L   `   `   `  ����B  >Encrypt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EncryptEncrypt  5   	       Encrypt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Encrypt     5   	   $��14(�5   	     � Title$  
MainWindow��5	   	   $	��550��6   $	��800��6)   .��5
      � $��0,0,0,-1q�6   .+�5   
   �� -   5        $��SelectEncryptionCombobox��5      $
��Left=�63   $��	80,64,0,0q�6N   $	��Top=�6a   $	��120��5       �� SelectedIndex$ 0��6   .@�5      �� AES6   �� 5      DES6   �� 5      	TripleDes6#   5      �� 5   
   $��Select Encryption��6   $
��Left=�6,   $��	80,34,0,0q�6G   $	��Top=�6Z   $	��120��5      �� 5   
   -   5        $��KeyText��5      $
��Left=�6!   $��
280,64,0,0q�6<    �� TextWrapping$
 Wrap=�6P   $	��Top=�5      $	��380��6*   �� 5   
   $	��Key��6   $
��Left=�6   $��
280,35,0,0q�69   $	��Top=�6M   $	��120��6e   �� 5   
   -   5         ��Name$ IvText��5      $
��Left=�6"   $��280,114,0,0q�6=   $
 Wrap=�6R   $	��Top=�5      $	��380��6*   �� 5   
   $��IV��6   $
��Left=�6   $��
280,85,0,0q�68   $	��Top=�6L   $	��120��6d   �� 5   
   -   5        $��GenerateKeyAndIv��5      $��Generate Key and IV��6)   $
��Left=�6G   $��
80,111,0,0q�6b   $	��Top=�5      $	��141��6)   65   �� 5   
   -   5        $��Encrypt��5      $��Encrypt��6    $
��Left=�62   $��
79,189,0,0q�6M   $	��Top=�6a   $	��141��5      6   �� 5   
   $��Cipher Text��6   $
��Left=�6&   $��282,160,0,0q�6A   $	��Top=�6V    J� RenderTransformOrigin$ 0.469,1.713&�5      �� 5   
   -   5        $ EncryptedAsciiText��5      $
��Left=�6.   $��280,188,0,0q�6I   $
 Wrap=�6^   $	��Top=�5       $	��380��6*   �� 5!   
   $��ASCII��6   $
��Left=�6    $��237,184,0,0q�6;   $	��Top=�6P   �� 5"   
   -   5        $ EncryptedHexText��5"      $
��Left=�6,   $��280,238,0,0q�6G   $
 Wrap=�6\   $	��Top=�5#      $	��380��6*   �� 5$   
   $	��HEX��6   $
��Left=�6   $��244,234,0,0q�69   $	��Top=�6N   �� 5%   
   $��
Plain Text��6   $
��Left=�6%   $��283,280,0,0q�6@   $	��Top=�6U   $ 0.469,1.713&�5&      �� 5'   
   -   5        $ DecryptedText��5'      $
��Left=�6)   $��280,308,0,0q�6D   $
 Wrap=�6Y   $	��Top=�5(      $	��380��6*   �� 5)   
   $��Time for Decrypt��6   $
��Left=�6+   $��266,384,0,0q�6F   $	��Top=�6[   �� 5*   
   -	   5        $��Decrypt��5*      $��Decrypt��6    $
��Left=�62   $��
80,306,0,0q�6M   $	��Top=�6a   $	��140��5+      6   �� 5,   
   -
   5        $��MessageText��5,      $
��Left=�6%   $��
280,19,0,0q�6@   $��Hello Teacher!��6T   $
 Wrap=�5-      $	��Top=�6&   $	��380��6>   �� 5.   
   $��Time for Encrypt��6   $
��Left=�6+   $��504,385,0,0q�6F   $	��Top=�6[   �� 5/   
   -   5        $��DecryptTimeLabel��5/      $��0��6(   $
��Left=�64   $��275,415,0,0q�6O   $	��Top=�50      $ 1.425,0.491&�6(   �� 51   
   -   5        $��EncryptTimeLabel��51      $��0��6(   $
��Left=�64   $��507,419,0,0q�6O   $	��Top=�52      54      55      