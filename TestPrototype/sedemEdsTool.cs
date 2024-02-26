using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPrototype
{
    public partial class sedemEdsTool : Form
    {
        public bool StandardSeDeM;

        public sedemEdsTool(bool startupConfig)
        {
            InitializeComponent();
            StandardSeDeM = startupConfig;


        }



       
        //To Do: Sort out TAB index order
        //To Do: Add k value as a paramter, k value being a ratio between bulk density and true density. From K Value, the void fraction can also be calculated


        string sampleID;
        double bulkDensity;
        double radiusBulkDensity;
        double tappedDensity;
        double radiusTappedDensity;
        double trueDensity;
        double radiusTrueDensity;
        double constantOfProprtionality;
        double radiusConstantOfProportionality;
        double interParticlePorosity;
        double radiusInterParticlePorosity;
        double carrIndex;
        double radiusCarrIndex;
        double hausnerRatio;
        double radiusHausnerRatio;
        double cohesionIndex;
        double radiusCohesionIndex;
        double height;
        double meanRadius;
        double angleOfRepose;
        double radiusAngleOfRepose;
        double flowability;
        double radiusFlowability;
        double lossOnDrying;
        double radiusLossOnDrying;
        double hygroscopicity;
        double radiusHygroscopicity;
        double particlesLessThnFifty;
        double radiusParticlesLessThnFifty;
        double homogeneityIndex;
        double radiusHomogeneityIndex;


        public DataTable parameters = new DataTable();

        

        // To do: Add checkboxes for each parameter and make the messagebox conditions for invalid imputs dependent on whether these values will be used.
        //Calculates hausnerRatio, carrIndex and interparticleporosity after having checked that the values entered can be parsed to double values. Other values that can be entered are also
        //parsed in order to use them in further calculations. Radius values are also calculated from the parameter values and a radar chart is drawn with these values
        private void btnCalculateParameters_Click(object sender, EventArgs e)
        {
            sampleID = textBoxSampleID.Text;

            if (checkBoxBulkDensity.Checked == true)
            {

                textBoxBulkDensity.Enabled = true;
                bool testBulkDensity = double.TryParse(textBoxBulkDensity.Text, out bulkDensity);
                if (testBulkDensity == false)

                {
                    MessageBox.Show("Bulk Density value invalid");
                    return;
                }
                bulkDensity = Convert.ToDouble(textBoxBulkDensity.Text);
                if (bulkDensity <= 0)
                {
                    MessageBox.Show("Bulk Density value can't be zero or less than zero");
                    return;
                }
            }

            if (checkBoxTappedDensity.Checked == true)
            {
                textBoxTappedDensity.Enabled = true;
                bool testTappedDensity = double.TryParse(textBoxTappedDensity.Text, out tappedDensity);
                if (testTappedDensity == false)
                {
                    MessageBox.Show("Tapped Density value invalid");
                    return;
                }
                tappedDensity = Convert.ToDouble(textBoxTappedDensity.Text);
                if (tappedDensity <= 0)
                {
                    MessageBox.Show("Tapped Density can't be zero or less than zero");
                    return;
                }
            }

            if (checkBoxTrueDensity.Checked == true)
            {
                textBoxTrueDensity.Enabled = true;
                bool testTrueDensity = double.TryParse(textBoxTrueDensity.Text, out trueDensity);
                if (testTrueDensity == false)
                {
                    MessageBox.Show("True Density value invalid");
                }
                if (trueDensity <= 0)
                {
                    MessageBox.Show("True Density can't be zero or less than zero");
                    return;
                }
            }

            if (checkBoxCohesionIndex.Checked == true)
            {
                textBoxCohesionIndex.Enabled = true;
                bool testCohesionIndex = double.TryParse(textBoxCohesionIndex.Text, out cohesionIndex);
                if (testCohesionIndex == false || cohesionIndex <= 0)
                {
                    MessageBox.Show("Cohesion Index value invalid");
                    return;
                }
                cohesionIndex = Convert.ToDouble(textBoxCohesionIndex.Text);
            }
            if (checkBoxAngleOfRepose.Checked == true)
            {
                textBoxAngleOfRepose.Enabled = true;
                bool testAngleOfRepose = double.TryParse(textBoxAngleOfRepose.Text, out angleOfRepose);
                if (testAngleOfRepose == false)
                {
                    MessageBox.Show("Angle of Repose value invalid");
                    return;
                }
                if (checkBoxCalcAngleOfRepose.Checked == false && angleOfRepose <= 0)
                {
                    MessageBox.Show("Angle of Repose can't be zero or less than zero");
                }
            }
            if (checkBoxFlowability.Checked == true)
            {
                textBoxFlowability.Enabled = true;
                bool testFlowability = double.TryParse(textBoxFlowability.Text, out flowability);
                if (testFlowability == false || flowability <= 0)
                {
                    MessageBox.Show("Flowability value invalid");
                    return;
                }
                flowability = Convert.ToDouble(textBoxFlowability.Text);
            }
            if (checkBoxLossOnDrying.Checked == true)
            {
                textBoxLossOnDrying.Enabled = true;
                bool testLossOnDrying = double.TryParse(textBoxLossOnDrying.Text, out lossOnDrying);
                if (testLossOnDrying == false || lossOnDrying <= 0)
                {
                    MessageBox.Show("Loss on Drying value invalid");
                    return;
                }
                lossOnDrying = Convert.ToDouble(textBoxLossOnDrying.Text);
            }
            if (checkBoxHygroscopicity.Checked == true)
            {
                textBoxHygroscopicity.Enabled = true;
                bool testHygroscopicity = double.TryParse(textBoxHygroscopicity.Text, out hygroscopicity);
                if (testHygroscopicity == false || hygroscopicity <= 0)
                {
                    MessageBox.Show("Hygroscopicity value invalid");
                    return;
                }
                hygroscopicity = Convert.ToDouble(textBoxHygroscopicity.Text);
            }
            if (checkBoxParticleSizeLessThan50.Checked == true)
            {
                textBoxParticlesLessThnFifty.Enabled = true;
                bool testParticlesLessThnFifty = double.TryParse(textBoxParticlesLessThnFifty.Text, out particlesLessThnFifty);
                if (testParticlesLessThnFifty == false || particlesLessThnFifty <= 0)
                {
                    MessageBox.Show("Particles < 50 micron value invalid");
                    return;
                }
                particlesLessThnFifty = Convert.ToDouble(textBoxParticlesLessThnFifty.Text);
            }
            if (checkBoxHomogeneityIndex.Checked == true)
            {
                textBoxHomogeneityIndex.Enabled = true;
                bool testHomogeneityIndex = double.TryParse(textBoxHomogeneityIndex.Text, out homogeneityIndex);
                if (testHomogeneityIndex == false || homogeneityIndex <= 0)
                {
                    MessageBox.Show("Homogeniety Index value invalid");
                    return;
                }
                homogeneityIndex = Convert.ToDouble(textBoxHomogeneityIndex.Text);
            }

           
           

            if (checkBoxCalcAngleOfRepose.Checked == true)
            {
                textBoxAngleOfRepose.Enabled = false;
                bool testHeight = double.TryParse(textBoxHeight.Text, out height);
                if (testHeight == false || height < 0)
                {
                    MessageBox.Show("Height value invalid");
                    return;
                }

                bool testMeanRadius = double.TryParse(textBoxMeanRadius.Text, out meanRadius);
                if (testMeanRadius == false || meanRadius < 0)
                {
                    MessageBox.Show("Mean Radius value invalid");
                    return;
                }
                height = Convert.ToDouble(textBoxHeight.Text);
                meanRadius = Convert.ToDouble(textBoxMeanRadius.Text);
                if (height == 0 || meanRadius == 0)
                {
                    MessageBox.Show("Height or Mean Radius value can't be  zero");
                    return;
                }
                else angleOfRepose = Math.Atan2(height, meanRadius) * (180 / Math.PI);
                     textBoxAngleOfRepose.Text = angleOfRepose.ToString();


            }
            else if (checkBoxCalcAngleOfRepose.Checked == false)
            {
                angleOfRepose = Convert.ToDouble(textBoxAngleOfRepose.Text);
                textBoxHeight.Enabled = false;
                textBoxMeanRadius.Enabled = false;
            }
                
                 

            hausnerRatio = tappedDensity / bulkDensity;
            textBoxHausnerRatio.Text = hausnerRatio.ToString();
            interParticlePorosity = (tappedDensity - bulkDensity) / (tappedDensity * bulkDensity);
            textBoxInterParticlePorosity.Text = interParticlePorosity.ToString();
            carrIndex = ((tappedDensity - bulkDensity) / tappedDensity) * 100;
            textBoxCarrIndex.Text = carrIndex.ToString();

            radiusBulkDensity = bulkDensity * 10;
            if (radiusBulkDensity > 10)
            {
                radiusBulkDensity = 10;
            }

            radiusTappedDensity = tappedDensity * 10;

            if (radiusTappedDensity > 10)
            {
                radiusTappedDensity = 10;
            }

            radiusInterParticlePorosity = (interParticlePorosity * 10) / 1.2;

            if (radiusInterParticlePorosity > 10)
            {
                radiusInterParticlePorosity = 10;
            }

            radiusHausnerRatio = (30 - (hausnerRatio * 10)) / 2;

            if (radiusHausnerRatio > 10)
            {
                radiusHausnerRatio = 10;
            }

            radiusCarrIndex = carrIndex / 5;

            if (radiusCarrIndex > 10)
            {
                radiusCarrIndex = 10;
            }

            radiusCohesionIndex = cohesionIndex / 20;

            if (radiusCohesionIndex > 10)
            {
                radiusCohesionIndex = 10;
            }

            radiusAngleOfRepose = 10 - (angleOfRepose / 5);

            if (radiusAngleOfRepose > 10)
            {
                radiusAngleOfRepose = 10;
            }

            radiusFlowability = 10 - (flowability / 2);

            if (radiusFlowability > 10)
            {
                radiusFlowability = 10;
            }

            radiusLossOnDrying = 10 - lossOnDrying;

            if (radiusLossOnDrying > 10)
            {
                radiusLossOnDrying = 10;
            }

            radiusHygroscopicity = 10 - (hygroscopicity / 2);

            if (radiusHygroscopicity > 10)
            {
                radiusHygroscopicity = 10;
            }

            radiusParticlesLessThnFifty = 10 - (particlesLessThnFifty / 5);

            if (radiusParticlesLessThnFifty > 10)
            {
                radiusParticlesLessThnFifty = 10;
            }

            radiusHomogeneityIndex = homogeneityIndex * 500;

            if (radiusHomogeneityIndex > 10)
            {
                radiusHomogeneityIndex = 10;
            }

            radiusTrueDensity = trueDensity * 10;
            if (radiusTrueDensity > 10)
            {
                radiusTrueDensity = 10;
            }

            parameters.Rows.Add(sampleID, bulkDensity, radiusBulkDensity, tappedDensity, radiusTappedDensity, trueDensity, radiusTrueDensity, interParticlePorosity, radiusInterParticlePorosity, hausnerRatio, radiusHausnerRatio,
                carrIndex, radiusCarrIndex, cohesionIndex, radiusCohesionIndex, angleOfRepose, radiusAngleOfRepose, flowability, radiusFlowability,
                lossOnDrying, radiusLossOnDrying, hygroscopicity, radiusHygroscopicity, particlesLessThnFifty, radiusParticlesLessThnFifty,
                homogeneityIndex, radiusHomogeneityIndex);

            /* Change all chart series entries for parameters to "if" statements that will only used parameters those of which boxes are checked - see line 297 for ref 
               Remember to keep any parameter you add and its corresponding label in the same order */

            chart1.Titles["Title1"].Text = sampleID;
            chart1.Series["Formula"].Points.Clear();
            int i = 0;
            if (checkBoxBulkDensity.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusBulkDensity);
                i++;
            }
            if (checkBoxTappedDensity.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusTappedDensity);
                i++;
            }
            if (checkBoxTrueDensity.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusTrueDensity);
                i++;
            }
            if (checkBoxInterParticlePorosity.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusInterParticlePorosity);
                i++;
            }
            if (checkBoxCarrIndex.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusCarrIndex);
                i++;
            }
            if (checkBoxCohesionIndex.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusCohesionIndex);
                i++;
            }
            if (checkBoxHausnerRatio.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusHausnerRatio);
                i++;
            }
            if (checkBoxAngleOfRepose.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusAngleOfRepose);
                i++;
            }
            if (checkBoxFlowability.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusFlowability);
                i++;
            }
            if (checkBoxLossOnDrying.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusLossOnDrying);
                i++;
            }
            if (checkBoxHygroscopicity.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusHygroscopicity);
                i++;
            }
            if (checkBoxParticleSizeLessThan50.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusParticlesLessThnFifty);
                i++;
            }
            if (checkBoxHomogeneityIndex.Checked == true)
            {
                chart1.Series["Formula"].Points.AddXY(i, radiusHomogeneityIndex);
            }
            

            int j = 0;
            if (checkBoxBulkDensity.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "Da";
                j++;
            }
            if (checkBoxTappedDensity.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "Dc";
                j++;
            }
            if (checkBoxTrueDensity.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "Dt";
                j++;
            }
            if (checkBoxInterParticlePorosity.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "Ie";
                j++;
            }
            if (checkBoxCarrIndex.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "IC";
                j++;
            }
            if (checkBoxCohesionIndex.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "Icd";
                j++;
            }
            if (checkBoxHausnerRatio.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "IH";
                j++;
            }
            if (checkBoxAngleOfRepose.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "α";
                j++;
            }
            if (checkBoxFlowability.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "Flow";
                j++;
            }
            if (checkBoxLossOnDrying.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "%HR";
                j++;
            }
            if (checkBoxHygroscopicity.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "%H";
                j++;
            }
            if (checkBoxParticleSizeLessThan50.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "%Pf";
                j++;
            }
            if (checkBoxHomogeneityIndex.Checked == true)
            {
                chart1.Series["Formula"].Points[j].AxisLabel = "IΘ";
                j++;
            }
           


        }

        private void BulkAndTappedDensity_Load(object sender, EventArgs e)
        {


            parameters.Columns.Add("Sample ID");
            parameters.Columns.Add("Bulk Density");
            parameters.Columns.Add("Bulk Density Radius Value");
            parameters.Columns.Add("Tapped Density");
            parameters.Columns.Add("Tapped Density Radius Value");
            parameters.Columns.Add("True Density");
            parameters.Columns.Add("True Density Radius Value");
            parameters.Columns.Add("Inter-particle Porosity");
            parameters.Columns.Add("Inter-particle Porosity Radius Value");
            parameters.Columns.Add("Hausner Ratio");
            parameters.Columns.Add("Hausner Ratio Radius Value");
            parameters.Columns.Add("Carr Index");
            parameters.Columns.Add("Carr Index Radius Value");
            parameters.Columns.Add("Cohesion Index");
            parameters.Columns.Add("Cohesion Index Radius Value");
            parameters.Columns.Add("Angle of Repose");
            parameters.Columns.Add("Angle of Repose Radius value");
            parameters.Columns.Add("Flowability");
            parameters.Columns.Add("Flowability Radius Value");
            parameters.Columns.Add("Loss on Drying");
            parameters.Columns.Add("Loss on Drying Radius Value");
            parameters.Columns.Add("Hygroscopicity");
            parameters.Columns.Add("Hygroscopicity Radius Value");
            parameters.Columns.Add("Particles < 50 micron");
            parameters.Columns.Add("Particles< 50 micron Radius Value");
            parameters.Columns.Add("Homogeneity Index");
            parameters.Columns.Add("Homogeneity Index Radius Value");
            dataGridView1.DataSource = parameters;


        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            if (parameters == null || parameters.Rows.Count == 0)
            {
                MessageBox.Show("No Data to Save");
                return;
            }
            System.Windows.Forms.SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "CSV File|*.csv";
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                csvUtilities.ToCSV(parameters, filename);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (parameters.Rows.Count == 0)
            {
                return;
            }

            int cellNumber = dataGridView1.SelectedCells[0].RowIndex;
            parameters.Rows.RemoveAt(cellNumber);
        }



        private void buttonSaveChart_Click(object sender, EventArgs e)
        {

            using (Bitmap im = new Bitmap(chart1.Width, chart1.Height))
            {
                chart1.DrawToBitmap(im, new Rectangle(0, 0, chart1.Width, chart1.Height));
                using (Graphics gr = Graphics.FromImage(im))
                {
                    gr.DrawString("Test",
                        new Font(FontFamily.GenericSerif, 10, FontStyle.Bold),
                        new SolidBrush(Color.Red), new PointF(10, 10));
                }
                System.Windows.Forms.SaveFileDialog saveFileDialog1;
                saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
                saveFileDialog1.Filter = "png File|*.png";
                saveFileDialog1.DefaultExt = "*.png";
                saveFileDialog1.InitialDirectory = "C:\\";
                DialogResult dr = saveFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    im.Save(filename);
                }
               
            }
            
        }

        private void labelMeanRadius_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxCalcAngleOfRepose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalcAngleOfRepose.Checked == true)
            {
                textBoxHeight.Enabled = true;
                textBoxMeanRadius.Enabled = true;
                textBoxAngleOfRepose.Enabled = false;
                angleOfRepose = Math.Atan2(height, meanRadius) * (180/Math.PI);
                textBoxAngleOfRepose.Text = angleOfRepose.ToString();



            }
            else if (checkBoxCalcAngleOfRepose.Checked == false)
            {
                textBoxAngleOfRepose.Enabled = true;
                textBoxHeight.Text = "";
                textBoxMeanRadius.Text = "";
                textBoxHeight.Enabled = false;
                textBoxMeanRadius.Enabled = false;
            }
        }

        private void buttonNewEntry_Click(object sender, EventArgs e)
        {
            textBoxBulkDensity.Text = "";
            textBoxTappedDensity.Text = "";
            textBoxInterParticlePorosity.Text = "";
            textBoxCarrIndex.Text = "";
            textBoxHausnerRatio.Text = "";
            textBoxCohesionIndex.Text = "";
            textBoxAngleOfRepose.Text = "";
            textBoxFlowability.Text = "";
            textBoxLossOnDrying.Text = "";
            textBoxHygroscopicity.Text = "";
            textBoxParticlesLessThnFifty.Text = "";
            textBoxHomogeneityIndex.Text = "";
            textBoxHeight.Text = "";
            textBoxMeanRadius.Text = "";
            textBoxSampleID.Text = "";
        }

        private void checkBoxParticleSizeLessThan50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxParticleSizeLessThan50.Checked == false)
            {
                textBoxParticlesLessThnFifty.Enabled = false;
            }
            else
            {
                textBoxParticlesLessThnFifty.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxBulkDensity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBulkDensity.Checked == false)
            {
                textBoxBulkDensity.Enabled = false;
            }
            else if (checkBoxBulkDensity.Checked == true)
            {
                textBoxBulkDensity.Enabled = true;
            }
        }

        private void checkBoxTappedDensity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTappedDensity.Checked == false)
            {
                textBoxTappedDensity.Enabled = false;
            }
            else if (checkBoxTappedDensity.Checked == true)
            {
                textBoxTappedDensity.Enabled = true;
            }
        }

        private void checkBoxInterParticlePorosity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterParticlePorosity.Checked == false)
            {
                textBoxInterParticlePorosity.Enabled = false;
            }
            else if (checkBoxInterParticlePorosity.Checked == true)
            {
                textBoxInterParticlePorosity.Enabled = true;
               
            }
        }

        private void checkBoxHausnerRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHausnerRatio.Checked == false)
            {
                textBoxHausnerRatio.Enabled = false;
            }
            else if (checkBoxHausnerRatio.Checked == true)
            {
                textBoxHausnerRatio.Enabled = true;
                
            }
        }

        private void checkBoxCarrIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCarrIndex.Checked == false)
            {
                textBoxCarrIndex.Enabled = false;
            }
            else if (checkBoxCarrIndex.Checked == true)
            {
                textBoxCarrIndex.Enabled = true;

            }
        }

        private void checkBoxAngleOfRepose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAngleOfRepose.Checked == false)
            {
                textBoxAngleOfRepose.Enabled = false;
                checkBoxCalcAngleOfRepose.Enabled = false;
                textBoxHeight.Enabled = false;
                textBoxMeanRadius.Enabled = false;
            }
            else if (checkBoxAngleOfRepose.Checked == true)
            {
                textBoxAngleOfRepose.Enabled = true;
                checkBoxCalcAngleOfRepose.Enabled = true;
            }
        }

        private void checkBoxFlowability_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFlowability.Checked == false)
            {
                textBoxFlowability.Enabled = false;
            }
            else if (checkBoxFlowability.Checked == true)
            {
                textBoxFlowability.Enabled = true;
            }
        }

        private void checkBoxCohesionIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCohesionIndex.Checked == false)
            {
                textBoxCohesionIndex.Enabled = false;
            }
            else if (checkBoxCohesionIndex.Checked == true)
            {
                textBoxCohesionIndex.Enabled = true;
            }
        }

        private void checkBoxHygroscopicity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHygroscopicity.Checked == false)
            {
                textBoxHygroscopicity.Enabled = false;
            }
            else if (checkBoxHygroscopicity.Checked == true)
            {
                textBoxHygroscopicity.Enabled = true;
            }
        }

        private void checkBoxLossOnDrying_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLossOnDrying.Checked == false)
            {
                textBoxLossOnDrying.Enabled = false;
            }
            else if (checkBoxLossOnDrying.Checked == true)
            {
                textBoxLossOnDrying.Enabled = true;
            }
        }

        private void checkBoxHomogeneityIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHomogeneityIndex.Checked == false)
            {
                textBoxHomogeneityIndex.Enabled = false;
            }
            else if (checkBoxHomogeneityIndex.Checked == true)
            {
                textBoxHomogeneityIndex.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTappedDensity_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxTrueDensity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrueDensity.Checked)
            {
                textBoxTrueDensity.Enabled = true;
            }
        }
    }
}