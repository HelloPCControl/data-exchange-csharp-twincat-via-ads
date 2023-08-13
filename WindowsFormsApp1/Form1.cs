using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TcAdsClient adsClient = new TcAdsClient();

        public Form1()
        {
            InitializeComponent();
            adsClient.Connect(AmsNetId.Local, 851);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            // read integer variable
            Int16 intValueToRead = (Int16)adsClient.ReadSymbol("MAIN.intVar", typeof(Int16), false);
            textBoxIntVar.Text = intValueToRead.ToString();

            // read array variable
            int arrayHandle = adsClient.CreateVariableHandle("MAIN.arrVar");
            try
            {
                float[] arrayValueToRead = (float[])adsClient.ReadAny(arrayHandle, typeof(float[]), new int[] { 2 });
                textBoxArrayVar.Text = String.Join(",", arrayValueToRead);
            }
            finally
            {
                adsClient.DeleteVariableHandle(arrayHandle);
            }

            // read string variable
            int stringHandle = adsClient.CreateVariableHandle("MAIN.strVar");
            try
            {
                string str = adsClient.ReadAnyString(stringHandle, 80, Encoding.Default);
                textBoxStrVar.Text = str;
            }
            finally
            {
                adsClient.DeleteVariableHandle(stringHandle);
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            // write integer variable
            Int16 intValueToWrite = Int16.Parse(textBoxIntVar.Text);
            adsClient.WriteSymbol("MAIN.intVar", intValueToWrite, false);

            // write array variable
            int arrayHandle = adsClient.CreateVariableHandle("MAIN.arrVar");
            try
            {
                float[] arrayValueToWrite = textBoxArrayVar.Text.Split(',').Select(float.Parse).ToArray();
                adsClient.WriteAny(arrayHandle, arrayValueToWrite);
            }
            finally
            {
                adsClient.DeleteVariableHandle(arrayHandle);
            }

            // write string variable
            int stringHandle = adsClient.CreateVariableHandle("MAIN.strVar");
            try
            {
                adsClient.WriteAnyString(stringHandle, textBoxStrVar.Text, 80, Encoding.Default);
            }
            finally
            {
                adsClient.DeleteVariableHandle(stringHandle);
            }
        }
    }
}
