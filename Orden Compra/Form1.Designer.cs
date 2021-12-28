namespace Orden_Compra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAderezo = new System.Windows.Forms.ComboBox();
            this.chkIngHa3 = new System.Windows.Forms.CheckBox();
            this.chkIngHa2 = new System.Windows.Forms.CheckBox();
            this.chkIngHa1 = new System.Windows.Forms.CheckBox();
            this.rbHaCH = new System.Windows.Forms.RadioButton();
            this.rbHaG = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIngHo3 = new System.Windows.Forms.CheckBox();
            this.chkIngHo2 = new System.Windows.Forms.CheckBox();
            this.chkIngHo1 = new System.Windows.Forms.CheckBox();
            this.rbHoC = new System.Windows.Forms.RadioButton();
            this.rbHoG = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAderezo);
            this.groupBox1.Controls.Add(this.chkIngHa3);
            this.groupBox1.Controls.Add(this.chkIngHa2);
            this.groupBox1.Controls.Add(this.chkIngHa1);
            this.groupBox1.Controls.Add(this.rbHaCH);
            this.groupBox1.Controls.Add(this.rbHaG);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hamburguesas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elige un aderezo:";
            // 
            // cmbAderezo
            // 
            this.cmbAderezo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAderezo.FormattingEnabled = true;
            this.cmbAderezo.Items.AddRange(new object[] {
            "Aderezo 1",
            "Aderezo 2"});
            this.cmbAderezo.Location = new System.Drawing.Point(313, 50);
            this.cmbAderezo.Name = "cmbAderezo";
            this.cmbAderezo.Size = new System.Drawing.Size(121, 21);
            this.cmbAderezo.TabIndex = 5;
            // 
            // chkIngHa3
            // 
            this.chkIngHa3.AutoSize = true;
            this.chkIngHa3.Location = new System.Drawing.Point(172, 94);
            this.chkIngHa3.Name = "chkIngHa3";
            this.chkIngHa3.Size = new System.Drawing.Size(88, 17);
            this.chkIngHa3.TabIndex = 4;
            this.chkIngHa3.Text = "Ingrediente 3";
            this.chkIngHa3.UseVisualStyleBackColor = true;
            // 
            // chkIngHa2
            // 
            this.chkIngHa2.AutoSize = true;
            this.chkIngHa2.Location = new System.Drawing.Point(172, 71);
            this.chkIngHa2.Name = "chkIngHa2";
            this.chkIngHa2.Size = new System.Drawing.Size(88, 17);
            this.chkIngHa2.TabIndex = 3;
            this.chkIngHa2.Text = "Ingrediente 2";
            this.chkIngHa2.UseVisualStyleBackColor = true;
            // 
            // chkIngHa1
            // 
            this.chkIngHa1.AutoSize = true;
            this.chkIngHa1.Location = new System.Drawing.Point(172, 50);
            this.chkIngHa1.Name = "chkIngHa1";
            this.chkIngHa1.Size = new System.Drawing.Size(88, 17);
            this.chkIngHa1.TabIndex = 2;
            this.chkIngHa1.Text = "Ingrediente 1";
            this.chkIngHa1.UseVisualStyleBackColor = true;
            // 
            // rbHaCH
            // 
            this.rbHaCH.AutoSize = true;
            this.rbHaCH.Location = new System.Drawing.Point(23, 87);
            this.rbHaCH.Name = "rbHaCH";
            this.rbHaCH.Size = new System.Drawing.Size(52, 17);
            this.rbHaCH.TabIndex = 1;
            this.rbHaCH.TabStop = true;
            this.rbHaCH.Text = "Chica";
            this.rbHaCH.UseVisualStyleBackColor = true;
            // 
            // rbHaG
            // 
            this.rbHaG.AutoSize = true;
            this.rbHaG.Location = new System.Drawing.Point(23, 50);
            this.rbHaG.Name = "rbHaG";
            this.rbHaG.Size = new System.Drawing.Size(60, 17);
            this.rbHaG.TabIndex = 0;
            this.rbHaG.TabStop = true;
            this.rbHaG.Text = "Grande";
            this.rbHaG.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIngHo3);
            this.groupBox2.Controls.Add(this.chkIngHo2);
            this.groupBox2.Controls.Add(this.chkIngHo1);
            this.groupBox2.Controls.Add(this.rbHoC);
            this.groupBox2.Controls.Add(this.rbHoG);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 158);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hot Dogs";
            // 
            // chkIngHo3
            // 
            this.chkIngHo3.AutoSize = true;
            this.chkIngHo3.Location = new System.Drawing.Point(172, 96);
            this.chkIngHo3.Name = "chkIngHo3";
            this.chkIngHo3.Size = new System.Drawing.Size(88, 17);
            this.chkIngHo3.TabIndex = 7;
            this.chkIngHo3.Text = "Ingrediente 3";
            this.chkIngHo3.UseVisualStyleBackColor = true;
            // 
            // chkIngHo2
            // 
            this.chkIngHo2.AutoSize = true;
            this.chkIngHo2.Location = new System.Drawing.Point(172, 73);
            this.chkIngHo2.Name = "chkIngHo2";
            this.chkIngHo2.Size = new System.Drawing.Size(88, 17);
            this.chkIngHo2.TabIndex = 6;
            this.chkIngHo2.Text = "Ingrediente 2";
            this.chkIngHo2.UseVisualStyleBackColor = true;
            // 
            // chkIngHo1
            // 
            this.chkIngHo1.AutoSize = true;
            this.chkIngHo1.Location = new System.Drawing.Point(172, 52);
            this.chkIngHo1.Name = "chkIngHo1";
            this.chkIngHo1.Size = new System.Drawing.Size(88, 17);
            this.chkIngHo1.TabIndex = 5;
            this.chkIngHo1.Text = "Ingrediente 1";
            this.chkIngHo1.UseVisualStyleBackColor = true;
            // 
            // rbHoC
            // 
            this.rbHoC.AutoSize = true;
            this.rbHoC.Location = new System.Drawing.Point(23, 88);
            this.rbHoC.Name = "rbHoC";
            this.rbHoC.Size = new System.Drawing.Size(52, 17);
            this.rbHoC.TabIndex = 3;
            this.rbHoC.TabStop = true;
            this.rbHoC.Text = "Chico";
            this.rbHoC.UseVisualStyleBackColor = true;
            // 
            // rbHoG
            // 
            this.rbHoG.AutoSize = true;
            this.rbHoG.Location = new System.Drawing.Point(23, 51);
            this.rbHoG.Name = "rbHoG";
            this.rbHoG.Size = new System.Drawing.Size(60, 17);
            this.rbHoG.TabIndex = 2;
            this.rbHoG.TabStop = true;
            this.rbHoG.Text = "Grande";
            this.rbHoG.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 378);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(329, 20);
            this.txtName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre del cleinte:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(469, 378);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 410);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbAderezo;
        public System.Windows.Forms.CheckBox chkIngHa3;
        public System.Windows.Forms.CheckBox chkIngHa2;
        public System.Windows.Forms.CheckBox chkIngHa1;
        public System.Windows.Forms.RadioButton rbHaCH;
        public System.Windows.Forms.RadioButton rbHaG;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox chkIngHo3;
        public System.Windows.Forms.CheckBox chkIngHo2;
        public System.Windows.Forms.CheckBox chkIngHo1;
        public System.Windows.Forms.RadioButton rbHoC;
        public System.Windows.Forms.RadioButton rbHoG;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar;
    }
}

