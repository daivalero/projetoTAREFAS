namespace tarefas
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            // flowLayoutPanel1
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0); // removido para alinhar à esquerda
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;


            // Home
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Home";
            this.Text = "Minhas Tarefas";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
        }

    }
}
