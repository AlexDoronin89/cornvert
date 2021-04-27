using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cornevter
{
    public partial class Form1 : Form
    {
        int balance = 1000;
        int dolBalance = 0;
        int eurBalance = 0;
        int costEur = 90;
        int costDol = 75;
        int addBall = 1;
        

        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            labelBalanceRub.Text = balance.ToString();
            if (dolBalance >0)
            {
                balance = +costDol;
                dolBalance = -addBall;
            }
            else
            {
                if(eurBalance > 0)
                {
                    balance = +costEur;
                    eurBalance = -addBall;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelBalanceRub.Text = balance.ToString();
            labelBalanceDol.Text = dolBalance.ToString();
            labelBalanceEur.Text = eurBalance.ToString();
        }

        private void buttonTransDol_Click(object sender, EventArgs e)
        {
            labelBalanceDol.Text = dolBalance.ToString();
            if (balance >= costDol)
            {
                balance = -costDol;
                dolBalance = +addBall;
            }
            else
            {
                if(eurBalance >= 1)
                {
                    eurBalance = -addBall;
                    dolBalance = +addBall;
                }
            }
        }

        private void buttonTransEur_Click(object sender, EventArgs e)
        {
            labelBalanceEur.Text = eurBalance.ToString();
            if (balance >= costEur)
            {
                balance = -90;
                eurBalance = +addBall;
            }
            else
            {
                if (dolBalance >= 1)
                {
                    dolBalance = -addBall;
                    eurBalance = +addBall;
                }
            }
        }
    }
}
