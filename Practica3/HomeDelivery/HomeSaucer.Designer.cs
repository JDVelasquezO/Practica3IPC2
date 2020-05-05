namespace Practica3.HomeDelivery
{
    partial class HomeSaucer
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
            this.dgvSaucer = new System.Windows.Forms.DataGridView();
            this.idSaucer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSaucer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costSaucer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaucer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaucer
            // 
            this.dgvSaucer.AllowUserToDeleteRows = false;
            this.dgvSaucer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaucer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSaucer,
            this.nameSaucer,
            this.costSaucer,
            this.quantity});
            this.dgvSaucer.Location = new System.Drawing.Point(12, 92);
            this.dgvSaucer.Name = "dgvSaucer";
            this.dgvSaucer.Size = new System.Drawing.Size(483, 150);
            this.dgvSaucer.TabIndex = 0;
            this.dgvSaucer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaucer_CellContentClick);
            // 
            // idSaucer
            // 
            this.idSaucer.HeaderText = "ID";
            this.idSaucer.Name = "idSaucer";
            this.idSaucer.ReadOnly = true;
            // 
            // nameSaucer
            // 
            this.nameSaucer.HeaderText = "Platillo";
            this.nameSaucer.Name = "nameSaucer";
            this.nameSaucer.ReadOnly = true;
            // 
            // costSaucer
            // 
            this.costSaucer.HeaderText = "Costo";
            this.costSaucer.Name = "costSaucer";
            this.costSaucer.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Escoger Platillo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Agregar a la Orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeSaucer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSaucer);
            this.Name = "HomeSaucer";
            this.Text = "Saucer";
            this.Load += new System.EventHandler(this.Saucer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaucer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaucer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSaucer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSaucer;
        private System.Windows.Forms.DataGridViewTextBoxColumn costSaucer;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}