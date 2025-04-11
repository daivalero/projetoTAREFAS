namespace tarefas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criar = new System.Windows.Forms.Button();
            this.prioridade1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.caixa6 = new System.Windows.Forms.TextBox();
            this.caixa5 = new System.Windows.Forms.TextBox();
            this.volta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.groupBox1.Controls.Add(this.volta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.criar);
            this.groupBox1.Controls.Add(this.prioridade1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.caixa6);
            this.groupBox1.Controls.Add(this.caixa5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 388);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Título";
            // 
            // criar
            // 
            this.criar.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar.Location = new System.Drawing.Point(378, 349);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(110, 34);
            this.criar.TabIndex = 14;
            this.criar.Text = "Cadastrar";
            this.criar.UseVisualStyleBackColor = true;
            // 
            // prioridade1
            // 
            this.prioridade1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.prioridade1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prioridade1.FormattingEnabled = true;
            this.prioridade1.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.prioridade1.Location = new System.Drawing.Point(371, 309);
            this.prioridade1.Name = "prioridade1";
            this.prioridade1.Size = new System.Drawing.Size(121, 21);
            this.prioridade1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecione a Prioridade";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(712, 33);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // caixa6
            // 
            this.caixa6.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa6.Location = new System.Drawing.Point(60, 123);
            this.caixa6.Multiline = true;
            this.caixa6.Name = "caixa6";
            this.caixa6.Size = new System.Drawing.Size(712, 64);
            this.caixa6.TabIndex = 10;
            this.caixa6.Text = "Descrição";
            // 
            // caixa5
            // 
            this.caixa5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa5.Location = new System.Drawing.Point(60, 50);
            this.caixa5.Name = "caixa5";
            this.caixa5.Size = new System.Drawing.Size(712, 33);
            this.caixa5.TabIndex = 9;
            this.caixa5.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // volta
            // 
            this.volta.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volta.Location = new System.Drawing.Point(723, 331);
            this.volta.Name = "volta";
            this.volta.Size = new System.Drawing.Size(110, 34);
            this.volta.TabIndex = 18;
            this.volta.Text = "Voltar";
            this.volta.UseVisualStyleBackColor = true;
            this.volta.Click += new System.EventHandler(this.volta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(879, 499);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(108)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.ComboBox prioridade1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox caixa6;
        private System.Windows.Forms.TextBox caixa5;
        private System.Windows.Forms.Button volta;
    }
}

