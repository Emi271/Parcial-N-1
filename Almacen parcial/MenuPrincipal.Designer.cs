namespace Almacen_parcial
{
    partial class MenuPrincipal
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
            this.MenuProductos = new System.Windows.Forms.Button();
            this.MenuEnvios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuProductos
            // 
            this.MenuProductos.Location = new System.Drawing.Point(54, 281);
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(129, 23);
            this.MenuProductos.TabIndex = 3;
            this.MenuProductos.Text = "Ver Productos";
            this.MenuProductos.UseVisualStyleBackColor = true;
            this.MenuProductos.Click += new System.EventHandler(this.MenuProductos_Click);
            // 
            // MenuEnvios
            // 
            this.MenuEnvios.Location = new System.Drawing.Point(419, 281);
            this.MenuEnvios.Name = "MenuEnvios";
            this.MenuEnvios.Size = new System.Drawing.Size(99, 23);
            this.MenuEnvios.TabIndex = 4;
            this.MenuEnvios.Text = "Envíos";
            this.MenuEnvios.UseVisualStyleBackColor = true;
            this.MenuEnvios.Click += new System.EventHandler(this.MenuEnvios_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuEnvios);
            this.Controls.Add(this.MenuProductos);
            this.Name = "MenuPrincipal";
            this.Size = new System.Drawing.Size(616, 386);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MenuProductos;
        private System.Windows.Forms.Button MenuEnvios;
    }
}
