   M S B A M L   `   `   `  ����D  @LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LoginForm	LoginForm  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TextBox.Static.Border  �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border)    #LoginForm.BoolToVisibilityConverter  InputToVisibility  SimpleBlackTextBox �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius �� Padding J� SnapsToDevicePixels	 ��Name
 `� 	Converter �� ElementName �� Path ��Name �� Triggers ]� 
Conditions �� Property �� Value :� RoutedEvent �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  SimpleBlackPasswordBox�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !localclr-namespace:LoginForm  5      %�  &	        &	 %     &	 J     &	 m     &	 �     7   7  &	 �	    �� 5      $  Transparent��64   �� 5      $  Transparent��67   �� 5      $  	#FF5D6FD0��63      5	      6&   �� 5      " ��6'   .�5   
   ��  � �� �	#FF1B1B1B6'   �� 5   
    � ��8   6(   �� 5   
    � ��# � ��6'   �� 5   
    � ��$ 1q�6,   �� 5   
    �@ TabNavigation$
 None=�6=   �� 5   
    � ��$
 Left=�67   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop . 6&   �� 5   
    � ��$ Center=�65   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    �@�Cursor$ IBeam��6#   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $ border��6   $ 5��5      $ 5q�5      #��z��5      #��z��5      #��z��5        . ._�5"      � .+�5#      �� $	 PART_ContentHost��6+   $��15q�6E   |�.  $��Hidden=�6d   $��Hidden=�6�   �� 5$      $��Username��6(   $��Center=�68   y�5%   "   `� 5&   &   8
  .1�5'   *   �� $ 	inputText��62   $ Text.IsEmpty�6J   �� 5(   *   $ 	inputText��62   $ 	IsFocused�6J   5)   '   5+      �� 5,      $ 	inputText��6&   
������ 69   5-      5.      5/      51       52   
   ]� 53       54      �� 55      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 56       �@��IsSelectionActive .  6=   ./�58      ��  �@��SelectionBrush# � /�63   59      :� 5:      $ GotFocus��6   .[�5;      �� .��5<      �� .��5=      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5>        $ 0��62    	#005D6FD06>     5?      $ 0:0:0.3��62    	#FF5D6FD06D   5@      �� 5A      $0 *(Panel.Background).(SolidColorBrush.Color)�67   .g�5B        $ 0��62    	#FF1B1B1B6>     5C      $ 0:0:0.3��62    	#001B1B1B6D   5D      5E      5F      5G      :� 5H      $ 	LostFocus��6   .[�5I      �� .��5J      �� .��5K      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5L        $ 0��62    	#FF5D6FD06>     5M      $ 0:0:0.3��62    	#005D6FD06D   5N      �� 5O      $0 *(Panel.Background).(SolidColorBrush.Color)�67   .g�5P        $ 0��62    	#001B1B1B6>     5Q      $ 0:0:0.3��62    	#FF1B1B1B6D   5R      5S      5T      5U      5W      �� 5Y      " G�6+   .�5Z   
   ��  � �� �	#FF1B1B1B6'   �� 5[   
    � ��
 ���� 6(   �� 5\   
    � ��# � ��6'   �� 5]   
    � ��$ 1q�6,   �� 5^   
    �@ TabNavigation$
 None=�6=   �� 5_   
    � ��$
 Left=�67   �� 5`   
    �@�FocusVisualStyle 6-   Z� �� 5a   
    �@J�	AllowDrop . 6&   �� 5b   
    � ��$ Center=�65   �� 5c   
    �@��PanningMode$ VerticalFirst=�65   �� 5d   
    �@��IsFlicksEnabled .  63   �� 5e   
    �@�Cursor$ IBeam��6#   �� 5f   
    � �� 5g      �� 5h      " G�6"   .R�5i      �� $ border��6   $ 5��5j      $ 5q�5k      #��z��5l      #��z��5m      #��z��5n       . ._�5p      �� $	 PART_ContentHost��6'   |�.  $��Hidden=�6S   $��Hidden=�6z   5q      5r      5t       5u   
   ]� 5v       5w      �� 5x      + �@G�#IsInactiveSelectionHighlightEnabled . 6O   �� 5y       �@G�IsSelectionActive .  6=   ./�5{      ��  �@G�SelectionBrush# � /�63   5|      :� 5}      $ GotFocus��6   .[�5~      �� .��5      �� .��5�      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5�        $ 0��62    	#005D6FD06>     5�      $ 0:0:0.3��62    	#FF5D6FD06D   5�      �� 5�      $0 *(Panel.Background).(SolidColorBrush.Color)�67   .g�5�        $ 0��62    	#FF1B1B1B6>     5�      $ 0:0:0.3��62    	#001B1B1B6D   5�      5�      5�      5�      :� 5�      $ 	LostFocus��6   .[�5�      �� .��5�      �� .��5�      �� $2 ,(Border.BorderBrush).(SolidColorBrush.Color)�67   .g�5�        $ 0��62    	#FF5D6FD06>     5�      $ 0:0:0.3��62    	#005D6FD06D   5�      �� 5�      $0 *(Panel.Background).(SolidColorBrush.Color)�67   .g�5�        $ 0��62    	#001B1B1B6>     5�      $ 0:0:0.3��62    	#FF1B1B1B6D   5�      5�      5�      5�      5�      5�      