   M S B A M L   `   `   `  ����   KinectLibTest    KinectLibTest.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��600��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=�.���� -    ��Name$ iCanvas��.+��� -    ��Name$ 
txtGesture��$	��397��$��43�� �� TextAlignment$ Center=� �� Left$ 83��
 �� Top$ 12��$��Kinect gestures��$��28(����	#FFF51C1C�� -    ��Name$ leftHand��$��images/leftHand.png��$ 0��$ 0��	 K� ZIndex$	 1���� -   $ 	rightHand��$��images/rightHand.png��$ 0��$ 0��$	 1��� -   $��grid1��$ 0��$ 61��$	��488��$	��778��
 � RowDefinitions
 �� $	��39* ��� $	��39* ��� $	��37* ��� $	��33* ��� $	��30* ��� $	��29* ��� $	��29* ��� $	��30* ��� $	��33* ��� $	��27* ��� $	��27* ��� $	��29* ��� $	��26* ��� $	��26* ��� $	��31* ��� $	��27* �.+��� -   $��
textBlock1��$��27��$
��Left=�$��0,6,0,0q�$��	TextBlock��$	��Top=�$	��739�����	#FFEB0F0F�� -   $��
textBlock2��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��1�����	#FFEB0F0F�� -   $��
textBlock3��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��2�����	#FFEB0F0F�� -	   $��
textBlock4��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��3�����	#FFEB0F0F�� -
   $��
textBlock5��$��27��$
��Left=�$��1,2,0,0q�$��	TextBlock��$	��Top=�$	��739��$��4�����	#FFEB0F0F�� -   $��
textBlock6��$��27��$
��Left=�$��-3,2,0,0q�$��	TextBlock��$	��Top=�$	��739��$��5��$��2�����	#FFEB0F0F�� -   $��
textBlock7��$��27��$
��Left=�$��0,1,0,0q�$��	TextBlock��$	��Top=�$	��739��$��6�����	#FFEB0F0F�� -   $��
textBlock8��$��27��$
��Left=�$��-3,0,0,0q�$��	TextBlock��$	��Top=�$	��739��$��7�����	#FFEB0F0F�� -   $��
textBlock9��$��27��$
��Left=�$��0,6,0,0q�$��	TextBlock��$	��Top=�$	��739��$��8�����	#FFEB0F0F�� -   $��textBlock10��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��9��$��2�����	#FFEB0F0F�� -   $��textBlock11��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��10�����	#FFEB0F0F�� -   $��textBlock12��$��27��$
��Left=�$��0,2,0,0q�$��	TextBlock��$	��Top=�$	��739��$��11�����	#FFEB0F0F�� -   $��textBlock13��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��12��$��2�����	#FFEB0F0F�� -   $��textBlock14��$��27��$
��Left=�$��-3,0,0,0q�$��	TextBlock��$	��Top=�$	��739��$��13��$��2�����	#FFEB0F0F�� -   $��textBlock15��$��27��$
��Left=�$��-3,3,0,0q�$��	TextBlock��$	��Top=�$	��739��$��14�����	#FFEB0F0F�� -   $��textBlock16��$��27��$
��Left=�$��	TextBlock��$	��Top=�$	��739��$��15�����	#FFEB0F0F�� -   $��	checkBox1��$	 516��$ 11��$��Display VideoFrame��$��21��$	��231�� d� 	IsChecked$
 TrueY����	#FFEB1818