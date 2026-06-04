namespace PlataformaTorneosEsportTramontiniVito
{
    partial class GestionarTorneos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevoTorneo = new Button();
            btnBuscarTorneos = new Button();
            menuStrip1 = new MenuStrip();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lblTituloSistema = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoTorneo
            // 
            btnNuevoTorneo.Location = new Point(160, 106);
            btnNuevoTorneo.Name = "btnNuevoTorneo";
            btnNuevoTorneo.Size = new Size(135, 45);
            btnNuevoTorneo.TabIndex = 0;
            btnNuevoTorneo.Text = "NUEVO TORNEO";
            btnNuevoTorneo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTorneos
            // 
            btnBuscarTorneos.Location = new Point(160, 171);
            btnBuscarTorneos.Name = "btnBuscarTorneos";
            btnBuscarTorneos.Size = new Size(135, 45);
            btnBuscarTorneos.TabIndex = 1;
            btnBuscarTorneos.Text = "VER TORNEOS";
            btnBuscarTorneos.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(469, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(72, 20);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // lblTituloSistema
            // 
            lblTituloSistema.AutoSize = true;
            lblTituloSistema.Font = new Font("Segoe UI", 14F);
            lblTituloSistema.Location = new Point(40, 53);
            lblTituloSistema.Name = "lblTituloSistema";
            lblTituloSistema.Size = new Size(390, 25);
            lblTituloSistema.TabIndex = 4;
            lblTituloSistema.Text = "SISTEMA DE GESTIÓN DE TORNEOS ESPORTS";
            // 
            // GestionarTorneos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(469, 268);
            Controls.Add(lblTituloSistema);
            Controls.Add(menuStrip1);
            Controls.Add(btnBuscarTorneos);
            Controls.Add(btnNuevoTorneo);
            MainMenuStrip = menuStrip1;
            Name = "GestionarTorneos";
            Text = "Torneos Esports";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoTorneo;
        private Button btnBuscarTorneos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lblTituloSistema;
    }
}
