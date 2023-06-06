using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.CLASSES
{
    public class ClBlocs
    {
        int midapanellpetit;
        int cantitatpanellspetitsamplada;
        int cantitatpanellspetitsalçada;
        Panel panellPare;
        Color colorPanellFill;
        Form frmMain;

        Panel panellFill = new Panel();

        delegate void delegacio();

        public ClBlocs(int xmidapanellpetit, int xcantitatpanellspetitsamplada, int xcantitatpanellspetitsalçada, Color xColorPanellFills, Form xfMain)
        {
            cantitatpanellspetitsalçada = xcantitatpanellspetitsalçada;
            cantitatpanellspetitsamplada = xcantitatpanellspetitsamplada;
            midapanellpetit = xmidapanellpetit;
            colorPanellFill = xColorPanellFills;

            frmMain = xfMain;
            panellPare = new Panel();
            Random r = new Random();

            panellPare.Size = new Size(midapanellpetit * cantitatpanellspetitsamplada, midapanellpetit * cantitatpanellspetitsalçada);

            int posicioxpanellgran = r.Next(0, frmMain.Height);
            int posicioypanellgran = r.Next(0, frmMain.Width);
            panellPare.Location = new Point(posicioxpanellgran, posicioypanellgran);
            panellPare.BorderStyle = BorderStyle.FixedSingle;


            
            


            frmMain.Invoke(new delegacio(inserirblocgranalform));

            construirPanells();
        }

        private void inserirblocgranalform()
        {
            frmMain.Controls.Add(panellPare);
        }

        private void construirPanells()
        {
            int posicioxapintar = 0;
            int posicioyapintar = 0;


            //Primer haurem de fer els panells d'alçada i despres els panells de amplada
            for(int i = 0; i < cantitatpanellspetitsalçada; i++)
            {
                for(int z = 0; z < cantitatpanellspetitsamplada; z++)
                {
                    //Aqui farem la creacio del panell petit

                    panellFill = new Panel();
                    panellFill.Size = new Size(midapanellpetit,midapanellpetit);
                    panellFill.Location = new Point(posicioxapintar,posicioyapintar);

                    panellFill.BackColor = colorPanellFill;
                    panellFill.BorderStyle = BorderStyle.FixedSingle;

                    //panellFill.BringToFront();
                    Thread.Sleep(500);
                    panellPare.Invoke(new delegacio(inserirpanellpetit));
                    

                    

                    posicioxapintar += midapanellpetit;
                }
                posicioyapintar += midapanellpetit;
                posicioxapintar = 0;
            }
            //panellPare.SendToBack(); //Això també és una altre cosa que he trobat per internet
            //panellPare.Visible = false; //Això és una cosa que he vist per internet pero no funciona
            

        }

        private void inserirpanellpetit()
        {
            panellPare.Controls.Add(panellFill);
        }
    }
}
