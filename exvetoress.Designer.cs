namespace exvetores
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular média:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(695, 444);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(227, 20);
            this.txtmedia.TabIndex = 4;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(695, 239);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(227, 20);
            this.txtnota.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 76);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registrar notas:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Button button2;
    }
}