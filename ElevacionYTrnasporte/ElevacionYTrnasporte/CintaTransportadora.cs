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
    public partial class CintaTransportadora : Form
    {
        public double velocidad;
        public double inclinacionK;
        public double alimentacionK1;
        public Int32 IVT;

        public Int32 angulodesobrecara;
        public double pasoida;
        public double pasoretorno = 3.0;

        public String pasoVariable = "< 1.2";
        public int indexTamaño = 0;
        public int indexParticipacion;

        public double factorServicio;
        public double factorAmbiental;
        public double factorParticipacion;

        public double coeficienteResistencia;

        public CintaTransportadora()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CintaTransportadora_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public double getVelocidad(int value, String abrasividad)
        {
            double res = 0;
            if (value == 0)
            {
                if (abrasividad == "A")
                {
                    res = 2.5;
                }
                else if (abrasividad == "B")
                {
                    res = 2.3;
                }
                else if (abrasividad == "C")
                {
                    res = 2;
                }
                else if (abrasividad == "D")
                {
                    res = 1.65;
                }
            }
            if (value == 1)
            {
                if (abrasividad == "A")
                {
                    res = 3;
                }
                else if (abrasividad == "B")
                {
                    res = 2.75;
                }
                else if (abrasividad == "C")
                {
                    res = 2.38;
                }
                else if (abrasividad == "D")
                {
                    res = 2;
                }
            }
            if (value == 2)
            {
                if (abrasividad == "A")
                {
                    res = 3.5;
                }
                else if (abrasividad == "B")
                {
                    res = 3.2;
                }
                else if (abrasividad == "C")
                {
                    res = 2.75;
                }
                else if (abrasividad == "D")
                {
                    res = 2.35;
                }
            }
            if (value == 3)
            {
                if (abrasividad == "A")
                {
                    res = 4;
                }
                else if (abrasividad == "B")
                {
                    res = 3.65;
                }
                else if (abrasividad == "C")
                {
                    res = 3.15;
                }
                else if (abrasividad == "D")
                {
                    res = 2.65;
                }
            } if (value == 4)
            {
                if (abrasividad == "A")
                {
                    res = 4.5;
                }
                else if (abrasividad == "B")
                {
                    res = 4;
                }
                else if (abrasividad == "C")
                {
                    res = 3.5;
                }
                else if (abrasividad == "D")
                {
                    res = 3;
                }
            } if (value == 5)
            {
                if (abrasividad == "A")
                {
                    res = 5;
                }
                else if (abrasividad == "B")
                {
                    res = 4.5;
                }
                else if (abrasividad == "C")
                {
                    res = 3.5;
                }
                else if (abrasividad == "D")
                {
                    res = 3;
                }
            } if (value == 6)
            {
                if (abrasividad == "A")
                {
                    res = 6;
                }
                else if (abrasividad == "B")
                {
                    res = 5;
                }
                else if (abrasividad == "C")
                {
                    res = 4.5;
                }
                else if (abrasividad == "D")
                {
                    res = 4;
                }
            }
            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                velocidad = getVelocidad(Tamañomin.SelectedIndex, abrasividad.SelectedItem.ToString());
                //respuesta.Text = Tamañomin.SelectedItem.ToString();
                resultTxt.Text = resultTxt.Text + "Velocidad: " + velocidad + "\n";
                resultTxt.Text = resultTxt.Text + "Inclinacion: " + inclinacionK + "\n";
                resultTxt.Text = resultTxt.Text + "Alimentacion: " + alimentacionK1 + "\n";
                double valor = (velocidad * (inclinacionK * alimentacionK1));
                IVT = (Int32)((Convert.ToDouble(IMtxt.Text)) / valor);
                resultTxt.Text = resultTxt.Text + "IVT: " + IVT + "\n";
                respuesta.Text = IVT.ToString();

                AnchoBanda banda = new AnchoBanda();
                banda.result = IVT;
                banda.peso = pasoVariable;
                banda.retorno = pasoretorno;
                banda.velocidad = velocidad;
                banda.capacidad = Convert.ToInt32(capacidadTxt.Text);
                banda.tamañoMin = indexTamaño;
                banda.factorAmbiental = factorAmbiental;
                banda.factorServicio = factorServicio;
                banda.factorParticipacion = factorParticipacion;
                banda.Show();
            }
            catch (Exception) { }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void inclinacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inclinacionBox.SelectedItem == "0 º" || inclinacionBox.SelectedItem == "1 º" || inclinacionBox.SelectedItem == "2 º" || inclinacionBox.SelectedItem == "3 º")
            {
                inclinacionK = 1;
            }
            if (inclinacionBox.SelectedItem == "4 º" || inclinacionBox.SelectedItem == "5 º" || inclinacionBox.SelectedItem == "6 º" || inclinacionBox.SelectedItem == "7 º")
            {
                inclinacionK = 0.98;
            }
            if (inclinacionBox.SelectedItem == "8 º" || inclinacionBox.SelectedItem == "9 º")
            {
                inclinacionK = 0.96;
            }
            if (inclinacionBox.SelectedItem == "10 º" || inclinacionBox.SelectedItem == "11 º")
            {
                inclinacionK = 0.96;
            }
            if (inclinacionBox.SelectedItem == "12 º" || inclinacionBox.SelectedItem == "13 º")
            {
                inclinacionK = 0.94;
            }
            if (inclinacionBox.SelectedItem == "14 º")
            {
                inclinacionK = 0.92;
            }
            if (inclinacionBox.SelectedItem == "15 º")
            {
                inclinacionK = 0.90;
            }
            if (inclinacionBox.SelectedItem == "16 º")
            {
                inclinacionK = 0.88;
            }
            if (inclinacionBox.SelectedItem == "17 º")
            {
                inclinacionK = 0.86;
            }
            if (inclinacionBox.SelectedItem == "18 º")
            {
                inclinacionK = 0.84;
            }
            if (inclinacionBox.SelectedItem == "19 º")
            {
                inclinacionK = 0.82;
            }
            if (inclinacionBox.SelectedItem == "20 º")
            {
                inclinacionK = 0.80;
            }
            //respuesta.Text = inclinacionK.ToString();
        }

        private void Tamañomin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Tamañomin.SelectedIndex == 0){
                indexTamaño = 1;
                Tamañomax.SelectedIndex = 0;
            }
            if (Tamañomin.SelectedIndex == 1) {
                indexTamaño = 2;
                Tamañomax.SelectedIndex = 1;
            }
            if (Tamañomin.SelectedIndex == 2) {
                indexTamaño = 2;
                Tamañomax.SelectedIndex = 2;
            }
            if (Tamañomin.SelectedIndex == 3)
            {
                indexTamaño = 3;
                Tamañomax.SelectedIndex = 3;
            }
            if (Tamañomin.SelectedIndex == 4)
            {
                indexTamaño = 4;
                Tamañomax.SelectedIndex = 4;
            }
            if (Tamañomin.SelectedIndex == 5)
            {
                indexTamaño = 5;
                Tamañomax.SelectedIndex = 5;
            }
            if (Tamañomin.SelectedIndex == 6)
            {
                indexTamaño = 5;
                Tamañomax.SelectedIndex = 6;
            }
        }

        private void alimentacionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alimentacionBox.SelectedItem == "Regular")
            {
                alimentacionK1 = 1;
            } if (alimentacionBox.SelectedItem == "Poco Regular")
            {
                alimentacionK1 = 0.95;
            } if (alimentacionBox.SelectedItem == "Muy Irregular")
            {
                alimentacionK1 = 0.90;
            }
            //respuesta.Text = alimentacionK1.ToString();
        }

        private void angureposo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (angureposo.SelectedItem == "0 - 19")
            {
                angulodesobrecara = 5;
                indexParticipacion = 1;
                factorParticipacion = 1;
            }
            if (angureposo.SelectedItem == "20 - 29")
            {
                angulodesobrecara = 10;
                indexParticipacion = 2;
                factorParticipacion = 0.55;
            }
            if (angureposo.SelectedItem == "30 - 34")
            {
                angulodesobrecara = 20;
                indexParticipacion = 3;
                factorParticipacion = 0.67;

            }
            if (angureposo.SelectedItem == "35 - 39")
            {
                angulodesobrecara = 25;
                indexParticipacion = 4;
                factorParticipacion = 0.72;
            }
            if (angureposo.SelectedItem == "> 40")
            {
                angulodesobrecara = 30;
                indexParticipacion = 4;
                factorParticipacion = 0.40;
            }

        }

        private void pesobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pesobox.SelectedItem == "< 1.2") {
                pasoVariable = "< 1.2";
            }
            else if (pesobox.SelectedItem == "1.2 a 2")
            {
                pasoVariable = "1.2 a 2";
            }
            else {
                pasoVariable = "> 2";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(utilizacionTxt.SelectedIndex == 0){
                factorServicio = 0.8;
                utiltxt.Text = factorServicio.ToString();
            }
            else if (utilizacionTxt.SelectedIndex == 1) {
                factorServicio = 1.0;
                utiltxt.Text = factorServicio.ToString();
            }
            else if (utilizacionTxt.SelectedIndex == 2)
            {
                factorServicio = 1.1;
                utiltxt.Text = factorServicio.ToString();
            }
            else if (utilizacionTxt.SelectedIndex == 3)
            {
                factorServicio = 1.2;
                utiltxt.Text = factorServicio.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (condicionTxt.SelectedIndex == 0)
            {
                factorAmbiental = 0.9;
                utiltxt.Text = factorAmbiental.ToString();
            }
            else if (condicionTxt.SelectedIndex == 1)
            {
                factorAmbiental = 1.0;
                utiltxt.Text = factorAmbiental.ToString();
            }
            else if (condicionTxt.SelectedIndex == 2)
            {
                factorAmbiental = 1.1;
                utiltxt.Text = factorAmbiental.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void distanciaEjesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (distanciaEjesBox.SelectedIndex == 0) {
                coeficienteResistencia = 4.5;
            }
            if (distanciaEjesBox.SelectedIndex == 1)
            {
                coeficienteResistencia = 3.2;
            }
            if (distanciaEjesBox.SelectedIndex == 2)
            {
                coeficienteResistencia = 2.6;
            }
            if (distanciaEjesBox.SelectedIndex == 3)
            {
                coeficienteResistencia = 2.2;
            }
            if (distanciaEjesBox.SelectedIndex == 4)
            {
                coeficienteResistencia = 2.1;
            }
            if (distanciaEjesBox.SelectedIndex == 5)
            {
                coeficienteResistencia = 2.0;
            }
            if (distanciaEjesBox.SelectedIndex == 6)
            {
                coeficienteResistencia = 1.8;
            }
            if (distanciaEjesBox.SelectedIndex == 7)
            {
                coeficienteResistencia = 1.7;
            }
            if (distanciaEjesBox.SelectedIndex == 8)
            {
                coeficienteResistencia = 1.5;
            }
            if (distanciaEjesBox.SelectedIndex == 9)
            {
                coeficienteResistencia = 1.4;
            }
            if (distanciaEjesBox.SelectedIndex == 10)
            {
                coeficienteResistencia = 1.3;
            }
            if (distanciaEjesBox.SelectedIndex == 11)
            {
                coeficienteResistencia = 1.2;
            }
            if (distanciaEjesBox.SelectedIndex == 12)
            {
                coeficienteResistencia = 1.1;
            }
            if (distanciaEjesBox.SelectedIndex == 13)
            {
                coeficienteResistencia = 1.05;
            }
            if (distanciaEjesBox.SelectedIndex == 14)
            {
                coeficienteResistencia = 1.03;
            }
            //ultimo paso.
        }


    }
}
