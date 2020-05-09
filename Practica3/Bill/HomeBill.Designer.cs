namespace Practica3.Bill
{
    partial class HomeBill
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
            this.txtNoBill = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listSaucer = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar Factura";
            // 
            // txtNoBill
            // 
            this.txtNoBill.Location = new System.Drawing.Point(95, 100);
            this.txtNoBill.Name = "txtNoBill";
            this.txtNoBill.Size = new System.Drawing.Size(156, 20);
            this.txtNoBill.TabIndex = 4;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(418, 101);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(120, 20);
            this.txtSerie.TabIndex = 6;
            this.txtSerie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "No Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direccion de entrega";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(151, 146);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(387, 20);
            this.txtAdress.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Platillos";
            // 
            // listSaucer
            // 
            this.listSaucer.Location = new System.Drawing.Point(95, 234);
            this.listSaucer.Name = "listSaucer";
            this.listSaucer.Size = new System.Drawing.Size(156, 212);
            this.listSaucer.TabIndex = 40;
            this.listSaucer.UseCompatibleStateImageBehavior = false;
            this.listSaucer.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "NIT";
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(358, 234);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(180, 20);
            this.txtNIT.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 20);
            this.txtName.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listSaucer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtNoBill);
            this.Controls.Add(this.label1);
            this.Name = "HomeBill";
            this.Text = "HomeBill";
            this.Load += new System.EventHandler(this.HomeBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoBill;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listSaucer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
    }
}