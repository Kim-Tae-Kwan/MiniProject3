   M S B A M L   `   `   `  ����M  IMqtt_MonitoringApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Mqtt_MonitoringApp.ViewsMqtt_MonitoringApp.Views  5      *    $Mqtt_MonitoringApp.Views.HistoryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Mqtt_MonitoringApp.Views     5      R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5      .��5      �   � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��IoT History Datas��6      MahApps.Styles.Label#���   6,   $��30(�5      $
��Bold"�6   � 5   
   $��1��6     5      �� 5      $��40 �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��2q�62   .+�5      �� $��Division��6   #���   6+   $��Center=�5       �� 5!      -   5         ��Name$ 	Divisions��5!      $	��150��6.    �� DisplayMemberPath$ DivisionVal��6:   $��Center=�5"        MahApps.Styles.ComboBox#���  5#       �� SelectedItem 5$      �� *SelectedDivision+�� 5%      $��   StartDate��6   $��Center=�6/   (  "System.Windows.Controls.DatePicker  5&      -   5          Name$ 	StartDate��5&      $	��100��60      Text$ 
2020-09-01��6<   $	��Top=�5'        MahApps.Styles.DatePicker#���  5(      $��0,5,0,0q�6Q   �� 5)      $��   ~ EndDate��6   #���   6/   $��Center=�5*        5+      -   5        $ EndDate��5+      $	��100��6.   $ 
2020-09-02��6:   #���  5,      $��Center=�5-      �� 5.      $��Total Count : ��6   #���   61   $��Center=�5/      �� 50      -   5         ��Name$ 
TotalCount��50      $��50��60   $��Center=�6;     MahApps.Styles.TextBlock#���  51      52      �� 54      -   5        	 ��Name$	 Search��54      $��0��6%   $��1��62   $��SEARCH��6B   $
��10,0q�6S    ( $MahApps.Styles.Button.Dialogs.Accent#���  55      � 56      $��1��6   $��0��6    $��2��60   $��10q�6D   .+�57        OxyPlot.Wpf.Plot  
   Series
 58        OxyPlot.Wpf.LineSeries  59        OxyPlot.Wpf.Series   Color$ DarkRed��6)      
MarkerType$
 None=�69      Title$ Temperature��6K   ��5:   )   �� *
TempValues+  5;      $ 
Aquamarine��6)   $
 None=�6<   $ Humidity��6N   ��5<   )   �� *HumidValues+  5=      $ 
BlueViolet��6)   $
 None=�6<   $ Pressure��6N   ��5>   )   �� *PressValues+5@      5A      5B      5C      5D      