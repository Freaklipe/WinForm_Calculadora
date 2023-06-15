using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Calculadora
{
    public partial class Calculator : Form
    {
        //Variables globales
        string str_num = string.Empty;
        double result = 0;
        int count = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void construction_operation(object sender, EventArgs e)
        {
            //Modifica el primer ingreso de la pantalla para no trabajar con el 0
            if (tbx_screen.Text == "0") tbx_screen.Text = "";

            //Capturar cada caracter
            string ctr = ((Button)sender).Text;

            //Filtra el ingreso de numero o operacion
            bool isNumber = Char.IsNumber(ctr, 0);

            //Construir la operacion
            if (!isNumber && count == 1) { str_num += ctr; count--; } 
            else { str_num += ctr; count = 1; }

            //Visualiza la operacion
            tbx_screen.Text = str_num;
        }

        private void operation(object sender, EventArgs e)
        {
            //Operaciones a trabajar
            string arithmetic = "+-*÷";

            //Elimina, encaso de ser operacion, la ultima posicion para tener operacion sin problemas
            bool isNumber = Char.IsNumber(str_num, str_num.Length - 1);
            if (!isNumber) str_num = str_num.Substring(0, str_num.Length - 1);

            //Recorre la opracion y la realiza
            foreach (char c in arithmetic)
            {
                if (str_num.Contains(c))
                {
                    string[] values = str_num.Split(c);
                    double num1 = double.Parse(values[0]);
                    double num2 = double.Parse(values[1]);

                    switch (c)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '÷':
                            result = num1 / num2;
                            break;
                        default:
                            break;
                    }

                }
            }

            //Muestra resultado y actualiza la base de calculo
            tbx_screen.Text = result.ToString();
            str_num = result.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Elimina un caracter ingresado y actualiza el estado global para calculo
            if (tbx_screen.TextLength == 1) 
            { 
                tbx_screen.Text = "0";
                str_num = string.Empty;
                result = 0; 
            }
            else 
            { 
                tbx_screen.Text = tbx_screen.Text.Substring(0, tbx_screen.TextLength - 1); 
                str_num = tbx_screen.Text;
                result = double.Parse(str_num); 
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //Limpia todas las variables glabales y visuales
            tbx_screen.Text = "0";
            str_num = string.Empty;
            result = 0;
            count = 0;
        }
    }
}