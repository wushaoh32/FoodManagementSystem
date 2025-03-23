using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public SqlDataReader sdr;
        public string power;
        public string Names;
        public string Times;
        private void frmMain_Load(object sender, EventArgs e)
        {
            switch (power)
            {
                case "0":toolStripStatusLabel1.Text = "超级管理员";break;

            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
