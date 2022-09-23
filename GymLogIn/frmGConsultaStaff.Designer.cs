namespace GymLogIn
{
    partial class frmGConsultaStaff
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
            this.GridTipoConsulta = new System.Windows.Forms.DataGridView();
            this.btnAddConsulta = new System.Windows.Forms.Button();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.RadioAdicionarConsulta = new System.Windows.Forms.RadioButton();
            this.RadioRemoverConsulta = new System.Windows.Forms.RadioButton();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.btnRemoverConsulta = new System.Windows.Forms.Button();
            this.GridMarcConsulta = new System.Windows.Forms.DataGridView();
            this.btnRemoveMarc = new System.Windows.Forms.Button();
            this.txtIdMarc = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtIdClienteMarc = new System.Windows.Forms.TextBox();
            this.btnAddMarc = new System.Windows.Forms.Button();
            this.txtIdTipoMarc = new System.Windows.Forms.TextBox();
            this.txtDataMarc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMarcConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTipoConsulta
            // 
            this.GridTipoConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridTipoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoConsulta.Location = new System.Drawing.Point(41, 28);
            this.GridTipoConsulta.Name = "GridTipoConsulta";
            this.GridTipoConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridTipoConsulta.RowTemplate.Height = 25;
            this.GridTipoConsulta.Size = new System.Drawing.Size(442, 246);
            this.GridTipoConsulta.TabIndex = 0;
            // 
            // btnAddConsulta
            // 
            this.btnAddConsulta.Location = new System.Drawing.Point(100, 452);
            this.btnAddConsulta.Name = "btnAddConsulta";
            this.btnAddConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnAddConsulta.TabIndex = 1;
            this.btnAddConsulta.Text = "Adicionar";
            this.btnAddConsulta.UseVisualStyleBackColor = true;
            this.btnAddConsulta.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(100, 352);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(100, 23);
            this.txtNomeConsulta.TabIndex = 2;
            // 
            // RadioAdicionarConsulta
            // 
            this.RadioAdicionarConsulta.AutoSize = true;
            this.RadioAdicionarConsulta.BackColor = System.Drawing.Color.Transparent;
            this.RadioAdicionarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioAdicionarConsulta.Location = new System.Drawing.Point(100, 307);
            this.RadioAdicionarConsulta.Name = "RadioAdicionarConsulta";
            this.RadioAdicionarConsulta.Size = new System.Drawing.Size(130, 20);
            this.RadioAdicionarConsulta.TabIndex = 5;
            this.RadioAdicionarConsulta.TabStop = true;
            this.RadioAdicionarConsulta.Text = "Adicionar consulta";
            this.RadioAdicionarConsulta.UseVisualStyleBackColor = false;
            this.RadioAdicionarConsulta.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioRemoverConsulta
            // 
            this.RadioRemoverConsulta.AutoSize = true;
            this.RadioRemoverConsulta.Location = new System.Drawing.Point(303, 307);
            this.RadioRemoverConsulta.Name = "RadioRemoverConsulta";
            this.RadioRemoverConsulta.Size = new System.Drawing.Size(120, 19);
            this.RadioRemoverConsulta.TabIndex = 6;
            this.RadioRemoverConsulta.TabStop = true;
            this.RadioRemoverConsulta.Text = "Remover consulta";
            this.RadioRemoverConsulta.UseVisualStyleBackColor = true;
            this.RadioRemoverConsulta.CheckedChanged += new System.EventHandler(this.RadioRemover_CheckedChanged);
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Location = new System.Drawing.Point(303, 352);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(100, 23);
            this.txtIdConsulta.TabIndex = 7;
            // 
            // btnRemoverConsulta
            // 
            this.btnRemoverConsulta.Location = new System.Drawing.Point(303, 452);
            this.btnRemoverConsulta.Name = "btnRemoverConsulta";
            this.btnRemoverConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverConsulta.TabIndex = 8;
            this.btnRemoverConsulta.Text = "Remover";
            this.btnRemoverConsulta.UseVisualStyleBackColor = true;
            this.btnRemoverConsulta.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // GridMarcConsulta
            // 
            this.GridMarcConsulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridMarcConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMarcConsulta.Location = new System.Drawing.Point(518, 28);
            this.GridMarcConsulta.Name = "GridMarcConsulta";
            this.GridMarcConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridMarcConsulta.RowTemplate.Height = 25;
            this.GridMarcConsulta.Size = new System.Drawing.Size(442, 246);
            this.GridMarcConsulta.TabIndex = 9;
            // 
            // btnRemoveMarc
            // 
            this.btnRemoveMarc.Location = new System.Drawing.Point(775, 452);
            this.btnRemoveMarc.Name = "btnRemoveMarc";
            this.btnRemoveMarc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMarc.TabIndex = 15;
            this.btnRemoveMarc.Text = "Remover";
            this.btnRemoveMarc.UseVisualStyleBackColor = true;
            this.btnRemoveMarc.Click += new System.EventHandler(this.btnRemoveMarc_Click);
            // 
            // txtIdMarc
            // 
            this.txtIdMarc.Location = new System.Drawing.Point(775, 352);
            this.txtIdMarc.Name = "txtIdMarc";
            this.txtIdMarc.Size = new System.Drawing.Size(100, 23);
            this.txtIdMarc.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(775, 307);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 19);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Remover marcação";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(572, 307);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Adicionar marcação";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtIdClienteMarc
            // 
            this.txtIdClienteMarc.Location = new System.Drawing.Point(572, 352);
            this.txtIdClienteMarc.Name = "txtIdClienteMarc";
            this.txtIdClienteMarc.Size = new System.Drawing.Size(100, 23);
            this.txtIdClienteMarc.TabIndex = 11;
            // 
            // btnAddMarc
            // 
            this.btnAddMarc.Location = new System.Drawing.Point(572, 452);
            this.btnAddMarc.Name = "btnAddMarc";
            this.btnAddMarc.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarc.TabIndex = 10;
            this.btnAddMarc.Text = "Adicionar";
            this.btnAddMarc.UseVisualStyleBackColor = true;
            this.btnAddMarc.Click += new System.EventHandler(this.btnAddMarc_Click);
            // 
            // txtIdTipoMarc
            // 
            this.txtIdTipoMarc.Location = new System.Drawing.Point(572, 381);
            this.txtIdTipoMarc.Name = "txtIdTipoMarc";
            this.txtIdTipoMarc.Size = new System.Drawing.Size(100, 23);
            this.txtIdTipoMarc.TabIndex = 16;
            // 
            // txtDataMarc
            // 
            this.txtDataMarc.Location = new System.Drawing.Point(572, 410);
            this.txtDataMarc.Name = "txtDataMarc";
            this.txtDataMarc.Size = new System.Drawing.Size(100, 23);
            this.txtDataMarc.TabIndex = 17;
            // 
            // frmGConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 531);
            this.Controls.Add(this.txtDataMarc);
            this.Controls.Add(this.txtIdTipoMarc);
            this.Controls.Add(this.btnRemoveMarc);
            this.Controls.Add(this.txtIdMarc);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txtIdClienteMarc);
            this.Controls.Add(this.btnAddMarc);
            this.Controls.Add(this.GridMarcConsulta);
            this.Controls.Add(this.btnRemoverConsulta);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.RadioRemoverConsulta);
            this.Controls.Add(this.RadioAdicionarConsulta);
            this.Controls.Add(this.txtNomeConsulta);
            this.Controls.Add(this.btnAddConsulta);
            this.Controls.Add(this.GridTipoConsulta);
            this.Name = "frmGConsulta";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMarcConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridTipoConsulta;
        private Button btnAddConsulta;
        private TextBox txtNomeConsulta;
        private RadioButton RadioAdicionarConsulta;
        private RadioButton RadioRemoverConsulta;
        private TextBox txtIdConsulta;
        private Button btnRemoverConsulta;
        private DataGridView GridMarcConsulta;
        private Button btnRemoveMarc;
        private TextBox txtIdMarc;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txtIdClienteMarc;
        private Button btnAddMarc;
        private TextBox txtIdTipoMarc;
        private TextBox txtDataMarc;
    }
}