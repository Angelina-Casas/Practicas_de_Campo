using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G6_ENUNCIADO_2
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }
        int[] G6_Datos;
        private void G6_BtnInsertar_Click(object sender, EventArgs e)
        {
            G6_Datos = new int[dataGridView1.Rows.Count-1];

            for (int i=0; i<dataGridView1.Rows.Count-1;i++)
            {
                G6_Datos[i] = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            for(int i=0;i<G6_Datos.Count();i++)
            {
                textMostrar.Text = string.Join(" ; ", G6_Datos);

            }
        }
        private void G6_BtnAscendente_Click(object sender, EventArgs e)
        {
            int[] G6_Resultados = OrdenamientoSeleccionAsc(G6_Datos);

            for (int i = 0; i < G6_Resultados.Count(); i++)
            {
                ResulAscen.Text = string.Join(" ; ", G6_Resultados);

            }
        }
        public static int[] OrdenamientoSeleccionAsc(int [] vector)
        {
            for (int i =0;i<vector.Length-1;i++)
            {
                int min = i;
                for(int j=i+1;j<vector.Length;j++)
                {
                    if (vector[j] < vector[min])
                        min = j;
                }
                if(min !=i)
                {
                    int aux = vector[i];
                    vector[i] = vector[min];
                    vector[min] = aux;
                }
            }
            return vector;
        }
        private void G6_BtnDescendente_Click(object sender, EventArgs e)
        {
            int[] G6_Resultados = OrdenamientoSeleccionDesn(G6_Datos);

            for (int i = 0; i < G6_Resultados.Count(); i++)
            {
                txtResulDesn.Text = string.Join(" ; ", G6_Resultados);

            }
        }
        public static int[] OrdenamientoSeleccionDesn(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] > vector[min])
                        min = j;
                }
                if (min != i)
                {
                    int aux = vector[i];
                    vector[i] = vector[min];
                    vector[min] = aux;
                }
            }
            return vector;
        }
        public bool Buscar(int[] G6_Datos, int G6_numero)
        {
            foreach (int dato in G6_Datos)
            {
                if (dato == G6_numero)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int G6_numero = Int32.Parse(txtNumero.Text);
                if (Buscar(G6_Datos, G6_numero))
                {
                    lblNum.Text = $"Número encontrado: {G6_numero}";
                }
                else
                {
                    lblNum.Text = "Número no encontrado";
                }
            }
            catch (FormatException)
            {
                lblNum.Text = "Por favor, ingrese un número válido. ";
            }
            catch (Exception ex)
            {
                lblNum.Text = "Error: " + ex.Message;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int G6_numero = Int32.Parse(txtEliminar.Text);
                List<int> tempList = G6_Datos.ToList();
                if (tempList.Remove(G6_numero))
                {
                    G6_Datos = tempList.ToArray();
                    textMostrar.Text = string.Join(" ; ", G6_Datos);
                    ResulAscen.Text = string.Join(" ; ", OrdenamientoSeleccionAsc(G6_Datos));
                    txtResulDesn.Text = string.Join(" ; ", OrdenamientoSeleccionDesn(G6_Datos));
                    lblNum.Text = $"Número {G6_numero} eliminado.";
                }
                else
                {
                    lblNum.Text = "Número no encontrado.";
                }
            }
            catch (FormatException)
            {
                lblNum.Text = "Por favor, ingrese un número válido.";
            }
            catch (Exception ex)
            {
                lblNum.Text = "Error: " + ex.Message;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            G6_Datos = new int[0];
            textMostrar.Text = "";
            ResulAscen.Text = "";
            txtResulDesn.Text = "";
            lblNum.Text = "";
            txtEliminar.Text = "";
            txtNumero.Text = "";
            dataGridView1.Rows.Clear();
        }
        private void Lista_Load(object sender, EventArgs e)
        {

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
