namespace AtencionProcesos_ListaCircularEnlazada
{
    partial class FormMain
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
            this.bttonComenzar = new System.Windows.Forms.Button();
            this.bttonMostrarReportes = new System.Windows.Forms.Button();
            this.txtCilcosOcio = new System.Windows.Forms.TextBox();
            this.lblCiclosOcio = new System.Windows.Forms.Label();
            this.txtNumMaximoProcesos = new System.Windows.Forms.TextBox();
            this.lblNumeroMaximoP = new System.Windows.Forms.Label();
            this.txtCiclosPendientes = new System.Windows.Forms.TextBox();
            this.lblCiclosPendientes = new System.Windows.Forms.Label();
            this.txtProcesosPendientes = new System.Windows.Forms.TextBox();
            this.lblNumProcesosPendientes = new System.Windows.Forms.Label();
            this.txtProcesosAtendidos = new System.Windows.Forms.TextBox();
            this.lbltotalProcesosAtendidos = new System.Windows.Forms.Label();
            this.txtListaProcesosPendientes = new System.Windows.Forms.TextBox();
            this.lblListadoProcesosPendientes = new System.Windows.Forms.Label();
            this.lblMostrarActividad = new System.Windows.Forms.Label();
            this.txtMostrarActividad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttonComenzar
            // 
            this.bttonComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonComenzar.Location = new System.Drawing.Point(12, 12);
            this.bttonComenzar.Name = "bttonComenzar";
            this.bttonComenzar.Size = new System.Drawing.Size(142, 67);
            this.bttonComenzar.TabIndex = 0;
            this.bttonComenzar.Text = "Comenzar";
            this.bttonComenzar.UseVisualStyleBackColor = true;
            this.bttonComenzar.Click += new System.EventHandler(this.bttonComenzar_Click);
            // 
            // bttonMostrarReportes
            // 
            this.bttonMostrarReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonMostrarReportes.Location = new System.Drawing.Point(204, 12);
            this.bttonMostrarReportes.Name = "bttonMostrarReportes";
            this.bttonMostrarReportes.Size = new System.Drawing.Size(142, 67);
            this.bttonMostrarReportes.TabIndex = 1;
            this.bttonMostrarReportes.Text = "Mostrar\r\nReportes";
            this.bttonMostrarReportes.UseVisualStyleBackColor = true;
            this.bttonMostrarReportes.Click += new System.EventHandler(this.bttonMostrarReportes_Click);
            // 
            // txtCilcosOcio
            // 
            this.txtCilcosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCilcosOcio.Location = new System.Drawing.Point(12, 108);
            this.txtCilcosOcio.Name = "txtCilcosOcio";
            this.txtCilcosOcio.ReadOnly = true;
            this.txtCilcosOcio.Size = new System.Drawing.Size(160, 22);
            this.txtCilcosOcio.TabIndex = 2;
            this.txtCilcosOcio.TabStop = false;
            // 
            // lblCiclosOcio
            // 
            this.lblCiclosOcio.AutoSize = true;
            this.lblCiclosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclosOcio.Location = new System.Drawing.Point(9, 92);
            this.lblCiclosOcio.Name = "lblCiclosOcio";
            this.lblCiclosOcio.Size = new System.Drawing.Size(85, 16);
            this.lblCiclosOcio.TabIndex = 0;
            this.lblCiclosOcio.Text = "Ciclos ocio";
            // 
            // txtNumMaximoProcesos
            // 
            this.txtNumMaximoProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaximoProcesos.Location = new System.Drawing.Point(12, 179);
            this.txtNumMaximoProcesos.Name = "txtNumMaximoProcesos";
            this.txtNumMaximoProcesos.ReadOnly = true;
            this.txtNumMaximoProcesos.Size = new System.Drawing.Size(160, 22);
            this.txtNumMaximoProcesos.TabIndex = 3;
            this.txtNumMaximoProcesos.TabStop = false;
            // 
            // lblNumeroMaximoP
            // 
            this.lblNumeroMaximoP.AutoSize = true;
            this.lblNumeroMaximoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMaximoP.Location = new System.Drawing.Point(9, 144);
            this.lblNumeroMaximoP.Name = "lblNumeroMaximoP";
            this.lblNumeroMaximoP.Size = new System.Drawing.Size(167, 32);
            this.lblNumeroMaximoP.TabIndex = 0;
            this.lblNumeroMaximoP.Text = "Número max. procesos\r\nformados";
            // 
            // txtCiclosPendientes
            // 
            this.txtCiclosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiclosPendientes.Location = new System.Drawing.Point(12, 321);
            this.txtCiclosPendientes.Name = "txtCiclosPendientes";
            this.txtCiclosPendientes.ReadOnly = true;
            this.txtCiclosPendientes.Size = new System.Drawing.Size(160, 22);
            this.txtCiclosPendientes.TabIndex = 5;
            this.txtCiclosPendientes.TabStop = false;
            // 
            // lblCiclosPendientes
            // 
            this.lblCiclosPendientes.AutoSize = true;
            this.lblCiclosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclosPendientes.Location = new System.Drawing.Point(9, 286);
            this.lblCiclosPendientes.Name = "lblCiclosPendientes";
            this.lblCiclosPendientes.Size = new System.Drawing.Size(163, 32);
            this.lblCiclosPendientes.TabIndex = 0;
            this.lblCiclosPendientes.Text = "Total ciclos restantes\r\nde todos los procesos";
            // 
            // txtProcesosPendientes
            // 
            this.txtProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesosPendientes.Location = new System.Drawing.Point(12, 250);
            this.txtProcesosPendientes.Name = "txtProcesosPendientes";
            this.txtProcesosPendientes.ReadOnly = true;
            this.txtProcesosPendientes.Size = new System.Drawing.Size(160, 22);
            this.txtProcesosPendientes.TabIndex = 4;
            this.txtProcesosPendientes.TabStop = false;
            // 
            // lblNumProcesosPendientes
            // 
            this.lblNumProcesosPendientes.AutoSize = true;
            this.lblNumProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProcesosPendientes.Location = new System.Drawing.Point(9, 215);
            this.lblNumProcesosPendientes.Name = "lblNumProcesosPendientes";
            this.lblNumProcesosPendientes.Size = new System.Drawing.Size(131, 32);
            this.lblNumProcesosPendientes.TabIndex = 0;
            this.lblNumProcesosPendientes.Text = "Número procesos\r\npendientes";
            // 
            // txtProcesosAtendidos
            // 
            this.txtProcesosAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesosAtendidos.Location = new System.Drawing.Point(12, 392);
            this.txtProcesosAtendidos.Name = "txtProcesosAtendidos";
            this.txtProcesosAtendidos.ReadOnly = true;
            this.txtProcesosAtendidos.Size = new System.Drawing.Size(160, 22);
            this.txtProcesosAtendidos.TabIndex = 5;
            this.txtProcesosAtendidos.TabStop = false;
            // 
            // lbltotalProcesosAtendidos
            // 
            this.lbltotalProcesosAtendidos.AutoSize = true;
            this.lbltotalProcesosAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalProcesosAtendidos.Location = new System.Drawing.Point(9, 357);
            this.lbltotalProcesosAtendidos.Name = "lbltotalProcesosAtendidos";
            this.lbltotalProcesosAtendidos.Size = new System.Drawing.Size(135, 32);
            this.lbltotalProcesosAtendidos.TabIndex = 0;
            this.lbltotalProcesosAtendidos.Text = "Total de procesos\r\natendidos";
            // 
            // txtListaProcesosPendientes
            // 
            this.txtListaProcesosPendientes.Location = new System.Drawing.Point(204, 146);
            this.txtListaProcesosPendientes.Multiline = true;
            this.txtListaProcesosPendientes.Name = "txtListaProcesosPendientes";
            this.txtListaProcesosPendientes.ReadOnly = true;
            this.txtListaProcesosPendientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaProcesosPendientes.Size = new System.Drawing.Size(142, 268);
            this.txtListaProcesosPendientes.TabIndex = 5;
            this.txtListaProcesosPendientes.TabStop = false;
            // 
            // lblListadoProcesosPendientes
            // 
            this.lblListadoProcesosPendientes.AutoSize = true;
            this.lblListadoProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoProcesosPendientes.Location = new System.Drawing.Point(201, 111);
            this.lblListadoProcesosPendientes.Name = "lblListadoProcesosPendientes";
            this.lblListadoProcesosPendientes.Size = new System.Drawing.Size(135, 32);
            this.lblListadoProcesosPendientes.TabIndex = 0;
            this.lblListadoProcesosPendientes.Text = "Número procesos \r\npendientes";
            // 
            // lblMostrarActividad
            // 
            this.lblMostrarActividad.AutoSize = true;
            this.lblMostrarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarActividad.Location = new System.Drawing.Point(395, 12);
            this.lblMostrarActividad.Name = "lblMostrarActividad";
            this.lblMostrarActividad.Size = new System.Drawing.Size(128, 16);
            this.lblMostrarActividad.TabIndex = 0;
            this.lblMostrarActividad.Text = "Mostrar actividad";
            // 
            // txtMostrarActividad
            // 
            this.txtMostrarActividad.Location = new System.Drawing.Point(362, 31);
            this.txtMostrarActividad.Multiline = true;
            this.txtMostrarActividad.Name = "txtMostrarActividad";
            this.txtMostrarActividad.ReadOnly = true;
            this.txtMostrarActividad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarActividad.Size = new System.Drawing.Size(192, 383);
            this.txtMostrarActividad.TabIndex = 5;
            this.txtMostrarActividad.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 439);
            this.Controls.Add(this.lblMostrarActividad);
            this.Controls.Add(this.lblListadoProcesosPendientes);
            this.Controls.Add(this.lblNumProcesosPendientes);
            this.Controls.Add(this.lbltotalProcesosAtendidos);
            this.Controls.Add(this.lblCiclosPendientes);
            this.Controls.Add(this.txtMostrarActividad);
            this.Controls.Add(this.txtListaProcesosPendientes);
            this.Controls.Add(this.txtProcesosAtendidos);
            this.Controls.Add(this.txtProcesosPendientes);
            this.Controls.Add(this.txtCiclosPendientes);
            this.Controls.Add(this.lblNumeroMaximoP);
            this.Controls.Add(this.txtNumMaximoProcesos);
            this.Controls.Add(this.lblCiclosOcio);
            this.Controls.Add(this.txtCilcosOcio);
            this.Controls.Add(this.bttonMostrarReportes);
            this.Controls.Add(this.bttonComenzar);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttonComenzar;
        private System.Windows.Forms.Button bttonMostrarReportes;
        private System.Windows.Forms.TextBox txtCilcosOcio;
        private System.Windows.Forms.Label lblCiclosOcio;
        private System.Windows.Forms.TextBox txtNumMaximoProcesos;
        private System.Windows.Forms.Label lblNumeroMaximoP;
        private System.Windows.Forms.TextBox txtCiclosPendientes;
        private System.Windows.Forms.Label lblCiclosPendientes;
        private System.Windows.Forms.TextBox txtProcesosPendientes;
        private System.Windows.Forms.Label lblNumProcesosPendientes;
        private System.Windows.Forms.TextBox txtProcesosAtendidos;
        private System.Windows.Forms.Label lbltotalProcesosAtendidos;
        private System.Windows.Forms.TextBox txtListaProcesosPendientes;
        private System.Windows.Forms.Label lblListadoProcesosPendientes;
        private System.Windows.Forms.Label lblMostrarActividad;
        private System.Windows.Forms.TextBox txtMostrarActividad;
    }
}

