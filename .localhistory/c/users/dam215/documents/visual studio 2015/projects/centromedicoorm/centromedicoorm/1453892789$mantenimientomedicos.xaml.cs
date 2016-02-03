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
        Repositorio<Medicos> repoMedicos;

        public MantenimientoMedicos()
        {
            InitializeComponent();
        }

        private void buttonGetAll_Click(object sender, RoutedEventArgs e)
        {
            repoMedicos = new Repositorio<Medicos>();
            actualizarTabla();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            repoMedicos = new Repositorio<Medicos>();
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
            actualizarTabla();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            repoMedicos = new Repositorio<Medicos>();
            Medicos medico = new Medicos();
            medico.idMedico = idtextbox.Text;
            medico.servicio = serviciotextbox.Text;
            medico.especialidad = especialidadtextbox.Text;
            medico.nombre = NombretextBox.Text;
            medico.apellidos = apellidostextbox.Text;
            medico.telefono = telefonotextbox.Text;
            medico.dni = dnitextbox.Text;
            repoMedicos.delete(medico);
            MessageBox.Show(("El medico " + NombretextBox.Text + " se ha eliminado correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearTextbox();
            actualizarTabla();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            repoMedicos = new Repositorio<Medicos>();
            Medicos medico = new Medicos();
            medico.idMedico = idtextbox.Text;
            medico.servicio = serviciotextbox.Text;
            medico.especialidad = especialidadtextbox.Text;
            medico.nombre = NombretextBox.Text;
            medico.apellidos = apellidostextbox.Text;
            medico.telefono = telefonotextbox.Text;
            medico.dni = dnitextbox.Text;
            repoMedicos.update(medico);
            MessageBox.Show(("El medico " + NombretextBox.Text + " se ha modificado correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearTextbox();
            actualizarTabla();
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
        private void actualizarTabla()
        {
            dataGrid.ItemsSource = repoMedicos.getAll().Select(h => new { h.idMedico, h.servicio, h.especialidad, h.nombre, h.apellidos, h.telefono, h.dni });
        }

        private bool validate()
        {
            if (!String.IsNullOrEmpty(idtextbox.Text))
            {

            }
            return false;
        }
    }
}
