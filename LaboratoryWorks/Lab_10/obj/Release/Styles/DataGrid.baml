   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   FlatDataGrid  �� 
TargetType&    System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType �� CornerRadius �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions	 � RowDefinitions
    SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight � Maximum �� Orientation* �� #ComputedVerticalScrollBarVisibility �� ViewportHeight �� ViewportSize � Value �� Mode  �� ScrollableWidth,! �� %ComputedHorizontalScrollBarVisibility" �� ViewportWidth# �� Triggers$ ]� 
Conditions% �� Property& �� Value  DataGridStyle1' �� 	Resources)  #System.Windows.Controls.DataGridRow( P� Property) P� Value*  $System.Windows.Controls.DataGridCell�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %�  &	        &	 ~    �� "    .���  � ��# � ����  � ��# � ����  � �� �#111111��  � ��$ 2q���   �@  RowDetailsVisibilityMode$ VisibleWhenSelected=���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � �� �� "   .R��� #��z��$ 10��#��z��#��z��# z�� . ._��� $ DG_ScrollViewer��|�.  ���� " ��.R��  �� $
��Auto ��� $��* ��� $
��Auto �	 �� $
��Auto ��� $��* ��� $
��Auto �.+��� #��Z
 |�.  ��C� *�� $" DataGridSelectAllButtonStyle��"   +y��� *HeadersVisibility+# Z # Z  �� "   ���� *CellsPanelHorizontalOffset+ �� "     $! PART_ColumnHeadersPresenter��$��1��y��� *HeadersVisibility+# Z # Z  �� "   �� $! PART_ScrollContentPresenter��# z��$��2��$��1���� $ PART_VerticalScrollBar��$��2��# z $ Vertical=�$��1��#y�z # z  �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+� $��1��$��2�� �� ���� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� $��* �.+��� $ PART_HorizontalScrollBar��$��1��# z  $ 
Horizontal=�#y�z! # z"  �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+.���� # z # ]� $ �� % �@��
IsGrouping& . �� "% �@%�IsVirtualizingWhenGrouping& .  ./���  � �� .  �� "    ' ���� '��       "  ��.���  �@��CornerRadius$ 10��.���  � �� �#111��  � ��$ 10q���  � ��
 �������  �@  RowStyle �� "   # P� ( �@J�IsMouseOver) . . ���  � �� �#1f1f1f��  �@  	CellStyle �� "   # P� ( �@ 
IsSelected) . . ���  � �� �#151515��  � ��
 ���� ��  � ��
 �����P� ( �@J�	IsFocused) . . ���  � �� �#191919��  � ��$ 0q���  � ��
 �����.���  � ��$ 2q���  � ��
 ���� ��  � ��$ 0q���  � �� �� "  .R��� # z��#��z��#��z�����#111._��� $��Center=�$��Center=���  �@�FocusVisualStyle �� "  ��.���  � ��
 ���� 