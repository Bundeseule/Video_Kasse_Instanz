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
                MessageBox.Show("Konstruktor der Klasse Student wird aufgerufen");
                name = "Hans";
            }

            public string GetName()
            {
                return name;
            }
        }
    }
}
