
namespace Admitere_Liceu.Forms
{
    partial class VizualizareEleviSQLite
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
            this.dgvEleviSQLite = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIDDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleviSQLite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEleviSQLite
            // 
            this.dgvEleviSQLite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleviSQLite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvEleviSQLite.Location = new System.Drawing.Point(165, 78);
            this.dgvEleviSQLite.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEleviSQLite.Name = "dgvEleviSQLite";
            this.dgvEleviSQLite.RowHeadersWidth = 51;
            this.dgvEleviSQLite.RowTemplate.Height = 24;
            this.dgvEleviSQLite.Size = new System.Drawing.Size(552, 286);
            this.dgvEleviSQLite.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nume";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenume";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Medie admitere";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(331, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vizualizare elevi din SQLite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "UPDATE ELEVI SET MEDIE =";
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(276, 404);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 28);
            this.tbMedie.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "WHERE ID =";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(515, 402);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(86, 28);
            this.tbID.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.Location = new System.Drawing.Point(664, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "DELETE FROM ELEVI WHERE ID =";
            // 
            // tbIDDelete
            // 
            this.tbIDDelete.Location = new System.Drawing.Point(276, 482);
            this.tbIDDelete.Name = "tbIDDelete";
            this.tbIDDelete.Size = new System.Drawing.Size(100, 28);
            this.tbIDDelete.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.Location = new System.Drawing.Point(402, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VizualizareEleviSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 557);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbIDDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEleviSQLite);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VizualizareEleviSQLite";
            this.Text = "VizualizareEleviSQLite";
            this.Load += new System.EventHandler(this.VizualizareEleviSQLite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleviSQLite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEleviSQLite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIDDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}