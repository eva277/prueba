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
    /// Lógica de interacción para MantenimientoUsuarios.xaml
    /// </summary>
    public partial class MantenimientoUsuarios : Window
    {
        Repositorio<Usuarios> reposUsuarios;

        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (validated())
            {
                reposUsuarios = new Repositorio<Usuarios>();
                Usuarios usuario = new Usuarios();
                usuario.NssUsuario = NSStextBox.Text;
                usuario.nombre = NombretextBox.Text;
                usuario.apellidos = apellidostextbox.Text;
                usuario.contrasena = contraseñatextbox.Text;
                usuario.direccion = direcciontextbox.Text;
                usuario.localidad = localidadtextbox.Text;
                usuario.telefono = telefonotextbox.Text;
                usuario.dni = dnitextbox.Text;
                usuario.email = emailtextbox.Text;
                reposUsuarios.create(usuario);
                MessageBox.Show(("El usuario " + NombretextBox.Text + " se ha añadido correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                clearTextbox();

                actualizarTabla();
            }
            else
            {
                MessageBox.Show("El Nss del usuario, el nombre, los apellidos y la contraseña no pueden ser campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                clearTextbox();
            }

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (validated())
            {
                reposUsuarios = new Repositorio<Usuarios>();
                Usuarios usuario = new Usuarios();
                usuario.NssUsuario = NSStextBox.Text;
                usuario.nombre = NombretextBox.Text;
                usuario.apellidos = apellidostextbox.Text;
                usuario.contrasena = contraseñatextbox.Text;
                usuario.direccion = direcciontextbox.Text;
                usuario.localidad = localidadtextbox.Text;
                usuario.telefono = telefonotextbox.Text;
                usuario.dni = dnitextbox.Text;
                usuario.email = emailtextbox.Text;
                reposUsuarios.delete(usuario);
                MessageBox.Show(("El usuario " + NombretextBox.Text + " se ha eliminado correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                clearTextbox();
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("El Nss del usuario, el nombre, los apellidos y la contraseña no pueden ser campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                clearTextbox();
            }

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (validated())
            {
                reposUsuarios = new Repositorio<Usuarios>();
                Usuarios usuario = new Usuarios();
                usuario.NssUsuario = NSStextBox.Text;
                usuario.nombre = NombretextBox.Text;
                usuario.apellidos = apellidostextbox.Text;
                usuario.contrasena = contraseñatextbox.Text;
                usuario.direccion = direcciontextbox.Text;
                usuario.localidad = localidadtextbox.Text;
                usuario.telefono = telefonotextbox.Text;
                usuario.dni = dnitextbox.Text;
                usuario.email = emailtextbox.Text;
                reposUsuarios.update(usuario);
                MessageBox.Show(("El usuario " + NombretextBox.Text + " se ha modificado correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);

                clearTextbox();
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("El Nss del usuario, el nombre, los apellidos y la contraseña no pueden ser campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                clearTextbox();
            }

        }
        private void clearTextbox()
        {
            NSStextBox.Clear();
            NombretextBox.Clear();
            apellidostextbox.Clear();
            contraseñatextbox.Clear();
            direcciontextbox.Clear();
            localidadtextbox.Clear();
            telefonotextbox.Clear();
            dnitextbox.Clear();
            emailtextbox.Clear();
        }

        private void buttonGetAllUsers_Click(object sender, RoutedEventArgs e)
        {
            reposUsuarios = new Repositorio<Usuarios>();
            actualizarTabla();
        }

        private void buttonGetAllHist_Click(object sender, RoutedEventArgs e)
        {
            Repositorio<Historiales> repoHist = new Repositorio<Historiales>();
            dataGridHist.ItemsSource = repoHist.getAll();
        }
        private void actualizarTabla()
        {
            dataGridUsers.ItemsSource = reposUsuarios.getAll().Select(h => new { h.NssUsuario, h.nombre, h.apellidos, h.contrasena, h.direccion, h.localidad, h.telefono, h.dni, h.email });
        }

        private bool validated()
        {
            if (!String.IsNullOrEmpty(NSStextBox.Text)&& !String.IsNullOrEmpty(NombretextBox.Text) && !String.IsNullOrEmpty(apellidostextbox.Text) && !String.IsNullOrEmpty(telefonotextbox.Text) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
