
namespace Admitere_Liceu.Forms
{
    partial class EditLiceu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeLiceu = new System.Windows.Forms.TextBox();
            this.tbMedieLiceu = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numele liceului :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Media liceului :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profilul :";
            // 
            // tbNumeLiceu
            // 
            this.tbNumeLiceu.Location = new System.Drawing.Point(212, 33);
            this.tbNumeLiceu.Name = "tbNumeLiceu";
            this.tbNumeLiceu.Size = new System.Drawing.Size(190, 22);
            this.tbNumeLiceu.TabIndex = 3;
            this.tbNumeLiceu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeLiceu_KeyPress);
            // 
            // tbMedieLiceu
            // 
            this.tbMedieLiceu.Location = new System.Drawing.Point(212, 89);
            this.tbMedieLiceu.Name = "tbMedieLiceu";
            this.tbMedieLiceu.Size = new System.Drawing.Size(190, 22);
            this.tbMedieLiceu.TabIndex = 4;
            this.tbMedieLiceu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMedieLiceu_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Orange;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(88, 244);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 47);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 47);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Specializarea :";
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Location = new System.Drawing.Point(212, 144);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(194, 24);
            this.comboBoxProfil.TabIndex = 16;
            this.comboBoxProfil.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProfil_SelectionChangeCommitted);
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Location = new System.Drawing.Point(212, 195);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(194, 24);
            this.comboBoxSpecializare.TabIndex = 17;
            // 
            // EditLiceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(451, 322);
            this.Controls.Add(this.comboBoxSpecializare);
            this.Controls.Add(this.comboBoxProfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbMedieLiceu);
            this.Controls.Add(this.tbNumeLiceu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLiceu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Liceu";
            this.Load += new System.EventHandler(this.EditLiceu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeLiceu;
        private System.Windows.Forms.TextBox tbMedieLiceu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
    }
}