   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp2.MVVM.ViewWpfApp2.MVVM.View  5           WpfApp2.MVVM.View.TuyChinh   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:WpfApp2.MVVM.View     5      .��5
      �� $��	0,0,0,-34q�6   .+�5   
   �� $��Thay đổi hình dạng��6   
�������$��28(�5      $
��Left=�5      $��	0,10,0,20q�5      �� 5   
     �� Orientation$  
Horizontal=�6   .+�5      �� $��60,0,0,0q�6z   ��6   �� *ShapeButtonSize+��67   �� *ShapeButtonSize+ �� CornerRadius 6Z   �� *Radius+��5      �� 5       �� EndPoint$ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;    �� 
StartPoint$ 0.5,0&�6_   .��5      �  � Color$ 	#FF986BFF��6'    � Offset$ 0.653Q�69   � 5      $ 	#FF5D38B4��6'   5      ._�5      � .+�5      �� -   5         ��Name$ SettingButton��5      
������ $��0q�5      ��5   4   �� *ShapeCommand+.��5      �� 5      5      5!      5"      �� 5$   
    � 	Resources 5&      	 �� 
TargetType
 �� Property �� Value��%[   '��       �� 5'      "	 ��6   .�5(      �� 
 � ��$ 80, 0, 0, 0q�6/   5)      5*      .+�5+      �� $ ��Thay đổi kích thước��6   $��20(�5,      
�������$
��Left=�5.      $��
10,30,0,10q�5/      �� 50      $  
Horizontal=�6   .+�52      �� -   5         ��Name$	 Big��55      $	��150��52      $	��150��53       54      �� *Radius+��56      �� 57      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��58      � $ 	#FF82B7FF��6+   $ 0.916Q�6=   � 59      $ 	#FF4E88FF��6+   5:      ._�5<      �� -   5        $ LightButton��5<      
������ $��0q�5=      ��5>      �� *BigSizeCommand+.��5?      �� 5@      5B      �� 5C      -   5        $ Medium��5F      $	��130��5C      $	��130��5D       5E      �� *Radius+��5G      �� 5H      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��5I      � $ 	#FF92FFBB��6+   $ 1Q�6=   � 5J      $ 	#FF19D962��6+   5K      ._�5M      �� -   5        $ ACButton��5M      
������ $��0q�5N      ��5O      �� *MediumSizeCommand+.��5P      �� 5Q      5R      �� 5S      $	��110��6   $	��110��5T       5U      �� *Radius+��5W      �� 5X      $ 0.5,1&�6.   $ RelativeToBoundingBox=�6?   $ 0.5,0&�6c   .��5Y      � $ 	#FFF1FF7D��6+   $ 0.728Q�6=   � 5Z      $ 	#FFBECF2E��6+   5[      ._�5]      �� -   5        $ 	FanButton��5]      
������ $��0q�5^      ��5_      �� *SmallSizeCommand+.��5`      �� 5a      5b      5d      5e      5f      5g      