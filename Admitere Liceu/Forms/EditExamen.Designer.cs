
namespace Admitere_Liceu.Forms
{
    partial class EditExamen
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
            this.tbNotaRomana = new System.Windows.Forms.TextBox();
            this.tbNotaMate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNotaRomana
            // 
            this.tbNotaRomana.Location = new System.Drawing.Point(352, 269);
            this.tbNotaRomana.Name = "tbNotaRomana";
            this.tbNotaRomana.Size = new System.Drawing.Size(100, 23);
            this.tbNotaRomana.TabIndex = 8;
            this.tbNotaRomana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotaRomana_KeyPress);
            this.tbNotaRomana.Validating += new System.ComponentModel.CancelEventHandler(this.tbNotaRomana_Validating);
            this.tbNotaRomana.Validated += new System.EventHandler(this.tbNotaRomana_Validated);
            // 
            // tbNotaMate
            // 
            this.tbNotaMate.Location = new System.Drawing.Point(352, 164);
            this.tbNotaMate.Name = "tbNotaMate";
            this.tbNotaMate.Size = new System.Drawing.Size(100, 23);
            this.tbNotaMate.TabIndex = 7;
            this.tbNotaMate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotaMate_KeyPress);
            this.tbNotaMate.Validating += new System.ComponentModel.CancelEventHandler(this.tbNotaMate_Validating);
            this.tbNotaMate.Validated += new System.EventHandler(this.tbNotaMate_Validated);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota de la limba si literatura romana :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 53);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota de la matematica :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(313, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 47);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Orange;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(128, 347);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 47);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(175, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "Editeaza notele examenului";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(541, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbNotaRomana);
            this.Controls.Add(this.tbNotaMate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "EditExamen";
            this.Text = "EditExamen";
            this.Load += new System.EventHandler(this.EditExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNotaRomana;
        private System.Windows.Forms.TextBox tbNotaMate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}