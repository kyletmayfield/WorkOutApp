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
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(283, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset Workout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(283, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kyle\'s Workout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChest
            // 
            this.lblChest.BackColor = System.Drawing.Color.SandyBrown;
            this.lblChest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblChest.Location = new System.Drawing.Point(283, 123);
            this.lblChest.Name = "lblChest";
            this.lblChest.Size = new System.Drawing.Size(266, 40);
            this.lblChest.TabIndex = 2;
            this.lblChest.Text = "Chest";
            this.lblChest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArms
            // 
            this.lblArms.BackColor = System.Drawing.Color.SandyBrown;
            this.lblArms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblArms.Location = new System.Drawing.Point(283, 162);
            this.lblArms.Name = "lblArms";
            this.lblArms.Size = new System.Drawing.Size(266, 40);
            this.lblArms.TabIndex = 3;
            this.lblArms.Text = "Arms";
            this.lblArms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegs
            // 
            this.lblLegs.BackColor = System.Drawing.Color.SandyBrown;
            this.lblLegs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLegs.Location = new System.Drawing.Point(283, 202);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(266, 40);
            this.lblLegs.TabIndex = 4;
            this.lblLegs.Text = "legs";
            this.lblLegs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShoulders
            // 
            this.lblShoulders.BackColor = System.Drawing.Color.SandyBrown;
            this.lblShoulders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShoulders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoulders.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblShoulders.Location = new System.Drawing.Point(283, 241);
            this.lblShoulders.Name = "lblShoulders";
            this.lblShoulders.Size = new System.Drawing.Size(266, 40);
            this.lblShoulders.TabIndex = 5;
            this.lblShoulders.Text = "Shoulders";
            this.lblShoulders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.SandyBrown;
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBack.Location = new System.Drawing.Point(283, 279);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(266, 40);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardio
            // 
            this.lblCardio.BackColor = System.Drawing.Color.SandyBrown;
            this.lblCardio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCardio.Location = new System.Drawing.Point(283, 318);
            this.lblCardio.Name = "lblCardio";
            this.lblCardio.Size = new System.Drawing.Size(266, 40);
            this.lblCardio.TabIndex = 7;
            this.lblCardio.Text = "Cardio";
            this.lblCardio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStretch
            // 
            this.lblStretch.BackColor = System.Drawing.Color.SandyBrown;
            this.lblStretch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStretch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStretch.Location = new System.Drawing.Point(283, 358);
            this.lblStretch.Name = "lblStretch";
            this.lblStretch.Size = new System.Drawing.Size(266, 40);
            this.lblStretch.TabIndex = 8;
            this.lblStretch.Text = "Stretch";
            this.lblStretch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 606);
            this.Controls.Add(this.lblStretch);
            this.Controls.Add(this.lblCardio);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblShoulders);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblArms);
            this.Controls.Add(this.lblChest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

