
namespace Admitere_Liceu.Forms
{
    partial class EditElev
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbMedieSc = new System.Windows.Forms.TextBox();
            this.tbSexElev = new System.Windows.Forms.TextBox();
            this.tbAdresaElev = new System.Windows.Forms.TextBox();
            this.tbPrenumeElev = new System.Windows.Forms.TextBox();
            this.tbNumeElev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(92, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data nasterii  :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDataNasterii
            // 
            this.tbDataNasterii.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataNasterii.Location = new System.Drawing.Point(373, 307);
            this.tbDataNasterii.Name = "tbDataNasterii";
            this.tbDataNasterii.Size = new System.Drawing.Size(319, 23);
            this.tbDataNasterii.TabIndex = 27;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(498, 236);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(194, 23);
            this.tbCNP.TabIndex = 26;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNP_KeyPress);
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            this.tbCNP.Validated += new System.EventHandler(this.tbCNP_Validated);
            // 
            // tbMedieSc
            // 
            this.tbMedieSc.Location = new System.Drawing.Point(587, 167);
            this.tbMedieSc.Name = "tbMedieSc";
            this.tbMedieSc.Size = new System.Drawing.Size(105, 23);
            this.tbMedieSc.TabIndex = 25;
            this.tbMedieSc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMedieSc_KeyPress);
            this.tbMedieSc.Validating += new System.ComponentModel.CancelEventHandler(this.tbMedieSc_Validating);
            this.tbMedieSc.Validated += new System.EventHandler(this.tbMedieSc_Validated);
            // 
            // tbSexElev
            // 
            this.tbSexElev.Location = new System.Drawing.Point(587, 106);
            this.tbSexElev.Name = "tbSexElev";
            this.tbSexElev.Size = new System.Drawing.Size(105, 23);
            this.tbSexElev.TabIndex = 24;
            // 
            // tbAdresaElev
            // 
            this.tbAdresaElev.Location = new System.Drawing.Point(211, 233);
            this.tbAdresaElev.Name = "tbAdresaElev";
            this.tbAdresaElev.Size = new System.Drawing.Size(155, 23);
            this.tbAdresaElev.TabIndex = 23;
            // 
            // tbPrenumeElev
            // 
            this.tbPrenumeElev.Location = new System.Drawing.Point(211, 167);
            this.tbPrenumeElev.Name = "tbPrenumeElev";
            this.tbPrenumeElev.Size = new System.Drawing.Size(155, 23);
            this.tbPrenumeElev.TabIndex = 22;
            this.tbPrenumeElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrenumeElev_KeyPress);
            this.tbPrenumeElev.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenumeElev_Validating);
            this.tbPrenumeElev.Validated += new System.EventHandler(this.tbPrenumeElev_Validated);
            // 
            // tbNumeElev
            // 
            this.tbNumeElev.Location = new System.Drawing.Point(211, 106);
            this.tbNumeElev.Name = "tbNumeElev";
            this.tbNumeElev.Size = new System.Drawing.Size(155, 23);
            this.tbNumeElev.TabIndex = 21;
            this.tbNumeElev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeElev_KeyPress);
            this.tbNumeElev.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeElev_Validating);
            this.tbNumeElev.Validated += new System.EventHandler(this.tbNumeElev_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "CNP :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Media pe anii 5-8 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Adresa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prenume :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nume :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(425, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 47);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Orange;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(240, 383);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 47);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditElev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(778, 478);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
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
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "EditElev";
            this.Text = "EditElev";
            this.Load += new System.EventHandler(this.EditElev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tbDataNasterii;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbMedieSc;
        private System.Windows.Forms.TextBox tbSexElev;
        private System.Windows.Forms.TextBox tbAdresaElev;
        private System.Windows.Forms.TextBox tbPrenumeElev;
        private System.Windows.Forms.TextBox tbNumeElev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}