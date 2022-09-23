namespace GymLogIn
{
    partial class frmGPagamento
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
            this.GridManutencao = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.RadioAdicionar = new System.Windows.Forms.RadioButton();
            this.RadioRemover = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridManutencao)).BeginInit();
            this.SuspendLayout();
            // 
            // GridManutencao
            // 
            this.GridManutencao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridManutencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridManutencao.Location = new System.Drawing.Point(25, 29);
            this.GridManutencao.Name = "GridManutencao";
            this.GridManutencao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridManutencao.RowTemplate.Height = 25;
            this.GridManutencao.Size = new System.Drawing.Size(954, 246);
            this.GridManutencao.TabIndex = 0;
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
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(100, 380);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 23);
            this.txtTipo.TabIndex = 2;
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
            this.RadioAdicionar.Text = "Adicionar pagamento";
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
            this.RadioRemover.Text = "Remover pagamento";
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
            // txtMontante
            // 
            this.txtMontante.Location = new System.Drawing.Point(100, 409);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(100, 23);
            this.txtMontante.TabIndex = 9;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(100, 351);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 23);
            this.txtIdCliente.TabIndex = 10;
            // 
            // frmGPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 531);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.RadioRemover);
            this.Controls.Add(this.RadioAdicionar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GridManutencao);
            this.Name = "frmGPagamento";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridManutencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridManutencao;
        private Button btnAdd;
        private TextBox txtTipo;
        private RadioButton RadioAdicionar;
        private RadioButton RadioRemover;
        private TextBox txtId;
        private Button btnRemover;
        private TextBox txtMontante;
        private TextBox txtIdCliente;
    }
}