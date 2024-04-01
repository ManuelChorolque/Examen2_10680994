namespace SistemasVentas.VISTA.VendedorVista
{
    partial class VendedorInsertarVista
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            domainUpDown1 = new DomainUpDown();
            panel2 = new Panel();
            label2 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(domainUpDown1);
            panel1.Location = new Point(2, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 476);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.DialogResult = DialogResult.OK;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(10, 199);
            button5.Name = "button5";
            button5.Size = new Size(97, 34);
            button5.TabIndex = 19;
            button5.Text = "AGREGAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.DialogResult = DialogResult.Cancel;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(204, 428);
            button4.Name = "button4";
            button4.Size = new Size(97, 34);
            button4.TabIndex = 18;
            button4.Text = "CANCELAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.DialogResult = DialogResult.OK;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(69, 428);
            button3.Name = "button3";
            button3.Size = new Size(97, 34);
            button3.TabIndex = 17;
            button3.Text = "GUARDAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(417, 385);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(366, 385);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "TOTAL :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(10, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(439, 150);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(347, 127);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 9;
            button2.Text = "SELECCIONAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(10, 172);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 7;
            label5.Text = "CANTIDAD :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(7, 130);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "PRODUCTO :";
            // 
            // button1
            // 
            button1.Location = new Point(347, 36);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 5;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(87, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(362, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(31, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "FECHA :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(24, 39);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "CLIENTE :";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("1");
            domainUpDown1.Items.Add("2");
            domainUpDown1.Items.Add("3");
            domainUpDown1.Items.Add("4");
            domainUpDown1.Items.Add("5");
            domainUpDown1.Items.Add("6");
            domainUpDown1.Items.Add("7");
            domainUpDown1.Items.Add("8");
            domainUpDown1.Items.Add("9");
            domainUpDown1.Items.Add("10");
            domainUpDown1.Items.Add("11");
            domainUpDown1.Items.Add("12");
            domainUpDown1.Items.Add("13");
            domainUpDown1.Items.Add("14");
            domainUpDown1.Items.Add("15");
            domainUpDown1.Items.Add("16");
            domainUpDown1.Items.Add("17");
            domainUpDown1.Items.Add("18");
            domainUpDown1.Items.Add("19");
            domainUpDown1.Items.Add("20");
            domainUpDown1.Location = new Point(87, 170);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.ReadOnly = true;
            domainUpDown1.Size = new Size(79, 23);
            domainUpDown1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 90);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 22);
            label2.Name = "label2";
            label2.Size = new Size(338, 45);
            label2.TabIndex = 13;
            label2.Text = "VENDER PRODUCTO";
            // 
            // Column1
            // 
            Column1.HeaderText = "NRO";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "DETALLE";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "CANTIDAD";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "PRECIO";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "SUBTOTAL";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // VendedorInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VendedorInsertarVista";
            Text = "VendedorInsertarVista";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DomainUpDown domainUpDown1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Button button2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}