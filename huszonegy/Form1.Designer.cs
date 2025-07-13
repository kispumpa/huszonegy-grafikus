namespace Huszonegy
{
    partial class Huszonegy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huszonegy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jatekszabalyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altalanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konnyuJatekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kozepesJatekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nehezJatekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nehézségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konnyuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kozepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nehezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kerekmeg = new System.Windows.Forms.Button();
            this.lbl_kiiras = new System.Windows.Forms.Label();
            this.btn_nemkerek = new System.Windows.Forms.Button();
            this.lbl_nehezseg = new System.Windows.Forms.Label();
            this.lbl_kor = new System.Windows.Forms.Label();
            this.btn_ujjatek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.jatekszabalyToolStripMenuItem,
            this.nehézségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.infoToolStripMenuItem.Text = "A játékról";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // jatekszabalyToolStripMenuItem
            // 
            this.jatekszabalyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altalanosToolStripMenuItem,
            this.konnyuJatekToolStripMenuItem,
            this.kozepesJatekToolStripMenuItem,
            this.nehezJatekToolStripMenuItem});
            this.jatekszabalyToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jatekszabalyToolStripMenuItem.Name = "jatekszabalyToolStripMenuItem";
            this.jatekszabalyToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.jatekszabalyToolStripMenuItem.Text = "Játékszabály";
            // 
            // altalanosToolStripMenuItem
            // 
            this.altalanosToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altalanosToolStripMenuItem.Name = "altalanosToolStripMenuItem";
            this.altalanosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altalanosToolStripMenuItem.Text = "Általános";
            this.altalanosToolStripMenuItem.Click += new System.EventHandler(this.AltalanosToolStripMenuItem_Click);
            // 
            // konnyuJatekToolStripMenuItem
            // 
            this.konnyuJatekToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konnyuJatekToolStripMenuItem.Name = "konnyuJatekToolStripMenuItem";
            this.konnyuJatekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konnyuJatekToolStripMenuItem.Text = "Könnyű játék";
            this.konnyuJatekToolStripMenuItem.Click += new System.EventHandler(this.KonnyuJatekToolStripMenuItem_Click);
            // 
            // kozepesJatekToolStripMenuItem
            // 
            this.kozepesJatekToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kozepesJatekToolStripMenuItem.Name = "kozepesJatekToolStripMenuItem";
            this.kozepesJatekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kozepesJatekToolStripMenuItem.Text = "Közepes játék";
            this.kozepesJatekToolStripMenuItem.Click += new System.EventHandler(this.KozepesJatekToolStripMenuItem_Click);
            // 
            // nehezJatekToolStripMenuItem
            // 
            this.nehezJatekToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nehezJatekToolStripMenuItem.Name = "nehezJatekToolStripMenuItem";
            this.nehezJatekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nehezJatekToolStripMenuItem.Text = "Nehéz játék";
            this.nehezJatekToolStripMenuItem.Click += new System.EventHandler(this.NehezJatekToolStripMenuItem_Click);
            // 
            // nehézségToolStripMenuItem
            // 
            this.nehézségToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konnyuToolStripMenuItem,
            this.kozepesToolStripMenuItem,
            this.nehezToolStripMenuItem});
            this.nehézségToolStripMenuItem.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nehézségToolStripMenuItem.Name = "nehézségToolStripMenuItem";
            this.nehézségToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.nehézségToolStripMenuItem.Text = "Nehézség";
            // 
            // konnyuToolStripMenuItem
            // 
            this.konnyuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konnyuToolStripMenuItem.Name = "konnyuToolStripMenuItem";
            this.konnyuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konnyuToolStripMenuItem.Text = "Könnyű";
            this.konnyuToolStripMenuItem.Click += new System.EventHandler(this.KonnyuToolStripMenuItem_Click);
            // 
            // kozepesToolStripMenuItem
            // 
            this.kozepesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kozepesToolStripMenuItem.Name = "kozepesToolStripMenuItem";
            this.kozepesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kozepesToolStripMenuItem.Text = "Közepes";
            this.kozepesToolStripMenuItem.Click += new System.EventHandler(this.KozepesToolStripMenuItem_Click);
            // 
            // nehezToolStripMenuItem
            // 
            this.nehezToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nehezToolStripMenuItem.Name = "nehezToolStripMenuItem";
            this.nehezToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nehezToolStripMenuItem.Text = "Nehéz";
            this.nehezToolStripMenuItem.Click += new System.EventHandler(this.NehezToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Huszonegy";
            // 
            // btn_kerekmeg
            // 
            this.btn_kerekmeg.Enabled = false;
            this.btn_kerekmeg.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kerekmeg.Location = new System.Drawing.Point(12, 165);
            this.btn_kerekmeg.Name = "btn_kerekmeg";
            this.btn_kerekmeg.Size = new System.Drawing.Size(124, 23);
            this.btn_kerekmeg.TabIndex = 8;
            this.btn_kerekmeg.Text = "Kérek még!";
            this.btn_kerekmeg.UseVisualStyleBackColor = true;
            this.btn_kerekmeg.Click += new System.EventHandler(this.Btn_kerekmeg_Click);
            // 
            // lbl_kiiras
            // 
            this.lbl_kiiras.AutoSize = true;
            this.lbl_kiiras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_kiiras.Location = new System.Drawing.Point(202, 144);
            this.lbl_kiiras.Name = "lbl_kiiras";
            this.lbl_kiiras.Size = new System.Drawing.Size(0, 19);
            this.lbl_kiiras.TabIndex = 9;
            // 
            // btn_nemkerek
            // 
            this.btn_nemkerek.Enabled = false;
            this.btn_nemkerek.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_nemkerek.Location = new System.Drawing.Point(12, 210);
            this.btn_nemkerek.Name = "btn_nemkerek";
            this.btn_nemkerek.Size = new System.Drawing.Size(124, 23);
            this.btn_nemkerek.TabIndex = 10;
            this.btn_nemkerek.Text = "Nem kérek!";
            this.btn_nemkerek.UseVisualStyleBackColor = true;
            this.btn_nemkerek.Click += new System.EventHandler(this.Btn_nemkerek_Click);
            // 
            // lbl_nehezseg
            // 
            this.lbl_nehezseg.AutoSize = true;
            this.lbl_nehezseg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nehezseg.Location = new System.Drawing.Point(279, 45);
            this.lbl_nehezseg.Name = "lbl_nehezseg";
            this.lbl_nehezseg.Size = new System.Drawing.Size(227, 22);
            this.lbl_nehezseg.TabIndex = 11;
            this.lbl_nehezseg.Text = "Kérlek válassz nehézséget!";
            // 
            // lbl_kor
            // 
            this.lbl_kor.AutoSize = true;
            this.lbl_kor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_kor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_kor.Location = new System.Drawing.Point(206, 123);
            this.lbl_kor.Name = "lbl_kor";
            this.lbl_kor.Size = new System.Drawing.Size(2, 21);
            this.lbl_kor.TabIndex = 12;
            this.lbl_kor.Visible = false;
            // 
            // btn_ujjatek
            // 
            this.btn_ujjatek.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujjatek.Location = new System.Drawing.Point(13, 121);
            this.btn_ujjatek.Name = "btn_ujjatek";
            this.btn_ujjatek.Size = new System.Drawing.Size(123, 23);
            this.btn_ujjatek.TabIndex = 13;
            this.btn_ujjatek.Text = "Új játék";
            this.btn_ujjatek.UseVisualStyleBackColor = true;
            this.btn_ujjatek.Click += new System.EventHandler(this.Btn_ujjatek_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 2);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(590, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 162);
            this.label3.TabIndex = 15;
            // 
            // Huszonegy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ujjatek);
            this.Controls.Add(this.lbl_kor);
            this.Controls.Add(this.lbl_nehezseg);
            this.Controls.Add(this.btn_nemkerek);
            this.Controls.Add(this.lbl_kiiras);
            this.Controls.Add(this.btn_kerekmeg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Huszonegy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huszonegy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jatekszabalyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kerekmeg;
        private System.Windows.Forms.ToolStripMenuItem nehézségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konnyuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kozepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nehezToolStripMenuItem;
        private System.Windows.Forms.Label lbl_kiiras;
        private System.Windows.Forms.Button btn_nemkerek;
        private System.Windows.Forms.Label lbl_nehezseg;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_kor;
        private System.Windows.Forms.Button btn_ujjatek;
        private System.Windows.Forms.ToolStripMenuItem konnyuJatekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kozepesJatekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nehezJatekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altalanosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

