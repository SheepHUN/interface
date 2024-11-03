
namespace @interface
{
    partial class Form2
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
            this.carroad = new System.Windows.Forms.PictureBox();
            this.trainroad = new System.Windows.Forms.PictureBox();
            this.carspawn = new System.Windows.Forms.PictureBox();
            this.trainspawner = new System.Windows.Forms.PictureBox();
            this.crossingbtn = new Guna.UI2.WinForms.Guna2Button();
            this.crossing = new System.Windows.Forms.PictureBox();
            this.pointslabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainroad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carspawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainspawner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossing)).BeginInit();
            this.SuspendLayout();
            // 
            // carroad
            // 
            this.carroad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.carroad.Location = new System.Drawing.Point(-3, 156);
            this.carroad.Name = "carroad";
            this.carroad.Size = new System.Drawing.Size(492, 50);
            this.carroad.TabIndex = 0;
            this.carroad.TabStop = false;
            // 
            // trainroad
            // 
            this.trainroad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.trainroad.Location = new System.Drawing.Point(216, -5);
            this.trainroad.Name = "trainroad";
            this.trainroad.Size = new System.Drawing.Size(63, 587);
            this.trainroad.TabIndex = 1;
            this.trainroad.TabStop = false;
            // 
            // carspawn
            // 
            this.carspawn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.carspawn.Location = new System.Drawing.Point(-29, 166);
            this.carspawn.Name = "carspawn";
            this.carspawn.Size = new System.Drawing.Size(58, 30);
            this.carspawn.TabIndex = 2;
            this.carspawn.TabStop = false;
            // 
            // trainspawner
            // 
            this.trainspawner.BackColor = System.Drawing.Color.Yellow;
            this.trainspawner.Location = new System.Drawing.Point(229, 588);
            this.trainspawner.Name = "trainspawner";
            this.trainspawner.Size = new System.Drawing.Size(35, 141);
            this.trainspawner.TabIndex = 3;
            this.trainspawner.TabStop = false;
            // 
            // crossingbtn
            // 
            this.crossingbtn.Animated = true;
            this.crossingbtn.BorderRadius = 20;
            this.crossingbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.crossingbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.crossingbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.crossingbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.crossingbtn.FillColor = System.Drawing.Color.Red;
            this.crossingbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.crossingbtn.ForeColor = System.Drawing.Color.White;
            this.crossingbtn.Location = new System.Drawing.Point(294, 312);
            this.crossingbtn.Name = "crossingbtn";
            this.crossingbtn.Size = new System.Drawing.Size(180, 45);
            this.crossingbtn.TabIndex = 4;
            this.crossingbtn.Text = "Sorompó lezárás";
            // 
            // crossing
            // 
            this.crossing.BackColor = System.Drawing.Color.Red;
            this.crossing.Location = new System.Drawing.Point(199, 71);
            this.crossing.Name = "crossing";
            this.crossing.Size = new System.Drawing.Size(11, 79);
            this.crossing.TabIndex = 5;
            this.crossing.TabStop = false;
            // 
            // pointslabel
            // 
            this.pointslabel.AutoSize = true;
            this.pointslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointslabel.Location = new System.Drawing.Point(12, 9);
            this.pointslabel.Name = "pointslabel";
            this.pointslabel.Size = new System.Drawing.Size(81, 24);
            this.pointslabel.TabIndex = 6;
            this.pointslabel.Text = "Points: 0";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(486, 572);
            this.Controls.Add(this.pointslabel);
            this.Controls.Add(this.crossing);
            this.Controls.Add(this.crossingbtn);
            this.Controls.Add(this.trainspawner);
            this.Controls.Add(this.carspawn);
            this.Controls.Add(this.trainroad);
            this.Controls.Add(this.carroad);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.carroad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainroad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carspawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainspawner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carspawner;
        private System.Windows.Forms.PictureBox carroad;
        private System.Windows.Forms.PictureBox trainroad;
        private System.Windows.Forms.PictureBox carspawn;
        private System.Windows.Forms.PictureBox trainspawner;
        private Guna.UI2.WinForms.Guna2Button crossingbtn;
        private System.Windows.Forms.PictureBox crossing;
        private System.Windows.Forms.Label pointslabel;
    }
}
