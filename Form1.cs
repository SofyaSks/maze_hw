using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            moveToStart();
        }

        private void moveToStart()
        {
            Point startP = panel1.Location;
            startP.Offset(32, 25);
            Cursor.Position = PointToScreen(startP);
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("VICTORY!!!");
            Form2 Form2 = new Form2();        
            Form2.Show();

        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            moveToStart();
        }

        
    }
}

