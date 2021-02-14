using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Form_01
{
        public partial class Form_back : Form
        {
        double Primero;
        double Segundo;
        double Result;
        string Operador;
        public Form_back()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button_0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void porcent_Click(object sender, EventArgs e)
        {
            Operador = "%";
            Primero = double.Parse(Screen.Text);
            Screen.Clear();
        }


        private void button_point_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ".";
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(Screen.Text);
            Screen.Clear();
            switch (Operador)
            {
                case "+":
                    Result = Primero + Segundo;
                    Screen.Text = Result.ToString();
                    break;
                case "-":
                    Result = Primero - Segundo;
                    Screen.Text = Result.ToString();
                    break;
                case "*":
                    Result = Primero * Segundo;
                    Screen.Text = Result.ToString();
                    break;    
                case "/":
                    Result = Primero / Segundo;
                    Screen.Text = Result.ToString();
                    break;
                case "%":
                    Result = Primero % Segundo;
                    Screen.Text = Result.ToString();
                    break;
            }
        }
        private void Button_Suma_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Primero = double.Parse(Screen.Text);
            Screen.Clear();
        }
        private void button_resta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = double.Parse(Screen.Text);
            Screen.Clear();
        }
        private void Button_Multiplicacion_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Primero = double.Parse(Screen.Text);
            Screen.Clear();
        }
        private void Button_Division_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = double.Parse(Screen.Text);
            Screen.Clear();
        }
        private void button_borrar_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(const string[]);
        }

    }
}
