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

        private void HourMeter_Click(object sender, EventArgs e)
        {

            string fileToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\ADDITONAL OPTIONS ON\\4 HOUR METER ON.txt";
            string newLocation = "C:\\Users\\Public\\Schematics\\Schematics.txt";
            string folderLocation = "C:\\Users\\Public\\Schematics";

            string text;
            using (var streamReader = new StreamReader(fileToCopy))
            {
                text = streamReader.ReadToEnd();
            }

                File.AppendAllText(newLocation, text);
        }

        private void singlePhaseOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (singlePhaseOptions.SelectedIndex == 0)
            {
                string ModelSelectionToCopy = "C:\\Users\\Public\\Schematics\\GENERATOR DOCUMENTS\\FINAL LAYERS (AND FOR GUI)\\1 PHASE CHAMBERS\\1-1PH-ZP-8_16_32-2-H_AC.txt";
                string newLocation = "C:\\Users\\Public\\Schematics\\Schematics.txt";
                string folderLocation = "C:\\Users\\Public\\Schematics";

                string text;
                using (var streamReader = new StreamReader(ModelSelectionToCopy))
                {
                    text = streamReader.ReadToEnd();
                }

                File.AppendAllText(newLocation, text);
            }
        }
    }



   }
 
