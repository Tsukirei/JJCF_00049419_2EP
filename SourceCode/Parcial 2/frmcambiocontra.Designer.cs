using System.ComponentModel;

namespace Parcial_2
{
    partial class frmcambiocontra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcambiocontra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textnueva = new System.Windows.Forms.TextBox();
            this.textnuevacon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbuser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textcontra
            // 
            this.textcontra.Location = new System.Drawing.Point(370, 155);
            this.textcontra.Name = "textcontra";
            this.textcontra.Size = new System.Drawing.Size(250, 20);
            this.textcontra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(370, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña actual:";
            // 
            // textnueva
            // 
            this.textnueva.Location = new System.Drawing.Point(370, 207);
            this.textnueva.Name = "textnueva";
            this.textnueva.Size = new System.Drawing.Size(250, 20);
            this.textnueva.TabIndex = 1;
            // 
            // textnuevacon
            // 
            this.textnuevacon.Location = new System.Drawing.Point(370, 259);
            this.textnuevacon.Name = "textnuevacon";
            this.textnuevacon.Size = new System.Drawing.Size(250, 20);
            this.textnuevacon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(370, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva contraseña:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(370, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar nueva contraseña:";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(332, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cambiar contraseña";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbuser
            // 
            this.cmbuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbuser.FormattingEnabled = true;
            this.cmbuser.Location = new System.Drawing.Point(370, 102);
            this.cmbuser.Name = "cmbuser";
            this.cmbuser.Size = new System.Drawing.Size(250, 21);
            this.cmbuser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(370, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario:\r\n";
            // 
            // bttncancelar
            // 
            this.bttncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttncancelar.BackColor = System.Drawing.Color.BlueViolet;
            this.bttncancelar.Location = new System.Drawing.Point(529, 302);
            this.bttncancelar.Name = "bttncancelar";
            this.bttncancelar.Size = new System.Drawing.Size(149, 50);
            this.bttncancelar.TabIndex = 5;
            this.bttncancelar.Text = "Cancelar";
            this.bttncancelar.UseVisualStyleBackColor = false;
            this.bttncancelar.Click += new System.EventHandler(this.bttncancelar_Click);
            // 
            // frmcambiocontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttncancelar);
            this.Controls.Add(this.cmbuser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textnuevacon);
            this.Controls.Add(this.textnueva);
            this.Controls.Add(this.textcontra);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmcambiocontra";
            this.Text = "frmcambiocontra";
            this.Load += new System.EventHandler(this.frmcambiocontra_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bttncancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textcontra;
        private System.Windows.Forms.TextBox textnueva;
        private System.Windows.Forms.TextBox textnuevacon;

        #endregion
    }
}