   M S B A M L   `   `   `  ����   
BaanCorner    UnitConverter.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Unit Converter��$	��450��$	��800��.��� .+��� -   $��DisciplineComboBox��$��
10,10,10,0q�$	��Top=�$��30��.@��� $��Common���� $��
Electrical���� $��Energy���� $
��HVAC���� $��Infrastructure���� $��Piping���� $��
Structural��&   System.Windows.Controls.DataGrid  -   $��UnitsDataGrid��$��10,50,10,50q�   AutoGenerateColumns$ False��   
IsReadOnly$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Unit Name��   
IsReadOnly$
 True��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
UnitName+4  .System.Windows.Controls.DataGridTemplateColumn  $ Unit Format��$ *    CellTemplate �� .R��� ���� *FormatOptions+	 �� SelectedItem	 �� *SelectedFormat+
 �� Mode$
 TwoWay=���  �� Orientation$ 
Horizontal=�$��Right=�$��Bottom=�$��10q�.+��� -   $��ApplyButton��$��Apply��$��0,0,10,0q�$	��100���� -   $��CloseButton��$��Close��$	��100��