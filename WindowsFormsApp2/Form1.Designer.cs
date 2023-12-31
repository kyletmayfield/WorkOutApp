namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChest = new System.Windows.Forms.Label();
            this.lblArms = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.lblShoulders = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblCardio = new System.Windows.Forms.Label();
            this.lblStretch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 808);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(318, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblChest
            // 
            this.lblChest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChest.Location = new System.Drawing.Point(318, 154);
            this.lblChest.Name = "lblChest";
            this.lblChest.Size = new System.Drawing.Size(168, 49);
            this.lblChest.TabIndex = 2;
            this.lblChest.Text = "Chest";
            // 
            // lblArms
            // 
            this.lblArms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArms.Location = new System.Drawing.Point(318, 203);
            this.lblArms.Name = "lblArms";
            this.lblArms.Size = new System.Drawing.Size(168, 49);
            this.lblArms.TabIndex = 3;
            this.lblArms.Text = "Arms";
            // 
            // lblLegs
            // 
            this.lblLegs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLegs.Location = new System.Drawing.Point(319, 252);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(168, 49);
            this.lblLegs.TabIndex = 4;
            this.lblLegs.Text = "legs";
            // 
            // lblShoulders
            // 
            this.lblShoulders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShoulders.Location = new System.Drawing.Point(318, 301);
            this.lblShoulders.Name = "lblShoulders";
            this.lblShoulders.Size = new System.Drawing.Size(168, 49);
            this.lblShoulders.TabIndex = 5;
            this.lblShoulders.Text = "Shoulders";
            // 
            // lblBack
            // 
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBack.Location = new System.Drawing.Point(318, 349);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(168, 49);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "Back";
            // 
            // lblCardio
            // 
            this.lblCardio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardio.Location = new System.Drawing.Point(319, 398);
            this.lblCardio.Name = "lblCardio";
            this.lblCardio.Size = new System.Drawing.Size(168, 49);
            this.lblCardio.TabIndex = 7;
            this.lblCardio.Text = "Cardio";
            // 
            // lblStretch
            // 
            this.lblStretch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStretch.Location = new System.Drawing.Point(319, 447);
            this.lblStretch.Name = "lblStretch";
            this.lblStretch.Size = new System.Drawing.Size(168, 49);
            this.lblStretch.TabIndex = 8;
            this.lblStretch.Text = "Stretch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 907);
            this.Controls.Add(this.lblStretch);
            this.Controls.Add(this.lblCardio);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblShoulders);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblArms);
            this.Controls.Add(this.lblChest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChest;
        private System.Windows.Forms.Label lblArms;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.Label lblShoulders;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblCardio;
        private System.Windows.Forms.Label lblStretch;
    }
}

