namespace SistemasVentas.VISTA.DetalleIngVista
{
    partial class DetalleIngInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 95);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 54);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 137);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHAVENC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 176);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 218);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "PRECIOCOSTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 256);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 5;
            label6.Text = "PRECIOVENTA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 296);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 6;
            label7.Text = "SUBTOTAL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 173);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(447, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 215);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(447, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(180, 256);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(447, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(180, 293);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(447, 23);
            textBox7.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(262, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 357);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(447, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(526, 91);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 17;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(526, 50);
            button4.Name = "button4";
            button4.Size = new Size(101, 23);
            button4.TabIndex = 18;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DetalleIngInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleIngInsertarVista";
            Text = "DetalleIngInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
    }
}