using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Schematic_Generator
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ModelSelectionToCopy;
        string newLocation = "C:\\Users\\Public\\Schematics\\Schematics.txt";
        string folderLocation = "C:\\Users\\Public\\Schematics";



        private void HourMeter_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\HOUR METER ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("HOUR METER SELECTED");
        }
                      
        
        private void DigIn_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\DIGITAL INPUT.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("DIGITAL INPUTS SELECTED");

        }

        private void DigOut_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\CUSTOMER EVENTS.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("CUSTOMER EVENT OUTPUTS SELECTED");
        }

        private void IEEEOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\IEEE ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("IEEE SELECTED");
        }

        private void SizeOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\32,44,64-CHAMBERS.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("32, 44, 64 CUBIC FEET SELECTED");
        }

        private void RecircButton_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\RECIRC WATER ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("RECIRC WATER SELECTED");


        }

        private void DAPOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\DRY AIR PURGE ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("DRY AIR PURGE SELECTED");
        }

        private void MonitorOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\MONITOR PACKAGE ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("MONITOR INPUTS SELECTED");
        }

        private void RTDOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\MONITOR PACKAGE ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("RTD'S SELECTED");
        }

        private void AtomizerOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\ATOMIZER ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("ATOMIZER SELECTED");

        }

        private void HiLoButton_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\HIGH LOW LIMIT ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("HI-LO LIMIT SELECTED");
        }

        private void LN2Option_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\LN2 ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("LN2 SELECTED");
        }

        private void ChartOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\CHART RECORDER ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("CHART RECORDER SELECTED");
        }

        private void FrozenCoilOption_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\FROZEN COIL ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("FROZEN COIL SELECTED");
        }

        private void VoltageSelection1_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\200V-ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("200VAC SELECTED");
        }

        private void VoltageSelection2_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\208V-ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("208VAC SELECTED");
        }

        private void VoltageSelection3_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\220V-ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("220VAC SELECTED");
        }

        private void VoltageSelection4_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\230V-ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("230VAC SELECTED");
        }

        private void PhaseButton1_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\50HZ-ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("50Hz SELECTED");
        }

        private void PhaseButton2_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\60HZ-ON.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("60Hz SELECTED");
        }

        private void DisconnectOption1_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\3 PHASE POWER DISCONNECT.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("3PH DISCONNECT SELECTED");
        }

        private void DisconnectOption2_Click_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\1 PHASE POWER DISCONNECT.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("1PH DISCONNECT SELECTED");
        }

        private void GenerateScript_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\GENERATE SCHEMATIC.txt";
            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }
            File.AppendAllText(newLocation, text);
            MessageBox.Show("SCHEMATIC SCRIPT GENERATED!!!");
        }

       // private void button1_Click(object sender, EventArgs e)
        //{
          //  File.WriteAllText(newLocation, String.Empty);
           // MessageBox.Show("SCHEMATIC SCRIPT CLEARED!!!");
        //}

        private void ClearScript_Click(object sender, EventArgs e)
        {
            File.WriteAllText(newLocation, String.Empty);
            MessageBox.Show("SCHEMATIC SCRIPT CLEARED!!!");
        }



        private void singlePhaseOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (singlePhaseOptions.SelectedIndex == 1)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\1-1PH-ZP-8_16_32-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 2)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\2-1PH-ZP-44_64-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 3)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\3-1PH-ZPH-8_16_32-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 4)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\4-1PH-ZPH-44_64-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 5)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\5-1PH-ZP-8_16_32-2-SCT_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 6)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\6-1PH-ZPH-8_16_32-2-SCT_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 7)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\7-1PH-ZP-8-1-1-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 8)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\8-1PH-ZPH-8-1-1-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }

            else if (singlePhaseOptions.SelectedIndex == 9)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\9-1PH-ZP-8_16_32-2-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (singlePhaseOptions.SelectedIndex == 10)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\10-1PH-ZPH-8_16_32-2-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else
            {
                singlePhaseOptions.SelectedIndex = 0;
            }

            }

        private void threePhaseOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (threePhaseOptions.SelectedIndex == 1)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\1-3PH-ZP-8_16_32-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 2)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\2-3PH-ZP-44_64-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 3)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\3-3PH-ZPH-8_16_32-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 4)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\4-3PH-ZPH-44_64-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 5)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\5-3PH-ZP-8_16_32-2-SCT_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 6)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\6-3PH-ZPH-8_16_32-2-SCT_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 7)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\7-3PH-ZP-8-1-1-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 8)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\8-3PH-ZPH-8-1-1-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }

            else if (threePhaseOptions.SelectedIndex == 9)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\9-3PH-ZP-8_16_32-2-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else if (threePhaseOptions.SelectedIndex == 10)
            {
                ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\3 PHASE CHAMBERS\\10-3PH-ZPH-8_16_32-2-2-H_AC.txt";
                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }
                File.AppendAllText(newLocation, text);
            }
            else
            {
                threePhaseOptions.SelectedIndex = 0;
            }
        }

       
    }



}
 
