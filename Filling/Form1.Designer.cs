namespace Filling
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDims = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fillingGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contourCheckBox = new System.Windows.Forms.CheckBox();
            this.lambertGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabel = new System.Windows.Forms.Label();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.ksLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kdLabel = new System.Windows.Forms.Label();
            this.kdTrackBar = new System.Windows.Forms.TrackBar();
            this.ksTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.normalVectorGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.changeMapButton = new System.Windows.Forms.Button();
            this.constVecRadioButton = new System.Windows.Forms.RadioButton();
            this.mapVecRadioButton = new System.Windows.Forms.RadioButton();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lightZValue = new System.Windows.Forms.Label();
            this.timerStopButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timeStartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lambertCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightZTrackBar = new System.Windows.Forms.TrackBar();
            this.lightZMaxLabel = new System.Windows.Forms.Label();
            this.lightZMinLabel = new System.Windows.Forms.Label();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.reflectorCheckBox = new System.Windows.Forms.CheckBox();
            this.insideColorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contourColorDialog = new System.Windows.Forms.ColorDialog();
            this.mapOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lightColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxDims.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.fillingGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.lambertGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).BeginInit();
            this.normalVectorGroupBox.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.timerGroupBox.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightZTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.04878F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(762, 555);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxDims);
            this.flowLayoutPanel1.Controls.Add(this.fillingGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.lambertGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.timerGroupBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(771, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 555);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxDims
            // 
            this.groupBoxDims.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxDims.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDims.Name = "groupBoxDims";
            this.groupBoxDims.Size = new System.Drawing.Size(198, 67);
            this.groupBoxDims.TabIndex = 0;
            this.groupBoxDims.TabStop = false;
            this.groupBoxDims.Text = "Grid Dimensions";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.875F));
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownX, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownY, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.91667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.08333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 48);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(57, 3);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX.TabIndex = 0;
            this.numericUpDownX.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(57, 26);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY.TabIndex = 3;
            this.numericUpDownY.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "yUnits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "xUnits";
            // 
            // fillingGroupBox
            // 
            this.fillingGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.fillingGroupBox.Location = new System.Drawing.Point(3, 76);
            this.fillingGroupBox.Name = "fillingGroupBox";
            this.fillingGroupBox.Size = new System.Drawing.Size(198, 93);
            this.fillingGroupBox.TabIndex = 4;
            this.fillingGroupBox.TabStop = false;
            this.fillingGroupBox.Text = "Filling";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.contourCheckBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureButton
            // 
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureButton.Location = new System.Drawing.Point(99, 3);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(90, 19);
            this.pictureButton.TabIndex = 1;
            this.pictureButton.Text = "Picture";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorButton.Location = new System.Drawing.Point(3, 3);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(90, 19);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contour color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contourCheckBox
            // 
            this.contourCheckBox.AutoSize = true;
            this.contourCheckBox.Checked = true;
            this.contourCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.contourCheckBox, 2);
            this.contourCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contourCheckBox.Location = new System.Drawing.Point(3, 53);
            this.contourCheckBox.Name = "contourCheckBox";
            this.contourCheckBox.Size = new System.Drawing.Size(186, 18);
            this.contourCheckBox.TabIndex = 3;
            this.contourCheckBox.Text = "Draw contours";
            this.contourCheckBox.UseVisualStyleBackColor = true;
            // 
            // lambertGroupBox
            // 
            this.lambertGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.lambertGroupBox.Location = new System.Drawing.Point(3, 175);
            this.lambertGroupBox.Name = "lambertGroupBox";
            this.lambertGroupBox.Size = new System.Drawing.Size(200, 202);
            this.lambertGroupBox.TabIndex = 5;
            this.lambertGroupBox.TabStop = false;
            this.lambertGroupBox.Text = "Lambert";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.normalVectorGroupBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 183);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24138F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.75862F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel6.Controls.Add(this.mLabel, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.mTrackBar, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.ksLabel, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.kdLabel, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.kdTrackBar, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ksTrackBar, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(188, 95);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLabel.Location = new System.Drawing.Point(148, 62);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(37, 33);
            this.mLabel.TabIndex = 14;
            this.mLabel.Text = "50";
            // 
            // mTrackBar
            // 
            this.mTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTrackBar.Location = new System.Drawing.Point(28, 65);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(114, 27);
            this.mTrackBar.TabIndex = 11;
            this.mTrackBar.Value = 50;
            this.mTrackBar.ValueChanged += new System.EventHandler(this.mTrackBar_ValueChanged);
            // 
            // ksLabel
            // 
            this.ksLabel.AutoSize = true;
            this.ksLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksLabel.Location = new System.Drawing.Point(148, 31);
            this.ksLabel.Name = "ksLabel";
            this.ksLabel.Size = new System.Drawing.Size(37, 31);
            this.ksLabel.TabIndex = 13;
            this.ksLabel.Text = "0.5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "kd";
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdLabel.Location = new System.Drawing.Point(148, 0);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(37, 31);
            this.kdLabel.TabIndex = 12;
            this.kdLabel.Text = "0.5";
            // 
            // kdTrackBar
            // 
            this.kdTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdTrackBar.Location = new System.Drawing.Point(28, 3);
            this.kdTrackBar.Maximum = 100;
            this.kdTrackBar.Name = "kdTrackBar";
            this.kdTrackBar.Size = new System.Drawing.Size(114, 25);
            this.kdTrackBar.TabIndex = 6;
            this.kdTrackBar.Value = 50;
            this.kdTrackBar.ValueChanged += new System.EventHandler(this.kdTrackBar_ValueChanged);
            // 
            // ksTrackBar
            // 
            this.ksTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ksTrackBar.Location = new System.Drawing.Point(28, 34);
            this.ksTrackBar.Maximum = 100;
            this.ksTrackBar.Name = "ksTrackBar";
            this.ksTrackBar.Size = new System.Drawing.Size(114, 25);
            this.ksTrackBar.TabIndex = 9;
            this.ksTrackBar.Value = 50;
            this.ksTrackBar.ValueChanged += new System.EventHandler(this.ksTrackBar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "ks";
            // 
            // normalVectorGroupBox
            // 
            this.normalVectorGroupBox.Controls.Add(this.tableLayoutPanel7);
            this.normalVectorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalVectorGroupBox.Location = new System.Drawing.Point(3, 104);
            this.normalVectorGroupBox.Name = "normalVectorGroupBox";
            this.normalVectorGroupBox.Size = new System.Drawing.Size(188, 76);
            this.normalVectorGroupBox.TabIndex = 15;
            this.normalVectorGroupBox.TabStop = false;
            this.normalVectorGroupBox.Text = "Normal vector";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel7.Controls.Add(this.changeMapButton, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.constVecRadioButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.mapVecRadioButton, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(182, 57);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // changeMapButton
            // 
            this.changeMapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeMapButton.Enabled = false;
            this.changeMapButton.Location = new System.Drawing.Point(125, 31);
            this.changeMapButton.Name = "changeMapButton";
            this.changeMapButton.Size = new System.Drawing.Size(54, 23);
            this.changeMapButton.TabIndex = 6;
            this.changeMapButton.Text = "Change";
            this.changeMapButton.UseVisualStyleBackColor = true;
            this.changeMapButton.Click += new System.EventHandler(this.changeMapButton_Click);
            // 
            // constVecRadioButton
            // 
            this.constVecRadioButton.AutoSize = true;
            this.constVecRadioButton.Checked = true;
            this.tableLayoutPanel7.SetColumnSpan(this.constVecRadioButton, 2);
            this.constVecRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constVecRadioButton.Location = new System.Drawing.Point(3, 3);
            this.constVecRadioButton.Name = "constVecRadioButton";
            this.constVecRadioButton.Size = new System.Drawing.Size(176, 22);
            this.constVecRadioButton.TabIndex = 0;
            this.constVecRadioButton.TabStop = true;
            this.constVecRadioButton.Text = "Constant [0, 0, 1]";
            this.constVecRadioButton.UseVisualStyleBackColor = true;
            this.constVecRadioButton.CheckedChanged += new System.EventHandler(this.constVecRadioButton_CheckedChanged);
            // 
            // mapVecRadioButton
            // 
            this.mapVecRadioButton.AutoSize = true;
            this.mapVecRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapVecRadioButton.Location = new System.Drawing.Point(3, 31);
            this.mapVecRadioButton.Name = "mapVecRadioButton";
            this.mapVecRadioButton.Size = new System.Drawing.Size(116, 23);
            this.mapVecRadioButton.TabIndex = 1;
            this.mapVecRadioButton.TabStop = true;
            this.mapVecRadioButton.Text = "Normal map...";
            this.mapVecRadioButton.UseVisualStyleBackColor = true;
            this.mapVecRadioButton.CheckedChanged += new System.EventHandler(this.mapVecRadioButton_CheckedChanged);
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Controls.Add(this.tableLayoutPanel8);
            this.timerGroupBox.Location = new System.Drawing.Point(3, 383);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(198, 163);
            this.timerGroupBox.TabIndex = 6;
            this.timerGroupBox.TabStop = false;
            this.timerGroupBox.Text = "Light";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.9635F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0365F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel8.Controls.Add(this.lightZValue, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.timerStopButton, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.timeStartButton, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lambertCheckBox, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.lightColorButton, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.reflectorCheckBox, 1, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.375F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.625F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(192, 144);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // lightZValue
            // 
            this.lightZValue.AutoSize = true;
            this.lightZValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lightZValue.Location = new System.Drawing.Point(137, 0);
            this.lightZValue.Name = "lightZValue";
            this.lightZValue.Size = new System.Drawing.Size(52, 51);
            this.lightZValue.TabIndex = 4;
            this.lightZValue.Text = "50";
            this.lightZValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerStopButton
            // 
            this.timerStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerStopButton.Location = new System.Drawing.Point(137, 54);
            this.timerStopButton.Name = "timerStopButton";
            this.timerStopButton.Size = new System.Drawing.Size(52, 28);
            this.timerStopButton.TabIndex = 1;
            this.timerStopButton.Text = "Stop";
            this.timerStopButton.UseVisualStyleBackColor = true;
            this.timerStopButton.Click += new System.EventHandler(this.timerStopButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "Animate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeStartButton
            // 
            this.timeStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeStartButton.Location = new System.Drawing.Point(90, 54);
            this.timeStartButton.Name = "timeStartButton";
            this.timeStartButton.Size = new System.Drawing.Size(41, 28);
            this.timeStartButton.TabIndex = 0;
            this.timeStartButton.Text = "Start";
            this.timeStartButton.UseVisualStyleBackColor = true;
            this.timeStartButton.Click += new System.EventHandler(this.timeStartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(90, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 51);
            this.label3.TabIndex = 0;
            this.label3.Text = "Light z-postion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lambertCheckBox
            // 
            this.lambertCheckBox.AutoSize = true;
            this.lambertCheckBox.Checked = true;
            this.lambertCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lambertCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lambertCheckBox.Location = new System.Drawing.Point(3, 3);
            this.lambertCheckBox.Name = "lambertCheckBox";
            this.lambertCheckBox.Size = new System.Drawing.Size(81, 45);
            this.lambertCheckBox.TabIndex = 5;
            this.lambertCheckBox.Text = "Switch on the light";
            this.lambertCheckBox.UseVisualStyleBackColor = true;
            this.lambertCheckBox.CheckedChanged += new System.EventHandler(this.lambertCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.lightZTrackBar);
            this.panel1.Controls.Add(this.lightZMaxLabel);
            this.panel1.Controls.Add(this.lightZMinLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 24);
            this.panel1.TabIndex = 6;
            // 
            // lightZTrackBar
            // 
            this.lightZTrackBar.Location = new System.Drawing.Point(23, 3);
            this.lightZTrackBar.Maximum = 200;
            this.lightZTrackBar.Minimum = 1;
            this.lightZTrackBar.Name = "lightZTrackBar";
            this.lightZTrackBar.Size = new System.Drawing.Size(139, 45);
            this.lightZTrackBar.TabIndex = 1;
            this.lightZTrackBar.Value = 50;
            this.lightZTrackBar.ValueChanged += new System.EventHandler(this.lightZTrackBar_ValueChanged);
            // 
            // lightZMaxLabel
            // 
            this.lightZMaxLabel.AutoSize = true;
            this.lightZMaxLabel.Location = new System.Drawing.Point(160, 3);
            this.lightZMaxLabel.Name = "lightZMaxLabel";
            this.lightZMaxLabel.Size = new System.Drawing.Size(14, 13);
            this.lightZMaxLabel.TabIndex = 3;
            this.lightZMaxLabel.Text = "Z";
            // 
            // lightZMinLabel
            // 
            this.lightZMinLabel.AutoSize = true;
            this.lightZMinLabel.Location = new System.Drawing.Point(3, 3);
            this.lightZMinLabel.Name = "lightZMinLabel";
            this.lightZMinLabel.Size = new System.Drawing.Size(14, 13);
            this.lightZMinLabel.TabIndex = 2;
            this.lightZMinLabel.Text = "Z";
            // 
            // lightColorButton
            // 
            this.lightColorButton.Location = new System.Drawing.Point(3, 118);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(81, 23);
            this.lightColorButton.TabIndex = 7;
            this.lightColorButton.Text = "Light color";
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // reflectorCheckBox
            // 
            this.reflectorCheckBox.AutoSize = true;
            this.reflectorCheckBox.Checked = true;
            this.reflectorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel8.SetColumnSpan(this.reflectorCheckBox, 2);
            this.reflectorCheckBox.Location = new System.Drawing.Point(90, 118);
            this.reflectorCheckBox.Name = "reflectorCheckBox";
            this.reflectorCheckBox.Size = new System.Drawing.Size(69, 17);
            this.reflectorCheckBox.TabIndex = 7;
            this.reflectorCheckBox.Text = "Reflector";
            this.reflectorCheckBox.UseVisualStyleBackColor = true;
            this.reflectorCheckBox.CheckedChanged += new System.EventHandler(this.reflectorCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\damak\\Desktop\\PW\\GK\\filling-triangles\\Filling\\bin\\Debug\\maps";
            // 
            // mapOpenFileDialog
            // 
            this.mapOpenFileDialog.FileName = "map3.png";
            this.mapOpenFileDialog.InitialDirectory = "C:\\Users\\damak\\Desktop\\PW\\GK\\filling-triangles\\Filling\\bin\\Debug\\maps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GK lab2";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxDims.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.fillingGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.lambertGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).EndInit();
            this.normalVectorGroupBox.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.timerGroupBox.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightZTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxDims;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox fillingGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog insideColorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog contourColorDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox contourCheckBox;
        private System.Windows.Forms.GroupBox lambertGroupBox;
        private System.Windows.Forms.TrackBar lightZTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lightZMaxLabel;
        private System.Windows.Forms.Label lightZMinLabel;
        private System.Windows.Forms.CheckBox lambertCheckBox;
        private System.Windows.Forms.TrackBar kdTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar ksTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar mTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label ksLabel;
        private System.Windows.Forms.Label kdLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox normalVectorGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RadioButton mapVecRadioButton;
        private System.Windows.Forms.RadioButton constVecRadioButton;
        private System.Windows.Forms.Button changeMapButton;
        private System.Windows.Forms.OpenFileDialog mapOpenFileDialog;
        private System.Windows.Forms.GroupBox timerGroupBox;
        private System.Windows.Forms.Button timeStartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lightZValue;
        private System.Windows.Forms.Button timerStopButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox reflectorCheckBox;
        private System.Windows.Forms.Button lightColorButton;
        private System.Windows.Forms.ColorDialog lightColorDialog;
    }
}

