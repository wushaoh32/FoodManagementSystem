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
                case "0": toolStripStatusLabel2.Text = "超级管理员"; break;
                case "1": toolStripStatusLabel2.Text = "经理"; break;
                case "2": toolStripStatusLabel2.Text = "一般用户"; break;
            }
            toolStripStatusLabel1.Text = Names;
            toolStripStatusLabel3.Text = Times;
            if (power == "2")
            {
                系统维护SToolStripMenuItem.Enabled = false;
                基础信息MToolStripMenuItem.Enabled = false;
            }
            if (power == "1")
            {
                系统维护SToolStripMenuItem.Enabled = false;
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Activated_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDesk.Items.Clear();
            SqlConnection conn = BaseClass.DBConn.CyCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_Room",conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string zt = sdr["RoomZT"].ToString().Trim();
                AddItems(zt);
            }
            conn.Close();
        }

        private void AddItems(string rzt)
        {
            if(rzt == "使用")
            {
                lvDesk.Items.Add(sdr["RoomName"].ToString(), 1);
            }
            else
            {
                lvDesk.Items.Add(sdr["RoomName"].ToString(),0);
            }
        }
    }
}
