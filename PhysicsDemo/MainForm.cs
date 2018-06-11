using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PhysicsDemo
{
    public partial class MainForm : Form
    {
        MoleculeVelocity moleculeVelocity = new MoleculeVelocity();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Version_L.Text = Application.ProductVersion;
            chart1.Legends.Clear();
        }

        private void Temprature_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Temprature_TB.Text.Contains("."))
                {
                    Temprature_TB.Text = Temprature_TB.Text.Replace(".", ",");
                }

                if (Temprature_TB.Text!=String.Empty)
                {
                    moleculeVelocity.Temprature = Convert.ToDouble(Temprature_TB.Text);                   
                }
                
                if(Temprature_TB.Text!=String.Empty && MolarMass_TB.Text!=String.Empty)
                {
                    Velocity_TB.Text = moleculeVelocity.CalcAverageVelocity().ToString("F3");
                }
                else
                {
                    Velocity_TB.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MolarMass_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MolarMass_TB.Text.Contains("."))
                {
                    MolarMass_TB.Text = MolarMass_TB.Text.Replace(".", ",");
                }

                if (MolarMass_TB.Text!=String.Empty)
                {
                    moleculeVelocity.MolarMass = Convert.ToDouble(MolarMass_TB.Text);                 
                }
                
                if (Temprature_TB.Text != String.Empty && MolarMass_TB.Text != String.Empty)
                {
                    Velocity_TB.Text = moleculeVelocity.CalcAverageVelocity().ToString("F3");            
                }
                else
                {
                    Velocity_TB.Text = String.Empty;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Velocity_TB_TextChanged(object sender, EventArgs e)
        {
            if(Temprature_TB.Text!=String.Empty && MolarMass_TB.Text!=String.Empty && Velocity_TB.Text!=String.Empty)
            {              
                
            }
        }

        private void Draw_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MolarMass_Graph_TB.Text != String.Empty)
                {
                    if (MolarMass_Graph_TB.Text.Contains("."))
                    {
                        MolarMass_Graph_TB.Text = MolarMass_Graph_TB.Text.Replace(".", ",");
                    }
                    

                    Int64 dT = Int64.Parse(Interval_NumUD.Value.ToString());
                    Int64 Start = Int64.Parse(Start_NumUD.Value.ToString());
                    Int64 End = Int64.Parse(End_NumUD.Value.ToString());                 
                    moleculeVelocity.MolarMass = Convert.ToDouble(MolarMass_Graph_TB.Text);

                    if(Start >= End)
                    {
                        MessageBox.Show("Диапозон начало и конец либо совпадает либо значений начало больше чем на конец");
                        return;
                    }

                    chart1.Series[0].Points.Clear();
                    chart1.ChartAreas[0].AxisX.Minimum = Start;
                    chart1.ChartAreas[0].AxisX.Maximum = End;
                    chart1.ChartAreas[0].AxisX.Interval = dT;
                    chart1.ChartAreas[0].AxisY.Minimum = moleculeVelocity.CalcAverageVelocity(Start, moleculeVelocity.MolarMass);
                    chart1.ChartAreas[0].AxisY.Maximum = moleculeVelocity.CalcAverageVelocity(End, moleculeVelocity.MolarMass);

                    for (Int64 T = Start; T <= End; T += dT)
                    {
                        chart1.Series[0].Points.AddXY(T, moleculeVelocity.CalcAverageVelocity(T, moleculeVelocity.MolarMass));
                    }
                }
                else
                {
                    MessageBox.Show("Введите правильные значения молярной массы в контексте графики");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
