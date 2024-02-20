namespace Assignment_3_windowsforms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rbMetric = new RadioButton();
            rbImperial = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            lblResult = new Label();
            lblWeightCategory = new Label();
            lblNormalWeightRange = new Label();
            btnCalculate = new Button();
            txtWeight = new TextBox();
            txtName = new TextBox();
            txtHeight = new TextBox();
            grp = new GroupBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            txtHeightInches = new TextBox();
            lblFt = new Label();
            lblIn = new Label();
            txtHeightFeet = new TextBox();
            grp.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 58);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Your Name";
            label1.Click += label1_Click;
            // 
            // rbMetric
            // 
            rbMetric.AutoSize = true;
            rbMetric.Location = new Point(31, 22);
            rbMetric.Name = "rbMetric";
            rbMetric.Size = new Size(131, 19);
            rbMetric.TabIndex = 1;
            rbMetric.TabStop = true;
            rbMetric.Text = "Metric Unit (kg, cm)";
            rbMetric.UseVisualStyleBackColor = true;
            rbMetric.CheckedChanged += rbMetric_CheckedChanged;
            // 
            // rbImperial
            // 
            rbImperial.AutoSize = true;
            rbImperial.Location = new Point(31, 60);
            rbImperial.Name = "rbImperial";
            rbImperial.Size = new Size(118, 19);
            rbImperial.TabIndex = 2;
            rbImperial.TabStop = true;
            rbImperial.Text = "US Unit (foot, lbs)";
            rbImperial.UseVisualStyleBackColor = true;
            rbImperial.CheckedChanged += rbImperial_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 114);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Height";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 142);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Weight";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(318, 36);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 5;
            // 
            // lblWeightCategory
            // 
            lblWeightCategory.AutoSize = true;
            lblWeightCategory.Location = new Point(318, 71);
            lblWeightCategory.Name = "lblWeightCategory";
            lblWeightCategory.Size = new Size(0, 15);
            lblWeightCategory.TabIndex = 6;
            // 
            // lblNormalWeightRange
            // 
            lblNormalWeightRange.AutoSize = true;
            lblNormalWeightRange.Location = new Point(318, 130);
            lblNormalWeightRange.Name = "lblNormalWeightRange";
            lblNormalWeightRange.Size = new Size(0, 15);
            lblNormalWeightRange.TabIndex = 7;
            lblNormalWeightRange.Click += lblResult_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(241, 247);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(114, 39);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(143, 132);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(69, 23);
            txtWeight.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(478, 23);
            txtName.TabIndex = 11;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(143, 109);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(69, 23);
            txtHeight.TabIndex = 12;
            // 
            // grp
            // 
            grp.Controls.Add(rbMetric);
            grp.Controls.Add(rbImperial);
            grp.Location = new Point(388, 114);
            grp.Name = "grp";
            grp.Size = new Size(200, 100);
            grp.TabIndex = 13;
            grp.TabStop = false;
            grp.Text = "Unit";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblResult);
            groupBox2.Controls.Add(lblWeightCategory);
            groupBox2.Controls.Add(lblNormalWeightRange);
            groupBox2.Location = new Point(25, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(563, 249);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 71);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 1;
            label8.Text = "Weight Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 36);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 0;
            label7.Text = "Your BMI";
            label7.Click += label7_Click;
            // 
            // txtHeightInches
            // 
            txtHeightInches.Location = new Point(239, 109);
            txtHeightInches.Name = "txtHeightInches";
            txtHeightInches.Size = new Size(64, 23);
            txtHeightInches.TabIndex = 15;
            // 
            // lblFt
            // 
            lblFt.AutoSize = true;
            lblFt.Location = new Point(218, 117);
            lblFt.Name = "lblFt";
            lblFt.Size = new Size(15, 15);
            lblFt.TabIndex = 16;
            lblFt.Text = "ft";
            lblFt.Click += label4_Click;
            // 
            // lblIn
            // 
            lblIn.AutoSize = true;
            lblIn.Location = new Point(309, 117);
            lblIn.Name = "lblIn";
            lblIn.Size = new Size(17, 15);
            lblIn.TabIndex = 17;
            lblIn.Text = "in";
            // 
            // txtHeightFeet
            // 
            txtHeightFeet.Location = new Point(143, 109);
            txtHeightFeet.Name = "txtHeightFeet";
            txtHeightFeet.Size = new Size(69, 23);
            txtHeightFeet.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 623);
            Controls.Add(txtHeightFeet);
            Controls.Add(lblIn);
            Controls.Add(lblFt);
            Controls.Add(txtHeightInches);
            Controls.Add(groupBox2);
            Controls.Add(grp);
            Controls.Add(txtHeight);
            Controls.Add(txtName);
            Controls.Add(txtWeight);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            grp.ResumeLayout(false);
            grp.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbMetric;
        private RadioButton rbImperial;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private Label lblWeightCategory;
        private Label lblNormalWeightRange;
        private Button btnCalculate;
        private TextBox txtWeight;
        private TextBox txtName;
        private TextBox txtHeight;
        private GroupBox grp;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private TextBox txtHeightInches;
        private Label lblFt;
        private Label lblIn;
        private TextBox txtHeightFeet;
    }
}
