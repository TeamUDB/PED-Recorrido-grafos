namespace Grafos
{
    partial class Simulator
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
            this.components = new System.ComponentModel.Container();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalNodos = new System.Windows.Forms.TextBox();
            this.lbNodoInicial = new System.Windows.Forms.Label();
            this.txtNodoInicial = new System.Windows.Forms.TextBox();
            this.btnAncho = new System.Windows.Forms.Button();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.CMSCrearVertice.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pizarra
            // 
            this.Pizarra.BackColor = System.Drawing.Color.SteelBlue;
            this.Pizarra.Location = new System.Drawing.Point(24, 127);
            this.Pizarra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(1098, 844);
            this.Pizarra.TabIndex = 0;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizarra_Paint);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.Pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseUp);
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agregar,
            this.eliminarVerticeToolStripMenuItem,
            this.eliminarArcoToolStripMenuItem});
            this.CMSCrearVertice.Name = "CMSCrearVertice";
            this.CMSCrearVertice.Size = new System.Drawing.Size(253, 118);
            // 
            // Agregar
            // 
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(252, 38);
            this.Agregar.Text = "Nuevo Vertice";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // eliminarVerticeToolStripMenuItem
            // 
            this.eliminarVerticeToolStripMenuItem.Name = "eliminarVerticeToolStripMenuItem";
            this.eliminarVerticeToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.eliminarVerticeToolStripMenuItem.Text = "Eliminar Vertice";
            this.eliminarVerticeToolStripMenuItem.Click += new System.EventHandler(this.eliminarVerticeToolStripMenuItem_Click);
            // 
            // eliminarArcoToolStripMenuItem
            // 
            this.eliminarArcoToolStripMenuItem.Name = "eliminarArcoToolStripMenuItem";
            this.eliminarArcoToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.eliminarArcoToolStripMenuItem.Text = "Eliminar Arco";
            this.eliminarArcoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArcoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulador de Grafos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1147, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de nodos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotalNodos
            // 
            this.txtTotalNodos.Location = new System.Drawing.Point(1425, 291);
            this.txtTotalNodos.Name = "txtTotalNodos";
            this.txtTotalNodos.ReadOnly = true;
            this.txtTotalNodos.Size = new System.Drawing.Size(100, 31);
            this.txtTotalNodos.TabIndex = 3;
            this.txtTotalNodos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNodoInicial
            // 
            this.lbNodoInicial.AutoSize = true;
            this.lbNodoInicial.Location = new System.Drawing.Point(1147, 374);
            this.lbNodoInicial.Name = "lbNodoInicial";
            this.lbNodoInicial.Size = new System.Drawing.Size(124, 25);
            this.lbNodoInicial.TabIndex = 4;
            this.lbNodoInicial.Text = "Nodo Inicial";
            // 
            // txtNodoInicial
            // 
            this.txtNodoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodoInicial.Location = new System.Drawing.Point(1143, 422);
            this.txtNodoInicial.Name = "txtNodoInicial";
            this.txtNodoInicial.Size = new System.Drawing.Size(537, 44);
            this.txtNodoInicial.TabIndex = 5;
            this.txtNodoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAncho
            // 
            this.btnAncho.Location = new System.Drawing.Point(1143, 508);
            this.btnAncho.Name = "btnAncho";
            this.btnAncho.Size = new System.Drawing.Size(255, 47);
            this.btnAncho.TabIndex = 6;
            this.btnAncho.Text = "Recorrido a lo Ancho";
            this.btnAncho.UseVisualStyleBackColor = true;
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Location = new System.Drawing.Point(1425, 508);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(255, 47);
            this.btnProfundidad.TabIndex = 7;
            this.btnProfundidad.Text = "Recorrido profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1768, 994);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.btnAncho);
            this.Controls.Add(this.txtNodoInicial);
            this.Controls.Add(this.lbNodoInicial);
            this.Controls.Add(this.txtTotalNodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pizarra);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Simulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Simulator_Load);
            this.CMSCrearVertice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem Agregar;
        private System.Windows.Forms.ToolStripMenuItem eliminarVerticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArcoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalNodos;
        private System.Windows.Forms.Label lbNodoInicial;
        private System.Windows.Forms.TextBox txtNodoInicial;
        private System.Windows.Forms.Button btnAncho;
        private System.Windows.Forms.Button btnProfundidad;
    }
}