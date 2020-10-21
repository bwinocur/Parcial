using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Entidades;


namespace Parcial.Forms
{
    public partial class Form1 : Form
    {
        private static Presentismo _presentismo;
        public Form1()
        {
            _presentismo = new Presentismo();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox2.Text == string.Empty || this.textBox3.Text == string.Empty || this.textBox4.Text == string.Empty)
                {
                    MessageBox.Show("Fecha ingresada incompleta, ingrese una nueva fecha.");
                }
                else
                {
                    string fecha = this.textBox2.Text + "/" + this.textBox4.Text + "/" + this.textBox3.Text;
                    List<Asistencia> listaAsistencias = new List<Asistencia>();
                    foreach (object item in checkedListBox1.Items)
                    {
                        if (checkedListBox1.CheckedItems.Contains(item))
                            listaAsistencias.Add(new Asistencia(fecha, DateTime.Now, _presentismo.GetPreceptorActivo(),
                                (Alumno)item, true));
                        else
                            listaAsistencias.Add(new Asistencia(fecha, DateTime.Now, _presentismo.GetPreceptorActivo(),
                             (Alumno)item, false));
                    }
                    _presentismo.AgregarAsistencia(listaAsistencias, fecha);
                    checkedListBox1.DataSource = null;
                    MessageBox.Show("Asistencia para el dia {0} cargada correctamente.", fecha);
                    this.textBox1.Text = string.Empty;
                    this.textBox2.Text = string.Empty;
                    this.textBox3.Text = string.Empty;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                checkedListBox1.DataSource = null;
                checkedListBox1.DataSource = _presentismo.GetListaAlumnosRegulares();
                MessageBox.Show("Marque los alumnos presentes.");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox2.Text, out int dia) && (dia > 31 || dia < 1))
            {
                MessageBox.Show("El campo dia debe ser númerico y estar entre 1 y 31.");
                this.textBox2.Text = string.Empty;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox3.Text, out int mes) && (mes > 12 || mes < 1))
            {
                MessageBox.Show("El campo mes debe ser númerico y estar entre 1 y 12.");
                this.textBox3.Text = string.Empty;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox4.Text, out int año) && (año > 1 || año < 2020))
            {
                MessageBox.Show("El campo mes debe ser númerico y estar entre 1 y 2020.");
                this.textBox4.Text = string.Empty;
            }
        }

        private void mostrarAsistenciaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox6.Text == string.Empty || this.textBox5.Text == string.Empty || this.textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Fecha ingresada incompleta, ingrese una nueva fecha.");
                }
                else
                {
                    asistenciaAlumnosTextBox.DataSource = null;
                    asistenciaAlumnosTextBox.DataSource = _presentismo.GetAsistenciasPorFecha(this.textBox6.Text + "/" + this.textBox5.Text + "/" + this.textBox1.Text);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox6.Text, out int dia) && (dia > 31 || dia < 1))
            {
                MessageBox.Show("El campo dia debe ser númerico y estar entre 1 y 31.");
                this.textBox6.Text = string.Empty;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox5.Text, out int mes) && (mes > 12 || mes < 1))
            {
                MessageBox.Show("El campo mes debe ser númerico y estar entre 1 y 12.");
                this.textBox5.Text = string.Empty;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox1.Text, out int año) && (año > 1 || año < 2020))
            {
                MessageBox.Show("El campo mes debe ser númerico y estar entre 1 y 2020.");
                this.textBox1.Text = string.Empty;
            }
        }
    }
}
