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
using static parcialcubo.Entidades.Trazo;

namespace parcialcubo.windows
{
    public partial class formularioCuboAE : Form
    {
        public formularioCuboAE()
        {
            InitializeComponent();
        }
        private cubo cubo;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Cargarcolores();
        }

        private void Cargarcolores()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Relleno));
            comboBox1.SelectedIndex = 0;
        }

        public cubo GetCubo()
        {
            return cubo;
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        //valido los datos ingresados
        private void okbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cubo == null)
                {
                    cubo = new cubo();
                }
                cubo.Arista = int.Parse(textBox1.Text);
                cubo.relleno = (Relleno)comboBox1.SelectedItem;

                if (cuntinuocheckBox.Checked)
                {
                    cubo.trazo = Trazo.continuo;
                }
                else if (rayascheckBox.Checked)
                {
                    cubo.trazo = Trazo.rayas;
                }
                else
                {
                    cubo.trazo = Trazo.puntos;
                }
                if (cubo.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                errorProvider1.SetError(textBox1, "El valor de la arista tiene que se positivo");
               
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(textBox1.Text, out int cubo))
            {
                valido = false;
                errorProvider1.SetError(textBox1, "Error al ingresar la Arista");
                return valido;
            }
            return valido;
        }

        private void formularioCuboAE_Load(object sender, EventArgs e)
        {

        }
    }
        
}
