using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Runtime.InteropServices;
using System.Threading;
//using System.Diagnostics;

namespace free_minecraft__no_punjabi__pls_cry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        string current = Directory.GetCurrentDirectory();
        private void Form1_Load(object sender, EventArgs e)
        {
            

            try
            {
                Process.Start(current + "\\MC-ON.reg");
               
            }
            catch (Exception c)
            {
                MessageBox.Show("You dont have MC-ON.reg in the correct place", "Error");
            }
            try
            {
                Process.Start(current + "\\on.bat");

            }
            catch (Exception d)
            {
                MessageBox.Show("You dont have on.bat in the correct place", "Error");
            }
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(current + "\\MC-OFF.reg");
                Thread.Sleep(4000);
                try
                {
                    Process.Start(current + "\\off.bat");
                }
                catch (Exception f)
                {
                    MessageBox.Show("You dont have off.bat in the correct place", "Error");
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("You dont have MC-OFF.reg in the correct place", "Error");
            }
            
            
            //Process.Start(current + "\\MC-OFF.reg");
            System.Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("minecraft://");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/tsGY9heFpu");
        }
    }
}
