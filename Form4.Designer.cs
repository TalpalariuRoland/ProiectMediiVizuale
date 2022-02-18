
namespace WinFormsApp2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.RoleIDBox = new System.Windows.Forms.ListBox();
            this.Addbutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role ID";
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(151, 61);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(125, 27);
            this.FnameBox.TabIndex = 4;
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(151, 104);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(125, 27);
            this.LNameBox.TabIndex = 5;
            // 
            // RoleIDBox
            // 
            this.RoleIDBox.FormattingEnabled = true;
            this.RoleIDBox.ItemHeight = 20;
            this.RoleIDBox.Location = new System.Drawing.Point(151, 145);
            this.RoleIDBox.Name = "RoleIDBox";
            this.RoleIDBox.Size = new System.Drawing.Size(125, 24);
            this.RoleIDBox.TabIndex = 9;
            // 
            // Addbutt
            // 
            this.Addbutt.Location = new System.Drawing.Point(188, 355);
            this.Addbutt.Name = "Addbutt";
            this.Addbutt.Size = new System.Drawing.Size(87, 38);
            this.Addbutt.TabIndex = 10;
            this.Addbutt.Text = "Done";
            this.Addbutt.UseVisualStyleBackColor = true;
            this.Addbutt.Click += new System.EventHandler(this.Addbutt_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.Addbutt);
            this.Controls.Add(this.RoleIDBox);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.FnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.ListBox RoleIDBox;
        private System.Windows.Forms.Button Addbutt;
    }
}