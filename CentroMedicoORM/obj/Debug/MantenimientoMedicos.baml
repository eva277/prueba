   M S B A M L   `   `   `  ����J  FCentroMedicoORM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CentroMedicoORMCentroMedicoORM  5   	   *    $CentroMedicoORM.MantenimientoMedicos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CentroMedicoORM     5   	     � Title$  MantenimientoMedicos��5   	   $	��400��6&   $	��500��63   .��5	      ]� .+�5
   
   `� $	��Top=�6   .�5      c� -   5         c�Name$ toolBar��5      $
��Left=�6'   $	��Top=�6B   $��35��6Z   $	��185��6f   $��	0,0,-85,0q�6r   .@�5      �� -   5        $��	addButton��5      $��Añadir��6*   $��25��6;   $��45��6G   6R   �� 5      -   5        $��deleteButton��5      $��Eliminar��6-   $��26��6@   $��52��6L   $	��0,2q�6W   6d   �� 5      -   5        $��updateButton��5      $��	Modificar��6-   $��26��6A   $��61��6M   $��0,2,0,0q�6s   $	��Top=�6�   5      5      � 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��	0,147,0,0q�6)   �� 5      -   5         ��Name$ buttonGetAll��5      $��Listar Medicos��6+   $
��Left=�6D   $��30��6_   $��368,112,0,0q�6k   $	��Top=�6�   $	��114��6�    J� RenderTransformOrigin$ 
0.509,-0.3&�6�   �� 5      -   5         ��Name$ label��5      $��	ID Medico��6#   $
��Left=�67   $��	13,10,0,0q�6R   $	��Top=�6e   �� 5      -   5         ��Name$ 	idtextbox��5      $
��Left=�6)   $��23��6D   $��	88,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�    �� 	MaxLength$ 8��6�   ��6�   �� 	 �� ElementName$	 dataGrid��
 �� Path$
 SelectedItem.idMedico� �� Mode$ OneWay=�6�   �� 5      -	   5        $ 
label_Copy��5      $��Nombre��6(   $
��Left=�69   $��	29,41,0,0q�6T   $	��Top=�6g   �� 5      -
   5        $ NombretextBox��5      $
��Left=�6-   $��23��6H   $��	88,41,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $ 10��6�   ��6�   �� $	 dataGrid��$
 SelectedItem.nombre�$ OneWay=�6�   �� 5      -   5        $ label_Copy1��5      $��	Apellidos��6)   $
��Left=�6=   $��	24,69,0,0q�6X   $	��Top=�6k   �� 5      -   5        $ apellidostextbox��5      $
��Left=�60   $��23��6K   $��	88,69,0,0q�6W   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $ 30��6�   ��6�   �� $	 dataGrid��$
 SelectedItem.apellidos�$ OneWay=�6�   �� 5      -   5        $ label_Copy5��5      $��Telefono��6)   $
��Left=�6<   $��	29,94,0,0q�6W   $	��Top=�6j   �� 5      -   5        $ telefonotextbox��5      $
��Left=�6/   $��23��6J   $��	89,97,0,0q�6V   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $ 12��6�   ��6�   �� $	 dataGrid��$
 SelectedItem.telefono�$ OneWay=�6�   �� 5      -   5        $ label_Copy6��5      $	��DNI��6)   $
��Left=�67   $��
261,66,0,0q�6R   $	��Top=�6f   �� 5      -   5        $ 
dnitextbox��5      $
��Left=�6*   $��23��6E   $��
297,69,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $��90��6�   $ 9��6�   ��6�   �� $	 dataGrid��$
 SelectedItem.dni�$ OneWay=�6�   �� 5      -   5        $ label_Copy3��5      $��Servicio��6)   $
��Left=�6<   $��
241,10,0,0q�6W   $	��Top=�6k   �� 5       -   5        $ serviciotextbox��5       $
��Left=�6/   $��23��6J   $��
297,10,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $��90��6�   $ 8��6�   {�.  ��6�   �� $
 SelectedItem.servicio�$	 dataGrid��$ OneWay=�6�   �� 5!      -   5        $ label_Copy4��5!      $��Especialidad��6)   $
��Left=�6@   $��
222,41,0,0q�6[   $	��Top=�6o   �� 5"      -   5        $ especialidadtextbox��5"      $
��Left=�63   $��23��6N   $��
297,41,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $��90��6�   $ 8��6�   {�.  ��6�   �� $
 SelectedItem.especialidad�$	 	dataGridd��$ OneWay=�6  �� 5#      -   5         ��Name$ comboBoxServ��5#      $
��Left=�6-   $��
392,10,0,0q�6H   $	��Top=�6\   $��90��6t   6   �� 5$      -   5        $ comboBoxEspec��5$      $
��Left=�6.   $��
392,41,0,0q�6I   $	��Top=�6]   $��90��6u   6�   5%      5&      5'      