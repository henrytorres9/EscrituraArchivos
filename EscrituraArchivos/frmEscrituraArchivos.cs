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
    public partial class frmEscrituraArchivos : Form
    {
        public frmEscrituraArchivos()
        {
            InitializeComponent();
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //comparamos si el usuario seleccinó un archivo
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //si seleccionó un archivo, se obtiene la ruta absoluta del archivo
                rutaArchivo = openFileDialog.FileName;
            }

            //Obtiene la ruta absoluta en el text box
            txtRutaArchivo.Text = rutaArchivo;
        }

        private void btnCopiarArchivo_Click(object sender, EventArgs e)
        {
            string rutaInicial = @txtRutaArchivo.Text;
            string rutaFinal = @"D:\prueba\COPIA-DEL-ARCHIVO";

            if (!(Directory.Exists(@"D:\prueba")))
            {
                Directory.CreateDirectory(@"D:\prueba");
            }

            if (File.Exists(rutaInicial))
            {
                File.Copy(rutaInicial, rutaFinal, true);
            }
        }
    }
}
