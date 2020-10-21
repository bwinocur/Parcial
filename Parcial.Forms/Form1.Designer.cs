namespace Parcial.Forms
{
    partial class Form1
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
            this.cargarAsistenciaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mostrarAsistenciaButton = new System.Windows.Forms.Button();
            this.asistenciaAlumnosTextBox = new System.Windows.Forms.ListBox();
            this.traerAlumnosButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cargarAsistenciaButton
            // 
            this.cargarAsistenciaButton.Location = new System.Drawing.Point(12, 415);
            this.cargarAsistenciaButton.Name = "cargarAsistenciaButton";
            this.cargarAsistenciaButton.Size = new System.Drawing.Size(143, 23);
            this.cargarAsistenciaButton.TabIndex = 0;
            this.cargarAsistenciaButton.Text = "Confirmar carga";
            this.cargarAsistenciaButton.UseVisualStyleBackColor = true;
            this.cargarAsistenciaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carga de presentismo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese la fecha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(28, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Día";
            // 
            // mostrarAsistenciaButton
            // 
            this.mostrarAsistenciaButton.Location = new System.Drawing.Point(675, 67);
            this.mostrarAsistenciaButton.Name = "mostrarAsistenciaButton";
            this.mostrarAsistenciaButton.Size = new System.Drawing.Size(121, 23);
            this.mostrarAsistenciaButton.TabIndex = 12;
            this.mostrarAsistenciaButton.Text = "Mostrar Presentismo";
            this.mostrarAsistenciaButton.UseVisualStyleBackColor = true;
            this.mostrarAsistenciaButton.Click += new System.EventHandler(this.mostrarAsistenciaButton_Click);
            // 
            // asistenciaAlumnosTextBox
            // 
            this.asistenciaAlumnosTextBox.FormattingEnabled = true;
            this.asistenciaAlumnosTextBox.Location = new System.Drawing.Point(497, 96);
            this.asistenciaAlumnosTextBox.Name = "asistenciaAlumnosTextBox";
            this.asistenciaAlumnosTextBox.Size = new System.Drawing.Size(470, 329);
            this.asistenciaAlumnosTextBox.TabIndex = 13;
            // 
            // traerAlumnosButton
            // 
            this.traerAlumnosButton.Location = new System.Drawing.Point(12, 99);
            this.traerAlumnosButton.Name = "traerAlumnosButton";
            this.traerAlumnosButton.Size = new System.Drawing.Size(143, 23);
            this.traerAlumnosButton.TabIndex = 14;
            this.traerAlumnosButton.Text = "Tomar presentismo";
            this.traerAlumnosButton.UseVisualStyleBackColor = true;
            this.traerAlumnosButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 128);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(245, 274);
            this.checkedListBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Día";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(748, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(746, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(712, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(28, 20);
            this.textBox5.TabIndex = 25;
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(675, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ingrese la fecha";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(678, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(28, 20);
            this.textBox6.TabIndex = 23;
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.traerAlumnosButton);
            this.Controls.Add(this.asistenciaAlumnosTextBox);
            this.Controls.Add(this.mostrarAsistenciaButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cargarAsistenciaButton);
            this.Name = "Form1";
            this.Text = "Presentismo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargarAsistenciaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mostrarAsistenciaButton;
        private System.Windows.Forms.ListBox asistenciaAlumnosTextBox;
        private System.Windows.Forms.Button traerAlumnosButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
    }
}

