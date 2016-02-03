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
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Repositorio<Usuarios> reposUsuarios = new Repositorio<Usuarios>();
            reposUsuarios.getAll();
        }
    }
}
