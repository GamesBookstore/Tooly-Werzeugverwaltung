   M S B A M L   `   `   `  ����
  Toolyy!    Toolyy.View.AddWerkzeugView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      � $��10q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0,0,0,10q�6,   .+�5      �� $��Name:��6   �� 5      $
��Auto��6   $��0,0,0,10q�6p   ��6#   �� *AktuellesWerkzeug.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6p   �� 5      $��
Kategorie:��6   �� 5      $��0,0,0,10q�6g   ��6   �� *AktuellesWerkzeug.Category+$ PropertyChanged=�6g   �� 5      $��Verfügbar:��6   �� 5      $��
Verfügbar��6I   $��0,0,0,10q�6]    d� 	IsChecked 6   �� *AktuellesWerkzeug.Available+6]   �� 5      $��	Standort:��6   �� 5      $��0,0,0,10q�6g   ��6   �� *AktuellesWerkzeug.Location+$ PropertyChanged=�6g   �� 5!      -   5        $��Hinzufügen��5!      $	��100��6D   $��0,0,10,0q�6P   �� 5"      -   5        $��	Abbrechen��5"      $	��100��6A   5#      5$      5%      