namespace Bromo_Airline_2
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.hhdhdhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urururToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(-6, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 392);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hhdhdhToolStripMenuItem,
            this.urururToolStripMenuItem,
            this.masterJadwalPenerbanganToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(185, 390);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(55, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Logout";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::Bromo_Airline_2.Properties.Resources.log_out_unselected_721;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(23, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 26);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // hhdhdhToolStripMenuItem
            // 
            this.hhdhdhToolStripMenuItem.Image = global::Bromo_Airline_2.Properties.Resources.map_unselected_72;
            this.hhdhdhToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hhdhdhToolStripMenuItem.Name = "hhdhdhToolStripMenuItem";
            this.hhdhdhToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.hhdhdhToolStripMenuItem.Text = "Master Bandara";
            this.hhdhdhToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hhdhdhToolStripMenuItem.Click += new System.EventHandler(this.hhdhdhToolStripMenuItem_Click);
            // 
            // urururToolStripMenuItem
            // 
            this.urururToolStripMenuItem.Image = global::Bromo_Airline_2.Properties.Resources.plane_take_off_unselected_72;
            this.urururToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urururToolStripMenuItem.Name = "urururToolStripMenuItem";
            this.urururToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.urururToolStripMenuItem.Text = "Master Maskapai";
            this.urururToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urururToolStripMenuItem.Click += new System.EventHandler(this.urururToolStripMenuItem_Click);
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            this.masterJadwalPenerbanganToolStripMenuItem.Image = global::Bromo_Airline_2.Properties.Resources.calendar_unselected_72;
            this.masterJadwalPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            this.masterJadwalPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            this.masterJadwalPenerbanganToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterJadwalPenerbanganToolStripMenuItem.Click += new System.EventHandler(this.masterJadwalPenerbanganToolStripMenuItem_Click);
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Image = global::Bromo_Airline_2.Properties.Resources.purchase_tag_alt_unselected_72;
            this.masterKodePromoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            this.masterKodePromoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterKodePromoToolStripMenuItem.Click += new System.EventHandler(this.masterKodePromoToolStripMenuItem_Click);
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubahStatusPenerbanganToolStripMenuItem.Image = global::Bromo_Airline_2.Properties.Resources.notepad_unselected_72;
            this.ubahStatusPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            this.ubahStatusPenerbanganToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ubahStatusPenerbanganToolStripMenuItem.Click += new System.EventHandler(this.ubahStatusPenerbanganToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = global::Bromo_Airline_2.Properties.Resources.menu_alt_72;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Bromo Airlines - Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hhdhdhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urururToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}