   M S B A M L   `   `   `  ����J  FCentroMedicoORM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CentroMedicoORMCentroMedicoORM  5   	   .    (CentroMedicoORM.MantenimientoHistoriales   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CentroMedicoORM     5   	     � Title$  MantenimientoHistoriales��5   	   $	��400��6*   $	��500��67   .��5	      ]� .+�5
   
   `� $	��Top=�6   .�5      c� -   5         c�Name$ toolBar��5      $
��Left=�6'   $	��Top=�6B   $��35��6Z   $	��185��6f   $��	0,0,-85,0q�6r   .@�5      �� -   5        $��	addButton��5      $��Añadir��6*   $��25��6;   $��45��6G   6R   �� 5      -   5        $��deleteButton��5      $��Eliminar��6-   $��26��6@   $��52��6L   $	��0,2q�6W   6d   �� 5      -   5        $��updateButton��5      $��	Modificar��6-   $��26��6A   $��61��6M   6X   5      5      � 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��	0,163,0,0q�6)   �� 5      -   5         ��Name$ buttonGetAll��5      $��Listar Historiales��6+   $
��Left=�6H   $��30��6c   $��368,128,0,0q�6o   $	��Top=�6�   $	��114��6�   6�   �� 5      -   5         ��Name$ label��5      $��Id Historial��6#   $
��Left=�6:   $��	13,10,0,0q�6U   $	��Top=�6h   �� 5      -   5         ��Name$ 	idtextobx��5      $
��Left=�6)   $��23��6D   $��	88,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   ��6�   ��  �� ElementName$ dataGrid�� �� Path$ SelectedItem.idHistoria�	 �� Mode$	 OneWay=��� 5      -	   5        $ 
label_Copy��5      $��Usuario��6(   $
��Left=�6:   $��	29,41,0,0q�6U   $	��Top=�6h   �� 5      -
   5        $ usuariotetbox��5      $
��Left=�6-   $��23��6H   $��	88,41,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $��40��6�   
 �� 	MaxLength$
 15��6�   {�.  ��6�   �� $ dataGrid��$ SelectedItem.usuario�$	 OneWay=�6�   �� 5      -   5        $ label_Copy1��5      $��Medico��6)   $
��Left=�6:   $��	24,69,0,0q�6U   $	��Top=�6h   �� 5      -   5        $ medicotextbox��5      $
��Left=�6-   $��23��6H   $��	88,69,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $��40��6�   $
 8��6�   {�.  ��6�   �� $ dataGrid��$ SelectedItem.medico�$	 OneWay=�6�   �� 5      -   5        $ label_Copy2��5      $��Sintomas��6)   $
��Left=�6<   $��8,94,0,0q�6W   $	��Top=�6i   �� 5      -   5        $ sintomastextbox��5      $
��Left=�6/   $��23��6J   $��	88,97,0,0q�6V   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $	
 200��6�   ��6�   �� $ dataGrid��$ SelectedItem.sintomas�$	 OneWay=�6�   �� 5      -   5        $ label_Copy3��5      $��Diagnostico��6)   $��10,122,409,0q�6?   $	��Top=�6U   �� 5      -   5        $ diagnosticotextbox��5      $
��Left=�62   $��23��6M   $��
88,125,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   $	
 200��6�   ��6�   �� $ dataGrid��$ SelectedItem.diagnostico�$	 OneWay=�6�   �� 5      -   5        $ label_Copy4��5      $��Tratamiento��6)   $
��Left=�6?   $��
230,10,0,0q�6Z   $	��Top=�6n   �� 5       -   5        $ tratamientotextbox��5       $
��Left=�62   $��23��6M   $��
303,10,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   $	
 200��6�   ��6�   �� $ dataGrid��$ SelectedItem.tratamiento�$	 OneWay=�6�   �� 5!      -   5        $ label_Copy5��5!      $��Fecha��6)   $
��Left=�69   $��
243,35,0,0q�6T   $	��Top=�6h   (  "System.Windows.Controls.DatePicker  5"      -   5        $��
datePicker��5"      $
��Left=�6+   $��23��6F   $��
303,38,0,0q�6R   $	��Top=�6f   $	��120��6~      SelectedDate 6�   �� $ dataGrid��$ SelectedItem.fecha�$	 OneWay=��� 5#      -   5         ��Name$ comboBoxUSU��5#      $
��Left=�6,   $��
133,42,0,0q�6G   $	��Top=�6[   $	��100��6s   6   �� 5$      -   5        $ comboBoxMED��5$      $
��Left=�6,   $��
133,69,0,0q�6G   $	��Top=�6[   $	��100��6s   6   5%      5&      5'      