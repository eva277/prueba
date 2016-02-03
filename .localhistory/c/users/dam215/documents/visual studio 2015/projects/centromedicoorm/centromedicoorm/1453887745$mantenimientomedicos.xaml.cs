using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CentroMedicoORM.AD;


namespace CentroMedicoORM
{
    /// <summary>
    /// Lógica de interacción para MantenimientoMedicos.xaml
    /// </summary>
    public partial class MantenimientoMedicos : Window
    {
        Repositorio<Medicos> repoMedicos = new Repositorio<Medicos>();

        public MantenimientoMedicos()
        {
            InitializeComponent();
        }

        private void buttonGetAll_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = repoMedicos.getAll();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Medicos medico = new Medicos();
            medico.idMedico = idtextbox.Text;
            medico.servicio = serviciotextbox.Text;
            medico.especialidad = especialidadtextbox.Text;
            medico.nombre = NombretextBox.Text;
            medico.apellidos = apellidostextbox.Text;
            medico.telefono = telefonotextbox.Text;
            medico.dni = dnitextbox.Text;
            repoMedicos.create(medico);
            MessageBox.Show(("El medico " + NombretextBox.Text + " se ha añadido correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearTextbox();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Medicos medico = new Medicos();
            medico.idMedico = idtextbox.Text;
            medico.servicio = serviciotextbox.Text;
            medico.especialidad = especialidadtextbox.Text;
            medico.nombre = NombretextBox.Text;
            medico.apellidos = apellidostextbox.Text;
            medico.telefono = telefonotextbox.Text;
            medico.dni = dnitextbox.Text;
            repoMedicos.delete(medico);
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Medicos medico = new Medicos();
            medico.idMedico = idtextbox.Text;
            medico.servicio = serviciotextbox.Text;
            medico.especialidad = especialidadtextbox.Text;
            medico.nombre = NombretextBox.Text;
            medico.apellidos = apellidostextbox.Text;
            medico.telefono = telefonotextbox.Text;
            medico.dni = dnitextbox.Text;
            repoMedicos.update(medico);
        }
        private void ClearTextbox()
        {
            idtextbox.Clear();
            serviciotextbox.Clear();
            especialidadtextbox.Clear();
            NombretextBox.Clear();
            apellidostextbox.Clear();
            telefonotextbox.Clear();
            dnitextbox.Clear();
        }
    }
}
