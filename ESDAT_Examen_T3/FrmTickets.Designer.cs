namespace ESDAT_Examen_T3
{
    partial class FrmTickets
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLista = new System.Windows.Forms.ListView();
            this.btnAtender = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción ticket:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 22);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(248, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.rbUrgente);
            this.gbDatos.Controls.Add(this.rbNormal);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(378, 90);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Crear nuevo ticket";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(297, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(188, 51);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbUrgente.TabIndex = 4;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            this.rbUrgente.CheckedChanged += new System.EventHandler(this.rbUrgente_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(124, 51);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 3;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prioridad:";
            // 
            // lvLista
            // 
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLista.FullRowSelect = true;
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(12, 108);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(378, 209);
            this.lvLista.TabIndex = 3;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // btnAtender
            // 
            this.btnAtender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.Location = new System.Drawing.Point(273, 323);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(117, 25);
            this.btnAtender.TabIndex = 4;
            this.btnAtender.Text = "Atender ticket";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prioridad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 270;
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 360);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lvLista);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.FrmTickets_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbUrgente;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

