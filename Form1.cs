using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        int point_cnt = 0;
        double vis = 0;
        string vis_ari = "";
        bool is_vis_ari = false;
        bool is_equal = false;
        //int ari_count = 0;
        //string ari_nxt = "";
        //bool is_ari_count = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //default 0
            visual.Text = "0";
            vis = 0;
            vis_ari = "";
            point_cnt = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //string num = visual.Text;
            //float nums = float.Parse(num);
            if(point_cnt < 1)
            {
                point_cnt++;
                visual.Text += ".";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void visual_Click(object sender, EventArgs e)
        {
  
        }

        private void num1_Click(object sender, EventArgs e)
        {
            //visual.Text = num1.Text;
            //visual.Text += num1.Text;
            Button btn = (Button)sender;
            String num = btn.Text;

            

            if (visual.Text == "0" || visual.Text == "+" || visual.Text == "-"
                || visual.Text == "*" || visual.Text == "/" 
                || vis > 0)
                visual.Text = num;
            else
                visual.Text += num;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (visual.Text != "0")
                visual.Text += num0.Text;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(visual.Text);
            bool zero_error = false;

            //string ari_n_n = vis_ari;
            //
            //if(ari_count > 1 && ari_nxt != vis_ari)
            //{
            //    //ari_n_n = vis_ari;
            //    vis_ari = ari_nxt;
            //
            //    is_ari_count = true;
            //
            //    if (is_equal)
            //        ari_count = 0;
            //}

            switch (vis_ari)
            {
                case "+":
                    vis += temp;
                    break;
                case "-":
                    vis -= temp;
                    break;
                case "*":
                    vis *= temp;
                    break;
                case "/":
                    if (temp != 0)
                        vis /= temp;
                    else
                        zero_error = true;
                    break;
            }

            if (zero_error)
                visual.Text = "除数不能为零";
            else
                visual.Text = vis.ToString();

            if (!is_vis_ari && is_equal)
            {
                vis_ari = "";
                is_equal = false;
            }
            else
                is_vis_ari = false;

            //if (is_ari_count)
            //{
            //    vis_ari = ari_n_n;
            //    is_ari_count = false;
            //}
                   
        }

        private void sum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String ari = btn.Text;

            is_equal = true;
            //ari_count++;

                //if (vis_ari != "")
                //{
                //    if (ari_count > 1)
                //    {
                //        ari_nxt = ari;
                //    }
                //    else
                //    {
                //        vis_ari = ari;
                //    }
                //    is_vis_ari = true;
                //    is_equal = false;
                //    equal_Click(sender, e);
                //}
           if (vis_ari != "")
           {
                //vis_ari = ari;
                is_vis_ari = true;
                is_equal = false;
                equal_Click(sender, e);
                }
            else
            {
                vis = double.Parse(visual.Text);
                vis_ari = ari;
                visual.Text = "";
                //visual.Text = vis_ari;
                point_cnt = 0;
            }

            //switch (ari)
            //{
            //    case "+":
            //        vis_ari = "+";
            //        break;
            //    case "-":
            //
            //        break;
            //    case "*":
            //
            //        break;
            //    case "/":
            //
            //        break;
            //}
        }

        private void sub_Click(object sender, EventArgs e)
        {
            sum_Click(sender, e);
        }

        private void mul_Click(object sender, EventArgs e)
        {
            sum_Click(sender, e);
        }

        private void div_Click(object sender, EventArgs e)
        {
            sum_Click(sender, e);
        }
    }
}
