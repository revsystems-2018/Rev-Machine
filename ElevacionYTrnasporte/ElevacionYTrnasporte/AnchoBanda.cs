using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevacionYTrnasporte
{
    public partial class AnchoBanda : Form
    {
        public Int32 result;
        public string peso; 
        public double paso;
        public int ancho;
        public double retorno;
        public double diametro;
        public double velocidad;

        public AnchoBanda()
        {
            InitializeComponent();
        }

        private void enviarbtn_Click(object sender, EventArgs e)
        {
            pasoTxt.Text = paso.ToString() + " " + retorno.ToString();
        }

        private void AnchoBanda_Load(object sender, EventArgs e)
        {
            resultadoTxt.Text = result.ToString();
        }

        public int getDiametro(double ancho, double velocidad) {
            int res = 0;
            if (ancho == 500 || ancho == 650 || ancho == 800){
                if(velocidad <= 2){
                    res = 89;
                }
                else if (velocidad > 2 || velocidad <= 4)
                {
                    res = 89;
                }
                else {
                    res = 133;
                }
            }
            if(ancho == 1000 || ancho == 1200){
                if (velocidad <= 2)
                {
                    res = 108;
                }
                else if (velocidad > 2 || velocidad <= 4)
                {
                    res = 108;
                }
                else
                {
                    res = 133;
                }
            }
            if(ancho == 1400 || ancho == 1600){
                if (velocidad <= 2 || velocidad >= 4)
                {
                    res = 159;
                }
            }
            if(ancho == 1800 || ancho == 2000){
                if (velocidad <= 2 || velocidad >= 4)
                {
                    res = 159;
                }
            }
            if(ancho >= 2200){
                res = 194;
            }
            return res;
        }

        private void anchobandabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (anchobandabox.SelectedItem == "300" || anchobandabox.SelectedItem == "400" || anchobandabox.SelectedItem == "500" || anchobandabox.SelectedItem == "650") { 
                if (peso == "< 1.2" ){
                    paso = 1.65;
                } if (peso == "1.2 a 2")
                {
                    paso = 1.5;
                } if (peso == "> 2")
                {
                    paso = 1.4;
                }
            } if (anchobandabox.SelectedItem == "1200" || anchobandabox.SelectedItem == "1400" || anchobandabox.SelectedItem == "1600" || anchobandabox.SelectedItem == "1800")
            {
                if (peso == "< 1.2")
                {
                    paso = 1.2;
                } if (peso == "1.2 a 2")
                {
                    paso = 1;
                } if (peso == "> 2")
                {
                    paso = 0.8;
                }
            } if (anchobandabox.SelectedItem == "2000" || anchobandabox.SelectedItem == "2200" ) 
                if (peso == "< 1.2" ){
                    paso = 1;
                } if (peso == "1.2 a 2")
                {
                    paso = 0.8;
                } if (peso == "> 2")
                {
                    paso = 0.7;
                }
             if (anchobandabox.SelectedItem == "800"){
                 if (peso == "< 1.2")
                 {
                     paso = 1.5;
                 } if (peso == "1.2 a 2")
                 {
                     paso = 1.35;
                 } if (peso == "> 2")
                 {
                     paso = 1.25;
                 }
             }
             if (anchobandabox.SelectedItem == "1000")
             {
                 if (peso == "< 1.2")
                 {
                     paso = 1.35;
                 } if (peso == "1.2 a 2")
                 {
                     paso = 1.20;
                 } if (peso == "> 2")
                 {
                     paso = 1.1;
                 }
             }
            ancho = Convert.ToInt32(anchobandabox.SelectedItem.ToString());
            diametro = getDiametro(ancho, velocidad);
            pasoTxt.Text = paso.ToString() +" "+ retorno +" "+ ancho.ToString() +" "+diametro;
        }

    }
}
