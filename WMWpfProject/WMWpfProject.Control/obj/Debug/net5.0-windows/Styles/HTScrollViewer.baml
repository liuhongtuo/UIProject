   M S B A M L   `   `   `  ����O  KWMWpfProject.Control, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WMWpfProject.Control.ControlsWMWpfProject.Control.Controls  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   RepeatButtonTransparent �� 
TargetType �� Property �� Value �� 
TargetType+    %WMWpfProject.Control.Controls.HTThumb ��Name J� SnapsToDevicePixels �� RelativeSource	 �� Mode
 �� Path �� RadiusX �� RadiusY �� Triggers P� Property P� Value �� 
TargetName/   )WMWpfProject.Control.Controls.HTScrollBar �Name ]�Name J� IsMouseOver ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb    RadiusX    RadiusY    
ThemeColor    ThemeColorMouseOver    ThemeColorPressed �� Triggers �� PageLeftCommand  �� PageRightCommand2   ,WMWpfProject.Control.Controls.HTScrollViewer! ��Name" �� CanContentScroll# �� CanHorizontallyScroll$ �� CanVerticallyScroll%  Name4  .System.Windows.Automation.AutomationProperties&   AutomationId  TransparentColor' � Cursor( �� ScrollableHeight) � Maximum* � Minimum+ �� ViewportHeight, �� ViewportSize*- �� #ComputedVerticalScrollBarVisibility.   RadiusX/   RadiusY0   ScrollBarSize1   
ThemeColor2   ThemeColorMouseOver3   ThemeColorPressed4 � Value5 �� Mode6 �� ScrollableWidth7 �� Orientation8 �� ViewportWidth,9 �� %ComputedHorizontalScrollBarVisibility  ScrollBarThumb ! HorizontalScrollBarPageButton  VerticalScrollBarPageButton   VerticalScrollBarPageButton2  for_scrollbar: � UseLayoutRounding; � RowDefinitions  for_scrollviewer< ��Name= �� VerticalOffset> �� HorizontalOffset? :� RoutedEvent@ �� 
TargetNameA �� TargetProperty	B W� ToC g� DurationD :� 
SourceName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      8controls+clr-namespace:WMWpfProject.Control.Controls  5        5      �� 5   
   $O Ipack://application:,,,/WMWpfProject.Control;Component/Styles/HTColor.xaml?�6   �� 5   
   $N Hpack://application:,,,/WMWpfProject.Control;Component/Styles/HTIcon.xaml?�6   �� 5   
   $N Hpack://application:,,,/WMWpfProject.Control;Component/Styles/HTSkin.xaml?�6   %')  &	        '   r    '  �    7   7   7   7   '  ;    7  7  &	 Y    &	 �    &	 8    &	 �    &	 �    7  7  7  7  7  7  7  7  &	 �     7  7  �� 5
      " ��5      .�5   
   ��  �@�OverridesDefaultStyle$
 true��5      �� 5   
    � ��
 ���� 5      �� 5   
    � |�$ false��5      �� 5   
    � ��$ false��5      �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� #��z��6    #��z��5       #��z��5       5      5      5      �� 5       "   6   .�5!   
   ��  �@�OverridesDefaultStyle$
 true��5"      �� 5#   
    � ��$ false��5$      �� 5%   
    � �� 5&      �� 5'      "   6"   .R�5(      �� $ 	rectangle��6    #��z��5)       #��z��5*       $
 True��5.       ��5+       ��  �� $	 TemplatedParent=�$
 
ThemeColor� 5,       ��  �� $	 TemplatedParent=�$
 RadiusX� 5-       ��  �� $	 TemplatedParent=�$
 RadiusY�5.        5/      P� 50       �@J�IsMouseOver$
 true��51   "   . �52      �� $ 	rectangle��6%    54   %   ��  �� $	 TemplatedParent=�$
 ThemeColorMouseOver� � ��55      P� 56       �@n�
IsDragging$
 true��57   "   . �58      �� $ 	rectangle��6%    5:   %   ��  �� $	 TemplatedParent=�$
 ThemeColorPressed� � ��5;      5=      5?      5@      �� 5C      "  6   .�5D   
   ��  �@��IsPressAndHoldEnabled$ false��5E      �� 5F   
    �@��IsFlicksEnabled$ false��5G      �� 5H   
    � �� 5I      �� *ScrollBarSize+ �� $	 TemplatedParent=��� 5J   
    � �� 5K      �� *ScrollBarSize+ �� $	 TemplatedParent=��� 5L   
    � ��
 ���� 5M      �� 5N   
    � ��
 ���� 5O      �� 5P   
    � �� 5Q      �� 5R      "  6"   .R�5S      � $ Bg��6   $
 true��5T      .+�5U      ]� $ 
PART_Track��6    $��1��5V       $
��true��5W       #{�z 5X        5Y      �� 5Z   "   #��Z 6/   8��  5[   /    5]      �� 5^   "   #��Z 6/   8�� 5_   /    5a         5b   "    63   �� *	RadiusX+ �� $	 TemplatedParent=� 5c   3   �� *	RadiusY+ �� $	 TemplatedParent=� 5d   3   �� *
ThemeColor+ �� *TemplatedParent+ 5e   3   �� *ThemeColorMouseOver+ �� *TemplatedParent+ 5f   3   �� *ThemeColorPressed+ �� *TemplatedParent+5h      5i      5j      5l       5m   
   P� 5n       �@��Orientation$ 
Horizontal=�5o      . �5p      ��  � ��$
 Auto��5q      �� 5r       � ��$ 0��5s      �� 5t       � �� 5u      �� *ScrollBarSize+ �� $	 TemplatedParent=��� 5v       � �� 5w      �� *ScrollBarSize+ �� $	 TemplatedParent=��� 5x       � �� 5y      �� 5z      "  6*   .R�5{      � $ Bg��6#   $
 true��5|   #   .+�5}   "   ]� $ 
PART_Track��6(   $��1��5~   (   #{�z 5   (    5�   &   �� 5�   *   #��Z 67   8�� 5�   7    5�   &   �� 5�   *   #��Z  67   8�� 5�   7    5�   &      5�   *    6;   �� *	RadiusX+ �� $	 TemplatedParent=� 5�   ;   �� *	RadiusY+ �� $	 TemplatedParent=� 5�   ;   �� *
ThemeColor+ �� *TemplatedParent+ 5�   ;   �� *ThemeColorMouseOver+ �� *TemplatedParent+ 5�   ;   �� *ThemeColorPressed+ �� *TemplatedParent+5�   #   5�      5�      5�      5�      5�      �� 5�      "  6   .�5�   
   ��  � ��$
 Auto=�5�      �� 5�   
    � ��$ Disabled=�5�      �� 5�   
    � ��$
 True��5�      �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      � $
 Grid��6   #��z��5�      .+�5�      �� $!! PART_ScrollContentPresenter��61   #��z��5�   1   #" z��5�   1   $# False��5�   1   $$ False��5�   1   #��z��5�   1   #��z��5�   1     5�      $% PART_VerticalScrollBar��6/   $��Right=�5�   /   $& VerticalScrollBar��5�   /   8��  $' Arrow��5�   /   #) z( 5�   /   $* 0Q�5�   /   #, z+ 5�   /   #y�z- 5�   /   . 5�   /   �� *	RadiusX+ �� $	 TemplatedParent=�/ 5�   /   �� *	RadiusY+ �� $	 TemplatedParent=�0 5�   /   �� *ScrollBarSize+ �� $	 TemplatedParent=�1 5�   /   �� *
ThemeColor+ �� *TemplatedParent+2 5�   /   �� *ThemeColorMouseOver+ �� *TemplatedParent+3 5�   /   �� *ThemeColorPressed+ �� *TemplatedParent+4 5�   /   �� *VerticalOffset+$5 OneWay=� �� *TemplatedParent+  5�      $% PART_HorizontalScrollBar��6/   $��Bottom=�5�   /   $& HorizontalScrollBar��5�   /   8�� $' Arrow��5�   /   #) z6 5�   /   $* 0Q�5�   /   $7 
Horizontal=�5�   /   #, z8 5�   /   #y�z9 5�   /   . 5�   /   �� *	RadiusX+ �� $	 TemplatedParent=�/ 5�   /   �� *	RadiusY+ �� $	 TemplatedParent=�0 5�   /   �� *ScrollBarSize+ �� $	 TemplatedParent=�1 5�   /   �� *
ThemeColor+ �� *TemplatedParent+2 5�   /   �� *ThemeColorMouseOver+ �� *TemplatedParent+3 5�   /   �� *ThemeColorPressed+ �� *TemplatedParent+4 5�   /   �� *HorizontalOffset+$5 OneWay=� �� *TemplatedParent+5�      5�      5�      5�      �� 5�      " n�5�      .�5�   
   ��  �@�OverridesDefaultStyle$
 true��5�      �� 5�   
    � ��$ false��5�      �� 5�   
    � �� 5�      �� 5�      " n�6"   .R�5�      � .+�5�      �� ���#CFCFD1$ 3��5�   $   $ 3��5�   $   5�      5�      5�      5�      �� 5�      " ��5�      .�5�   
   ��  �@�OverridesDefaultStyle$
 true��5�      �� 5�   
    � ��
 ���� 5�      �� 5�   
    � |�$ false��5�      �� 5�   
    � ��$ false��5�      �� 5�   
    �@J�Opacity$	 0.2Q�5�      �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� #��z��6    #��z��5�       #��z��5�       5�      5�      5�      �� 5�      " ��5�      .�5�   
   ��  �@�OverridesDefaultStyle$
 true��5�      �� 5   
    � ��
 ���� 5     �� 5  
    � |�$ false��5     �� 5  
    � ��$ false��5     �� 5  
    �@J�Opacity$	 0.2Q�5     �� 5  
    � �� 5	     �� 5
     " ��6"   .R�5     �� #��z��6    #��z��5      #��z��5      5     5     5     �� 5     " ��5     .�5  
   ��  �@�OverridesDefaultStyle$
 true��5     �� 5  
    � ��
 ���� 5     �� 5  
    � |�$ false��5     �� 5  
    � ��$ false��5     �� 5  
    �@J�Opacity$ 0Q�5     �� 5  
    � �� 5      �� 5!     " ��6"   .R�5"     �� $��0��6    $��0��5#      ���	#900000005$      5%     5'     5(     �� 5)     " ��5*     .�5+  
   ��  �@��IsPressAndHoldEnabled$ false��5,     �� 5-  
    �@��IsFlicksEnabled$ false��5.     �� 5/  
    � ��
 ���� 50     �� 51  
    � ��$ 0,1,1,6q�52     �� 53  
    � ��$ 6��54     �� 55  
    � ��$ 6��56     �� 57  
    �@J�Opacity$ 1Q�58     �� 59  
    � �� 5:     �� 5;     " ��6"   .R�5<     � $ Bg��6   $
: true��5=     ; 5>     �� 5?     $
��auto �6,   �� 5@     $��* �6,   �� 5A     $
��auto �6,   .+�5C     �� $��0��6'   #��Z 5D  '   8��  5E  '   ]� 5F     $ 
PART_Track��6    $��1��5G      $
��true��5H      #{�z 5I       5J     �� 5K  "   #��Z 6/   8�� 5L  /    5N     �� 5O  "   #��Z 6/   8�� 5P  /    5R     n� 5S  "   8�� 6(   5U     �� 5V     $��2��6'   #��Z 5W  '   8�� 5X  '   5Y     5Z     5\      5]  
   P� 5^      �@��Orientation$ 
Horizontal=�5_     . �5`     ��  � ��
 ���� 5a     �� 5b      � ��$ 1,0,6,1q�5c     �� 5d      � ��$ 5��5e     �� 5f      � ��$ 5��5g     �� 5h      � ��$
 Auto��5i     �� 5j      �@J�Opacity$ 1Q�5k     �� 5l      � �� 5m     �� 5n     " ��6*   .R�5o     � $ Bg��6#   $
: true��5p  #   .+�5q  "   ]� $ 
PART_Track��6(   #{�z 5r  (    5s  &   �� 5t  *   #��Z 67   8�� 5u  7    5w  &   �� 5x  *   #��Z  67   8�� 5y  7    5{  &   n� 5|  *   8�� 60   5~  #   5     5�     5�     5�     5�     �� 5�     " ��5�     .�5�  
   ��  � ��
 �����5�     �� 5�  
    � ��$ 0q�5�     �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� #��z��6   #��z��5�     $
: True��5�     ._�5�     � #��z��6   .+�5�     �� #��z��65   #��z��5�  5   #' z' 5�  5   �� 5�     $< PART_VerticalScrollBar��6(   $��Right=�5�  (   #) z( 5�  (   $7 Vertical=�5�  (   8��  #, z+ 5�  (   #y�z- 5�  (   #4 z= 5�  (   �� 5�     $< PART_HorizontalScrollBar��6(   $��Bottom=�5�  (   #) z6 5�  (   $7 
Horizontal=�5�  (   8�� #, z8 5�  (   #y�z9 5�  (   #4 z> 5�  (   5�     5�      5�     :� 5�     $? ScrollChanged��6'   .[�5�     �� .��5�  "   �� .��5�  &   W� $@ PART_VerticalScrollBar��66   $A Opacity�5�  6   B 15�  6   $C 0:0:0.2D�5�  6   5�  #   5�     5�     :� 5�     $? 
MouseEnter��6'   $D PART_VerticalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $@ PART_VerticalScrollBar��66   $A Opacity�5�  6   B 15�  6   $C 0:0:0.2D�5�  6   5�  #   5�     5�     :� 5�     $? 
MouseLeave��6'   $D PART_VerticalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $@ PART_VerticalScrollBar��66   $A Opacity�5�  6   B 0.55�  6   $C 0:0:0.2D�5�  6   5�  #   5�     5�     :� 5�     $? 
MouseEnter��6'   $D PART_HorizontalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $@ PART_HorizontalScrollBar��66   $A Opacity�5�  6   B 15�  6   $C 0:0:0.2D�5�  6   5�  #   5�     5�     :� 5�     $? 
MouseLeave��6'   $D PART_HorizontalScrollBar��5�  '   .[�5�     �� .��5�  "   �� .��5�  &   W� $@ PART_HorizontalScrollBar��66   $A Opacity�5�  6   B 0.55�  6   $C 0:0:0.2D�5�  6   5�  #   5�     5�     5�     5�     5�     5�     