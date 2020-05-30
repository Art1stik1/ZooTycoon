using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooTycoon
{
    public partial class Accueil : Form
    {
        private int v1 = 1;
        
        public Accueil()
        {
            InitializeComponent();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }

        private void BtnCommencer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.gererTempsLancement));
            thread.IsBackground = true;
            thread.Name = "Boucle de jeu";
            thread.Start();
        }

        private void gererTempsLancement()
        {
        for (int i =0; i < 3; i++) {
                btnCommencer.Invoke(new updateUI(uiEdit));
                v1 = v1 + 1;
                Thread.Sleep(1000);
            }
            btnCommencer.Invoke(new updateUIDone(uiEditDone));
        }
        public delegate void updateUI();
        public delegate void updateUIDone();
        public  void uiEdit(){
            btnCommencer.Size = new System.Drawing.Size(300, 70);
            btnCommencer.Text = "Lancement du jeu dans : "+v1;
            
        }
        public void uiEditDone()
        {
            Zoo form_zoo = new Zoo();
            this.Hide();
            form_zoo.ShowDialog();
            this.Close();
           
    }   }
}
