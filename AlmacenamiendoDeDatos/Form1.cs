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

namespace AlmacenamiendoDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int control = 0;
        string direccion = null;

        private void rb_opcion_txt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_opcion_txt.Checked == true)
            {
                txt_texto.Visible = true;
            }
            else
            {
                txt_texto.Visible = false;
            }
        }

        private void rb_opcion_csv_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_opcion_csv.Checked == true)
            {
                dbgrd_datos_csv.Visible = true;
            }
            else
            {
                dbgrd_datos_csv.Visible = false;
            }
        }

        private void rb_opcion_xml_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_opcion_rtf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            if (rb_opcion_txt.Checked == true)
            {
                openFileDialog1.Filter = "Documento de texto (*.txt) | *.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    direccion = openFileDialog1.FileName;

                    txt_texto.Text = System.IO.File.ReadAllText(direccion);
                }

                btn_editar.Visible = true;
            }

            if (rb_opcion_csv.Checked == true)
            {
               /* openFileDialog1.Filter = "Archivo de valores separados por comas de Microsoft Excel | *.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    direccion = openFileDialog1.FileName;

                    dbgrd_datos_csv = System.IO.File.ReadAllText(direccion);
                }¨*/
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (rb_opcion_txt.Checked == true)
            {
                control = control + 1;

                string nom_arch = "Texto" + control + ".txt";
                string ruta_arch = "C:\\Users\\gookk\\Downloads\\";

                FileStream crear;

                crear = File.Create(ruta_arch + nom_arch);
                crear.Close();

                StreamWriter leer = new StreamWriter(ruta_arch + nom_arch);

                leer.WriteLine(txt_texto.Text);
                leer.Close();

                direccion = ruta_arch + nom_arch;

                MessageBox.Show("Archivo creado con exito en la direccion: " + ruta_arch + nom_arch);
                txt_texto.Clear();
            }

            if (rb_opcion_csv.Checked == true)
            {

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (rb_opcion_txt.Checked == true)
            {
                StreamWriter reescribir = new StreamWriter(direccion);

                reescribir.WriteLine(txt_texto.Text);
                reescribir.Close();

                MessageBox.Show("Archivo editado con exito en la direccion: " + direccion);
            }

            if (rb_opcion_csv.Checked == true)
            {

            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (rb_opcion_txt.Checked == true)
            {
                openFileDialog1.Filter = "Documento de texto (*.txt) | *.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    direccion = openFileDialog1.FileName;

                    DialogResult r = MessageBox.Show("Esta seguro que desea borrar este archivo?" + direccion 
                        , "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                    if (r == DialogResult.Yes)
                    {
                        File.Delete(direccion);

                        MessageBox.Show("Archivo borrado.");
                    }
                }

                txt_texto.Clear();
                btn_editar.Visible = false;
            }

            if (rb_opcion_csv.Checked == true)
            {

            }
        }
    }
}
