using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class title : Form
    {
        public title()
        {
            InitializeComponent();
        }

        private void lecar_Click(object sender, EventArgs e)
        {
            lecar form = new lecar ();
            form.Show();
            this.Hide();
        }

        private void skid_Click(object sender, EventArgs e)
        {
            skid form = new skid();
            form.Show();
            this.Hide();
        }

        private void tovar_Click(object sender, EventArgs e)
        {
            tovar form = new tovar();
            form.Show();
            this.Hide();
        }

        private void sotrud_Click(object sender, EventArgs e)
        {
            sotrud form = new sotrud();
            form.Show();
            this.Hide();
        }

        private void zakaz_Click(object sender, EventArgs e)
        {
            zakaz form = new zakaz();
            form.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
           title form = new title();
            form.Show();
            this.Hide();
        }

        private void title_Load(object sender, EventArgs e)
        {

        }
    }
}
