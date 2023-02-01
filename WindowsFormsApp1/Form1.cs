using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        //private void btnNao_Click(object sender, EventArgs e)
        //{
        //    //Cursor.Position = PointToScreen(btnSim.Location);
            
        //}

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigadinho!! <3");
            Application.Exit();
        }

      

        private void txtPergunta_TextChanged(object sender, EventArgs e)
        {
            
        }
        public static Int16 GetNumRandom(Int16 Min, Int16 Max)
        {
            Random r = new Random();
            return (short)r.Next(Min, Max);
            
        }

        private void btnNao_MouseHover(object sender, EventArgs e)
        {
            int x, y, x_, y_;

            x = 10;
            y = (this.Width + this.Height) / 2;

            x_ = GetNumRandom((short)x, (short)y);
            y_ = GetNumRandom((short)x, (short)y);

            btnNao.Location = new System.Drawing.Point(x_, y_);
        }
    }
}
