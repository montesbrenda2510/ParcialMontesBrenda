using parcialcubo.Datos;
using parcialcubo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcialcubo.windows
{
    public partial class formularioprincipal : Form
    {
        public formularioprincipal()
        {
            InitializeComponent();
        }


        private void nuevoButton_Click(object sender, EventArgs e)
        {
            formularioCuboAE fmr = new formularioCuboAE() { Text = "Aagregar un nuevo cubo" };
            DialogResult dr = fmr.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            cubo cubo=fmr.GetCubo();
            repositorio.Agragar(cubo);

            //metodo para armar las grillas
            DataGridViewRow r = Constuirfila();
            setearfila(r, cubo);
            Agregarfila(r);

        }

        private void Agregarfila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void setearfila(DataGridViewRow r, cubo cubo)
        {
            r.Cells[ColArista.Index].Value = cubo.Arista;
            r.Cells[ColRelleno.Index].Value = cubo.relleno.ToString();
            r.Cells[ColTrazo.Index].Value = cubo.trazo.ToString();
            r.Cells[ColVolumen.Index].Value = cubo.GetVolumen();
            r.Cells[ColArea.Index].Value = cubo.GetArea();

            r.Tag = cubo;

        }

        private DataGridViewRow Constuirfila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;


        }

        //instancio el repo
        private Repositorio repositorio;


        private void formularioprincipal_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            repositorio.GuardarenArchivo();
        }
    }
}
