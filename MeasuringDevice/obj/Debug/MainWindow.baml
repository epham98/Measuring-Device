   M S B A M L   `   `   `  ����J  FMeasuringDevice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MeasuringDeviceMeasuringDevice  5   	        MeasuringDevice.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MeasuringDevice     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��370��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
titleBlock��5
      $
��Left=�5      $��
110,30,0,0q�5      $
��Wrap=�5      $��Measuring Device��5      $	��Top=�5      $��18(�5      �� 5   
   -   5        $ measureBlock��5      $
��Left=�5      $��	10,88,0,0q�5      $
��Wrap=�5      $��Select Measurement Unit:��5      $	��Top=�5      $��16(�5      �� 5   
   -   5         ��Name$ measureComboBox��5      $
��Left=�5      $��
196,84,0,0q�5      $	��Top=�5      $	��154��5      $��16(�5       �� SelectedIndex$ 0��5      .@�5      �� $��Inches��6   �� 5       $��Centimeters��6   5!      �� 5"   
   -   5         ��Name$ startButton��5"      $��Start Collecting��5#      $
��Left=�5$      $��
10,185,0,0q�5%      $	��Top=�5&      $��16(�5'      $	��151��5(      5)      �� 5*   
   -   5         ��Name$ 
rawListBox��5*      $
��Left=�5+      $	��204��5,      $��
10,399,0,0q�5-      $	��Top=�5.      $	��340��5/      �� 50   
   -   5        $ 
stopButton��50      $��Stop Collecting��51      $
��Left=�52      $��196,185,0,0q�53      $	��Top=�54      $��16(�55      $	��154��56      57      �� 58   
   -   5        $ statusBlock��58      $
��Left=�59      $��110,144,0,0q�5:      $
��Wrap=�5;      $��Press Start to Collect��5<      $	��Top=�5=      4  .System.Windows.Automation.AutomationProperties   Name$ statusBlock��5>      �� 5?   
   -   5        $ recentMeasureBlock��5?      $
��Left=�5@      $��
14,297,0,0q�5A      $
��Wrap=�5B      $��Latest Measurement: ��5C      $	��Top=�5D      $��16(�5E      �� 5F   
   -	   5        $ recentMeasureButton��5F      $��Get Latest Measurement��5G      $
��Left=�5H      $��
10,250,0,0q�5I      $	��Top=�5J      $	��340��5K      5L      �� 5M   
   -
   5        $ rawDataButton��5M      $��Get Raw Data��5N      $
��Left=�5O      $��
10,333,0,0q�5P      $	��Top=�5Q      $	��340��5R      5S      5T      5U      