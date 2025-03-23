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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("请输入用户名", "警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if(txtPwd.Text == "")
                {
                    MessageBox.Show("请输入密码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = BaseClass.DBConn.CyCon();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from tb_User where UserName='" + txtName.Text+"' and UserPwd='" + txtPwd.Text +"'",conn);
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0)
                    {
                        cmd = new SqlCommand("select * from tb_User where UserName='" + txtName.Text + "'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        string UserPower = sdr["power"].ToString().Trim();
                        conn.Close();
                        frmMain main =new frmMain();
                        main.power  = UserPower;
                        main.Names = txtName.Text;
                        main.Times = DateTime.Now.ToShortDateString();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
            }
        }
    }
}
