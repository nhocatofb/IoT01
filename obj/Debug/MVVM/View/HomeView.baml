   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp2.MVVM.ViewWpfApp2.MVVM.View  5      ?$clr-namespace:WpfApp2.MVVM.ViewModelWpfApp2.MVVM.ViewModel  5           WpfApp2.MVVM.View.HomeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WpfApp2.MVVM.View     5      :	viewModel$clr-namespace:WpfApp2.MVVM.ViewModel     5      .��5      �� .+�5   
   �� $��	Xin chào��6   
�������$��28(�5      $
��Left=�5      $��0,0,0,20q�5      �� 5   
     �� Orientation$  
Horizontal=�6   .+�5      �� ��6   �� *
BanerWidth+��5      �� *BanerHeight+��5      �� 5       �� EndPoint$ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;    �� 
StartPoint$ 0.5,0&�6_   .��5      �  � Color$ 	#FF5BC3FF��6'    � Offset$ 1Q�69   � 5      $ 	#FF3AA0FF��6'   5       J� Clip 5      �� 5       �� RadiusX$ 20Q�6(    �� RadiusY$ 20Q�5   (   	 �� Rect	 5    (   �� *
RectSize+._�5#      � .+�5$      �� .+�5%      �� $��Beautiful Life��6$   
�������$��38(�5'   $   $��
20,10,10,0q�5(   $   �� 5*      $,��&cho cuộc sống tươi đẹp hơn !��6$   
�������$��14(�5,   $   $��
20,10,10,0q�5-   $   5/      �� 51      $	��130��6   $	��130��52      $��/Images/idea.png��53      $��Right=�54      $��Bottom=�55      58      5:      �� 5<      $��45,0,0,0q�6�   ��6   �� *TuychinhButtonSize+��6:   �� *TuychinhButtonSize+
 �� CornerRadius
 6`   �� *Radius+��5=      �� 5>      $ 0.5,1&�6*   $ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5?      � $ 	#FFFFE5B3��6'   $ 1Q�69   � 5@      $ 	#FFFFB73A��6'   $ 0.257Q�69   5A      ._�5C      � .+�5D      �� -   5         ��Name$ SettingButton��5D      
������ $��0q�5F      ��5D   4   �� *TuychinhCommand+.��5G      �� 5H      5I      5K      5L      �� 5N   
    � 	Resources 5P       �� 
TargetType �� Property �� Value��%[   '��       �� 5Q      " ��6   .�5R      ��  � ��$ 15, 0, 0, 0q�6/   5S      5T      .+�5U      �� $��Các thiết bị��6   $��20(�5V      
�������$
��Left=�5X      $��
10,10,0,10q�5Y      �� 5Z      $  
Horizontal=�6   .+�5[      �� $��0q�5^      ��5[      �� *DeviceButtonSize+��5\      �� *DeviceButtonSize+
 5]      �� *Radius+��5`      �� 5a      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��5b      � $ 	#FF986BFF��6+   $ 0.653Q�6=   � 5c      $ 	#FF5D38B4��6+   5d      ._�5f      �� -   5        $ TVButton��5f      
������ $��0q�5g      ��5h      �� *TiviCommand+.��5i      �� 5j      5k      �� 5l      ��6   �� *DeviceButtonSize+��5m      �� *DeviceButtonSize+
 5n      �� *Radius+��5p      �� 5q      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��5r      � $ 	#FF82B7FF��6+   $ 0.916Q�6=   � 5s      $ 	#FF4E88FF��6+   5t      ._�5v      �� -   5        $ LightButton��5v      
������ $��0q�5w      ��5x      �� *LightCommand+.��5y      �� 5z      5|      �� 5}      ��6   �� *DeviceButtonSize+��5~      �� *DeviceButtonSize+
 5      �� *Radius+��5�      �� 5�      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��5�      � $ 	#FF92FFBB��6+   $ 1Q�6=   � 5�      $ 	#FF19D962��6+   5�      ._�5�      �� -   5        $ ACButton��5�      
������ $��0q�5�      ��5�      �� *
AirCommand+.��5�      �� 5�      5�      �� 5�      ��6   �� *DeviceButtonSize+��5�      �� *DeviceButtonSize+
 5�      �� *Radius+��5�      �� 5�      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��5�      � $ 	#FFF1FF7D��6+   $ 0.728Q�6=   � 5�      $ 	#FFBECF2E��6+   5�      ._�5�      �� -   5        $ 	FanButton��5�      
������ $��0q�5�      ��5�      �� *
FanCommand+.��5�      �� 5�      5�      5�      5�      5�      5�      