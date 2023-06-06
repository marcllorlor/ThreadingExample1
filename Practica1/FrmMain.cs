using Practica1.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class FrmMain : Form
    {

        int alçadamaximapantalla = 0;
        int ampladamaixmapantalla = 0;

        Color[] arraycolors = {Color.Black,Color.Blue,Color.Red,Color.Yellow};

        

        List<Thread> llThreads = new List<Thread>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNouBloc_Click(object sender, EventArgs e)
        {
            llThreads.Add(new Thread(afegirnoubloc));
            llThreads[llThreads.Count - 1].IsBackground = true;
            llThreads[llThreads.Count - 1].Start();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            alçadamaximapantalla = Screen.PrimaryScreen.Bounds.Height;
            ampladamaixmapantalla = Screen.PrimaryScreen.Bounds.Width;
        }
        
        private void afegirnoubloc()
        {
            Random r = new Random();
            
            int midapanellpetit = r.Next(30, 70);
            int cantitatpanellspetitsalçada = r.Next(2,7);
            int cantitatpanellspetitsamplada = r.Next(2,7);
            //Abans de fer la mida del panell pare haurem de fer un calcul per saber quants requadres petits hauran d'haver a dins del panell pare

            Color colorPanellFill = arraycolors[r.Next(0, arraycolors.Length - 1)];

            ClBlocs bloc = new ClBlocs(midapanellpetit, cantitatpanellspetitsamplada, cantitatpanellspetitsalçada, colorPanellFill, this);

            //afegirblocclblocs();
            //this.Invoke(afegirblocclblocs);
               
        }

        private void afegirblocclblocs()
        {
            
        }
    }
}
