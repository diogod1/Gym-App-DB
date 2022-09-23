namespace GymLogIn
{
    partial class frmGAulasUser
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
            ((System.ComponentModel.ISupportInitialize)(this.GridAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAulas
            // 
            this.GridAulas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAulas.Location = new System.Drawing.Point(28, 65);
            this.GridAulas.Name = "GridAulas";
            this.GridAulas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridAulas.RowTemplate.Height = 25;
            this.GridAulas.Size = new System.Drawing.Size(954, 370);
            this.GridAulas.TabIndex = 0;
            // 
            // frmGAulasUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 531);
            this.Controls.Add(this.GridAulas);
            this.Name = "frmGAulasUser";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridAulas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridAulas;
    }
}