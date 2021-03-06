﻿using System;
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
        Repositorio<Historiales> repoHistoriales;
        public MantenimientoHistoriales()
        {
            InitializeComponent();
            Repositorio<Usuarios> repoUsu = new Repositorio<Usuarios>();
            comboBox.Items.Add(repoUsu.getAll());
        }

        private void buttonGetAll_Click(object sender, RoutedEventArgs e)
        {
            repoHistoriales = new Repositorio<Historiales>();
            ClearTextBox();
            actualizarTabla();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (validated())
            {
                repoHistoriales = new Repositorio<Historiales>();
                Historiales historial = new Historiales();
                historial.idHistoria = Convert.ToInt16(idtextobx.Text);
                historial.usuario = usuariotetbox.Text;
                historial.medico = medicotextbox.Text;
                historial.sintomas = sintomastextbox.Text;
                historial.diagnostico = diagnosticotextbox.Text;
                historial.tratamiento = tratamientotextbox.Text;
                historial.fecha = datePicker.SelectedDate;
                repoHistoriales.create(historial);
                MessageBox.Show(("El historial " + idtextobx.Text + " se ha añadido correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearTextBox();
                actualizarTabla();
            }

            else
            {
                MessageBox.Show("El id de la historia, el usuario y el medico no pueden ser campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearTextBox();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (validated())
            {
                repoHistoriales = new Repositorio<Historiales>();
                Historiales historial = new Historiales();
                historial.idHistoria = Convert.ToInt16(idtextobx.Text);
                historial.usuario = usuariotetbox.Text;
                historial.medico = medicotextbox.Text;
                historial.sintomas = sintomastextbox.Text;
                historial.diagnostico = diagnosticotextbox.Text;
                historial.tratamiento = tratamientotextbox.Text;
                historial.fecha = datePicker.SelectedDate;

                repoHistoriales.delete(historial);

                MessageBox.Show(("El historial " + idtextobx.Text + " se ha eliminado correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);

                ClearTextBox();
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("El id de la historia, el usuario y el medico no pueden ser campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearTextBox();
            }

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if (validated())
            {
                repoHistoriales = new Repositorio<Historiales>();
                Historiales historial = new Historiales();
                historial.idHistoria = Convert.ToInt16(idtextobx.Text);
                historial.usuario = usuariotetbox.Text;
                historial.medico = medicotextbox.Text;
                historial.sintomas = sintomastextbox.Text;
                historial.diagnostico = diagnosticotextbox.Text;
                historial.tratamiento = tratamientotextbox.Text;
                historial.fecha = datePicker.SelectedDate;
                repoHistoriales.update(historial);
                MessageBox.Show(("El historial " + idtextobx.Text + " se ha Modificado correctamente"), "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);

                ClearTextBox();
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("El id de la historia, el usuario y el medico no pueden ser campos vacios", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearTextBox();
            }

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
        private void actualizarTabla()
        {
            dataGrid.ItemsSource = repoHistoriales.getAll().Select(h => new { h.idHistoria, h.usuario, h.medico, h.sintomas, h.diagnostico, h.tratamiento, h.fecha });
        }
        private bool validated()
        {
            if (!String.IsNullOrEmpty(idtextobx.Text)&&!String.IsNullOrEmpty(usuariotetbox.Text)&&!String.IsNullOrEmpty(medicotextbox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void idtextobx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
