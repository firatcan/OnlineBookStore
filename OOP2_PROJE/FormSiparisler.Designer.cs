namespace OOP2_PROJE
{
    partial class FormSiparisler
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
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(0, 0);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowTemplate.Height = 24;
            this.dgvSiparisler.Size = new System.Drawing.Size(596, 197);
            this.dgvSiparisler.TabIndex = 0;
            // 
            // FormSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 200);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "FormSiparisler";
            this.Text = "FormSiparisler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
    }
}