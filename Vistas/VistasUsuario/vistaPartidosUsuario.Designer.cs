namespace QuinielaSprint1.Vistas.VistasUsuario
{
    partial class vistaPartidosUsuario
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
            this.dtPartidos.Location = new System.Drawing.Point(12, 32);
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
            this.dtPartidos.RowHeadersVisible = false;
            this.dtPartidos.RowHeadersWidth = 1030;
            this.dtPartidos.Size = new System.Drawing.Size(1034, 549);
            this.dtPartidos.TabIndex = 28;
            // 
            // vistaPartidosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1058, 612);
            this.Controls.Add(this.dtPartidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vistaPartidosUsuario";
            this.Text = "vistaPartidosUsuario";
            this.Load += new System.EventHandler(this.vistaPartidosUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPartidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtPartidos;
    }
}