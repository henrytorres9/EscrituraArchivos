using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscrituraArchivos
{
    public partial class frmListaArchivos : Form
    {
        public frmListaArchivos()
        {
            InitializeComponent();
        }

        private void btnSeleccionarDirectorio_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fbd.SelectedPath;
            }
            
            txtRutaDirectorio.Text = rutaDirectorio;

            if (rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);

                foreach (var item in di.GetFiles())
                {
                    lvArchivos.Items.Add(item.Name);
                }
            }
        }

        private void lvArchivos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSeleccionado.Text = lvArchivos.SelectedItems[0].SubItems[0].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaInicial = @txtRutaDirectorio.Text + @"\texto_ejemplo.txt";
            string rutaInicial2 = @txtRutaDirectorio.Text + @"\texto_ejemplo2.txt";
            string rutaInicial3 = @txtRutaDirectorio.Text + @"\texto_ejemplo3.txt";
            string rutaInicial4 = @txtRutaDirectorio.Text + @"\texto_ejemplo4.txt";
            string rutaFinal1 = @"C:\prueba\COPIA DE-" + lblSeleccionado.Text;

            if (!(Directory.Exists(@"C:\prueba")))
            {
                Directory.CreateDirectory(@"C:\prueba");
            }

            if (File.Exists(rutaInicial) || File.Exists(rutaInicial2) || File.Exists(rutaInicial3) || File.Exists(rutaInicial4))
            {
                File.Copy(rutaInicial, rutaFinal1, true);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
