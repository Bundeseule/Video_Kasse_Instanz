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
            //bResult = bNumber1 + bNumber2; this isnt allowed by the compailer, cause the number could be over 255
            iResult = bNumber1 * bNumber2;

            MessageBox.Show(iResult.ToString());
        }
        
    }
}
