namespace GymLogIn
{
    partial class frmGConsultaUser
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
            this.GridMarcConsulta = new System.Windows.Forms.DataGridView();
            this.btnRemoveMarc = new System.Windows.Forms.Button();
            this.txtIdMarc = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.btnRemoveMarc.Location = new System.Drawing.Point(305, 463);
            this.btnRemoveMarc.Name = "btnRemoveMarc";
            this.btnRemoveMarc.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMarc.TabIndex = 15;
            this.btnRemoveMarc.Text = "Remover";
            this.btnRemoveMarc.UseVisualStyleBackColor = true;
            this.btnRemoveMarc.Click += new System.EventHandler(this.btnRemoveMarc_Click);
            // 
            // txtIdMarc
            // 
            this.txtIdMarc.Location = new System.Drawing.Point(305, 363);
            this.txtIdMarc.Name = "txtIdMarc";
            this.txtIdMarc.Size = new System.Drawing.Size(100, 23);
            this.txtIdMarc.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(305, 318);
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
            this.radioButton2.Location = new System.Drawing.Point(102, 318);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Adicionar marcação";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnAddMarc
            // 
            this.btnAddMarc.Location = new System.Drawing.Point(102, 463);
            this.btnAddMarc.Name = "btnAddMarc";
            this.btnAddMarc.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarc.TabIndex = 10;
            this.btnAddMarc.Text = "Adicionar";
            this.btnAddMarc.UseVisualStyleBackColor = true;
            this.btnAddMarc.Click += new System.EventHandler(this.btnAddMarc_Click);
            // 
            // txtIdTipoMarc
            // 
            this.txtIdTipoMarc.Location = new System.Drawing.Point(102, 363);
            this.txtIdTipoMarc.Name = "txtIdTipoMarc";
            this.txtIdTipoMarc.Size = new System.Drawing.Size(100, 23);
            this.txtIdTipoMarc.TabIndex = 16;
            // 
            // txtDataMarc
            // 
            this.txtDataMarc.Location = new System.Drawing.Point(102, 392);
            this.txtDataMarc.Name = "txtDataMarc";
            this.txtDataMarc.Size = new System.Drawing.Size(100, 23);
            this.txtDataMarc.TabIndex = 17;
            // 
            // frmGConsultaUser
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
            this.Controls.Add(this.btnAddMarc);
            this.Controls.Add(this.GridMarcConsulta);
            this.Controls.Add(this.GridTipoConsulta);
            this.Name = "frmGConsultaUser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMarcConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridTipoConsulta;
        private DataGridView GridMarcConsulta;
        private Button btnRemoveMarc;
        private TextBox txtIdMarc;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnAddMarc;
        private TextBox txtIdTipoMarc;
        private TextBox txtDataMarc;
    }
}