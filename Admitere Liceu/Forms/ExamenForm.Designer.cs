
namespace Admitere_Liceu.Forms
{
    partial class ExamenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNotaMate = new System.Windows.Forms.TextBox();
            this.tbNotaRomana = new System.Windows.Forms.TextBox();
            this.btnAdaugareExamen = new System.Windows.Forms.Button();
            this.btnEditExamen = new System.Windows.Forms.Button();
            this.btnNextToElev = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMedieExamen = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti notele de la examenul national ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota de la matematica :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota de la limba si literatura romana :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNotaMate
            // 
            this.tbNotaMate.Location = new System.Drawing.Point(348, 163);
            this.tbNotaMate.Name = "tbNotaMate";
            this.tbNotaMate.Size = new System.Drawing.Size(100, 22);
            this.tbNotaMate.TabIndex = 3;
            this.tbNotaMate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotaMate_KeyPress);
            this.tbNotaMate.Validating += new System.ComponentModel.CancelEventHandler(this.tbNotaMate_Validating);
            this.tbNotaMate.Validated += new System.EventHandler(this.tbNotaMate_Validated);
            // 
            // tbNotaRomana
            // 
            this.tbNotaRomana.Location = new System.Drawing.Point(348, 268);
            this.tbNotaRomana.Name = "tbNotaRomana";
            this.tbNotaRomana.Size = new System.Drawing.Size(100, 22);
            this.tbNotaRomana.TabIndex = 4;
            this.tbNotaRomana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotaRomana_KeyPress);
            this.tbNotaRomana.Validating += new System.ComponentModel.CancelEventHandler(this.tbNotaRomana_Validating);
            this.tbNotaRomana.Validated += new System.EventHandler(this.tbNotaRomana_Validated);
            // 
            // btnAdaugareExamen
            // 
            this.btnAdaugareExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdaugareExamen.BackColor = System.Drawing.Color.Orange;
            this.btnAdaugareExamen.Location = new System.Drawing.Point(48, 364);
            this.btnAdaugareExamen.Name = "btnAdaugareExamen";
            this.btnAdaugareExamen.Size = new System.Drawing.Size(128, 47);
            this.btnAdaugareExamen.TabIndex = 8;
            this.btnAdaugareExamen.Text = "Adauga notele examenului";
            this.btnAdaugareExamen.UseVisualStyleBackColor = false;
            this.btnAdaugareExamen.Click += new System.EventHandler(this.btnAdaugareExamen_Click);
            // 
            // btnEditExamen
            // 
            this.btnEditExamen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditExamen.BackColor = System.Drawing.Color.Orange;
            this.btnEditExamen.Location = new System.Drawing.Point(249, 364);
            this.btnEditExamen.Name = "btnEditExamen";
            this.btnEditExamen.Size = new System.Drawing.Size(128, 47);
            this.btnEditExamen.TabIndex = 9;
            this.btnEditExamen.Text = "Editeaza notele examenului";
            this.btnEditExamen.UseVisualStyleBackColor = false;
            this.btnEditExamen.Click += new System.EventHandler(this.btnEditExamen_Click);
            // 
            // btnNextToElev
            // 
            this.btnNextToElev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextToElev.BackColor = System.Drawing.Color.Orange;
            this.btnNextToElev.Location = new System.Drawing.Point(515, 364);
            this.btnNextToElev.Name = "btnNextToElev";
            this.btnNextToElev.Size = new System.Drawing.Size(128, 47);
            this.btnNextToElev.TabIndex = 14;
            this.btnNextToElev.Text = "Next";
            this.btnNextToElev.UseVisualStyleBackColor = false;
            this.btnNextToElev.Click += new System.EventHandler(this.btnNextToExamen_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 53);
            this.label4.TabIndex = 15;
            this.label4.Text = "Media examenului national :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMedieExamen
            // 
            this.tbMedieExamen.Location = new System.Drawing.Point(573, 220);
            this.tbMedieExamen.Name = "tbMedieExamen";
            this.tbMedieExamen.ReadOnly = true;
            this.tbMedieExamen.Size = new System.Drawing.Size(100, 22);
            this.tbMedieExamen.TabIndex = 16;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ExamenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMedieExamen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNextToElev);
            this.Controls.Add(this.btnEditExamen);
            this.Controls.Add(this.btnAdaugareExamen);
            this.Controls.Add(this.tbNotaRomana);
            this.Controls.Add(this.tbNotaMate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ExamenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Examen Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotaMate;
        private System.Windows.Forms.TextBox tbNotaRomana;
        private System.Windows.Forms.Button btnAdaugareExamen;
        private System.Windows.Forms.Button btnEditExamen;
        private System.Windows.Forms.Button btnNextToElev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMedieExamen;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}