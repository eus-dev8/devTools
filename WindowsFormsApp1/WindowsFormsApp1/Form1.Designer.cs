namespace WindowsFormsApp1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNombreDelBoton = new System.Windows.Forms.Button();
            this.Campo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutoCompleteDataBaseValues = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(264, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titulo 1";
            // 
            // btnNombreDelBoton
            // 
            this.btnNombreDelBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(157)))));
            this.btnNombreDelBoton.FlatAppearance.BorderSize = 0;
            this.btnNombreDelBoton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombreDelBoton.ForeColor = System.Drawing.Color.White;
            this.btnNombreDelBoton.Location = new System.Drawing.Point(270, 137);
            this.btnNombreDelBoton.Margin = new System.Windows.Forms.Padding(1);
            this.btnNombreDelBoton.Name = "btnNombreDelBoton";
            this.btnNombreDelBoton.Size = new System.Drawing.Size(105, 40);
            this.btnNombreDelBoton.TabIndex = 1;
            this.btnNombreDelBoton.Text = "Button";
            this.btnNombreDelBoton.UseVisualStyleBackColor = false;
            // 
            // Campo
            // 
            this.Campo.AutoSize = true;
            this.Campo.ForeColor = System.Drawing.Color.Black;
            this.Campo.Location = new System.Drawing.Point(273, 103);
            this.Campo.Name = "Campo";
            this.Campo.Size = new System.Drawing.Size(98, 20);
            this.Campo.TabIndex = 2;
            this.Campo.Text = "checkBox1";
            this.Campo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(407, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "name: lblNombreLabel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(407, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "name: txtNombreTextBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(407, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "name: txtNombreCheckBox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(407, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "name: btnNombreButton";
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "La Paz",
            "Oruro",
            "Cochabamba",
            "Potosi",
            "Chuquisaca",
            "Tarija",
            "Santa Cruz",
            "Pando",
            "Beni"});
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox4.Location = new System.Drawing.Point(270, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(407, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "name: acpNombreAutocomplete";
            // 
            // txtAutoCompleteDataBaseValues
            // 
            this.txtAutoCompleteDataBaseValues.Location = new System.Drawing.Point(270, 242);
            this.txtAutoCompleteDataBaseValues.Name = "txtAutoCompleteDataBaseValues";
            this.txtAutoCompleteDataBaseValues.Size = new System.Drawing.Size(112, 22);
            this.txtAutoCompleteDataBaseValues.TabIndex = 14;
            this.txtAutoCompleteDataBaseValues.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(407, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "name: acpNombreAutocomplete";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bolivia",
            "Peru",
            "Brasil",
            "Argentina",
            "Colombia",
            "Chile"});
            this.comboBox1.Location = new System.Drawing.Point(261, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(407, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "name: acpNombreAutocomplete";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(270, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 38);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(407, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "name: grpNombreDeGroupBox";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(270, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 31);
            this.panel1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(407, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "name: pnlNombreDePanel";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(270, 432);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(407, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "name: cmbNombreDeComboBox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(273, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 33);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(407, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "name: picNombreDePictureBox";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAutoCompleteDataBaseValues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Campo);
            this.Controls.Add(this.btnNombreDelBoton);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNombreDelBoton;
        private System.Windows.Forms.CheckBox Campo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutoCompleteDataBaseValues;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

