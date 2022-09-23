namespace GymLogIn
{
    partial class frmGFunc
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
            this.GridFunc = new System.Windows.Forms.DataGridView();
            this.btnAddFunc = new System.Windows.Forms.Button();
            this.txtUsernameFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtPasswordFunc = new System.Windows.Forms.TextBox();
            this.RadioAdicionar = new System.Windows.Forms.RadioButton();
            this.RadioRemover = new System.Windows.Forms.RadioButton();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.btnRemoverFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // GridFunc
            // 
            this.GridFunc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFunc.Location = new System.Drawing.Point(25, 29);
            this.GridFunc.Name = "GridFunc";
            this.GridFunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridFunc.RowTemplate.Height = 25;
            this.GridFunc.Size = new System.Drawing.Size(954, 246);
            this.GridFunc.TabIndex = 0;
            // 
            // btnAddFunc
            // 
            this.btnAddFunc.Location = new System.Drawing.Point(100, 452);
            this.btnAddFunc.Name = "btnAddFunc";
            this.btnAddFunc.Size = new System.Drawing.Size(75, 23);
            this.btnAddFunc.TabIndex = 1;
            this.btnAddFunc.Text = "Adicionar";
            this.btnAddFunc.UseVisualStyleBackColor = true;
            this.btnAddFunc.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUsernameFunc
            // 
            this.txtUsernameFunc.Location = new System.Drawing.Point(100, 352);
            this.txtUsernameFunc.Name = "txtUsernameFunc";
            this.txtUsernameFunc.Size = new System.Drawing.Size(100, 23);
            this.txtUsernameFunc.TabIndex = 2;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(100, 410);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 23);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // txtPasswordFunc
            // 
            this.txtPasswordFunc.Location = new System.Drawing.Point(100, 381);
            this.txtPasswordFunc.Name = "txtPasswordFunc";
            this.txtPasswordFunc.Size = new System.Drawing.Size(100, 23);
            this.txtPasswordFunc.TabIndex = 4;
            // 
            // RadioAdicionar
            // 
            this.RadioAdicionar.AutoSize = true;
            this.RadioAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.RadioAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioAdicionar.Location = new System.Drawing.Point(100, 307);
            this.RadioAdicionar.Name = "RadioAdicionar";
            this.RadioAdicionar.Size = new System.Drawing.Size(146, 20);
            this.RadioAdicionar.TabIndex = 5;
            this.RadioAdicionar.TabStop = true;
            this.RadioAdicionar.Text = "Adicionar funcionário";
            this.RadioAdicionar.UseVisualStyleBackColor = false;
            this.RadioAdicionar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioRemover
            // 
            this.RadioRemover.AutoSize = true;
            this.RadioRemover.Location = new System.Drawing.Point(303, 307);
            this.RadioRemover.Name = "RadioRemover";
            this.RadioRemover.Size = new System.Drawing.Size(136, 19);
            this.RadioRemover.TabIndex = 6;
            this.RadioRemover.TabStop = true;
            this.RadioRemover.Text = "Remover funcionário";
            this.RadioRemover.UseVisualStyleBackColor = true;
            this.RadioRemover.CheckedChanged += new System.EventHandler(this.RadioRemover_CheckedChanged);
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(303, 352);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(100, 23);
            this.txtIdFunc.TabIndex = 7;
            // 
            // btnRemoverFunc
            // 
            this.btnRemoverFunc.Location = new System.Drawing.Point(303, 452);
            this.btnRemoverFunc.Name = "btnRemoverFunc";
            this.btnRemoverFunc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverFunc.TabIndex = 8;
            this.btnRemoverFunc.Text = "Remover";
            this.btnRemoverFunc.UseVisualStyleBackColor = true;
            this.btnRemoverFunc.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmGFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 531);
            this.Controls.Add(this.btnRemoverFunc);
            this.Controls.Add(this.txtIdFunc);
            this.Controls.Add(this.RadioRemover);
            this.Controls.Add(this.RadioAdicionar);
            this.Controls.Add(this.txtPasswordFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.txtUsernameFunc);
            this.Controls.Add(this.btnAddFunc);
            this.Controls.Add(this.GridFunc);
            this.Name = "frmGFunc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridFunc;
        private Button btnAddFunc;
        private TextBox txtUsernameFunc;
        private TextBox txtNomeFunc;
        private TextBox txtPasswordFunc;
        private RadioButton RadioAdicionar;
        private RadioButton RadioRemover;
        private TextBox txtIdFunc;
        private Button btnRemoverFunc;
    }
}