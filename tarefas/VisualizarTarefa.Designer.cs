using System.Windows.Forms;


namespace tarefas
{
    partial class VisualizarTarefa
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label lblData;
        private Label lblPrioridade;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(30, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(30, 110);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(89, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Vencimento";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(30, 150);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lblPrioridade.TabIndex = 3;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // VisualizarTarefa
            // 
            this.ClientSize = new System.Drawing.Size(442, 203);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPrioridade);
            this.Name = "VisualizarTarefa";
            this.Text = "Detalhes da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
