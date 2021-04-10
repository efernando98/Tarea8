using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA8
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 100;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 500;
            arreglo[4] = 5;

            ClassArrays ObjetoArreglo = new ClassArrays(arreglo);
            int[] resultado = ObjetoArreglo.MetodoBurbuja();

            foreach (int r in resultado)
            {
                lista.Items.Add(r);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassFile ar = new ClassFile();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Por favor, selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\Fernando Olivares\Desktop\tarea8CSV";
            ofd.Filter = "archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBox1.Text = resultado;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                lista.Items.Add($"Nombre: {datosUnitarios[1]}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)

            {
                string[] datosUnitarios = Linea.Split(';');
                lista.Items.Add($"Correlativo: {datosUnitarios[0]} Parcial 1: {datosUnitarios[2]} Parcial 2: {datosUnitarios[3]} Parcial 3: {datosUnitarios[4]}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datosUnitarios = Linea.Split(';');
                lista.Items.Add($" Alumno: {datosUnitarios[1]} Promedio: {datosUnitarios[5]}");

            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
