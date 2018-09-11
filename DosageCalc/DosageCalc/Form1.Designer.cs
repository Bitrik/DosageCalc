namespace DosageCalc
{
    partial class Dosage_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DosageOutput = new System.Windows.Forms.TextBox();
            this.Disclaimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LETHAL DOSAGE CALCULATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "DXM/Dextromethorphan",
            "Caffiene",
            "Amphetamine",
            "Alprazolam/Xanax",
            "LSD",
            "Psilocybin"});
            this.listBox1.Location = new System.Drawing.Point(84, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 69);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(112, 133);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // WeightInput
            // 
            this.WeightInput.Location = new System.Drawing.Point(100, 35);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(100, 20);
            this.WeightInput.TabIndex = 3;
            this.WeightInput.TextChanged += new System.EventHandler(this.WeightInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter LBS:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter weight in LBS, select the drug, and press calculate! LSD Calculation is in " +
    "MG, along with every other drug.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DosageOutput
            // 
            this.DosageOutput.Location = new System.Drawing.Point(100, 158);
            this.DosageOutput.Name = "DosageOutput";
            this.DosageOutput.Size = new System.Drawing.Size(100, 20);
            this.DosageOutput.TabIndex = 6;
            this.DosageOutput.TextChanged += new System.EventHandler(this.DosageOutput_TextChanged);
            // 
            // Disclaimer
            // 
            this.Disclaimer.Location = new System.Drawing.Point(39, 186);
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(233, 27);
            this.Disclaimer.TabIndex = 7;
            this.Disclaimer.Text = "THIS IS APPROXIMATE. Don\'t count on this program to save your life.";
            this.Disclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output in MG:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dosage_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Disclaimer);
            this.Controls.Add(this.DosageOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeightInput);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dosage_Calculator";
            this.Text = "Dosage_Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DosageOutput;
        private System.Windows.Forms.Label Disclaimer;
        private System.Windows.Forms.Label label4;
    }
}

