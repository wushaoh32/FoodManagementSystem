namespace FoodManagementSystem
{
    partial class Login
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
            btnSubmit = new Button();
            txtName = new TextBox();
            txtPwd = new TextBox();
            lable1 = new Label();
            label2 = new Label();
            btn = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(188, 239);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "登录";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(259, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(259, 114);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(150, 30);
            txtPwd.TabIndex = 2;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(188, 65);
            lable1.Name = "lable1";
            lable1.Size = new Size(64, 24);
            lable1.TabIndex = 3;
            lable1.Text = "用户名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 117);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 4;
            label2.Text = "密 码";
            // 
            // btn
            // 
            btn.Location = new Point(376, 239);
            btn.Name = "btn";
            btn.Size = new Size(112, 34);
            btn.TabIndex = 5;
            btn.Text = "取消";
            btn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Controls.Add(label2);
            Controls.Add(lable1);
            Controls.Add(txtPwd);
            Controls.Add(txtName);
            Controls.Add(btnSubmit);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtName;
        private TextBox txtPwd;
        private Label lable1;
        private Label label2;
        private Button btn;
    }
}