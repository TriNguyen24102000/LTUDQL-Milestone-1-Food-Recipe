   M S B A M L   `   `   `  ����N  JLTUDQL1- Milestone1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LTUDQL1__Milestone1LTUDQL1__Milestone1  5   	   $    LTUDQL1__Milestone1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:LTUDQL1__Milestone1     5   	     � Title$  
MainWindow��5   	   $	��360��6   $	��300��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z   .��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      $��80 �6    �� 5      .+�5      ��  �� CornerRadius$ 15��6   $��2��6'   $��10q�68   ��5      �� 5      .��5      �  � Color$ #214252��6'    � Offset$	 0.0Q�67   � 5      $ #0e918c��6'   $ 1Q�67   5      5      �� 5      $��Center=�6   .+�5      �� $��FoodShop��6   $��
ExtraLight"�5      $��Elephant)�5      $��30(�5      
�������$��Center=�5       $��58��69   $��74,40,50.6,0q�6E   $	��169��6[   5!      �� 5%      $��1��6   .+�5&      �� .+�5'      �� -   5        $��usernamePlaceholder��5'      $��Username��68   $��Italic$�6K   
������� �� Left$ 65��6p   
 �� Top$ 43��6�   $��74��6�   �� 5(      -   5        $��usernameTextBox��5(      $��	Helvetica)�5)      $��Light"�5*      $��Center=�5+      
�������
������ $��0q�5.      $	��120��5/      $
��Left=�50      	 J� Opacity$		 0.5Q�51      $��26��52      $ 65��6*   $ 43��6;   �� 53      $��Images/user.png��6   $��22��65   $��26��6@   $	 205��6L   $ 43��6^   
 �� BitmapScalingMode$
 HighQuality=�6n    J� RenderTransformOrigin$ 0.282,0.568&�6�   54      �� 58      $��0,20,0,0q�6   .+�59      �� -   5        $��passwordPlaceholder��59      $��Password��67   $��Italic$�6J   
�������$ 69��6o   $ 80��6�   G� 5:      -   5        $��passwordTextBox��5:   "   $��	Helvetica)�5;   "   $��Light"�5<      $��Center=�5=      
�������
������ $��0q�5@      $	��120��5A      $
��Left=�5B      $		 0.5Q�5C      $��26��5D      $ 69��6*   $ 81��6;   �� 5E      $��Images/pw.png��6   $��22��63   $��26��6>   $	 206��6J   $ 80��6\   $
 HighQuality=�6l   $ 
-0.512,0.5&�6�   5F      �� 5G      $	��250��6   $��2��5H      
�������$		 0.5Q�5J      $��
62,48,61,0q�6'   �� 5K      $	��250��6   $��2��5L      
�������$		 0.5Q�5N      $��62,55,61.6,0q�6'   5P      � 5Q      .+�5R      �� -   5        
�������$��2q�5R   -   $��Sign in��6A   $		 0.6Q�6n   $
��Bold"�6|   $��15(�6�   $��67,240,65.6,-195q�6�   5S      �� 5T      $��Forgot Password ?��6   
�������$��95,228,81.6,0.6q�6C   $��1��6\   5V      5W      5X      