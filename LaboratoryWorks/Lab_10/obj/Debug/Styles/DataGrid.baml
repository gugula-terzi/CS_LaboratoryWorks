   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FlatDataGrid  �� 
TargetType&    System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType �� CornerRadius �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions	 � RowDefinitions
    SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value �� Mode  �� ScrollableWidth,! �� %ComputedHorizontalScrollBarVisibility" �� ViewportWidth# �� Triggers$ ]� 
Conditions% �� Property& �� Value  DataGridStyle1' �� 	Resources)  #System.Windows.Controls.DataGridRow( P� Property) P� Value*  $System.Windows.Controls.DataGridCell�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	 g    �� 5      "    6!   .�5   
   ��  � ��# � ��6'   �� 5   
    � ��# � ��6'   �� 5   
    � �� �#1111116(   �� 5   
    � ��$ 2q�6,   �� 5   
     �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5	   
    � �� . 6:   �� 5
   
    �@��PanningMode$
 Both=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� #��z��6   $ 10��6I   #��z��6[   #��z��6�   # z��6�    . ._�5      �� $ DG_ScrollViewer��6'   |�.  ��5      �� 5   "   " ��62   .R�5   &   �  5   *   �� 5   .   $
��Auto �6?   �� 5   .   $��* �6?   �� 5   .   $
��Auto �6?   	 5   *   �� 5   .   $
��Auto �6<   �� 5   .   $��* �6<   �� 5   .   $
��Auto �6<   .+�5   *   �� #��Z
 61   |�.  ��6r   C� *�� $" DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5   *   $! PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z  �� "   �� 5    *   $! PART_ScrollContentPresenter��6A   # z��6f   $��2��6�   $��1��6�   �� 5!   *   $ PART_VerticalScrollBar��64   $��2��6T   # z 6d   $ Vertical=�6�   $��1��6�   #y�z 6�   # z 6W   6�   �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+6W  � 5"   *   $��1��6/   $��2��6?    5#   .   �� 5$   2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5%   2   $��* �6C   .+�5'   .   �� $ PART_HorizontalScrollBar��68   $��1��6Z   # z  6j   $ 
Horizontal=�6�   #y�z! 6�   # z" 6U   6�   �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+6U  5(   +   5)   '   5*   #   .��5,      �� # z 6-   5-      5.      5/      51      # 52   
   ]� 53      $ 54      �� 55      % �@��
IsGrouping& . 66   �� 56      "% �@%�IsVirtualizingWhenGrouping& .  6X   ./�58      ��  � �� .  6B   59      5;      �� 5=      "    6#   ' 5>   
   ���� 5?      '��       "  ��6   .�5@      ��  �@��CornerRadius$ 10��61   5A      5C      .�5E   
   ��  � �� �#1116(   �� 5F   
    � ��$ 10q�6,   �� 5G   
    � ��
 �����6'   �� 5I   
    �@  RowStyle 5J      �� 5K      "   6   # 5L      P� 5N      ( �@J�IsMouseOver) . . �5O      ��  � �� �#1f1f1f6;   5P      5R      5T      �� 5U   
    �@  	CellStyle 5V      �� 5W      "   6   # 5X      P� 5Z      ( �@ 
IsSelected) . . �5[      ��  � �� �#1515156;   �� 5\       � ��
 ���� 6<   �� 5]       � ��
 �����6;   5^      P� 5_      ( �@J�	IsFocused) . . �5`      ��  � �� �#1919196;   �� 5a       � ��$ 0q�6@   �� 5b       � ��
 �����6;   5c      .�5f      ��  � ��$ 2q�60   �� 5g       � ��
 ���� 64   �� 5h       � ��$ 0q�68   �� 5i       � �� 5j      �� 5k      "  6.   .R�5l   "   �� # z��6)   #��z��5m   )   #��z��5n   )   ���#111._�5p   "   �� $��Center=�63   $��Center=�5q   5   5r   #   5s      5u      �� 5v       �@�FocusVisualStyle 5w      �� 5x      "  ��6$   .�5y   "   ��  � ��
 ���� 6@   5z      5|      5}      5      5�      5�      