namespace TrabajosPracticos123.TPractico2
{
    partial class Practico2
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
            this.LNya = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNya.Location = new System.Drawing.Point(46, 46);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(128, 18);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(46, 117);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 18);
            this.LDni.TabIndex = 1;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(46, 167);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(59, 18);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(46, 214);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(62, 18);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "Nombre";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(192, 46);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(69, 18);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Location = new System.Drawing.Point(58, 289);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(100, 33);
            this.BGuardar.TabIndex = 5;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.Location = new System.Drawing.Point(193, 289);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(100, 33);
            this.BEliminar.TabIndex = 6;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(146, 118);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(163, 20);
            this.TDni.TabIndex = 7;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(146, 212);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(163, 20);
            this.TNombre.TabIndex = 8;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(146, 165);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(163, 20);
            this.TApellido.TabIndex = 9;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // Practico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LNya);
            this.Name = "Practico2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Practico2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
    }
}