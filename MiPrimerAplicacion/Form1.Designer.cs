namespace MiPrimerAplicacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.lblUno = new System.Windows.Forms.Label();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(73, 578);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(793, 191);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Run";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.ForeColor = System.Drawing.Color.LightCoral;
            this.lblUno.Location = new System.Drawing.Point(95, 394);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(57, 21);
            this.lblUno.TabIndex = 1;
            this.lblUno.Text = "Control";
            this.lblUno.MouseLeave += new System.EventHandler(this.lblUno_MouseLeave);
            this.lblUno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblUno_MouseMove);
            // 
            // txtControl
            // 
            this.txtControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtControl.Location = new System.Drawing.Point(73, 149);
            this.txtControl.MaxLength = 50;
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(756, 26);
            this.txtControl.TabIndex = 2;
            this.txtControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtControl_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 256);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNombre.Size = new System.Drawing.Size(410, 159);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(958, 1053);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtControl);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimeraApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

