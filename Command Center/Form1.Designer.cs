namespace Command_Center
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CPU = new MetroFramework.Controls.MetroProgressBar();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.RAM = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CPU
            // 
            this.CPU.Location = new System.Drawing.Point(50, 108);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(190, 110);
            this.CPU.TabIndex = 0;
            // 
            // Clock
            // 
            this.Clock.Interval = 500;
            this.Clock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAM
            // 
            this.RAM.Location = new System.Drawing.Point(257, 329);
            this.RAM.Maximum = 100;
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(121, 118);
            this.RAM.TabIndex = 1;
            this.RAM.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(368, 190);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(77, 37);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.CPU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar CPU;
        private System.Windows.Forms.Timer Clock;
        private MetroFramework.Controls.MetroProgressSpinner RAM;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

