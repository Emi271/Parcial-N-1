namespace Almacen_parcial
{
    partial class MenuEnvios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuEnvios = new System.Windows.Forms.Panel();
            this.Subtitulo1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.Titulo3 = new System.Windows.Forms.Label();
            this.listViewRepartidores = new System.Windows.Forms.ListView();
            this.buttonSeleccionarRepartidor = new System.Windows.Forms.Button();
            this.panelMenuEnvios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuEnvios
            // 
            this.panelMenuEnvios.Controls.Add(this.buttonSeleccionarRepartidor);
            this.panelMenuEnvios.Controls.Add(this.listViewRepartidores);
            this.panelMenuEnvios.Controls.Add(this.Subtitulo1);
            this.panelMenuEnvios.Controls.Add(this.buttonVolver);
            this.panelMenuEnvios.Controls.Add(this.Titulo3);
            this.panelMenuEnvios.Location = new System.Drawing.Point(3, 3);
            this.panelMenuEnvios.Name = "panelMenuEnvios";
            this.panelMenuEnvios.Size = new System.Drawing.Size(754, 363);
            this.panelMenuEnvios.TabIndex = 0;
            this.panelMenuEnvios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuEnvios_Paint);
            // 
            // Subtitulo1
            // 
            this.Subtitulo1.AutoSize = true;
            this.Subtitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Subtitulo1.Location = new System.Drawing.Point(28, 95);
            this.Subtitulo1.Name = "Subtitulo1";
            this.Subtitulo1.Size = new System.Drawing.Size(175, 20);
            this.Subtitulo1.TabIndex = 3;
            this.Subtitulo1.Text = "Seleccione el repartidor";
            this.Subtitulo1.Click += new System.EventHandler(this.Subtitulo1_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(23, 43);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(50, 29);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Titulo3
            // 
            this.Titulo3.AutoSize = true;
            this.Titulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Titulo3.Location = new System.Drawing.Point(97, 43);
            this.Titulo3.Name = "Titulo3";
            this.Titulo3.Size = new System.Drawing.Size(85, 29);
            this.Titulo3.TabIndex = 0;
            this.Titulo3.Text = "Envios";
            this.Titulo3.Click += new System.EventHandler(this.Titulo3_Click);
            // 
            // listViewRepartidores
            // 
            this.listViewRepartidores.HideSelection = false;
            this.listViewRepartidores.Location = new System.Drawing.Point(52, 145);
            this.listViewRepartidores.Name = "listViewRepartidores";
            this.listViewRepartidores.Size = new System.Drawing.Size(642, 190);
            this.listViewRepartidores.TabIndex = 4;
            this.listViewRepartidores.UseCompatibleStateImageBehavior = false;
            this.listViewRepartidores.View = System.Windows.Forms.View.Details;
            // 
            // buttonSeleccionarRepartidor
            // 
            this.buttonSeleccionarRepartidor.Location = new System.Drawing.Point(591, 114);
            this.buttonSeleccionarRepartidor.Name = "buttonSeleccionarRepartidor";
            this.buttonSeleccionarRepartidor.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarRepartidor.TabIndex = 5;
            this.buttonSeleccionarRepartidor.Text = "Seleccionar";
            this.buttonSeleccionarRepartidor.UseVisualStyleBackColor = true;
            this.buttonSeleccionarRepartidor.Click += new System.EventHandler(this.buttonSeleccionarRepartidor_Click);
            // 
            // MenuEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenuEnvios);
            this.Name = "MenuEnvios";
            this.Size = new System.Drawing.Size(760, 369);
            this.Load += new System.EventHandler(this.MenuEnvios_Load);
            this.panelMenuEnvios.ResumeLayout(false);
            this.panelMenuEnvios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuEnvios;
        private System.Windows.Forms.Label Titulo3;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label Subtitulo1;
        private System.Windows.Forms.ListView listViewRepartidores;
        private System.Windows.Forms.Button buttonSeleccionarRepartidor;
    }
}
