using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSFC_OSFinalProject
{
    public partial class Queue: Form
    {
        public Queue()
        {
            InitializeComponent();

            //transparent label

            txtConsultation.BackColor = Color.Transparent;
            txtConsultation.Parent = pictureBox1;
            txtLabTesting.BackColor = Color.Transparent;
            txtLabTesting.Parent = pictureBox1;
            txtVaccination.BackColor = Color.Transparent;
            txtVaccination.Parent = pictureBox1;
            txtBilling.BackColor = Color.Transparent;
            txtBilling.Parent = pictureBox1;
        }
    }
}
