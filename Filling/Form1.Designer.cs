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
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fillingGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contourCheckBox = new System.Windows.Forms.CheckBox();
            this.lambertGroupBox = new System.Windows.Forms.GroupBox();
            this.mTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ksTrackBar = new System.Windows.Forms.TrackBar();
            this.kdTrackBar = new System.Windows.Forms.TrackBar();
            this.lightZValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lightZMaxLabel = new System.Windows.Forms.Label();
            this.lightZMinLabel = new System.Windows.Forms.Label();
            this.lambertCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lightZTrackBar = new System.Windows.Forms.TrackBar();
            this.insideColorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contourColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxDims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.fillingGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.lambertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).BeginInit();
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(771, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 555);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxDims
            // 
            this.groupBoxDims.Controls.Add(this.numericUpDownY);
            this.groupBoxDims.Controls.Add(this.label2);
            this.groupBoxDims.Controls.Add(this.numericUpDownX);
            this.groupBoxDims.Controls.Add(this.label1);
            this.groupBoxDims.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDims.Name = "groupBoxDims";
            this.groupBoxDims.Size = new System.Drawing.Size(198, 86);
            this.groupBoxDims.TabIndex = 0;
            this.groupBoxDims.TabStop = false;
            this.groupBoxDims.Text = "Grid Dimensions";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(56, 54);
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
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "yUnits";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(56, 26);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "xUnits";
            // 
            // fillingGroupBox
            // 
            this.fillingGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.fillingGroupBox.Location = new System.Drawing.Point(3, 95);
            this.fillingGroupBox.Name = "fillingGroupBox";
            this.fillingGroupBox.Size = new System.Drawing.Size(198, 102);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 83);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureButton
            // 
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureButton.Location = new System.Drawing.Point(99, 3);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(90, 24);
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
            this.colorButton.Size = new System.Drawing.Size(90, 24);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 24);
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
            this.contourCheckBox.Location = new System.Drawing.Point(3, 63);
            this.contourCheckBox.Name = "contourCheckBox";
            this.contourCheckBox.Size = new System.Drawing.Size(186, 17);
            this.contourCheckBox.TabIndex = 3;
            this.contourCheckBox.Text = "Draw contours";
            this.contourCheckBox.UseVisualStyleBackColor = true;
            // 
            // lambertGroupBox
            // 
            this.lambertGroupBox.Controls.Add(this.mTrackBar);
            this.lambertGroupBox.Controls.Add(this.label6);
            this.lambertGroupBox.Controls.Add(this.ksTrackBar);
            this.lambertGroupBox.Controls.Add(this.kdTrackBar);
            this.lambertGroupBox.Controls.Add(this.lightZValue);
            this.lambertGroupBox.Controls.Add(this.label5);
            this.lambertGroupBox.Controls.Add(this.lightZMaxLabel);
            this.lambertGroupBox.Controls.Add(this.lightZMinLabel);
            this.lambertGroupBox.Controls.Add(this.lambertCheckBox);
            this.lambertGroupBox.Controls.Add(this.label4);
            this.lambertGroupBox.Controls.Add(this.label3);
            this.lambertGroupBox.Controls.Add(this.lightZTrackBar);
            this.lambertGroupBox.Location = new System.Drawing.Point(3, 203);
            this.lambertGroupBox.Name = "lambertGroupBox";
            this.lambertGroupBox.Size = new System.Drawing.Size(200, 300);
            this.lambertGroupBox.TabIndex = 5;
            this.lambertGroupBox.TabStop = false;
            this.lambertGroupBox.Text = "Lambert";
            // 
            // mTrackBar
            // 
            this.mTrackBar.Location = new System.Drawing.Point(18, 148);
            this.mTrackBar.Maximum = 100;
            this.mTrackBar.Minimum = 1;
            this.mTrackBar.Name = "mTrackBar";
            this.mTrackBar.Size = new System.Drawing.Size(158, 45);
            this.mTrackBar.TabIndex = 11;
            this.mTrackBar.Value = 50;
            this.mTrackBar.ValueChanged += new System.EventHandler(this.mTrackBar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "m";
            // 
            // ksTrackBar
            // 
            this.ksTrackBar.Location = new System.Drawing.Point(18, 115);
            this.ksTrackBar.Maximum = 100;
            this.ksTrackBar.Name = "ksTrackBar";
            this.ksTrackBar.Size = new System.Drawing.Size(158, 45);
            this.ksTrackBar.TabIndex = 9;
            this.ksTrackBar.Value = 50;
            this.ksTrackBar.ValueChanged += new System.EventHandler(this.ksTrackBar_ValueChanged);
            // 
            // kdTrackBar
            // 
            this.kdTrackBar.Location = new System.Drawing.Point(18, 86);
            this.kdTrackBar.Maximum = 100;
            this.kdTrackBar.Name = "kdTrackBar";
            this.kdTrackBar.Size = new System.Drawing.Size(158, 45);
            this.kdTrackBar.TabIndex = 6;
            this.kdTrackBar.Value = 50;
            this.kdTrackBar.ValueChanged += new System.EventHandler(this.kdTrackBar_ValueChanged);
            // 
            // lightZValue
            // 
            this.lightZValue.AutoSize = true;
            this.lightZValue.Location = new System.Drawing.Point(82, 37);
            this.lightZValue.Name = "lightZValue";
            this.lightZValue.Size = new System.Drawing.Size(19, 13);
            this.lightZValue.TabIndex = 4;
            this.lightZValue.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ks";
            // 
            // lightZMaxLabel
            // 
            this.lightZMaxLabel.AutoSize = true;
            this.lightZMaxLabel.Location = new System.Drawing.Point(174, 59);
            this.lightZMaxLabel.Name = "lightZMaxLabel";
            this.lightZMaxLabel.Size = new System.Drawing.Size(14, 13);
            this.lightZMaxLabel.TabIndex = 3;
            this.lightZMaxLabel.Text = "Z";
            // 
            // lightZMinLabel
            // 
            this.lightZMinLabel.AutoSize = true;
            this.lightZMinLabel.Location = new System.Drawing.Point(6, 59);
            this.lightZMinLabel.Name = "lightZMinLabel";
            this.lightZMinLabel.Size = new System.Drawing.Size(14, 13);
            this.lightZMinLabel.TabIndex = 2;
            this.lightZMinLabel.Text = "Z";
            // 
            // lambertCheckBox
            // 
            this.lambertCheckBox.AutoSize = true;
            this.lambertCheckBox.Checked = true;
            this.lambertCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lambertCheckBox.Location = new System.Drawing.Point(6, 17);
            this.lambertCheckBox.Name = "lambertCheckBox";
            this.lambertCheckBox.Size = new System.Drawing.Size(113, 17);
            this.lambertCheckBox.TabIndex = 5;
            this.lambertCheckBox.Text = "Switch on the light";
            this.lambertCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "kd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Light z-postion:";
            // 
            // lightZTrackBar
            // 
            this.lightZTrackBar.Location = new System.Drawing.Point(18, 53);
            this.lightZTrackBar.Maximum = 200;
            this.lightZTrackBar.Minimum = 1;
            this.lightZTrackBar.Name = "lightZTrackBar";
            this.lightZTrackBar.Size = new System.Drawing.Size(158, 45);
            this.lightZTrackBar.TabIndex = 1;
            this.lightZTrackBar.Value = 10;
            this.lightZTrackBar.ValueChanged += new System.EventHandler(this.lightZTrackBar_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\damak\\Desktop\\PW\\GK\\filling-triangles\\Filling\\bin\\Debug\\maps";
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
            this.groupBoxDims.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.fillingGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.lambertGroupBox.ResumeLayout(false);
            this.lambertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdTrackBar)).EndInit();
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
        private System.Windows.Forms.Label lightZValue;
        private System.Windows.Forms.Label lightZMaxLabel;
        private System.Windows.Forms.Label lightZMinLabel;
        private System.Windows.Forms.CheckBox lambertCheckBox;
        private System.Windows.Forms.TrackBar kdTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar ksTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar mTrackBar;
        private System.Windows.Forms.Label label6;
    }
}

