   M S B A M L   `   `   `  ����E  ATextViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TextViewer
TextViewer  5   	       TextViewer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TextViewer     5   	     � Title$  Text Viewer��5   	   $	��480��6   $	��800��6*    � 	Resources 5	         
StartFilte  StartPicture  OpenPicture  ChangeEmail  	OnPicture��%�   &	        &	      &	 &     &	 9     &	 L     �� 5
   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   �� 5   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6(     5   
   -   5        # [  5      5        5   
   -   5        # [ 5      6@     5   
   -   5        # [ 5      5        5   
   -   5        # [ 5      6@     5   
   -   5        # [ 5      6>   .��5       �� .+�5!   
   �� $/��)请在下方输入有效QQ邮箱地址：��6   �� 5"   
   -   5         ��Name$ email��5"      o� 5#   
   .@�5$      m� $&�� 请在下方输入Email正文：��6   m� 5%      $��打开文件��6    m� Command$
 Open��6%   5'      �� 5(   
    �� 
IsReadOnly .  �� TextWrapping$ NoWrap=�5)      $ �� HorizontalScrollBarVisibility$
 Auto=�5*      "	 �� VerticalScrollBarVisibility$
	 Auto=�5+      $	��135��65   ��5(      �� *
FiltedText+5+   5   o� 5-   
   .@�5.      m� $0��*请在下方输入或选择附件图片：��6   m� 5/      $��打开图片��6   # [ 6%   51      �� 52   
   -   5        $ PicturePath��52      6)   �� 53   
   $��图片预览��6   #��[ 6    6G   �� 54   
   $(��"C:\\Users\\LFeng\\Desktop\\001.jpg��6   $	��135��6>   �� 55   
   $��确定��6   #��[ 6   56      57      