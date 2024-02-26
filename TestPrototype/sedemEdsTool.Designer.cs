
namespace TestPrototype
{
    partial class sedemEdsTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sedemEdsTool));
            this.textBoxBulkDensity = new System.Windows.Forms.TextBox();
            this.labelBulkDensity = new System.Windows.Forms.Label();
            this.labelTappedDensity = new System.Windows.Forms.Label();
            this.textBoxTappedDensity = new System.Windows.Forms.TextBox();
            this.btnCalculateParameters = new System.Windows.Forms.Button();
            this.LabelInterParticlePorosity = new System.Windows.Forms.Label();
            this.labelHausnerRatio = new System.Windows.Forms.Label();
            this.textBoxInterParticlePorosity = new System.Windows.Forms.TextBox();
            this.textBoxHausnerRatio = new System.Windows.Forms.TextBox();
            this.labelCarrIndex = new System.Windows.Forms.Label();
            this.textBoxCarrIndex = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveCSV = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxHygroscopicity = new System.Windows.Forms.TextBox();
            this.textBoxParticlesLessThnFifty = new System.Windows.Forms.TextBox();
            this.textBoxCohesionIndex = new System.Windows.Forms.TextBox();
            this.textBoxHomogeneityIndex = new System.Windows.Forms.TextBox();
            this.textBoxAngleOfRepose = new System.Windows.Forms.TextBox();
            this.textBoxFlowability = new System.Windows.Forms.TextBox();
            this.textBoxLossOnDrying = new System.Windows.Forms.TextBox();
            this.labelCohesionIndex = new System.Windows.Forms.Label();
            this.labelAngleOfRepose = new System.Windows.Forms.Label();
            this.labelParticlesLessThnFifty = new System.Windows.Forms.Label();
            this.labelHomogeneityIndex = new System.Windows.Forms.Label();
            this.labelHygroscopicity = new System.Windows.Forms.Label();
            this.labelFlowability = new System.Windows.Forms.Label();
            this.labelLOD = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSaveChart = new System.Windows.Forms.Button();
            this.textBoxMeanRadius = new System.Windows.Forms.TextBox();
            this.labelMeanRadius = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelAngleOfReposeCalc = new System.Windows.Forms.Label();
            this.labelDensities = new System.Windows.Forms.Label();
            this.labelDensityParameters = new System.Windows.Forms.Label();
            this.labelParticleSize = new System.Windows.Forms.Label();
            this.labelOtherParameters = new System.Windows.Forms.Label();
            this.checkBoxCalcAngleOfRepose = new System.Windows.Forms.CheckBox();
            this.buttonNewEntry = new System.Windows.Forms.Button();
            this.labelSampleID = new System.Windows.Forms.Label();
            this.textBoxSampleID = new System.Windows.Forms.TextBox();
            this.checkBoxParticleSizeLessThan50 = new System.Windows.Forms.CheckBox();
            this.checkBoxHomogeneityIndex = new System.Windows.Forms.CheckBox();
            this.checkBoxInterParticlePorosity = new System.Windows.Forms.CheckBox();
            this.checkBoxHausnerRatio = new System.Windows.Forms.CheckBox();
            this.checkBoxCarrIndex = new System.Windows.Forms.CheckBox();
            this.checkBoxBulkDensity = new System.Windows.Forms.CheckBox();
            this.checkBoxTappedDensity = new System.Windows.Forms.CheckBox();
            this.checkBoxAngleOfRepose = new System.Windows.Forms.CheckBox();
            this.checkBoxFlowability = new System.Windows.Forms.CheckBox();
            this.checkBoxCohesionIndex = new System.Windows.Forms.CheckBox();
            this.checkBoxHygroscopicity = new System.Windows.Forms.CheckBox();
            this.checkBoxLossOnDrying = new System.Windows.Forms.CheckBox();
            this.labelTrueDensity = new System.Windows.Forms.Label();
            this.textBoxTrueDensity = new System.Windows.Forms.TextBox();
            this.checkBoxTrueDensity = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBulkDensity
            // 
            this.textBoxBulkDensity.Location = new System.Drawing.Point(160, 45);
            this.textBoxBulkDensity.Name = "textBoxBulkDensity";
            this.textBoxBulkDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxBulkDensity.TabIndex = 0;
            // 
            // labelBulkDensity
            // 
            this.labelBulkDensity.AutoSize = true;
            this.labelBulkDensity.Location = new System.Drawing.Point(12, 48);
            this.labelBulkDensity.Name = "labelBulkDensity";
            this.labelBulkDensity.Size = new System.Drawing.Size(129, 13);
            this.labelBulkDensity.TabIndex = 1;
            this.labelBulkDensity.Text = "Da (Bulk Density in g/cc):";
            // 
            // labelTappedDensity
            // 
            this.labelTappedDensity.AutoSize = true;
            this.labelTappedDensity.Location = new System.Drawing.Point(12, 77);
            this.labelTappedDensity.Name = "labelTappedDensity";
            this.labelTappedDensity.Size = new System.Drawing.Size(145, 13);
            this.labelTappedDensity.TabIndex = 2;
            this.labelTappedDensity.Text = "Dc (Tapped Density in g/cc):";
            // 
            // textBoxTappedDensity
            // 
            this.textBoxTappedDensity.Location = new System.Drawing.Point(160, 74);
            this.textBoxTappedDensity.Name = "textBoxTappedDensity";
            this.textBoxTappedDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxTappedDensity.TabIndex = 1;
            this.textBoxTappedDensity.TextChanged += new System.EventHandler(this.textBoxTappedDensity_TextChanged);
            // 
            // btnCalculateParameters
            // 
            this.btnCalculateParameters.Location = new System.Drawing.Point(48, 593);
            this.btnCalculateParameters.Name = "btnCalculateParameters";
            this.btnCalculateParameters.Size = new System.Drawing.Size(176, 23);
            this.btnCalculateParameters.TabIndex = 9;
            this.btnCalculateParameters.Text = "Calculate Paramaters";
            this.btnCalculateParameters.UseVisualStyleBackColor = true;
            this.btnCalculateParameters.Click += new System.EventHandler(this.btnCalculateParameters_Click);
            // 
            // LabelInterParticlePorosity
            // 
            this.LabelInterParticlePorosity.AutoSize = true;
            this.LabelInterParticlePorosity.Location = new System.Drawing.Point(12, 182);
            this.LabelInterParticlePorosity.Name = "LabelInterParticlePorosity";
            this.LabelInterParticlePorosity.Size = new System.Drawing.Size(127, 13);
            this.LabelInterParticlePorosity.TabIndex = 5;
            this.LabelInterParticlePorosity.Text = "Ie (Inter-Particle Porosity):";
            // 
            // labelHausnerRatio
            // 
            this.labelHausnerRatio.AutoSize = true;
            this.labelHausnerRatio.Location = new System.Drawing.Point(12, 212);
            this.labelHausnerRatio.Name = "labelHausnerRatio";
            this.labelHausnerRatio.Size = new System.Drawing.Size(98, 13);
            this.labelHausnerRatio.TabIndex = 6;
            this.labelHausnerRatio.Text = "IH (Hausner Ratio):";
            // 
            // textBoxInterParticlePorosity
            // 
            this.textBoxInterParticlePorosity.Location = new System.Drawing.Point(160, 179);
            this.textBoxInterParticlePorosity.Name = "textBoxInterParticlePorosity";
            this.textBoxInterParticlePorosity.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterParticlePorosity.TabIndex = 7;
            // 
            // textBoxHausnerRatio
            // 
            this.textBoxHausnerRatio.Location = new System.Drawing.Point(160, 209);
            this.textBoxHausnerRatio.Name = "textBoxHausnerRatio";
            this.textBoxHausnerRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxHausnerRatio.TabIndex = 8;
            // 
            // labelCarrIndex
            // 
            this.labelCarrIndex.AutoSize = true;
            this.labelCarrIndex.Location = new System.Drawing.Point(12, 246);
            this.labelCarrIndex.Name = "labelCarrIndex";
            this.labelCarrIndex.Size = new System.Drawing.Size(77, 13);
            this.labelCarrIndex.TabIndex = 9;
            this.labelCarrIndex.Text = "IC (Carr Index):";
            // 
            // textBoxCarrIndex
            // 
            this.textBoxCarrIndex.Location = new System.Drawing.Point(160, 243);
            this.textBoxCarrIndex.Name = "textBoxCarrIndex";
            this.textBoxCarrIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarrIndex.TabIndex = 10;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(305, 134);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 243);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saveCSV
            // 
            this.saveCSV.Location = new System.Drawing.Point(504, 593);
            this.saveCSV.Name = "saveCSV";
            this.saveCSV.Size = new System.Drawing.Size(110, 23);
            this.saveCSV.TabIndex = 11;
            this.saveCSV.Text = "Export to CSV";
            this.saveCSV.UseVisualStyleBackColor = true;
            this.saveCSV.Click += new System.EventHandler(this.saveCSV_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(293, 593);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(137, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear Selected Row";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxHygroscopicity
            // 
            this.textBoxHygroscopicity.Location = new System.Drawing.Point(1204, 48);
            this.textBoxHygroscopicity.Name = "textBoxHygroscopicity";
            this.textBoxHygroscopicity.Size = new System.Drawing.Size(100, 20);
            this.textBoxHygroscopicity.TabIndex = 6;
            // 
            // textBoxParticlesLessThnFifty
            // 
            this.textBoxParticlesLessThnFifty.Location = new System.Drawing.Point(490, 179);
            this.textBoxParticlesLessThnFifty.Name = "textBoxParticlesLessThnFifty";
            this.textBoxParticlesLessThnFifty.Size = new System.Drawing.Size(100, 20);
            this.textBoxParticlesLessThnFifty.TabIndex = 7;
            // 
            // textBoxCohesionIndex
            // 
            this.textBoxCohesionIndex.Location = new System.Drawing.Point(938, 74);
            this.textBoxCohesionIndex.Name = "textBoxCohesionIndex";
            this.textBoxCohesionIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxCohesionIndex.TabIndex = 2;
            // 
            // textBoxHomogeneityIndex
            // 
            this.textBoxHomogeneityIndex.Location = new System.Drawing.Point(490, 209);
            this.textBoxHomogeneityIndex.Name = "textBoxHomogeneityIndex";
            this.textBoxHomogeneityIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxHomogeneityIndex.TabIndex = 8;
            // 
            // textBoxAngleOfRepose
            // 
            this.textBoxAngleOfRepose.Location = new System.Drawing.Point(685, 74);
            this.textBoxAngleOfRepose.Name = "textBoxAngleOfRepose";
            this.textBoxAngleOfRepose.Size = new System.Drawing.Size(69, 20);
            this.textBoxAngleOfRepose.TabIndex = 3;
            // 
            // textBoxFlowability
            // 
            this.textBoxFlowability.Location = new System.Drawing.Point(938, 48);
            this.textBoxFlowability.Name = "textBoxFlowability";
            this.textBoxFlowability.Size = new System.Drawing.Size(100, 20);
            this.textBoxFlowability.TabIndex = 4;
            // 
            // textBoxLossOnDrying
            // 
            this.textBoxLossOnDrying.Location = new System.Drawing.Point(1204, 73);
            this.textBoxLossOnDrying.Name = "textBoxLossOnDrying";
            this.textBoxLossOnDrying.Size = new System.Drawing.Size(100, 20);
            this.textBoxLossOnDrying.TabIndex = 5;
            // 
            // labelCohesionIndex
            // 
            this.labelCohesionIndex.AutoSize = true;
            this.labelCohesionIndex.Location = new System.Drawing.Point(803, 77);
            this.labelCohesionIndex.Name = "labelCohesionIndex";
            this.labelCohesionIndex.Size = new System.Drawing.Size(129, 13);
            this.labelCohesionIndex.TabIndex = 22;
            this.labelCohesionIndex.Text = "Icd (Cohesion Index in N):";
            // 
            // labelAngleOfRepose
            // 
            this.labelAngleOfRepose.AutoSize = true;
            this.labelAngleOfRepose.Location = new System.Drawing.Point(539, 77);
            this.labelAngleOfRepose.Name = "labelAngleOfRepose";
            this.labelAngleOfRepose.Size = new System.Drawing.Size(140, 13);
            this.labelAngleOfRepose.TabIndex = 23;
            this.labelAngleOfRepose.Text = "α (Angle of Repose in deg) :";
            // 
            // labelParticlesLessThnFifty
            // 
            this.labelParticlesLessThnFifty.AutoSize = true;
            this.labelParticlesLessThnFifty.Location = new System.Drawing.Point(343, 182);
            this.labelParticlesLessThnFifty.Name = "labelParticlesLessThnFifty";
            this.labelParticlesLessThnFifty.Size = new System.Drawing.Size(146, 13);
            this.labelParticlesLessThnFifty.TabIndex = 24;
            this.labelParticlesLessThnFifty.Text = "%Pf (% Particles < 50 micron):";
            // 
            // labelHomogeneityIndex
            // 
            this.labelHomogeneityIndex.AutoSize = true;
            this.labelHomogeneityIndex.Location = new System.Drawing.Point(364, 212);
            this.labelHomogeneityIndex.Name = "labelHomogeneityIndex";
            this.labelHomogeneityIndex.Size = new System.Drawing.Size(120, 13);
            this.labelHomogeneityIndex.TabIndex = 25;
            this.labelHomogeneityIndex.Text = "(IΘ) Homogeneity Index:";
            // 
            // labelHygroscopicity
            // 
            this.labelHygroscopicity.AutoSize = true;
            this.labelHygroscopicity.Location = new System.Drawing.Point(1083, 51);
            this.labelHygroscopicity.Name = "labelHygroscopicity";
            this.labelHygroscopicity.Size = new System.Drawing.Size(115, 13);
            this.labelHygroscopicity.TabIndex = 26;
            this.labelHygroscopicity.Text = "%H (% Hygroscopicity):";
            // 
            // labelFlowability
            // 
            this.labelFlowability.AutoSize = true;
            this.labelFlowability.Location = new System.Drawing.Point(814, 51);
            this.labelFlowability.Name = "labelFlowability";
            this.labelFlowability.Size = new System.Drawing.Size(118, 13);
            this.labelFlowability.TabIndex = 27;
            this.labelFlowability.Text = "Flowability (in seconds):";
            // 
            // labelLOD
            // 
            this.labelLOD.AutoSize = true;
            this.labelLOD.Location = new System.Drawing.Point(1074, 80);
            this.labelLOD.Name = "labelLOD";
            this.labelLOD.Size = new System.Drawing.Size(124, 13);
            this.labelLOD.TabIndex = 28;
            this.labelLOD.Text = "%HR (% Loss on Drying):";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(800, 183);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Name = "Formula";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 10;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(404, 381);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Sample1";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonSaveChart
            // 
            this.buttonSaveChart.Location = new System.Drawing.Point(1079, 593);
            this.buttonSaveChart.Name = "buttonSaveChart";
            this.buttonSaveChart.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveChart.TabIndex = 12;
            this.buttonSaveChart.Text = "Save Current Chart";
            this.buttonSaveChart.UseVisualStyleBackColor = true;
            this.buttonSaveChart.Click += new System.EventHandler(this.buttonSaveChart_Click);
            // 
            // textBoxMeanRadius
            // 
            this.textBoxMeanRadius.Enabled = false;
            this.textBoxMeanRadius.Location = new System.Drawing.Point(433, 74);
            this.textBoxMeanRadius.Name = "textBoxMeanRadius";
            this.textBoxMeanRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxMeanRadius.TabIndex = 30;
            // 
            // labelMeanRadius
            // 
            this.labelMeanRadius.AutoSize = true;
            this.labelMeanRadius.Location = new System.Drawing.Point(328, 80);
            this.labelMeanRadius.Name = "labelMeanRadius";
            this.labelMeanRadius.Size = new System.Drawing.Size(95, 13);
            this.labelMeanRadius.TabIndex = 31;
            this.labelMeanRadius.Text = "Mean Radius (mm)";
            this.labelMeanRadius.Click += new System.EventHandler(this.labelMeanRadius_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(361, 48);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(66, 13);
            this.labelHeight.TabIndex = 32;
            this.labelHeight.Text = "Height (mm):";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(433, 44);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 33;
            // 
            // labelAngleOfReposeCalc
            // 
            this.labelAngleOfReposeCalc.AutoSize = true;
            this.labelAngleOfReposeCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngleOfReposeCalc.Location = new System.Drawing.Point(381, 9);
            this.labelAngleOfReposeCalc.Name = "labelAngleOfReposeCalc";
            this.labelAngleOfReposeCalc.Size = new System.Drawing.Size(203, 20);
            this.labelAngleOfReposeCalc.TabIndex = 35;
            this.labelAngleOfReposeCalc.Text = "Angle of Repose Calculator";
            // 
            // labelDensities
            // 
            this.labelDensities.AutoSize = true;
            this.labelDensities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDensities.Location = new System.Drawing.Point(110, 9);
            this.labelDensities.Name = "labelDensities";
            this.labelDensities.Size = new System.Drawing.Size(75, 20);
            this.labelDensities.TabIndex = 36;
            this.labelDensities.Text = "Densities";
            // 
            // labelDensityParameters
            // 
            this.labelDensityParameters.AutoSize = true;
            this.labelDensityParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDensityParameters.Location = new System.Drawing.Point(76, 153);
            this.labelDensityParameters.Name = "labelDensityParameters";
            this.labelDensityParameters.Size = new System.Drawing.Size(148, 20);
            this.labelDensityParameters.TabIndex = 37;
            this.labelDensityParameters.Text = "Density Parameters";
            // 
            // labelParticleSize
            // 
            this.labelParticleSize.AutoSize = true;
            this.labelParticleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticleSize.Location = new System.Drawing.Point(429, 153);
            this.labelParticleSize.Name = "labelParticleSize";
            this.labelParticleSize.Size = new System.Drawing.Size(104, 20);
            this.labelParticleSize.TabIndex = 38;
            this.labelParticleSize.Text = "Particle Sizes";
            // 
            // labelOtherParameters
            // 
            this.labelOtherParameters.AutoSize = true;
            this.labelOtherParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherParameters.Location = new System.Drawing.Point(857, 9);
            this.labelOtherParameters.Name = "labelOtherParameters";
            this.labelOtherParameters.Size = new System.Drawing.Size(426, 20);
            this.labelOtherParameters.TabIndex = 39;
            this.labelOtherParameters.Text = "Flowability, Cohesion Index, Hygroscopicity,  Loss on Drying";
            // 
            // checkBoxCalcAngleOfRepose
            // 
            this.checkBoxCalcAngleOfRepose.AutoSize = true;
            this.checkBoxCalcAngleOfRepose.Location = new System.Drawing.Point(585, 45);
            this.checkBoxCalcAngleOfRepose.Name = "checkBoxCalcAngleOfRepose";
            this.checkBoxCalcAngleOfRepose.Size = new System.Drawing.Size(152, 17);
            this.checkBoxCalcAngleOfRepose.TabIndex = 40;
            this.checkBoxCalcAngleOfRepose.Text = "Calculate Angle of Repose";
            this.checkBoxCalcAngleOfRepose.UseVisualStyleBackColor = true;
            this.checkBoxCalcAngleOfRepose.CheckedChanged += new System.EventHandler(this.checkBoxCalcAngleOfRepose_CheckedChanged);
            // 
            // buttonNewEntry
            // 
            this.buttonNewEntry.Location = new System.Drawing.Point(110, 636);
            this.buttonNewEntry.Name = "buttonNewEntry";
            this.buttonNewEntry.Size = new System.Drawing.Size(176, 23);
            this.buttonNewEntry.TabIndex = 41;
            this.buttonNewEntry.Text = "New Entry";
            this.buttonNewEntry.UseVisualStyleBackColor = true;
            this.buttonNewEntry.Click += new System.EventHandler(this.buttonNewEntry_Click);
            // 
            // labelSampleID
            // 
            this.labelSampleID.AutoSize = true;
            this.labelSampleID.Location = new System.Drawing.Point(45, 679);
            this.labelSampleID.Name = "labelSampleID";
            this.labelSampleID.Size = new System.Drawing.Size(59, 13);
            this.labelSampleID.TabIndex = 42;
            this.labelSampleID.Text = "Sample ID:";
            // 
            // textBoxSampleID
            // 
            this.textBoxSampleID.Location = new System.Drawing.Point(110, 676);
            this.textBoxSampleID.Name = "textBoxSampleID";
            this.textBoxSampleID.Size = new System.Drawing.Size(181, 20);
            this.textBoxSampleID.TabIndex = 43;
            // 
            // checkBoxParticleSizeLessThan50
            // 
            this.checkBoxParticleSizeLessThan50.AutoSize = true;
            this.checkBoxParticleSizeLessThan50.Checked = true;
            this.checkBoxParticleSizeLessThan50.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxParticleSizeLessThan50.Location = new System.Drawing.Point(597, 182);
            this.checkBoxParticleSizeLessThan50.Name = "checkBoxParticleSizeLessThan50";
            this.checkBoxParticleSizeLessThan50.Size = new System.Drawing.Size(15, 14);
            this.checkBoxParticleSizeLessThan50.TabIndex = 44;
            this.checkBoxParticleSizeLessThan50.UseVisualStyleBackColor = true;
            this.checkBoxParticleSizeLessThan50.CheckedChanged += new System.EventHandler(this.checkBoxParticleSizeLessThan50_CheckedChanged);
            // 
            // checkBoxHomogeneityIndex
            // 
            this.checkBoxHomogeneityIndex.AutoSize = true;
            this.checkBoxHomogeneityIndex.Checked = true;
            this.checkBoxHomogeneityIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHomogeneityIndex.Location = new System.Drawing.Point(597, 212);
            this.checkBoxHomogeneityIndex.Name = "checkBoxHomogeneityIndex";
            this.checkBoxHomogeneityIndex.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHomogeneityIndex.TabIndex = 45;
            this.checkBoxHomogeneityIndex.UseVisualStyleBackColor = true;
            this.checkBoxHomogeneityIndex.CheckedChanged += new System.EventHandler(this.checkBoxHomogeneityIndex_CheckedChanged);
            // 
            // checkBoxInterParticlePorosity
            // 
            this.checkBoxInterParticlePorosity.AutoSize = true;
            this.checkBoxInterParticlePorosity.Checked = true;
            this.checkBoxInterParticlePorosity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInterParticlePorosity.Location = new System.Drawing.Point(266, 182);
            this.checkBoxInterParticlePorosity.Name = "checkBoxInterParticlePorosity";
            this.checkBoxInterParticlePorosity.Size = new System.Drawing.Size(15, 14);
            this.checkBoxInterParticlePorosity.TabIndex = 46;
            this.checkBoxInterParticlePorosity.UseVisualStyleBackColor = true;
            this.checkBoxInterParticlePorosity.CheckedChanged += new System.EventHandler(this.checkBoxInterParticlePorosity_CheckedChanged);
            // 
            // checkBoxHausnerRatio
            // 
            this.checkBoxHausnerRatio.AutoSize = true;
            this.checkBoxHausnerRatio.Checked = true;
            this.checkBoxHausnerRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHausnerRatio.Location = new System.Drawing.Point(266, 212);
            this.checkBoxHausnerRatio.Name = "checkBoxHausnerRatio";
            this.checkBoxHausnerRatio.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHausnerRatio.TabIndex = 47;
            this.checkBoxHausnerRatio.UseVisualStyleBackColor = true;
            this.checkBoxHausnerRatio.CheckedChanged += new System.EventHandler(this.checkBoxHausnerRatio_CheckedChanged);
            // 
            // checkBoxCarrIndex
            // 
            this.checkBoxCarrIndex.AutoSize = true;
            this.checkBoxCarrIndex.Checked = true;
            this.checkBoxCarrIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarrIndex.Location = new System.Drawing.Point(266, 246);
            this.checkBoxCarrIndex.Name = "checkBoxCarrIndex";
            this.checkBoxCarrIndex.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCarrIndex.TabIndex = 48;
            this.checkBoxCarrIndex.UseVisualStyleBackColor = true;
            this.checkBoxCarrIndex.CheckedChanged += new System.EventHandler(this.checkBoxCarrIndex_CheckedChanged);
            // 
            // checkBoxBulkDensity
            // 
            this.checkBoxBulkDensity.AutoSize = true;
            this.checkBoxBulkDensity.Checked = true;
            this.checkBoxBulkDensity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBulkDensity.Location = new System.Drawing.Point(266, 48);
            this.checkBoxBulkDensity.Name = "checkBoxBulkDensity";
            this.checkBoxBulkDensity.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBulkDensity.TabIndex = 49;
            this.checkBoxBulkDensity.UseVisualStyleBackColor = true;
            this.checkBoxBulkDensity.CheckedChanged += new System.EventHandler(this.checkBoxBulkDensity_CheckedChanged);
            // 
            // checkBoxTappedDensity
            // 
            this.checkBoxTappedDensity.AutoSize = true;
            this.checkBoxTappedDensity.Checked = true;
            this.checkBoxTappedDensity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTappedDensity.Location = new System.Drawing.Point(266, 77);
            this.checkBoxTappedDensity.Name = "checkBoxTappedDensity";
            this.checkBoxTappedDensity.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTappedDensity.TabIndex = 50;
            this.checkBoxTappedDensity.UseVisualStyleBackColor = true;
            this.checkBoxTappedDensity.CheckedChanged += new System.EventHandler(this.checkBoxTappedDensity_CheckedChanged);
            // 
            // checkBoxAngleOfRepose
            // 
            this.checkBoxAngleOfRepose.AutoSize = true;
            this.checkBoxAngleOfRepose.Checked = true;
            this.checkBoxAngleOfRepose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAngleOfRepose.Location = new System.Drawing.Point(761, 54);
            this.checkBoxAngleOfRepose.Name = "checkBoxAngleOfRepose";
            this.checkBoxAngleOfRepose.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAngleOfRepose.TabIndex = 51;
            this.checkBoxAngleOfRepose.UseVisualStyleBackColor = true;
            this.checkBoxAngleOfRepose.CheckedChanged += new System.EventHandler(this.checkBoxAngleOfRepose_CheckedChanged);
            // 
            // checkBoxFlowability
            // 
            this.checkBoxFlowability.AutoSize = true;
            this.checkBoxFlowability.Checked = true;
            this.checkBoxFlowability.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFlowability.Location = new System.Drawing.Point(1044, 51);
            this.checkBoxFlowability.Name = "checkBoxFlowability";
            this.checkBoxFlowability.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFlowability.TabIndex = 52;
            this.checkBoxFlowability.UseVisualStyleBackColor = true;
            this.checkBoxFlowability.CheckedChanged += new System.EventHandler(this.checkBoxFlowability_CheckedChanged);
            // 
            // checkBoxCohesionIndex
            // 
            this.checkBoxCohesionIndex.AutoSize = true;
            this.checkBoxCohesionIndex.Checked = true;
            this.checkBoxCohesionIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCohesionIndex.Location = new System.Drawing.Point(1044, 77);
            this.checkBoxCohesionIndex.Name = "checkBoxCohesionIndex";
            this.checkBoxCohesionIndex.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCohesionIndex.TabIndex = 53;
            this.checkBoxCohesionIndex.UseVisualStyleBackColor = true;
            this.checkBoxCohesionIndex.CheckedChanged += new System.EventHandler(this.checkBoxCohesionIndex_CheckedChanged);
            // 
            // checkBoxHygroscopicity
            // 
            this.checkBoxHygroscopicity.AutoSize = true;
            this.checkBoxHygroscopicity.Checked = true;
            this.checkBoxHygroscopicity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHygroscopicity.Location = new System.Drawing.Point(1310, 48);
            this.checkBoxHygroscopicity.Name = "checkBoxHygroscopicity";
            this.checkBoxHygroscopicity.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHygroscopicity.TabIndex = 54;
            this.checkBoxHygroscopicity.UseVisualStyleBackColor = true;
            this.checkBoxHygroscopicity.CheckedChanged += new System.EventHandler(this.checkBoxHygroscopicity_CheckedChanged);
            // 
            // checkBoxLossOnDrying
            // 
            this.checkBoxLossOnDrying.AutoSize = true;
            this.checkBoxLossOnDrying.Checked = true;
            this.checkBoxLossOnDrying.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLossOnDrying.Location = new System.Drawing.Point(1310, 77);
            this.checkBoxLossOnDrying.Name = "checkBoxLossOnDrying";
            this.checkBoxLossOnDrying.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLossOnDrying.TabIndex = 55;
            this.checkBoxLossOnDrying.UseVisualStyleBackColor = true;
            this.checkBoxLossOnDrying.CheckedChanged += new System.EventHandler(this.checkBoxLossOnDrying_CheckedChanged);
            // 
            // labelTrueDensity
            // 
            this.labelTrueDensity.AutoSize = true;
            this.labelTrueDensity.Location = new System.Drawing.Point(14, 108);
            this.labelTrueDensity.Name = "labelTrueDensity";
            this.labelTrueDensity.Size = new System.Drawing.Size(127, 13);
            this.labelTrueDensity.TabIndex = 56;
            this.labelTrueDensity.Text = "Dt (True Density in g/cc):";
            this.labelTrueDensity.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTrueDensity
            // 
            this.textBoxTrueDensity.Enabled = false;
            this.textBoxTrueDensity.Location = new System.Drawing.Point(160, 105);
            this.textBoxTrueDensity.Name = "textBoxTrueDensity";
            this.textBoxTrueDensity.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrueDensity.TabIndex = 57;
            // 
            // checkBoxTrueDensity
            // 
            this.checkBoxTrueDensity.AutoSize = true;
            this.checkBoxTrueDensity.Location = new System.Drawing.Point(266, 108);
            this.checkBoxTrueDensity.Name = "checkBoxTrueDensity";
            this.checkBoxTrueDensity.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTrueDensity.TabIndex = 58;
            this.checkBoxTrueDensity.UseVisualStyleBackColor = true;
            this.checkBoxTrueDensity.CheckedChanged += new System.EventHandler(this.checkBoxTrueDensity_CheckedChanged);
            // 
            // sedemEdsTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.checkBoxTrueDensity);
            this.Controls.Add(this.textBoxTrueDensity);
            this.Controls.Add(this.labelTrueDensity);
            this.Controls.Add(this.checkBoxLossOnDrying);
            this.Controls.Add(this.checkBoxHygroscopicity);
            this.Controls.Add(this.checkBoxCohesionIndex);
            this.Controls.Add(this.checkBoxFlowability);
            this.Controls.Add(this.checkBoxAngleOfRepose);
            this.Controls.Add(this.checkBoxTappedDensity);
            this.Controls.Add(this.checkBoxBulkDensity);
            this.Controls.Add(this.checkBoxCarrIndex);
            this.Controls.Add(this.checkBoxHausnerRatio);
            this.Controls.Add(this.checkBoxInterParticlePorosity);
            this.Controls.Add(this.checkBoxHomogeneityIndex);
            this.Controls.Add(this.checkBoxParticleSizeLessThan50);
            this.Controls.Add(this.textBoxSampleID);
            this.Controls.Add(this.labelSampleID);
            this.Controls.Add(this.buttonNewEntry);
            this.Controls.Add(this.checkBoxCalcAngleOfRepose);
            this.Controls.Add(this.labelOtherParameters);
            this.Controls.Add(this.labelParticleSize);
            this.Controls.Add(this.labelDensityParameters);
            this.Controls.Add(this.labelDensities);
            this.Controls.Add(this.labelAngleOfReposeCalc);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelMeanRadius);
            this.Controls.Add(this.textBoxMeanRadius);
            this.Controls.Add(this.buttonSaveChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelLOD);
            this.Controls.Add(this.labelFlowability);
            this.Controls.Add(this.labelHygroscopicity);
            this.Controls.Add(this.labelHomogeneityIndex);
            this.Controls.Add(this.labelParticlesLessThnFifty);
            this.Controls.Add(this.labelAngleOfRepose);
            this.Controls.Add(this.labelCohesionIndex);
            this.Controls.Add(this.textBoxLossOnDrying);
            this.Controls.Add(this.textBoxFlowability);
            this.Controls.Add(this.textBoxAngleOfRepose);
            this.Controls.Add(this.textBoxHomogeneityIndex);
            this.Controls.Add(this.textBoxCohesionIndex);
            this.Controls.Add(this.textBoxParticlesLessThnFifty);
            this.Controls.Add(this.textBoxHygroscopicity);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.saveCSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxCarrIndex);
            this.Controls.Add(this.labelCarrIndex);
            this.Controls.Add(this.textBoxHausnerRatio);
            this.Controls.Add(this.textBoxInterParticlePorosity);
            this.Controls.Add(this.labelHausnerRatio);
            this.Controls.Add(this.LabelInterParticlePorosity);
            this.Controls.Add(this.btnCalculateParameters);
            this.Controls.Add(this.textBoxTappedDensity);
            this.Controls.Add(this.labelTappedDensity);
            this.Controls.Add(this.labelBulkDensity);
            this.Controls.Add(this.textBoxBulkDensity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sedemEdsTool";
            this.Text = "SeDeM EDS Tool";
            this.Load += new System.EventHandler(this.BulkAndTappedDensity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBulkDensity;
        private System.Windows.Forms.Label labelBulkDensity;
        private System.Windows.Forms.Label labelTappedDensity;
        private System.Windows.Forms.TextBox textBoxTappedDensity;
        private System.Windows.Forms.Button btnCalculateParameters;
        private System.Windows.Forms.Label LabelInterParticlePorosity;
        private System.Windows.Forms.Label labelHausnerRatio;
        private System.Windows.Forms.TextBox textBoxInterParticlePorosity;
        private System.Windows.Forms.TextBox textBoxHausnerRatio;
        private System.Windows.Forms.Label labelCarrIndex;
        private System.Windows.Forms.TextBox textBoxCarrIndex;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveCSV;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxHygroscopicity;
        private System.Windows.Forms.TextBox textBoxParticlesLessThnFifty;
        private System.Windows.Forms.TextBox textBoxCohesionIndex;
        private System.Windows.Forms.TextBox textBoxHomogeneityIndex;
        private System.Windows.Forms.TextBox textBoxAngleOfRepose;
        private System.Windows.Forms.TextBox textBoxFlowability;
        private System.Windows.Forms.TextBox textBoxLossOnDrying;
        private System.Windows.Forms.Label labelCohesionIndex;
        private System.Windows.Forms.Label labelAngleOfRepose;
        private System.Windows.Forms.Label labelParticlesLessThnFifty;
        private System.Windows.Forms.Label labelHomogeneityIndex;
        private System.Windows.Forms.Label labelHygroscopicity;
        private System.Windows.Forms.Label labelFlowability;
        private System.Windows.Forms.Label labelLOD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonSaveChart;
        private System.Windows.Forms.TextBox textBoxMeanRadius;
        private System.Windows.Forms.Label labelMeanRadius;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelAngleOfReposeCalc;
        private System.Windows.Forms.Label labelDensities;
        private System.Windows.Forms.Label labelDensityParameters;
        private System.Windows.Forms.Label labelParticleSize;
        private System.Windows.Forms.Label labelOtherParameters;
        private System.Windows.Forms.CheckBox checkBoxCalcAngleOfRepose;
        private System.Windows.Forms.Button buttonNewEntry;
        private System.Windows.Forms.Label labelSampleID;
        private System.Windows.Forms.TextBox textBoxSampleID;
        private System.Windows.Forms.CheckBox checkBoxParticleSizeLessThan50;
        private System.Windows.Forms.CheckBox checkBoxHomogeneityIndex;
        private System.Windows.Forms.CheckBox checkBoxInterParticlePorosity;
        private System.Windows.Forms.CheckBox checkBoxHausnerRatio;
        private System.Windows.Forms.CheckBox checkBoxCarrIndex;
        private System.Windows.Forms.CheckBox checkBoxBulkDensity;
        private System.Windows.Forms.CheckBox checkBoxTappedDensity;
        private System.Windows.Forms.CheckBox checkBoxAngleOfRepose;
        private System.Windows.Forms.CheckBox checkBoxFlowability;
        private System.Windows.Forms.CheckBox checkBoxCohesionIndex;
        private System.Windows.Forms.CheckBox checkBoxHygroscopicity;
        private System.Windows.Forms.CheckBox checkBoxLossOnDrying;
        private System.Windows.Forms.Label labelTrueDensity;
        private System.Windows.Forms.TextBox textBoxTrueDensity;
        private System.Windows.Forms.CheckBox checkBoxTrueDensity;
    }
}

