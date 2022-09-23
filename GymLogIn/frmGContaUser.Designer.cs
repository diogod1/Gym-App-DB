namespace GymLogIn
{
    partial class frmGContaUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutNome = new System.Windows.Forms.TextBox();
            this.txtOutUsername = new System.Windows.Forms.TextBox();
            this.txtOutPassword = new System.Windows.Forms.TextBox();
            this.txtInPassword = new System.Windows.Forms.TextBox();
            this.txtInUsername = new System.Windows.Forms.TextBox();
            this.txtInNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.chckbxEditar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // txtOutNome
            // 
            this.txtOutNome.Location = new System.Drawing.Point(129, 148);
            this.txtOutNome.Name = "txtOutNome";
            this.txtOutNome.ReadOnly = true;
            this.txtOutNome.Size = new System.Drawing.Size(144, 23);
            this.txtOutNome.TabIndex = 3;
            // 
            // txtOutUsername
            // 
            this.txtOutUsername.Location = new System.Drawing.Point(129, 187);
            this.txtOutUsername.Name = "txtOutUsername";
            this.txtOutUsername.ReadOnly = true;
            this.txtOutUsername.Size = new System.Drawing.Size(144, 23);
            this.txtOutUsername.TabIndex = 4;
            // 
            // txtOutPassword
            // 
            this.txtOutPassword.Location = new System.Drawing.Point(129, 238);
            this.txtOutPassword.Name = "txtOutPassword";
            this.txtOutPassword.ReadOnly = true;
            this.txtOutPassword.Size = new System.Drawing.Size(144, 23);
            this.txtOutPassword.TabIndex = 5;
            // 
            // txtInPassword
            // 
            this.txtInPassword.Location = new System.Drawing.Point(505, 238);
            this.txtInPassword.Name = "txtInPassword";
            this.txtInPassword.Size = new System.Drawing.Size(144, 23);
            this.txtInPassword.TabIndex = 11;
            // 
            // txtInUsername
            // 
            this.txtInUsername.Location = new System.Drawing.Point(505, 187);
            this.txtInUsername.Name = "txtInUsername";
            this.txtInUsername.Size = new System.Drawing.Size(144, 23);
            this.txtInUsername.TabIndex = 10;
            // 
            // txtInNome
            // 
            this.txtInNome.Location = new System.Drawing.Point(505, 148);
            this.txtInNome.Name = "txtInNome";
            this.txtInNome.Size = new System.Drawing.Size(144, 23);
            this.txtInNome.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Username";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(505, 288);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // chckbxEditar
            // 
            this.chckbxEditar.AutoSize = true;
            this.chckbxEditar.Location = new System.Drawing.Point(62, 102);
            this.chckbxEditar.Name = "chckbxEditar";
            this.chckbxEditar.Size = new System.Drawing.Size(91, 19);
            this.chckbxEditar.TabIndex = 13;
            this.chckbxEditar.Text = "Editar dados";
            this.chckbxEditar.UseVisualStyleBackColor = true;
            this.chckbxEditar.CheckedChanged += new System.EventHandler(this.chckbxEditar_CheckedChanged);
            // 
            // frmGContaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chckbxEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtInPassword);
            this.Controls.Add(this.txtInUsername);
            this.Controls.Add(this.txtInNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOutPassword);
            this.Controls.Add(this.txtOutUsername);
            this.Controls.Add(this.txtOutNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGContaUser";
            this.Text = "frmGContaUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOutNome;
        private TextBox txtOutUsername;
        private TextBox txtOutPassword;
        private TextBox txtInPassword;
        private TextBox txtInUsername;
        private TextBox txtInNome;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEditar;
        private CheckBox chckbxEditar;
    }
}