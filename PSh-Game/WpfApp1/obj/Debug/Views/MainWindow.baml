   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1260��6)    � 
ResizeMode$ NoResize=�66   .��5	      � .+�5
   
   �� -   5        $��1082,509,0,0q�5
      
�������$
��Left=�6O   $	��Top=�6j   .��5      ��  J� IsHitTestVisible .  
�������$��Center=�6@   $��Center=�6d   $��Export to CSV��6   5      �� 5   
   $��Top 10 Scores��6   
�������$��Center=�6;   $	��Top=�6_   $
��Left=�6w   $��29��6�   $��99��6�   $��
505,17,0,0q�6�   �� 5   
   $��505,46,255,45q�6h   ��6   �� *
TopPlayers+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $��Score��6%    �� DisplayMemberBinding 64   �� *Score+�� 5      $��Nickname��6%    67   �� *
Nickname+�� 5      $��Profile Image��6%    6<   �� *ProfileImage+5      5      �� 5   
   $��List of all players��6   
�������$��Center=�6A   $	��Top=�6e   $
��Left=�6}   $��29��6�   $��99��6�   $��	10,17,0,0q�6�   �� 5   
   $��10,46,750,45q�6e   ��6   �� *	Players+$ TwoWay=�$ PropertyChanged=� 5      �� 5      .P�5      �� $��Score��6%    64   �� *Score+�� 5      $��Nickname��6%    67   �� *
Nickname+�� 5      $��Profile Image��6%    6<   �� *ProfileImage+5       5"      �� 5%   
   $0��*Countdown until next generation of players��6   $
��Left=�6E   $	��Top=�6`   $��1000,135,0,0q�6x   $	��240��6�   �� 5&   
   $��Center=�6`   $	��Top=�6�   $��1048,166,58,0q�6�   $��32��6�   ��6   �� *	Countdown+$ TwoWay=�$ PropertyChanged=�6�   5(      5)      