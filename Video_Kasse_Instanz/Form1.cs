using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Kasse_Instanz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Student
        {
            private string name;

            public Student()
            {
                MessageBox.Show("constructor of class Student gets started");
                name = "Hans";
            }

            public string GetName()
            {
                return name;
            }

            public void SetName(string uName)
            {
                name = uName;
            }

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bTest_Click(object sender, EventArgs e)
        {
            {
                //Student student = new Student();

                //MessageBox.Show(student.GetName());
                //student.SetName( "Peter");
                //MessageBox.Show(student.GetName());
            }
            {
                /*
                            int number1, number2, result;
                            double dNumber1, dNumber2, dResult;
                            byte bNumber1, bNumber2, bResult;
                            int iResult;
                
                            number1 = 5;
                            number2 = 200; 
                            result = number1 * number2;
                
                            MessageBox.Show(result.ToString());
                
                            dNumber1 = 250.3;
                            dNumber2 = 3.0;
                            dResult = dNumber1 * dNumber2;
                
                            MessageBox.Show(dResult.ToString());
                
                            bNumber1 = 100;
                            bNumber2 = 0b00000010;
                            //bResult = bNumber1 + bNumber2; this isn't allowed by the compiler, cause the number could be over 255
                            iResult = bNumber1 * bNumber2;
                
                            MessageBox.Show(iResult.ToString());
                            */
            }
            { /*
            char letter1, letter2;
            string string1, string2, stringResult;

            letter1 = 'A';
            letter2 = (char) 66;

            MessageBox.Show(letter1.ToString());
            MessageBox.Show(letter2.ToString());

            string1 = "TestString 1";
            string2 = "TestString 2";

            stringResult = String.Concat(string1, string2);

            MessageBox.Show(stringResult);
            */

            }
            {/*
                double dnumber1, dnumber2, dnumber3;
                string sZeile;

                dnumber1 = 123.34567;
                dnumber2 = dnumber1 + 100.0;
                dnumber3 = 567.89012;

                sZeile = dnumber1.ToString("F8");

                //rtbAusgabe.Text = sZeile;
                rtbAusgabe.AppendText(sZeile);

                string str = Convert.ToString(8, 2);
                MessageBox.Show(str);
                */
            }
            {/*
                double dValue;
                string sZeile, msgStr;
                bool boolCheck;

                sZeile = tbEingabe.Text;

                {
                    //dValue = double.Parse(sZeile);
                    boolCheck = double.TryParse(sZeile, out dValue);

                    //MessageBox.Show(dValue.ToString());
                    //MessageBox.Show(dValue.ToString());
                }

                if (boolCheck)
                {
                    msgStr = String.Format("The Parsetry is BoolCheck {0} the parsed number is {1:00000.00000}", boolCheck, dValue);
                    MessageBox.Show(msgStr);
                }
                else
                {
                    MessageBox.Show("ERROR WITH INPUT!!!");
           
                }*/

            }

            double dVal;
            string zeile, msgStr;
            bool ok;

            zeile = tbEingabe.Text;

            ok = double.TryParse(zeile, out dVal);

            if (ok)
            {
                if (dVal < 0.0)
                    msgStr = String.Format("The parsed number is {0}, it is smaller than zero", dVal);
                else if (dVal == 0.0)
                    msgStr = String.Format("The parsed number is {0}, it is exactly zero", dVal);
                else
                {
                    msgStr = String.Format("The parsed Number is {0}, it is bigger than zero", dVal);
                }
            }
        }

        private void rtbAusgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void bFakultaet_Click(object sender, EventArgs e)
        {
            int iResult, iNumber, i;

            iNumber = 5;

            /*
            iResult = 1; // initialisieren
            i = 1; // initialisieren

            while (i <= 5)
            {
                iResult = iResult * i; // iResult *= i;
                i++; // i = i + 1;
            }

            */
            iResult = 1;
            for (i=1; i<=5; i++)
            {
                iResult *= i;
            }

            MessageBox.Show(iResult.ToString());
        }
    }
}

