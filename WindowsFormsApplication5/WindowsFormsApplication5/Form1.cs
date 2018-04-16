using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox2.Show();
            pictureBox1.Show();
            pictureBox3.Show();
            textBox2.Visible = false;
            buttonstop.Show();
            button1.Visible = false;
            

        }

        private void buttonstop_Click_1(object sender, EventArgs e)
        {
            buttonunpause.Enabled = true;
            buttonunpause.Show();
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            textBox2.Visible = false;
            buttonstop.Visible = false;
            
        }
      private void buttonunpause_Click(object sender, EventArgs e)
        {

            buttonunpause.Enabled = false;
            buttonunpause.Visible = false;
            button1.Enabled = true;
            pictureBox2.Show();
            pictureBox1.Show();
            pictureBox3.Show();
            textBox2.Visible = false;
            buttonstop.Show();
            
        }
       private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pictureBox2.Left = pictureBox2.Left + 5;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictureBox2.Left = pictureBox2.Left - 5;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox2.Top = pictureBox2.Top - 5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox2.Top = pictureBox2.Top + 5;
            }
            
        }


       
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                textBox2.Visible = true;
                timer1.Enabled = false;
                textBox2.Text = "YOU WON! Seconds until the automatical exit: ";
                textBox2.Enabled = true;
                buttonstop.Visible = false;
              
               
                    
               
            }
            
            
        }
        int i = 5;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i--;
            label1.Text = i.ToString() + "Seconds";
          
        }
      

      
        

       

        

       

        

       

        

        

        


      

        
        

     

       
    }
}