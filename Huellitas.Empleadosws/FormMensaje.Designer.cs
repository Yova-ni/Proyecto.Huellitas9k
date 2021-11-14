
namespace Huellitas.Empleadosws
{
    partial class FormMensaje
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.iconbtnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(1, 56);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(354, 53);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "MENSAJE";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // iconbtnCerrar
            // 
            this.iconbtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.iconbtnCerrar.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnCerrar.IconSize = 40;
            this.iconbtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconbtnCerrar.Location = new System.Drawing.Point(92, 128);
            this.iconbtnCerrar.Name = "iconbtnCerrar";
            this.iconbtnCerrar.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.iconbtnCerrar.Size = new System.Drawing.Size(171, 40);
            this.iconbtnCerrar.TabIndex = 3;
            this.iconbtnCerrar.Text = "Cerrar";
            this.iconbtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconbtnCerrar.UseVisualStyleBackColor = true;
            this.iconbtnCerrar.Click += new System.EventHandler(this.iconbtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 29);
            this.panel1.TabIndex = 4;
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(357, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconbtnCerrar);
            this.Controls.Add(this.lblMensaje);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(300, 200);
            this.Name = "FormMensaje";
            this.Text = "FormMensaje";
            this.Load += new System.EventHandler(this.FormMensaje_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMensaje_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconbtnCerrar;
        public System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panel1;
    }
}