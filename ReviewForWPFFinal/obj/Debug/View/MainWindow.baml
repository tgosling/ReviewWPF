   M S B A M L   `   `   `  ����L  HReviewForWPFFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ReviewForWPFFinalReviewForWPFFinal  5   	   C&clr-namespace:ReviewForWPFFinal.HelperReviewForWPFFinal.Helper  5   	   "    ReviewForWPFFinal.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ReviewForWPFFinal     5   	   9helper&clr-namespace:ReviewForWPFFinal.Helper     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      0  *ReviewForWPFFinal.Helper.FontSizeConverter   fontSizeConverter��%   &	          5   
   6#   5      .��5      � .+�5   
   ]� ��. .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� $��_Exit��6    m� Command 6.   �� *exitCommand+5      m� 5      $��_Edit��6   .@�5      m� $
��_Add��6    6-   �� *
addCommand+m� 5      $��_Change��6    60   �� *changeCommand+5      5      �� 5      -   5         ��Name$	 lxb��5   8   $
��Left=�6   $	��300��6,   ��6E   �� *	Squares+ �� SelectedIndex 5      �� *	MyIndex+�� 5       �� Orientation$ 
Horizontal=�6   $	��Top=�62   $��60��6G   $	��Top=�6S   .+�5      �� -   5         ��Name$ lblred��5      $��60��6(   
���  ����6D   �� *Red+��6]   �� *Red+ �� 	Converter# [  �� 5      -   5        $ lblBA��5      $��60��6'   
���������6N   �� *BlanchedAlmond+�� 5      -   5        $ lblaqua��5      $��60��6)   
��������6L   �� *	Aquamrine+�� 5      -   5        $ lblylw��5      $��60��6(   
��� �����6G   �� *Yellow+�� 5       -   5        $ lblbisq��5       $��60��6)   
���������6H   �� *bisque+�� 5!      -   5        $ lblCy��5!      $��60��6'   
����� ���6D   �� *cyan+5"      �� 5#      -   5        $ lblTotal��5#      ��6&   ��  �� ElementName$ lblaqua��	 �� Path$	 Items.Count�5$      5%      5&      