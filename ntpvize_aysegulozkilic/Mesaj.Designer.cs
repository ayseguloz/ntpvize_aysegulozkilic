
namespace ntpvize_aysegulozkilic
{
    partial class Mesaj
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerkapat = new System.Windows.Forms.Timer(this.components);
            this.labelbaslik = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.labelbaslik);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Son Haber";
            // 
            // timerkapat
            // 
            this.timerkapat.Enabled = true;
            this.timerkapat.Interval = 4000;
            this.timerkapat.Tick += new System.EventHandler(this.timerkapat_Tick);
            // 
            // labelbaslik
            // 
            this.labelbaslik.AutoSize = true;
            this.labelbaslik.Location = new System.Drawing.Point(23, 36);
            this.labelbaslik.Name = "labelbaslik";
            this.labelbaslik.Size = new System.Drawing.Size(46, 17);
            this.labelbaslik.TabIndex = 0;
            this.labelbaslik.Text = "label1";
            // 
            // Mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mesaj";
            this.Text = "Mesaj";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerkapat;
        private System.Windows.Forms.Label labelbaslik;
    }
}