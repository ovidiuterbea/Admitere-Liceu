
namespace Admitere_Liceu.Forms
{
    partial class ElevForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumeElev = new System.Windows.Forms.TextBox();
            this.tbPrenumeElev = new System.Windows.Forms.TextBox();
            this.tbAdresaElev = new System.Windows.Forms.TextBox();
            this.tbSexElev = new System.Windows.Forms.TextBox();
            this.tbMedieSc = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditElev = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(189, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti datele elevului :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenume :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Media pe anii 5-8 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "CNP :";
            // 
            // tbNumeElev
            // 
            this.tbNumeElev.Location = new System.Drawing.Point(193, 128);
            this.tbNumeElev.Name = "tbNumeElev";
            this.tbNumeElev.Size = new System.Drawing.Size(155, 28);
            this.tbNumeElev.TabIndex = 7;
            this.tbNumeElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeElev_KeyPress);
            this.tbNumeElev.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeElev_Validating);
            this.tbNumeElev.Validated += new System.EventHandler(this.tbNumeElev_Validated);
            // 
            // tbPrenumeElev
            // 
            this.tbPrenumeElev.Location = new System.Drawing.Point(193, 185);
            this.tbPrenumeElev.Name = "tbPrenumeElev";
            this.tbPrenumeElev.Size = new System.Drawing.Size(155, 28);
            this.tbPrenumeElev.TabIndex = 8;
            this.tbPrenumeElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrenumeElev_KeyPress);
            this.tbPrenumeElev.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenumeElev_Validating);
            this.tbPrenumeElev.Validated += new System.EventHandler(this.tbPrenumeElev_Validated);
            // 
            // tbAdresaElev
            // 
            this.tbAdresaElev.Location = new System.Drawing.Point(193, 247);
            this.tbAdresaElev.Name = "tbAdresaElev";
            this.tbAdresaElev.Size = new System.Drawing.Size(155, 28);
            this.tbAdresaElev.TabIndex = 9;
            // 
            // tbSexElev
            // 
            this.tbSexElev.Location = new System.Drawing.Point(569, 128);
            this.tbSexElev.Name = "tbSexElev";
            this.tbSexElev.Size = new System.Drawing.Size(105, 28);
            this.tbSexElev.TabIndex = 10;
            // 
            // tbMedieSc
            // 
            this.tbMedieSc.Location = new System.Drawing.Point(569, 185);
            this.tbMedieSc.Name = "tbMedieSc";
            this.tbMedieSc.Size = new System.Drawing.Size(105, 28);
            this.tbMedieSc.TabIndex = 11;
            this.tbMedieSc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMedieSc_KeyPress);
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(480, 250);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(194, 28);
            this.tbCNP.TabIndex = 12;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNP_KeyPress);
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            this.tbCNP.Validated += new System.EventHandler(this.tbCNP_Validated);
            // 
            // tbDataNasterii
            // 
            this.tbDataNasterii.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataNasterii.Location = new System.Drawing.Point(355, 314);
            this.tbDataNasterii.Name = "tbDataNasterii";
            this.tbDataNasterii.Size = new System.Drawing.Size(319, 28);
            this.tbDataNasterii.TabIndex = 13;
            this.tbDataNasterii.Validating += new System.ComponentModel.CancelEventHandler(this.tbDataNasterii_Validating);
            this.tbDataNasterii.Validated += new System.EventHandler(this.tbDataNasterii_Validated);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(74, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data nasterii  :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditElev
            // 
            this.btnEditElev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditElev.BackColor = System.Drawing.Color.Orange;
            this.btnEditElev.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditElev.Location = new System.Drawing.Point(133, 397);
            this.btnEditElev.Name = "btnEditElev";
            this.btnEditElev.Size = new System.Drawing.Size(160, 47);
            this.btnEditElev.TabIndex = 15;
            this.btnEditElev.Text = "Editeaza datele elevului ";
            this.btnEditElev.UseVisualStyleBackColor = false;
            this.btnEditElev.Click += new System.EventHandler(this.btnEditElev_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.BackColor = System.Drawing.Color.Orange;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(461, 397);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(160, 47);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ElevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(730, 479);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnEditElev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDataNasterii);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbMedieSc);
            this.Controls.Add(this.tbSexElev);
            this.Controls.Add(this.tbAdresaElev);
            this.Controls.Add(this.tbPrenumeElev);
            this.Controls.Add(this.tbNumeElev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ElevForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elev Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumeElev;
        private System.Windows.Forms.TextBox tbPrenumeElev;
        private System.Windows.Forms.TextBox tbAdresaElev;
        private System.Windows.Forms.TextBox tbSexElev;
        private System.Windows.Forms.TextBox tbMedieSc;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.DateTimePicker tbDataNasterii;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditElev;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}