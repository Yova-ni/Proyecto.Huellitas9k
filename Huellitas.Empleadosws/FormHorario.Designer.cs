
namespace Huellitas.Empleadosws
{
    partial class FormHorario
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
            this.dgvdatosHorario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechi = new System.Windows.Forms.TextBox();
            this.iconcerrarHora = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrarHora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatosHorario
            // 
            this.dgvdatosHorario.AllowUserToAddRows = false;
            this.dgvdatosHorario.AllowUserToDeleteRows = false;
            this.dgvdatosHorario.AllowUserToResizeColumns = false;
            this.dgvdatosHorario.AllowUserToResizeRows = false;
            this.dgvdatosHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatosHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.dgvdatosHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatosHorario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdatosHorario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatosHorario.ColumnHeadersHeight = 40;
            this.dgvdatosHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvdatosHorario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdatosHorario.EnableHeadersVisualStyles = false;
            this.dgvdatosHorario.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvdatosHorario.Location = new System.Drawing.Point(0, 82);
            this.dgvdatosHorario.Name = "dgvdatosHorario";
            this.dgvdatosHorario.ReadOnly = true;
            this.dgvdatosHorario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosHorario.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdatosHorario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdatosHorario.RowTemplate.Height = 30;
            this.dgvdatosHorario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvdatosHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosHorario.Size = new System.Drawing.Size(394, 368);
            this.dgvdatosHorario.TabIndex = 85;
            this.dgvdatosHorario.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvdatosHorario_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Los horarios disponibles para el día";
            // 
            // txtfechi
            // 
            this.txtfechi.Location = new System.Drawing.Point(310, 54);
            this.txtfechi.Name = "txtfechi";
            this.txtfechi.Size = new System.Drawing.Size(71, 20);
            this.txtfechi.TabIndex = 87;
            this.txtfechi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfechi.TextChanged += new System.EventHandler(this.txtfechi_TextChanged);
            // 
            // iconcerrarHora
            // 
            this.iconcerrarHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrarHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconcerrarHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconcerrarHora.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconcerrarHora.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconcerrarHora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcerrarHora.Location = new System.Drawing.Point(348, 1);
            this.iconcerrarHora.Name = "iconcerrarHora";
            this.iconcerrarHora.Size = new System.Drawing.Size(33, 32);
            this.iconcerrarHora.TabIndex = 148;
            this.iconcerrarHora.TabStop = false;
            this.iconcerrarHora.Click += new System.EventHandler(this.iconcerrarHora_Click);
            // 
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.iconcerrarHora);
            this.Controls.Add(this.txtfechi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdatosHorario);
            this.Name = "FormHorario";
            this.Text = "FormHorari";
            this.Load += new System.EventHandler(this.FormHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrarHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvdatosHorario;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtfechi;
        private FontAwesome.Sharp.IconPictureBox iconcerrarHora;
    }
}