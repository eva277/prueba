   M S B A M L   `   `   `  ����J  FCentroMedicoORM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CentroMedicoORMCentroMedicoORM  5   	   +    %CentroMedicoORM.MantenimientoUsuarios   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CentroMedicoORM     5   	     � Title$  MantenimientoUsuarios��5   	   $	��400��6'   $	��485��64   .��5	      ]� .+�5
   
   `� $	��Top=�6   .�5      c� -   5         c�Name$ toolBar��5      $
��Left=�6'   $	��Top=�6B   $��35��6Z   $	��185��6f   $��	0,0,-85,0q�6r   .@�5      �� -   5        $��	addButton��5      $��Añadir��6*   $��25��6;   $��45��6G   6R   �� 5      -   5        $��deleteButton��5      $��Eliminar��6-   $��26��6@   $��52��6L   $	��0,2q�6W   6d   �� 5      -   5        $��updateButton��5      $��	Modificar��6-   $��26��6A   $��61��6M   6X   5      5      � 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridUsers��5      $��	0,193,0,0q�6.   �� 5      -   5         ��Name$ buttonGetAllUsers��5      $��Listar Usuarios��60   $��30��6J   $��357,158,10,0q�6V   $	��Top=�6l   6�   �� 5      -   5         ��Name$ label��5      $��NSS Usuario��6#   $
��Left=�69   $��	36,10,0,0q�6T   $	��Top=�6g   �� 5      -   5         ��Name$ 
NSStextBox��5      $
��Left=�6*   $��23��6E   $��
116,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�    �� 	MaxLength$ 15��6  ��6�   ��  �� ElementName$ dataGridUsers��	 �� Path$	 SelectedItem.NssUsuario�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ OneWay=�6  �� 5      -	   5        $ 
label_Copy��5      $��Nombre��6(   $
��Left=�69   $��	57,41,0,0q�6T   $	��Top=�6g   �� 5      -
   5        $ NombretextBox��5      $
��Left=�6-   $��23��6H   $��
116,41,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $ 20��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.nombre�$
 PropertyChanged=�$ OneWay=�6  �� 5      -   5        $ label_Copy1��5      $��	Apellidos��6)   $
��Left=�6=   $��	52,68,0,0q�6X   $	��Top=�6k   �� 5      -   5        $ apellidostextbox��5      $
��Left=�60   $��23��6K   $��
116,69,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��120��6�   $ 30��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.apellidos�$
 PropertyChanged=�$ OneWay=�6  �� 5      -   5        $ label_Copy2��5      $��Contraseña��6)   $
��Left=�6>   $��	41,97,0,0q�6Y   $	��Top=�6l    J� RenderTransformOrigin$ 0.943,0.923&�6�   �� 5      -   5        $ contraseñatextbox��5      $
��Left=�61   $��23��6L   $��
116,97,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   $ 30��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.contraseña�$
 PropertyChanged=�$ OneWay=�6  �� 5      -   5        $ label_Copy3��5      $��	Direccion��6)   $��51,123,361,0q�6=   $	��Top=�6S   $ 0.969,0.615&�6k   �� 5      -   5        $ direcciontextbox��5      $
��Left=�60   $��23��6K   $��116,125,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   $ 30��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.direccion�$
 PropertyChanged=�$ OneWay=�6  �� 5      -   5        $ label_Copy4��5      $��	Localidad��6)   $
��Left=�6=   $��
279,10,0,0q�6X   $	��Top=�6l   �� 5       -   5        $ localidadtextbox��5       $
��Left=�60   $��23��6K   $��
344,10,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��123��6�   $ 20��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.localidad�$
 PropertyChanged=�$ OneWay=�6  �� 5!      -   5        $ label_Copy5��5!      $��Telefono��6)   $
��Left=�6<   $��
284,35,0,0q�6W   $	��Top=�6k   �� 5"      -   5        $ telefonotextbox��5"      $
��Left=�6/   $��23��6J   $��
344,38,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��123��6�   $ 12��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.telefono�$
 PropertyChanged=�$ OneWay=�6  �� 5#      -   5        $ label_Copy6��5#      $	��DNI��6)   $
��Left=�67   $��
308,63,0,0q�6R   $	��Top=�6f   �� 5$      -   5        $ 
dnitextbox��5$      $
��Left=�6*   $��23��6E   $��
344,66,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��123��6�   $ 9��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.dni�$
 PropertyChanged=�$ OneWay=�6  �� 5%      -   5        $ label_Copy7��5%      $��Email��6)   $
��Left=�69   $��
301,94,0,0q�6T   $	��Top=�6h   �� 5&      -   5        $ emailtextbox��5&      $
��Left=�6,   $��23��6G   $��
344,98,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��123��6�   $ 50��6  ��6�   �� $ dataGridUsers��$	 SelectedItem.email�$
 PropertyChanged=�$ OneWay=�6  5'      5(      5)      