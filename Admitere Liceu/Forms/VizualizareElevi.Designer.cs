﻿
namespace Admitere_Liceu.Forms
{
    partial class VizualizareElevi
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
            this.dgvElevi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElevi
            // 
            this.dgvElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElevi.Location = new System.Drawing.Point(12, 83);
            this.dgvElevi.Name = "dgvElevi";
            this.dgvElevi.RowHeadersWidth = 51;
            this.dgvElevi.RowTemplate.Height = 24;
            this.dgvElevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElevi.Size = new System.Drawing.Size(776, 344);
            this.dgvElevi.TabIndex = 0;
            this.dgvElevi.DoubleClick += new System.EventHandler(this.dgvElevi_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vizualizare elevi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VizualizareElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvElevi);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "VizualizareElevi";
            this.Text = "VizualizareElevi";
            this.Load += new System.EventHandler(this.VizualizareElevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElevi;
        private System.Windows.Forms.Label label1;
    }
}