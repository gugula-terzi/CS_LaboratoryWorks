   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ProgressBar.Progress  �� Color  ProgressBar.Background  ProgressBar.Border  FlatProgressBar �� 
TargetType �� Property �� Value �� 
TargetType �Name'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard	 g� RepeatBehavior
 �� TargetProperty �� 
TargetName9   3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8   2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value �� CornerRadius ��Name �� RadiusX �� RadiusY J� Opacity J� RenderTransformOrigin �� Triggers P� Property P� Value �� 
TargetName �� Angle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %l  &	        &	 !     &	 B     &	 e     7   7  �� 5      $  #e7ace6��63   �� 5      $  #1f1f1f��65   �� 5      $  	#FFBCBCBC��61   �� 5      " �6$   .�5   
   ��  � ��8   6'   �� 5   
    � ��8  6'   �� 5	   
    � ��$ 0q�6,   �� 5
   
    � �� 5      �� 5      " �6"   .R�5      � $ TemplateRoot��6    5        5      CommonStates��. 5   "     Determinate��6.     5   "   Indeterminate��. 5   &   �� $	 Forever��61   .��5   *   U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6H   $ 	Animation��6�   .\�5   .     $ 0��6C   $
 0.25Q�6O     5   .   $ 0:0:1��6C   $
 0.25Q�6S     5   .   $ 0:0:2��6C   $
 0.25Q�6S   5   +   *� 5   *   $'
 !(UIElement.RenderTransformOrigin)�6G   $ 	Animation��6�   .'�5   .     $ 0��6B   $ -0.5,0.5&�6N     5   .   $ 0:0:1��6B   $ 0.5,0.5&�6R     5   .   $ 0:0:2��6B   $ 1.5,0.5&�6R   5   +   5   '   5   #   5      .+�5!      �� #��z��6!   $ 10��6M   #��z��6_   #��z��6�   �� 5"      $ 
PART_Track��6$   � 5#      $ PART_Indicator��6   }�. $
��Left=�6K   .+�5$      �� $ 	Indicator��6(   #��z��6;   $ 10��6_   $ 10��6l   $	 0.5Q�6y   �� 5%      $ 	Animation��6(   #��z��6;   $ 10��6_   $ 10��6l   $	 0.5Q�6y   $ 0.5,0.5&�6�   z�5&   "   V� 5'   &   .~�5(   *   �� �� 5)   *   �� 5*   *   T� 5+   *   5,   '   5.      5/      50       51      P� 52       �@�Orientation$ Vertical=�69   . �53      �� $ TemplateRoot��6@    �@�LayoutTransform 54   "   �� 55   &   $	 -90Q�66   57      58      P� 59       �@�IsIndeterminate . . �5:      �� $ 	Indicator��6;    � y�$ 	Collapsed=�6R   5;      5=      5?      5@      5B      