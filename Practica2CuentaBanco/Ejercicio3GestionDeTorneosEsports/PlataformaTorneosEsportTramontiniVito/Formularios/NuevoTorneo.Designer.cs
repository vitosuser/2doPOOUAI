namespace PlataformaTorneosEsportTramontiniVito.Formularios
{
    partial class NuevoTorneo
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
            btnSalir = new Button();
            lblNombreTorneo = new Label();
            txtNombreTorneo = new TextBox();
            lblJuego = new Label();
            cboxJuego = new ComboBox();
            button1 = new Button();
            lblFechaInicio = new Label();
            timeInicio = new DateTimePicker();
            lblFechaFin = new Label();
            timeFinalizacion = new DateTimePicker();
            lblTitulo = new Label();
            lblPremio = new Label();
            txtPremio = new TextBox();
            lblFormato = new Label();
            cboxFormato = new ComboBox();
            lblEstado = new Label();
            cboxEstado = new ComboBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(21, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblNombreTorneo
            // 
            lblNombreTorneo.AutoSize = true;
            lblNombreTorneo.Font = new Font("Segoe UI", 10F);
            lblNombreTorneo.Location = new Point(21, 88);
            lblNombreTorneo.Name = "lblNombreTorneo";
            lblNombreTorneo.Size = new Size(134, 19);
            lblNombreTorneo.TabIndex = 1;
            lblNombreTorneo.Text = "Nombre del Torneo: ";
            // 
            // txtNombreTorneo
            // 
            txtNombreTorneo.Font = new Font("Segoe UI", 10F);
            txtNombreTorneo.Location = new Point(161, 85);
            txtNombreTorneo.Name = "txtNombreTorneo";
            txtNombreTorneo.Size = new Size(165, 25);
            txtNombreTorneo.TabIndex = 2;
            // 
            // lblJuego
            // 
            lblJuego.AutoSize = true;
            lblJuego.Font = new Font("Segoe UI", 11F);
            lblJuego.Location = new Point(413, 84);
            lblJuego.Name = "lblJuego";
            lblJuego.Size = new Size(55, 20);
            lblJuego.TabIndex = 3;
            lblJuego.Text = "Juego: ";
            // 
            // cboxJuego
            // 
            cboxJuego.Font = new Font("Segoe UI", 11F);
            cboxJuego.FormattingEnabled = true;
            cboxJuego.Location = new Point(488, 83);
            cboxJuego.Name = "cboxJuego";
            cboxJuego.Size = new Size(121, 28);
            cboxJuego.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(564, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 11F);
            lblFechaInicio.Location = new Point(21, 127);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(115, 20);
            lblFechaInicio.TabIndex = 6;
            lblFechaInicio.Text = "Fecha de Inicio: ";
            // 
            // timeInicio
            // 
            timeInicio.Location = new Point(142, 127);
            timeInicio.Name = "timeInicio";
            timeInicio.Size = new Size(200, 23);
            timeInicio.TabIndex = 7;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 11F);
            lblFechaFin.Location = new Point(21, 169);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(157, 20);
            lblFechaFin.TabIndex = 8;
            lblFechaFin.Text = "Fecha de Finalización: ";
            // 
            // timeFinalizacion
            // 
            timeFinalizacion.Location = new Point(184, 170);
            timeFinalizacion.Name = "timeFinalizacion";
            timeFinalizacion.Size = new Size(200, 23);
            timeFinalizacion.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.Location = new Point(21, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 25);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "NUEVO TORNEO";
            // 
            // lblPremio
            // 
            lblPremio.AutoSize = true;
            lblPremio.Font = new Font("Segoe UI", 11F);
            lblPremio.Location = new Point(413, 127);
            lblPremio.Name = "lblPremio";
            lblPremio.Size = new Size(63, 20);
            lblPremio.TabIndex = 11;
            lblPremio.Text = "Premio: ";
            lblPremio.Click += label1_Click;
            // 
            // txtPremio
            // 
            txtPremio.Font = new Font("Segoe UI", 11F);
            txtPremio.Location = new Point(478, 125);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(131, 27);
            txtPremio.TabIndex = 12;
            txtPremio.Text = "$";
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.Font = new Font("Segoe UI", 11F);
            lblFormato.Location = new Point(413, 169);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(68, 20);
            lblFormato.TabIndex = 13;
            lblFormato.Text = "Formato:";
            // 
            // cboxFormato
            // 
            cboxFormato.Font = new Font("Segoe UI", 11F);
            cboxFormato.FormattingEnabled = true;
            cboxFormato.Location = new Point(483, 169);
            cboxFormato.Name = "cboxFormato";
            cboxFormato.Size = new Size(121, 28);
            cboxFormato.TabIndex = 14;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 11F);
            lblEstado.Location = new Point(21, 215);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(134, 20);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado del torneo: ";
            // 
            // cboxEstado
            // 
            cboxEstado.Font = new Font("Segoe UI", 11F);
            cboxEstado.FormattingEnabled = true;
            cboxEstado.Location = new Point(161, 212);
            cboxEstado.Name = "cboxEstado";
            cboxEstado.Size = new Size(121, 28);
            cboxEstado.TabIndex = 16;
            // 
            // NuevoTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(661, 452);
            Controls.Add(cboxEstado);
            Controls.Add(lblEstado);
            Controls.Add(cboxFormato);
            Controls.Add(lblFormato);
            Controls.Add(txtPremio);
            Controls.Add(lblPremio);
            Controls.Add(lblTitulo);
            Controls.Add(timeFinalizacion);
            Controls.Add(lblFechaFin);
            Controls.Add(timeInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(button1);
            Controls.Add(cboxJuego);
            Controls.Add(lblJuego);
            Controls.Add(txtNombreTorneo);
            Controls.Add(lblNombreTorneo);
            Controls.Add(btnSalir);
            Name = "NuevoTorneo";
            Text = "NuevoTorneo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblNombreTorneo;
        private TextBox txtNombreTorneo;
        private Label lblJuego;
        private ComboBox cboxJuego;
        private Button button1;
        private Label lblFechaInicio;
        private DateTimePicker timeInicio;
        private Label lblFechaFin;
        private DateTimePicker timeFinalizacion;
        private Label lblTitulo;
        private Label lblPremio;
        private TextBox txtPremio;
        private Label lblFormato;
        private ComboBox cboxFormato;
        private Label lblEstado;
        private ComboBox cboxEstado;
    }
}