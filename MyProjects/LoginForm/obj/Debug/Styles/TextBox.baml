   M S B A M L   `   `   `  ����D  @LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LoginForm	LoginForm  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TextBox.Static.Border  �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  SimpleBlackTextBox �� 
TargetType �� Property �� Value-   'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels ��Name	 �� Triggers
 ]� 
Conditions �� Property �� Value :� RoutedEvent �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  SimpleBlackPasswordBox�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      "local1clr-namespace:LoginForm  5      %�  &	        &	 %     &	 J     &	 m     7   &	 �    �� 5      $  Transparent��64   �� 5      $  Transparent��67   �� 5      $  	#FF5D6FD0��63   �� 5
      " ��6'   .�5   
   ��  � �� �	#FF1515156'   �� 5   
    � ��8   6(   �� 5   
    � ��# � ��6'   �� 5   
    � ��$ 1q�6,   �� 5   
    �@  TabNavigation$
 None=�6=   �� 5   
    � ��$
 Left=�67   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop . 6&   �� 5   
    � ��$ Center=�65   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    �@�Cursor$ IBeam��6#   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $ border��6   $ 5��5      #��z��5      #��z��5      #��z��5       . ._�5       � .+�5!      �� $ PART_ContentHost��6+   $��15q�6E   |�.  $��Hidden=�6d   $��Hidden=�6�   5"      5#      5$      5&      	 5'   
   ]� 5(      
 5)      �� 5*      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 5+       �@��IsSelectionActive .  6=   ./�5-      ��  �@��SelectionBrush# � /�63   5.      :� 5/      $ GotFocus��6   .[�50      �� .��51      �� .��52      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�53        $ 0��62    	#005D6FD06>     54      $ 0:0:0.3��62    	#FF5D6FD06D   55      56      57      58      :� 59      $ 	LostFocus��6   .[�5:      �� .��5;      �� .��5<      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5=        $ 0��62    	#FF5D6FD06>     5>      $ 0:0:0.3��62    	#005D6FD06D   5?      5@      5A      5B      5D      �� 5F      " G�6+   .�5G   
   ��  � �� �	#FF1515156'   �� 5H   
    � ��
 ���� 6(   �� 5I   
    � ��# � ��6'   �� 5J   
    � ��$ 1q�6,   �� 5K   
    �@  TabNavigation$
 None=�6=   �� 5L   
    � ��$
 Left=�67   �� 5M   
    �@�FocusVisualStyle 6-   Z� �� 5N   
    �@J�	AllowDrop . 6&   �� 5O   
    � ��$ Center=�65   �� 5P   
    �@��PanningMode$ VerticalFirst=�65   �� 5Q   
    �@��IsFlicksEnabled .  63   �� 5R   
    �@�Cursor$ IBeam��6#   �� 5S   
    � �� 5T      �� 5U      " G�6"   .R�5V      �� $ border��6   $ 5��5W      #��z��5X      #��z��5Y      #��z��5Z       . ._�5\      �� $ PART_ContentHost��6'   $��15q�6A   |�.  $��Hidden=�6`   $��Hidden=�6�   5]      5^      5`      	 5a   
   ]� 5b      
 5c      �� 5d      + �@G�#IsInactiveSelectionHighlightEnabled . 6O   �� 5e       �@G�IsSelectionActive .  6=   ./�5g      ��  �@G�SelectionBrush# � /�63   5h      :� 5i      $ GotFocus��6   .[�5j      �� .��5k      �� .��5l      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5m        $ 0��62    	#005D6FD06>     5n      $ 0:0:0.3��62    	#FF5D6FD06D   5o      5p      5q      5r      :� 5s      $ 	LostFocus��6   .[�5t      �� .��5u      �� .��5v      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5w        $ 0��62    	#FF5D6FD06>     5x      $ 0:0:0.3��62    	#005D6FD06D   5y      5z      5{      5|      5~      5      