   M S B A M L   `   `   `  ����D  @LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LoginForm	LoginForm  5   	       LoginForm.MessageWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   #localclr-namespace:LoginForm  5   	     � AllowsTransparency  .  � WindowStyle$
 None=�5
   	    � SizeToContent$ Height=�5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$ 	Grayscale=�5   	    � Title$ Message��5   	   $
��auto��6   $	��400��6'   .��5      � -   5        $��NavPanel��5      .+�5   
   �� ���	#FF232323 �� CornerRadius$ 15��5      5      �� 5   
   -   5        $��CloseBtn��5      $	��Top=�5      $��Right=�5      $��25��5      $��25��5         OutlineButton#���   5      $��0, 10, 10, 0q�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$ Close=�5    &   $��20��5!   &   $��20��5"   &   5#      �� 5$   
   	 �� Orientation$	 
Horizontal=�6   $��Center=�5%      $��Center=�5&      $��0, 40q�5'      .+�5(      �� -   5        $��
ErrorImage��5+      $$��Images/message_icons/error.png��5(      $��Center=�5)      
 �� BitmapScalingMode$
 HighQuality=�5*      $��30��5,      $��30��5-      $��0,0,20,0q�5.      �� 5/      -   5         ��Name$ ErrorMessage��5/      $��Center=�50      $��Stretch=�51      $�� ��52      
�������   TextHintingMode$ Animated=�54      $
��Wrap=�55      $��18(�56      $2��,/LoginForm;component/Fonts/#Rounded Mplus 1c)�6&   57      58      59      