   M S B A M L   `   `   `  ����A  =Toolyy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Toolyy.ViewModelsToolyy.ViewModels  5   	   %    Toolyy.View.WerkzeugDetailsView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .vmclr-namespace:Toolyy.ViewModels     5   	     � Title$  Werkzeugdetails��5   	   $	��300��6!   $	��400��6.   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� $��0��6   $��0,0,0,10q�6"   .+�5      �� $
��Bold"�67   $��16(�6I   ��6   �� *Werkzeug.Name+6I   �� 5      ��6   �� *Werkzeug.Category+�� 5      ��6   �� *Werkzeug.Location+�� 5      $��Status:��6   $
��Bold"�6'   $��0,10,0,0q�69   �� 5      ��6   �� *
StatusText+�� 5      ��6   �� *VerliehenInfo+5      �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5      �� $��	Ausborgen��6   $	��100��6)   $��5q�65   ��5      �� *AusborgenCommand+{�5      �� *KannAusborgen+�� 5      $��Retournieren��6   $	��100��6,   $��5q�68   ��5      �� *RetournierenCommand+{�5      �� *KannRetournieren+5      5      5      