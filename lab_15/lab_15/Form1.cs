
/*
 1. Обчислити значення виразу за формулою (усі змінні приймають
дійсні значення):

2. Дано значення х. Одержати значення -2х + 3x^2 - 4x^3 і 1 + 2х + 3х^2 + 4х^3. Подбати про економію операцій.

3. Скласти лінійну програму, яка друкує значення true, якщо
зазначене висловлення є дійсним, і false – якщо ні: “Дано три сторони одного
й три сторони іншого трикутника. Ці трикутники рівновеликі, тобто мають
рівні площі”.

4. У хмарочосі N поверхів і всього один під’їзд. На кожному поверсі
по 3 квартири, ліфт може зупинятися тільки на непарних поверхах. Людина
сідає в ліфт і набирає номер потрібної йому квартири М. На який поверх
повинен доправити ліфт пасажира?

5. Дано ціле n > 2. Надрукувати всі прості числа з діапазону [2, n].

6. Дано послідовність цілих чисел а1, а2,..., аn. Найменший член цієї
послідовності замінити цілою частиною середнього арифметичного всіх
членів, інші члени залишити без зміни. Якщо в послідовності кілька
найменших членів, то замінити останній по черзі.

7. Дано рядок. Підрахувати кількість букв k в останньому її слові.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ЗАВДАННЯ 1
        private void btn1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            if (x == 1)
                result1.Text = "Помилка";
            else
            {
                double result = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);
                result1.Text = result.ToString();
            }    
        }

        private void txtX_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            int pos = txtX.SelectionStart;

            if (e.KeyChar == '-')
            {
                if (txtX.Text.StartsWith("-"))
                {
                    txtX.Text = txtX.Text.Substring(1);
                    txtX.SelectionStart = pos - 1;
                }
                else
                {
                    txtX.Text = "-" + txtX.Text;
                    txtX.SelectionStart = pos + 1;
                }

                e.Handled = true;
                return;
            }

            if (e.KeyChar == ',')
            {
                if (txtX.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn1.Focus();
                return;
            }

            e.Handled = true;

        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            int pos = txtY.SelectionStart;

            if (e.KeyChar == '-')
            {
                if (txtY.Text.StartsWith("-"))
                {
                    txtY.Text = txtY.Text.Substring(1);
                    txtY.SelectionStart = pos - 1;
                }
                else
                {
                    txtY.Text = "-" + txtY.Text;
                    txtY.SelectionStart = pos + 1;
                }

                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtY.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn1.Focus();
                return;
            }

            e.Handled = true;
        }



        //ЗАВДАННЯ 2
        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            int pos = txtX2.SelectionStart;

            if (e.KeyChar == '-')
            {
                if (txtX2.Text.StartsWith("-"))
                {
                    txtX2.Text = txtX2.Text.Substring(1);
                    txtX2.SelectionStart = pos - 1;
                }
                else
                {
                    txtX2.Text = "-" + txtX2.Text;
                    txtX2.SelectionStart = pos + 1;
                }

                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtX2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn2.Focus();
                return;
            }

            e.Handled = true;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX2.Text);
            double a = 2 * x;
            double b = 3 * Math.Pow(x, 2);
            double c = 4 * Math.Pow(x, 3);
            double res = -a + b - c;
            double ult = 1 + a + b + c;
            result2.Text = "1 Вираз:  " + res.ToString() + "\n" + "2 Вираз:  " + ult.ToString();
        }


        //ЗАВДАННЯ 3

        private void txtAB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtAB.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3.Focus();
                return;
            }

            e.Handled = true;
        }

        private void txtBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtBC.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3.Focus();
                return;
            }

            e.Handled = true;
        }

        private void txtAC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtAC.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3.Focus();
                return;
            }

            e.Handled = true;
        }

        private void txtKF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtKF.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3.Focus();
                return;
            }

            e.Handled = true;
        }

        private void txtFD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtFD.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3.Focus();
                return;
            }

            e.Handled = true;
        }

        private void txtDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (txtDK.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn3.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double AB = Convert.ToDouble(txtAB.Text);
            double BC = Convert.ToDouble(txtBC.Text);
            double AC = Convert.ToDouble(txtAC.Text);
            double KF = Convert.ToDouble(txtKF.Text);
            double FD = Convert.ToDouble(txtFD.Text);
            double DK = Convert.ToDouble(txtDK.Text);
            double S1, S2;
            double P1 = AB + BC + AC;
            double P2 = KF + FD + DK;
            if (AB > BC + AC || BC > AB + AC || AC > BC + AB || KF > FD + DK || FD > KF + DK || DK > KF + FD)
                result3.Text = "Такого трикутника не існує";

            else
            {
                S1 = Math.Sqrt(P1 * (P1 - AB) * (P1 - BC) * (P1 - AC));
                S2 = Math.Sqrt(P2 * (P2 - KF) * (P2 - FD) * (P2 - DK));
                if (S1 == S2)
                    result3.Text = "true";
                else
                    result3.Text = "false";
            }

        }


        //ЗАВДАННЯ 4

        private void floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn4.Focus();
                return;
            }

            e.Handled = true;
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn4.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int nFloor = Convert.ToInt32(floor.Text);
            int nNumber = Convert.ToInt32(number.Text);
            int maxNumber = 3 * nFloor;
            if (nNumber % 3 == 1)
                nNumber = nNumber + 2;
            else
            {
                if(nNumber % 3 == 2)
                    nNumber = nNumber + 1;
            }
                
            int position;
            if (nNumber > maxNumber)
                result4.Text = "Такої квартири не існує";
            else
            {
                if (nNumber % 2 == 0 && nNumber == maxNumber)
                    position = nNumber / 3 - 1;
                else
                {
                    if (nNumber % 2 == 0)
                    {
                        position = nNumber / 3 + 1;
                        result4.Text = "Ви прибули на: " + position + " поверх";
                    }
                    else
                    {
                        position = nNumber / 3;
                        result4.Text = "Ви прибули на: " + position + " поверх";
                    }
                }
            }
        }

        //ЗАВДАННЯ 5

        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }


        private void btn5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(prime.Text);
            if (n == 0 || n == 1)
            {
                nPrime.Text = "Числа 1 та 0 не є простими";
            }
            else
            {
                nPrime.Text = "";
                for (uint i = 0u; i <= n; i++) 
                {
                    if (IsPrimeNumber(i))
                    {
                        nPrime.Text = nPrime.Text + " " + i; 
                    }
                }
            }
        }

        private void prime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn5.Focus();
                return;
            }

            e.Handled = true;
        }


        //ЗАВДАННЯ 6

        private void arr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == ' ')
            {
                e.KeyChar = ';';
                return;
            }

            if (e.KeyChar == ';')
            {
                e.KeyChar = ';';
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btn6.Focus();
                return;
            }

            e.Handled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            char[] sign = new char[] { ';'};
            string[] a = arr.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries);
            int maxn = a.Length;
            int average = 0;
            int min = Convert.ToInt32(a[0]);
            int m = 0;
            for (int i = 0; i < maxn; i++)
            {
                int k = Convert.ToInt32(a[i]);
                average = average + k;
            }
            average = average / maxn;
            for (int i = 0; i < maxn; i++)
            {
                if (min >= Convert.ToInt32(a[i]))
                {
                    min = Convert.ToInt32(a[i]);
                    m = i;
                }
            }
            a[m] = Convert.ToString(average);
            for (int i = 0; i < maxn; i++)
            {
                result6.Text = result6.Text + a[i] + "; ";
            }
        }


        //ЗАВДАННЯ 7

        private void btn7_Click(object sender, EventArgs e)
        {
            char[] sign = new char[] { ' ', ';', '.', ',' };
            string[] a = txtString.Text.Split(sign, StringSplitOptions.RemoveEmptyEntries);
            int maxn = a.Length - 1;
            int length = a[maxn].Length;
            result7.Text = Convert.ToString(length);
        }
    }
}
