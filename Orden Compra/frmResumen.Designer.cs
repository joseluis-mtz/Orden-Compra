namespace Orden_Compra
{
    partial class frmResumen
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
            this.lblAderezos = new System.Windows.Forms.Label();
            this.lblIngHot = new System.Windows.Forms.Label();
            this.lblSizeHot = new System.Windows.Forms.Label();
            this.lblHot = new System.Windows.Forms.Label();
            this.lblIngHam = new System.Windows.Forms.Label();
            this.lblSizeHam = new System.Windows.Forms.Label();
            this.lblHamb = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAderezos
            // 
            this.lblAderezos.AutoSize = true;
            this.lblAderezos.Location = new System.Drawing.Point(6, 169);
            this.lblAderezos.Name = "lblAderezos";
            this.lblAderezos.Size = new System.Drawing.Size(54, 13);
            this.lblAderezos.TabIndex = 22;
            this.lblAderezos.Text = "Aderezos:";
            // 
            // lblIngHot
            // 
            this.lblIngHot.AutoSize = true;
            this.lblIngHot.Location = new System.Drawing.Point(292, 126);
            this.lblIngHot.Name = "lblIngHot";
            this.lblIngHot.Size = new System.Drawing.Size(68, 13);
            this.lblIngHot.TabIndex = 21;
            this.lblIngHot.Text = "Ingredientes:";
            // 
            // lblSizeHot
            // 
            this.lblSizeHot.AutoSize = true;
            this.lblSizeHot.Location = new System.Drawing.Point(141, 126);
            this.lblSizeHot.Name = "lblSizeHot";
            this.lblSizeHot.Size = new System.Drawing.Size(46, 13);
            this.lblSizeHot.TabIndex = 20;
            this.lblSizeHot.Text = "Tamaño";
            // 
            // lblHot
            // 
            this.lblHot.AutoSize = true;
            this.lblHot.Location = new System.Drawing.Point(6, 126);
            this.lblHot.Name = "lblHot";
            this.lblHot.Size = new System.Drawing.Size(53, 13);
            this.lblHot.TabIndex = 19;
            this.lblHot.Text = "Producto:";
            // 
            // lblIngHam
            // 
            this.lblIngHam.AutoSize = true;
            this.lblIngHam.Location = new System.Drawing.Point(292, 90);
            this.lblIngHam.Name = "lblIngHam";
            this.lblIngHam.Size = new System.Drawing.Size(68, 13);
            this.lblIngHam.TabIndex = 18;
            this.lblIngHam.Text = "Ingredientes:";
            // 
            // lblSizeHam
            // 
            this.lblSizeHam.AutoSize = true;
            this.lblSizeHam.Location = new System.Drawing.Point(141, 90);
            this.lblSizeHam.Name = "lblSizeHam";
            this.lblSizeHam.Size = new System.Drawing.Size(46, 13);
            this.lblSizeHam.TabIndex = 17;
            this.lblSizeHam.Text = "Tamaño";
            // 
            // lblHamb
            // 
            this.lblHamb.AutoSize = true;
            this.lblHamb.Location = new System.Drawing.Point(6, 90);
            this.lblHamb.Name = "lblHamb";
            this.lblHamb.Size = new System.Drawing.Size(53, 13);
            this.lblHamb.TabIndex = 16;
            this.lblHamb.Text = "Producto:";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(6, 48);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(77, 13);
            this.lblPedido.TabIndex = 15;
            this.lblPedido.Text = "No. de pedido:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(191, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Nombre del cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Resumen Del Pedido";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(370, 236);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 266);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAderezos);
            this.Controls.Add(this.lblIngHot);
            this.Controls.Add(this.lblSizeHot);
            this.Controls.Add(this.lblHot);
            this.Controls.Add(this.lblIngHam);
            this.Controls.Add(this.lblSizeHam);
            this.Controls.Add(this.lblHamb);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "frmResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAderezos;
        public System.Windows.Forms.Label lblIngHot;
        public System.Windows.Forms.Label lblSizeHot;
        public System.Windows.Forms.Label lblHot;
        public System.Windows.Forms.Label lblIngHam;
        public System.Windows.Forms.Label lblSizeHam;
        public System.Windows.Forms.Label lblHamb;
        public System.Windows.Forms.Label lblPedido;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}