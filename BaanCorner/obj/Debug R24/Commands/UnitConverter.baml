   M S B A M L   `   `   `  ����   
BaanCorner    UnitConverter.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Project Units��$	��450��$	��500��.��� .+���  �� Orientation$ 
Horizontal=�$
��Left=�$	��Top=�$��10q�.+��� -   $��Export��$��Export��$��0,0,10,0q�$	��100���� -   $��Import��$��Import��$	��100���� -   $��DisciplineTabControl��$��10,60,10,50q�.@��� $��Common��.��&   System.Windows.Controls.DataGrid  -   $��CommonDataGrid��   AutoGenerateColumns$ False��   
IsReadOnly$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$- 'ชื่อหน่วย (Unit Name)��   
IsReadOnly$
 True��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
UnitName+4  .System.Windows.Controls.DataGridTemplateColumn  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	   CellTemplate	 �� .R��� ���� *FormatOptions+
 �� SelectedItem
 �� *SelectedFormat+ �� Mode$ TwoWay=��� $��
Electrical��.��  -   $��ElectricalDataGrid��$ False��$ False��   $- 'ชื่อหน่วย (Unit Name)��$
 True��$ *  �� *
UnitName+  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	 �� .R��� ���� *FormatOptions+
 �� *SelectedFormat+$ TwoWay=��� $��Energy��.��  -   $��EnergyDataGrid��$ False��$ False��   $- 'ชื่อหน่วย (Unit Name)��$
 True��$ *  �� *
UnitName+  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	 �� .R��� ���� *FormatOptions+
 �� *SelectedFormat+$ TwoWay=��� $
��HVAC��.��  -   $��HVACDataGrid��$ False��$ False��   $- 'ชื่อหน่วย (Unit Name)��$
 True��$ *  �� *
UnitName+  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	 �� .R��� ���� *FormatOptions+
 �� *SelectedFormat+$ TwoWay=��� $��Infrastructure��.��  -   $��InfastructureDataGrid��$ False��$ False��   $- 'ชื่อหน่วย (Unit Name)��$
 True��$ *  �� *
UnitName+  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	 �� .R��� ���� *FormatOptions+
 �� *SelectedFormat+$ TwoWay=��� $��Piping��.��  -	   $��PipingDataGrid��$ False��$ False��   $- 'ชื่อหน่วย (Unit Name)��$
 True��$ *  �� *
UnitName+  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	 �� .R��� ���� *FormatOptions+
 �� *SelectedFormat+$ TwoWay=��� $��
Structural��.��  -
   $��StructuralDataGrid��$ False��$ False��   $- 'ชื่อหน่วย (Unit Name)��$
 True��$ *  �� *
UnitName+  $8 2ฟอร์แมตหน่วย (Unit Format)��$ * 	 �� .R��� ���� *FormatOptions+
 �� *SelectedFormat+$ TwoWay=��� $ 
Horizontal=�$��Right=�$��Bottom=�$��10q�.+��� -   $��ApplyButton��$��Apply��$��0,0,10,0q�$	��100���� -   $��CloseButton��$��Close��$	��100��