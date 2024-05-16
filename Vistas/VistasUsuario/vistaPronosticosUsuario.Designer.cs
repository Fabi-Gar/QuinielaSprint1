namespace QuinielaSprint1.Vistas.VistasUsuario
{
    partial class vistaPronosticosUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtPartidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnReiniciar = new QuinielaSprint1.Botones.RJButton();
            this.btnPerder = new QuinielaSprint1.Botones.RJButton();
            this.btnEmpate = new QuinielaSprint1.Botones.RJButton();
            this.btnGanador = new QuinielaSprint1.Botones.RJButton();
            this.btnPronosticar = new QuinielaSprint1.Botones.RJButton();
            this.btnLocal = new QuinielaSprint1.Botones.RJButton();
            this.btnVisitante = new QuinielaSprint1.Botones.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPartidos
            // 
            this.dtPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtPartidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPartidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPartidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtPartidos.EnableHeadersVisualStyles = false;
            this.dtPartidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(216)))), ((int)(((byte)(227)))));
            this.dtPartidos.Location = new System.Drawing.Point(12, 12);
            this.dtPartidos.Name = "dtPartidos";
            this.dtPartidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPartidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtPartidos.RowHeadersWidth = 105;
            this.dtPartidos.Size = new System.Drawing.Size(461, 549);
            this.dtPartidos.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Haga click en el partido que desea pronosticar y luego eliga al equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Usted escogio al equipo";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.ForeColor = System.Drawing.Color.White;
            this.lblEquipo.Location = new System.Drawing.Point(475, 176);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(13, 20);
            this.lblEquipo.TabIndex = 33;
            this.lblEquipo.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(475, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "¿Cual sera el resultado?";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(475, 365);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 20);
            this.lblResultado.TabIndex = 40;
            this.lblResultado.Text = ".";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnReiniciar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnReiniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReiniciar.BorderRadius = 15;
            this.btnReiniciar.BorderSize = 0;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(479, 521);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(215, 40);
            this.btnReiniciar.TabIndex = 38;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.TextColor = System.Drawing.Color.White;
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnPerder
            // 
            this.btnPerder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnPerder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnPerder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPerder.BorderRadius = 15;
            this.btnPerder.BorderSize = 0;
            this.btnPerder.FlatAppearance.BorderSize = 0;
            this.btnPerder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerder.ForeColor = System.Drawing.Color.White;
            this.btnPerder.Location = new System.Drawing.Point(869, 236);
            this.btnPerder.Name = "btnPerder";
            this.btnPerder.Size = new System.Drawing.Size(171, 40);
            this.btnPerder.TabIndex = 37;
            this.btnPerder.Text = "Perdedor";
            this.btnPerder.TextColor = System.Drawing.Color.White;
            this.btnPerder.UseVisualStyleBackColor = false;
            this.btnPerder.Click += new System.EventHandler(this.btnPerder_Click);
            // 
            // btnEmpate
            // 
            this.btnEmpate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnEmpate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnEmpate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEmpate.BorderRadius = 15;
            this.btnEmpate.BorderSize = 0;
            this.btnEmpate.FlatAppearance.BorderSize = 0;
            this.btnEmpate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpate.ForeColor = System.Drawing.Color.White;
            this.btnEmpate.Location = new System.Drawing.Point(671, 236);
            this.btnEmpate.Name = "btnEmpate";
            this.btnEmpate.Size = new System.Drawing.Size(171, 40);
            this.btnEmpate.TabIndex = 36;
            this.btnEmpate.Text = "Empate";
            this.btnEmpate.TextColor = System.Drawing.Color.White;
            this.btnEmpate.UseVisualStyleBackColor = false;
            this.btnEmpate.Click += new System.EventHandler(this.btnEmpate_Click);
            // 
            // btnGanador
            // 
            this.btnGanador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnGanador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnGanador.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGanador.BorderRadius = 15;
            this.btnGanador.BorderSize = 0;
            this.btnGanador.FlatAppearance.BorderSize = 0;
            this.btnGanador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanador.ForeColor = System.Drawing.Color.White;
            this.btnGanador.Location = new System.Drawing.Point(479, 236);
            this.btnGanador.Name = "btnGanador";
            this.btnGanador.Size = new System.Drawing.Size(171, 40);
            this.btnGanador.TabIndex = 35;
            this.btnGanador.Text = "Ganador";
            this.btnGanador.TextColor = System.Drawing.Color.White;
            this.btnGanador.UseVisualStyleBackColor = false;
            this.btnGanador.Click += new System.EventHandler(this.btnGanador_Click);
            // 
            // btnPronosticar
            // 
            this.btnPronosticar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnPronosticar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnPronosticar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPronosticar.BorderRadius = 15;
            this.btnPronosticar.BorderSize = 0;
            this.btnPronosticar.FlatAppearance.BorderSize = 0;
            this.btnPronosticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPronosticar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronosticar.ForeColor = System.Drawing.Color.White;
            this.btnPronosticar.Location = new System.Drawing.Point(825, 521);
            this.btnPronosticar.Name = "btnPronosticar";
            this.btnPronosticar.Size = new System.Drawing.Size(215, 40);
            this.btnPronosticar.TabIndex = 32;
            this.btnPronosticar.Text = "Pronosticar";
            this.btnPronosticar.TextColor = System.Drawing.Color.White;
            this.btnPronosticar.UseVisualStyleBackColor = false;
            this.btnPronosticar.Click += new System.EventHandler(this.btnPronosticar_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnLocal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnLocal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLocal.BorderRadius = 15;
            this.btnLocal.BorderSize = 0;
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.Location = new System.Drawing.Point(489, 43);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(215, 40);
            this.btnLocal.TabIndex = 29;
            this.btnLocal.Text = "Local";
            this.btnLocal.TextColor = System.Drawing.Color.White;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnVisitante
            // 
            this.btnVisitante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnVisitante.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(149)))), ((int)(((byte)(154)))));
            this.btnVisitante.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVisitante.BorderRadius = 15;
            this.btnVisitante.BorderSize = 0;
            this.btnVisitante.FlatAppearance.BorderSize = 0;
            this.btnVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitante.ForeColor = System.Drawing.Color.White;
            this.btnVisitante.Location = new System.Drawing.Point(825, 43);
            this.btnVisitante.Name = "btnVisitante";
            this.btnVisitante.Size = new System.Drawing.Size(215, 40);
            this.btnVisitante.TabIndex = 28;
            this.btnVisitante.Text = "Visitante";
            this.btnVisitante.TextColor = System.Drawing.Color.White;
            this.btnVisitante.UseVisualStyleBackColor = false;
            this.btnVisitante.Click += new System.EventHandler(this.btnVisitante_Click);
            // 
            // vistaPronosticosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1042, 573);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnPerder);
            this.Controls.Add(this.btnEmpate);
            this.Controls.Add(this.btnGanador);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.btnPronosticar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnVisitante);
            this.Controls.Add(this.dtPartidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vistaPronosticosUsuario";
            this.Text = "vistaPronosticosUsuario";
            this.Load += new System.EventHandler(this.vistaPronosticosUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtPartidos;
        public Botones.RJButton btnVisitante;
        public Botones.RJButton btnLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Botones.RJButton btnPronosticar;
        public System.Windows.Forms.Label lblEquipo;
        public Botones.RJButton btnGanador;
        public Botones.RJButton btnEmpate;
        public Botones.RJButton btnPerder;
        public Botones.RJButton btnReiniciar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblResultado;
    }
}