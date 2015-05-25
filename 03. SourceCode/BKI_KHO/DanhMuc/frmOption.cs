using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_KHO.DanhMuc {
    public partial class frmOption : Form {
        public frmOption() {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e) {
            try {
                f302_V_DM_NHOM_HANG_DE v_frm = new f302_V_DM_NHOM_HANG_DE("LOAI_NHOM");
                v_frm.display_for_insert();
            }
            catch(Exception v_e) {
                
                throw;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            try {
                f302_V_DM_NHOM_HANG_DE v_frm = new f302_V_DM_NHOM_HANG_DE("NHOM");
                v_frm.display_for_insert();
            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }
    }
}
