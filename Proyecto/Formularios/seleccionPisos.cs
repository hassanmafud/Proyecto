using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios
{
    public partial class seleccionPisos : Form
    {
        public seleccionPisos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex - 1) % tabControl.TabCount;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex - 1) % tabControl.TabCount;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex - 1) % tabControl.TabCount;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex - 1) % tabControl.TabCount;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (rbtn_totalizarXpiso.Checked || rbtn_totalizarXsector.Checked)
            {
                if (rbtn_totalizarXpiso.Checked)
                {
                    DialogResult dl = MessageBox.Show("Confirmar generacion de totalizacion por piso?", "Generar reporte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dl == DialogResult.OK)
                    {
                        tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
                    }

                }
                else
                {
                    DialogResult dl = MessageBox.Show("Confirmar generacion de totalizacion por sector?", "Generar reporte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dl == DialogResult.OK)
                    {
                        tabControl.SelectedIndex = (tabControl.SelectedIndex + 1) % tabControl.TabCount;
                    }

                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una forma de totalizacion..", "Generar reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = (tabControl.SelectedIndex - 1) % tabControl.TabCount;
        }
    }
}
