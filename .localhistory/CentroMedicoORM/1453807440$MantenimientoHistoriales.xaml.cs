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
    /// Lógica de interacción para MantenimientoHistoriales.xaml
    /// </summary>
    public partial class MantenimientoHistoriales : Window
    {
        Repositorio<Historiales> repoHistoriales = new Repositorio<Historiales>();
        public MantenimientoHistoriales()
        {
            InitializeComponent();
        }

        private void buttonGetAll_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = repoHistoriales.getAll();//.Select(h=>new Historiales {h.idHistoria,h.usuario,h });
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Historiales historial = new Historiales();
            historial.idHistoria = Convert.ToInt16(idtextobx.Text) ;
            historial.usuario = usuariotetbox.Text;
            historial.medico = medicotextbox.Text;
            historial.sintomas = sintomastextbox.Text;
            historial.diagnostico = diagnosticotextbox.Text;
            historial.tratamiento = tratamientotextbox.Text;
            historial.fecha = datePicker.DisplayDate;
            repoHistoriales.create(historial);
            MessageBox.Show(("El historial " + idtextobx.Text + " se ha añadido correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            ClearTextBox();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Historiales historial = new Historiales();
            historial.idHistoria = Convert.ToInt16(idtextobx.Text);
            historial.usuario = usuariotetbox.Text;
            historial.medico = medicotextbox.Text;
            historial.sintomas = sintomastextbox.Text;
            historial.diagnostico = diagnosticotextbox.Text;
            historial.tratamiento = tratamientotextbox.Text;
            historial.fecha = datePicker.DisplayDate;


            repoHistoriales.delete(historial);
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Historiales historial = new Historiales();
            historial.idHistoria = Convert.ToInt16(idtextobx.Text);
            historial.usuario = usuariotetbox.Text;
            historial.medico = medicotextbox.Text;
            historial.sintomas = sintomastextbox.Text;
            historial.diagnostico = diagnosticotextbox.Text;
            historial.tratamiento = tratamientotextbox.Text;
            historial.fecha = datePicker.DisplayDate;
            repoHistoriales.update(historial);
        }
        protected void ClearTextBox()
        {
            idtextobx.Clear();
            usuariotetbox.Clear();
            medicotextbox.Clear();
            sintomastextbox.Clear();
            diagnosticotextbox.Clear();
            tratamientotextbox.Clear();
        }
    }
}
