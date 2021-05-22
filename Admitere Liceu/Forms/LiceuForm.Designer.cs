
namespace Admitere_Liceu.Forms
{
    partial class LiceuForm
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
            this.lbNumeLiceu = new System.Windows.Forms.Label();
            this.lbMedieLiceu = new System.Windows.Forms.Label();
            this.lbSpecializare = new System.Windows.Forms.Label();
            this.tbNumeLiceu = new System.Windows.Forms.TextBox();
            this.tbMedieLiceu = new System.Windows.Forms.TextBox();
            this.btnAdaugareLiceu = new System.Windows.Forms.Button();
            this.lvHighschools = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditLiceu = new System.Windows.Forms.Button();
            this.btnDeleteLiceu = new System.Windows.Forms.Button();
            this.btnNextToExamen = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti liceele la care doriti sa aplicati";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumeLiceu
            // 
            this.lbNumeLiceu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeLiceu.Location = new System.Drawing.Point(12, 120);
            this.lbNumeLiceu.Name = "lbNumeLiceu";
            this.lbNumeLiceu.Size = new System.Drawing.Size(220, 39);
            this.lbNumeLiceu.TabIndex = 1;
            this.lbNumeLiceu.Text = "Numele liceului :";
            this.lbNumeLiceu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMedieLiceu
            // 
            this.lbMedieLiceu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedieLiceu.Location = new System.Drawing.Point(12, 218);
            this.lbMedieLiceu.Name = "lbMedieLiceu";
            this.lbMedieLiceu.Size = new System.Drawing.Size(220, 48);
            this.lbMedieLiceu.TabIndex = 2;
            this.lbMedieLiceu.Text = "Media liceului din ultimul an :";
            this.lbMedieLiceu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSpecializare
            // 
            this.lbSpecializare.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecializare.Location = new System.Drawing.Point(12, 386);
            this.lbSpecializare.Name = "lbSpecializare";
            this.lbSpecializare.Size = new System.Drawing.Size(220, 48);
            this.lbSpecializare.TabIndex = 3;
            this.lbSpecializare.Text = "Specializarea :";
            this.lbSpecializare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNumeLiceu
            // 
            this.tbNumeLiceu.Location = new System.Drawing.Point(238, 130);
            this.tbNumeLiceu.Name = "tbNumeLiceu";
            this.tbNumeLiceu.Size = new System.Drawing.Size(194, 23);
            this.tbNumeLiceu.TabIndex = 4;
            this.tbNumeLiceu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeLiceu_KeyPress);
            // 
            // tbMedieLiceu
            // 
            this.tbMedieLiceu.Location = new System.Drawing.Point(238, 233);
            this.tbMedieLiceu.Name = "tbMedieLiceu";
            this.tbMedieLiceu.Size = new System.Drawing.Size(194, 23);
            this.tbMedieLiceu.TabIndex = 5;
            this.tbMedieLiceu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMedieLiceu_KeyPress);
            this.tbMedieLiceu.Validating += new System.ComponentModel.CancelEventHandler(this.tbMedieLiceu_Validating);
            this.tbMedieLiceu.Validated += new System.EventHandler(this.tbMedieLiceu_Validated);
            // 
            // btnAdaugareLiceu
            // 
            this.btnAdaugareLiceu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdaugareLiceu.BackColor = System.Drawing.Color.Orange;
            this.btnAdaugareLiceu.Location = new System.Drawing.Point(56, 484);
            this.btnAdaugareLiceu.Name = "btnAdaugareLiceu";
            this.btnAdaugareLiceu.Size = new System.Drawing.Size(128, 47);
            this.btnAdaugareLiceu.TabIndex = 7;
            this.btnAdaugareLiceu.Text = "Adauga liceul";
            this.btnAdaugareLiceu.UseVisualStyleBackColor = false;
            this.btnAdaugareLiceu.Click += new System.EventHandler(this.btnAdaugareLiceu_Click);
            // 
            // lvHighschools
            // 
            this.lvHighschools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHighschools.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHighschools.GridLines = true;
            this.lvHighschools.HideSelection = false;
            this.lvHighschools.Location = new System.Drawing.Point(505, 120);
            this.lvHighschools.Name = "lvHighschools";
            this.lvHighschools.Size = new System.Drawing.Size(601, 326);
            this.lvHighschools.TabIndex = 8;
            this.lvHighschools.UseCompatibleStateImageBehavior = false;
            this.lvHighschools.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume Liceu";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Medie liceu";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Specializare";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vizualizare licee :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditLiceu
            // 
            this.btnEditLiceu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditLiceu.BackColor = System.Drawing.Color.Orange;
            this.btnEditLiceu.Location = new System.Drawing.Point(200, 484);
            this.btnEditLiceu.Name = "btnEditLiceu";
            this.btnEditLiceu.Size = new System.Drawing.Size(128, 47);
            this.btnEditLiceu.TabIndex = 11;
            this.btnEditLiceu.Text = "Editeaza liceul";
            this.btnEditLiceu.UseVisualStyleBackColor = false;
            this.btnEditLiceu.Click += new System.EventHandler(this.btnEditLiceu_Click);
            // 
            // btnDeleteLiceu
            // 
            this.btnDeleteLiceu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteLiceu.BackColor = System.Drawing.Color.Orange;
            this.btnDeleteLiceu.Location = new System.Drawing.Point(345, 484);
            this.btnDeleteLiceu.Name = "btnDeleteLiceu";
            this.btnDeleteLiceu.Size = new System.Drawing.Size(128, 47);
            this.btnDeleteLiceu.TabIndex = 12;
            this.btnDeleteLiceu.Text = "Sterge liceul";
            this.btnDeleteLiceu.UseVisualStyleBackColor = false;
            this.btnDeleteLiceu.Click += new System.EventHandler(this.btnDeleteLiceu_Click);
            // 
            // btnNextToExamen
            // 
            this.btnNextToExamen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextToExamen.BackColor = System.Drawing.Color.Orange;
            this.btnNextToExamen.Location = new System.Drawing.Point(770, 484);
            this.btnNextToExamen.Name = "btnNextToExamen";
            this.btnNextToExamen.Size = new System.Drawing.Size(128, 47);
            this.btnNextToExamen.TabIndex = 13;
            this.btnNextToExamen.Text = "Next";
            this.btnNextToExamen.UseVisualStyleBackColor = false;
            this.btnNextToExamen.Click += new System.EventHandler(this.btnNextToExamen_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "Profilul :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Location = new System.Drawing.Point(238, 317);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(194, 25);
            this.comboBoxProfil.TabIndex = 15;
            this.comboBoxProfil.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProfil_SelectionChangeCommitted);
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Location = new System.Drawing.Point(238, 401);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(194, 25);
            this.comboBoxSpecializare.TabIndex = 16;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Profil";
            this.columnHeader4.Width = 150;
            // 
            // LiceuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1180, 568);
            this.Controls.Add(this.comboBoxSpecializare);
            this.Controls.Add(this.comboBoxProfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNextToExamen);
            this.Controls.Add(this.btnDeleteLiceu);
            this.Controls.Add(this.btnEditLiceu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvHighschools);
            this.Controls.Add(this.btnAdaugareLiceu);
            this.Controls.Add(this.tbMedieLiceu);
            this.Controls.Add(this.tbNumeLiceu);
            this.Controls.Add(this.lbSpecializare);
            this.Controls.Add(this.lbMedieLiceu);
            this.Controls.Add(this.lbNumeLiceu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "LiceuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liceu";
            this.Load += new System.EventHandler(this.LiceuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumeLiceu;
        private System.Windows.Forms.Label lbMedieLiceu;
        private System.Windows.Forms.Label lbSpecializare;
        private System.Windows.Forms.TextBox tbNumeLiceu;
        private System.Windows.Forms.TextBox tbMedieLiceu;
        private System.Windows.Forms.Button btnAdaugareLiceu;
        private System.Windows.Forms.ListView lvHighschools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEditLiceu;
        private System.Windows.Forms.Button btnDeleteLiceu;
        private System.Windows.Forms.Button btnNextToExamen;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}