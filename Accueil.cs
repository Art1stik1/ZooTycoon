using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTycoon
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }

        private void BtnCommencer_Click(object sender, EventArgs e)
        {
            Zoo form_zoo = new Zoo();
            this.Hide();
            form_zoo.ShowDialog();
            this.Close();
        }
    }
}
