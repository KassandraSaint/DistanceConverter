
namespace DistanceConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.fromBox = new System.Windows.Forms.GroupBox();
            this.toBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.fromBox.SuspendLayout();
            this.toBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // distanceBox
            // 
            this.distanceBox.Font = new System.Drawing.Font("MS Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceBox.Location = new System.Drawing.Point(508, 35);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(258, 34);
            this.distanceBox.TabIndex = 1;
            // 
            // fromBox
            // 
            this.fromBox.Controls.Add(this.fromListBox);
            this.fromBox.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromBox.Location = new System.Drawing.Point(35, 98);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(335, 220);
            this.fromBox.TabIndex = 2;
            this.fromBox.TabStop = false;
            this.fromBox.Text = "From";
            // 
            // toBox
            // 
            this.toBox.Controls.Add(this.toListBox);
            this.toBox.Font = new System.Drawing.Font("Myanmar Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBox.Location = new System.Drawing.Point(431, 98);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(335, 220);
            this.toBox.TabIndex = 3;
            this.toBox.TabStop = false;
            this.toBox.Text = "To";
            // 
            // fromListBox
            // 
            this.fromListBox.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 37;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(60, 66);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(216, 115);
            this.fromListBox.TabIndex = 0;
            // 
            // toListBox
            // 
            this.toListBox.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 37;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(60, 65);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(216, 115);
            this.toListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Distance:";
            // 
            // convertedLabel
            // 
            this.convertedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedLabel.Font = new System.Drawing.Font("MS Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedLabel.Location = new System.Drawing.Point(431, 335);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(290, 44);
            this.convertedLabel.TabIndex = 5;
            this.convertedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertBtn
            // 
            this.convertBtn.Font = new System.Drawing.Font("MS Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(166, 402);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(205, 55);
            this.convertBtn.TabIndex = 6;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("MS Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(431, 402);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(205, 55);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 479);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.fromBox.ResumeLayout(false);
            this.toBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.GroupBox fromBox;
        private System.Windows.Forms.GroupBox toBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

