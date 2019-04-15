namespace Auction.UI
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_textBox.Location = new System.Drawing.Point(240, 208);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(320, 31);
            this.UserName_textBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(240, 273);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(320, 31);
            this.Password_textBox.TabIndex = 2;
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UserName_label.Location = new System.Drawing.Point(243, 183);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(96, 23);
            this.UserName_label.TabIndex = 0;
            this.UserName_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Password_label.Location = new System.Drawing.Point(243, 247);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(91, 23);
            this.Password_label.TabIndex = 0;
            this.Password_label.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserName_textBox);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Label Password_label;
    }
}

