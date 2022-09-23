namespace GymLogIn
{
    partial class frmGAulas
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
            this.GridAulas = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.RadioAdicionar = new System.Windows.Forms.RadioButton();
            this.RadioRemover = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAulas
            // 
            this.GridAulas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAulas.Location = new System.Drawing.Point(25, 29);
            this.GridAulas.Name = "GridAulas";
            this.GridAulas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridAulas.RowTemplate.Height = 25;
            this.GridAulas.Size = new System.Drawing.Size(954, 246);
            this.GridAulas.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 352);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 2;
            // 
            // RadioAdicionar
            // 
            this.RadioAdicionar.AutoSize = true;
            this.RadioAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.RadioAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioAdicionar.Location = new System.Drawing.Point(100, 307);
            this.RadioAdicionar.Name = "RadioAdicionar";
            this.RadioAdicionar.Size = new System.Drawing.Size(107, 20);
            this.RadioAdicionar.TabIndex = 5;
            this.RadioAdicionar.TabStop = true;
            this.RadioAdicionar.Text = "Adicionar aula";
            this.RadioAdicionar.UseVisualStyleBackColor = false;
            this.RadioAdicionar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioRemover
            // 
            this.RadioRemover.AutoSize = true;
            this.RadioRemover.Location = new System.Drawing.Point(303, 307);
            this.RadioRemover.Name = "RadioRemover";
            this.RadioRemover.Size = new System.Drawing.Size(97, 19);
            this.RadioRemover.TabIndex = 6;
            this.RadioRemover.TabStop = true;
            this.RadioRemover.Text = "Remover aula";
            this.RadioRemover.UseVisualStyleBackColor = true;
            this.RadioRemover.CheckedChanged += new System.EventHandler(this.RadioRemover_CheckedChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(303, 352);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 7;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(303, 452);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(100, 394);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 23);
            this.txtData.TabIndex = 9;
            // 
            // frmGAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 531);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.RadioRemover);
            this.Controls.Add(this.RadioAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GridAulas);
            this.Name = "frmGAulas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridAulas;
        private Button btnAdd;
        private TextBox txtNome;
        private RadioButton RadioAdicionar;
        private RadioButton RadioRemover;
        private TextBox txtId;
        private Button btnRemover;
        private TextBox txtData;
    }
}