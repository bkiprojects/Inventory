namespace BKI_KHO.DanhMuc {
    partial class frmOption {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_them_loai_nhom = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_them_nhom = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Controls.Add(this.m_cmd_them_nhom);
            this.panel1.Controls.Add(this.m_cmd_them_loai_nhom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 147);
            this.panel1.TabIndex = 0;
            // 
            // m_cmd_them_loai_nhom
            // 
            this.m_cmd_them_loai_nhom.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.m_cmd_them_loai_nhom.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_them_loai_nhom.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_them_loai_nhom.Name = "m_cmd_them_loai_nhom";
            this.m_cmd_them_loai_nhom.Size = new System.Drawing.Size(158, 147);
            this.m_cmd_them_loai_nhom.TabIndex = 59;
            this.m_cmd_them_loai_nhom.Text = "THÊM LOẠI NHÓM HÀNG";
            this.m_cmd_them_loai_nhom.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_them_nhom
            // 
            this.m_cmd_them_nhom.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.m_cmd_them_nhom.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_them_nhom.Location = new System.Drawing.Point(158, 0);
            this.m_cmd_them_nhom.Name = "m_cmd_them_nhom";
            this.m_cmd_them_nhom.Size = new System.Drawing.Size(158, 147);
            this.m_cmd_them_nhom.TabIndex = 60;
            this.m_cmd_them_nhom.Text = "THÊM NHÓM HÀNG";
            this.m_cmd_them_nhom.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_exit.Location = new System.Drawing.Point(316, 0);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(87, 147);
            this.m_cmd_exit.TabIndex = 61;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(404, 147);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them_nhom;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them_loai_nhom;



    }
}