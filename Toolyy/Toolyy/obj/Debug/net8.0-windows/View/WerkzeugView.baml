   M S B A M L   `   `   `  ����A  =Toolyy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Toolyy.ViewModelsToolyy.ViewModels  5          Toolyy.View.WerkzeugView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .vmclr-namespace:Toolyy.ViewModels     5      .��5      � $��20q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�6.   .+�5      �� $	��150��6   $��5q�6"    � ToolTip$
 Name��6z   ��6-   �� *AktuellesWerkzeug.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6z   �� 5      $	��150��6   $��5q�6"   $ 	Kategorie��6Y   ��6-   �� *AktuellesWerkzeug.Category+6Y   �� 5      $	��150��6   $��5q�6"   $	 Ort��6Y   ��6-   �� *AktuellesWerkzeug.Location+6Y   �� 5      $��
Verfügbar��6   $��5q�6]    d� 	IsChecked 6+   �� *AktuellesWerkzeug.Available+6]   5      �� 5   
   -   5        $��Werkzeug hinzufügen��5      $��1��6/   $��30��6<   $	��180��6H   $
��Left=�6T   ��5      Z� 6$   �� 5   
   $��2��6   $��0 10 0 0q�6    �� DisplayMemberPath$
 Name��6S   ��61   �� *	Werkzeuge+6S   5       5!      