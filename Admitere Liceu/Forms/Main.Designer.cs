
namespace Admitere_Liceu
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipuriDeSerializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInscriere = new System.Windows.Forms.Button();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.btnVisualizeElevi = new System.Windows.Forms.Button();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPageToolStripMenuItem,
            this.tipuriDeSerializareToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutPageToolStripMenuItem
            // 
            this.aboutPageToolStripMenuItem.Name = "aboutPageToolStripMenuItem";
            this.aboutPageToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.aboutPageToolStripMenuItem.Text = "About page";
            // 
            // tipuriDeSerializareToolStripMenuItem
            // 
            this.tipuriDeSerializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.tipuriDeSerializareToolStripMenuItem.Name = "tipuriDeSerializareToolStripMenuItem";
            this.tipuriDeSerializareToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.tipuriDeSerializareToolStripMenuItem.Text = "Tipuri de serializare";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.binarToolStripMenuItem.Text = "Binar";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareBinary);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareBinary);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem1,
            this.deserializareToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializareToolStripMenuItem1
            // 
            this.serializareToolStripMenuItem1.Name = "serializareToolStripMenuItem1";
            this.serializareToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.serializareToolStripMenuItem1.Text = "Serializare";
            this.serializareToolStripMenuItem1.Click += new System.EventHandler(this.serializareXML);
            // 
            // deserializareToolStripMenuItem1
            // 
            this.deserializareToolStripMenuItem1.Name = "deserializareToolStripMenuItem1";
            this.deserializareToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.deserializareToolStripMenuItem1.Text = "Deserializare";
            this.deserializareToolStripMenuItem1.Click += new System.EventHandler(this.deserializareXML);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem2,
            this.deserializareToolStripMenuItem2});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // serializareToolStripMenuItem2
            // 
            this.serializareToolStripMenuItem2.Name = "serializareToolStripMenuItem2";
            this.serializareToolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
            this.serializareToolStripMenuItem2.Text = "Serializare";
            this.serializareToolStripMenuItem2.Click += new System.EventHandler(this.serializareJSON);
            // 
            // deserializareToolStripMenuItem2
            // 
            this.deserializareToolStripMenuItem2.Name = "deserializareToolStripMenuItem2";
            this.deserializareToolStripMenuItem2.Size = new System.Drawing.Size(178, 26);
            this.deserializareToolStripMenuItem2.Text = "Deserializare";
            this.deserializareToolStripMenuItem2.Click += new System.EventHandler(this.deserializareJSON);
            // 
            // btnInscriere
            // 
            this.btnInscriere.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInscriere.Location = new System.Drawing.Point(95, 223);
            this.btnInscriere.Name = "btnInscriere";
            this.btnInscriere.Size = new System.Drawing.Size(119, 71);
            this.btnInscriere.TabIndex = 1;
            this.btnInscriere.Text = "Adaugare Elev";
            this.btnInscriere.UseVisualStyleBackColor = true;
            this.btnInscriere.Click += new System.EventHandler(this.btnInscriere_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.Transparent;
            this.label_Welcome.Location = new System.Drawing.Point(88, 78);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(379, 71);
            this.label_Welcome.TabIndex = 2;
            this.label_Welcome.Text = "Admitere liceu";
            this.label_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVisualizeElevi
            // 
            this.btnVisualizeElevi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVisualizeElevi.Location = new System.Drawing.Point(348, 223);
            this.btnVisualizeElevi.Name = "btnVisualizeElevi";
            this.btnVisualizeElevi.Size = new System.Drawing.Size(119, 71);
            this.btnVisualizeElevi.TabIndex = 3;
            this.btnVisualizeElevi.Text = "Vizualizare elevi (Data binding)";
            this.btnVisualizeElevi.UseVisualStyleBackColor = true;
            this.btnVisualizeElevi.Click += new System.EventHandler(this.btnVisualizeElevi_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(553, 429);
            this.Controls.Add(this.btnVisualizeElevi);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.btnInscriere);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admitere Liceu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipuriDeSerializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem2;
        private System.Windows.Forms.Button btnInscriere;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Button btnVisualizeElevi;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

