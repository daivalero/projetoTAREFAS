using System.Windows.Forms;


namespace tarefas
{
    partial class VisualizarTarefa
    {
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();
            // 
            // VisualizarTarefa
            // 
            this.ClientSize = new System.Drawing.Size(564, 280);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VisualizarTarefa";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.VisualizarTarefa_Load);
            this.ResumeLayout(false);

        }
    }
}
