namespace CST150_OC2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MaskNo = new System.Windows.Forms.RadioButton();
            this.MaskYes = new System.Windows.Forms.RadioButton();
            this.check_cough = new System.Windows.Forms.CheckBox();
            this.fever = new System.Windows.Forms.CheckBox();
            this.Headache = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LostSmell = new System.Windows.Forms.CheckBox();
            this.LostTaste = new System.Windows.Forms.CheckBox();
            this.Chils = new System.Windows.Forms.CheckBox();
            this.Aches = new System.Windows.Forms.CheckBox();
            this.sneez = new System.Windows.Forms.CheckBox();
            this.RunnyNose = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Principal",
            "Vice Principal",
            "Educator",
            "Staff",
            "Students",
            "Guest"});
            this.listBox1.Location = new System.Drawing.Point(228, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 43);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MaskNo
            // 
            this.MaskNo.AutoSize = true;
            this.MaskNo.Location = new System.Drawing.Point(318, 352);
            this.MaskNo.Name = "MaskNo";
            this.MaskNo.Size = new System.Drawing.Size(39, 17);
            this.MaskNo.TabIndex = 1;
            this.MaskNo.TabStop = true;
            this.MaskNo.Text = "No";
            this.MaskNo.UseVisualStyleBackColor = true;
            // 
            // MaskYes
            // 
            this.MaskYes.AutoSize = true;
            this.MaskYes.Location = new System.Drawing.Point(228, 352);
            this.MaskYes.Name = "MaskYes";
            this.MaskYes.Size = new System.Drawing.Size(43, 17);
            this.MaskYes.TabIndex = 2;
            this.MaskYes.TabStop = true;
            this.MaskYes.Text = "Yes";
            this.MaskYes.UseVisualStyleBackColor = true;
            // 
            // check_cough
            // 
            this.check_cough.AutoSize = true;
            this.check_cough.Location = new System.Drawing.Point(10, 95);
            this.check_cough.Name = "check_cough";
            this.check_cough.Size = new System.Drawing.Size(57, 17);
            this.check_cough.TabIndex = 4;
            this.check_cough.Text = "Cough";
            this.check_cough.UseVisualStyleBackColor = true;
            // 
            // fever
            // 
            this.fever.AutoSize = true;
            this.fever.Location = new System.Drawing.Point(10, 26);
            this.fever.Name = "fever";
            this.fever.Size = new System.Drawing.Size(53, 17);
            this.fever.TabIndex = 5;
            this.fever.Text = "Fever";
            this.fever.UseVisualStyleBackColor = true;
            // 
            // Headache
            // 
            this.Headache.AutoSize = true;
            this.Headache.Location = new System.Drawing.Point(10, 49);
            this.Headache.Name = "Headache";
            this.Headache.Size = new System.Drawing.Size(76, 17);
            this.Headache.TabIndex = 6;
            this.Headache.Text = "Headache";
            this.Headache.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LostSmell);
            this.panel1.Controls.Add(this.LostTaste);
            this.panel1.Controls.Add(this.Chils);
            this.panel1.Controls.Add(this.Aches);
            this.panel1.Controls.Add(this.sneez);
            this.panel1.Controls.Add(this.RunnyNose);
            this.panel1.Controls.Add(this.check_cough);
            this.panel1.Controls.Add(this.Headache);
            this.panel1.Controls.Add(this.fever);
            this.panel1.Location = new System.Drawing.Point(137, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 142);
            this.panel1.TabIndex = 7;
            this.panel1.Tag = "";
            // 
            // LostSmell
            // 
            this.LostSmell.AutoSize = true;
            this.LostSmell.Location = new System.Drawing.Point(227, 26);
            this.LostSmell.Name = "LostSmell";
            this.LostSmell.Size = new System.Drawing.Size(84, 17);
            this.LostSmell.TabIndex = 12;
            this.LostSmell.Text = "Lost of smell";
            this.LostSmell.UseVisualStyleBackColor = true;
            // 
            // LostTaste
            // 
            this.LostTaste.AutoSize = true;
            this.LostTaste.Location = new System.Drawing.Point(111, 72);
            this.LostTaste.Name = "LostTaste";
            this.LostTaste.Size = new System.Drawing.Size(84, 17);
            this.LostTaste.TabIndex = 11;
            this.LostTaste.Text = "Lost of taste";
            this.LostTaste.UseVisualStyleBackColor = true;
            // 
            // Chils
            // 
            this.Chils.AutoSize = true;
            this.Chils.Location = new System.Drawing.Point(111, 49);
            this.Chils.Name = "Chils";
            this.Chils.Size = new System.Drawing.Size(50, 17);
            this.Chils.TabIndex = 10;
            this.Chils.Text = "Chills";
            this.Chils.UseVisualStyleBackColor = true;
            // 
            // Aches
            // 
            this.Aches.AutoSize = true;
            this.Aches.Location = new System.Drawing.Point(111, 26);
            this.Aches.Name = "Aches";
            this.Aches.Size = new System.Drawing.Size(56, 17);
            this.Aches.TabIndex = 8;
            this.Aches.Text = "Aches";
            this.Aches.UseVisualStyleBackColor = true;
            // 
            // sneez
            // 
            this.sneez.AutoSize = true;
            this.sneez.Location = new System.Drawing.Point(10, 72);
            this.sneez.Name = "sneez";
            this.sneez.Size = new System.Drawing.Size(56, 17);
            this.sneez.TabIndex = 9;
            this.sneez.Text = "Sneez";
            this.sneez.UseVisualStyleBackColor = true;
            // 
            // RunnyNose
            // 
            this.RunnyNose.AutoSize = true;
            this.RunnyNose.Location = new System.Drawing.Point(111, 95);
            this.RunnyNose.Name = "RunnyNose";
            this.RunnyNose.Size = new System.Drawing.Size(85, 17);
            this.RunnyNose.TabIndex = 7;
            this.RunnyNose.Text = "Runny Nose";
            this.RunnyNose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Worn Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Member on Campus";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(249, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MaskYes);
            this.Controls.Add(this.MaskNo);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Campus Covid-19 Questionaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton MaskNo;
        private System.Windows.Forms.RadioButton MaskYes;
        private System.Windows.Forms.CheckBox check_cough;
        private System.Windows.Forms.CheckBox fever;
        private System.Windows.Forms.CheckBox Headache;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox LostSmell;
        private System.Windows.Forms.CheckBox LostTaste;
        private System.Windows.Forms.CheckBox Chils;
        private System.Windows.Forms.CheckBox Aches;
        private System.Windows.Forms.CheckBox sneez;
        private System.Windows.Forms.CheckBox RunnyNose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

