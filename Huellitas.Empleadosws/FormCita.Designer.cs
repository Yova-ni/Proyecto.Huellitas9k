
namespace Huellitas.Empleadosws
{
    partial class FormCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbuscarcita = new System.Windows.Forms.TextBox();
            this.lblbuscarEmpleado = new System.Windows.Forms.Label();
            this.dgvdatosCita = new System.Windows.Forms.DataGridView();
            this.txtfechaCita = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtidCita = new System.Windows.Forms.TextBox();
            this.dateTimefechaCita = new System.Windows.Forms.DateTimePicker();
            this.txthorafinCita = new System.Windows.Forms.TextBox();
            this.txthorainicioCita = new System.Windows.Forms.TextBox();
            this.txtprecioservicioCita = new System.Windows.Forms.TextBox();
            this.txttiposervicioCita = new System.Windows.Forms.TextBox();
            this.txtapellidomclienteCita = new System.Windows.Forms.TextBox();
            this.txtapellidoclienteCita = new System.Windows.Forms.TextBox();
            this.txtnombreclienteCita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCRUD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.iconbtnhoraCita = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconbtnservis = new FontAwesome.Sharp.IconPictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.iconbtnbuscarclienteCita = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconbtnagregardatosCita = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconbtnmodificarCita = new FontAwesome.Sharp.IconPictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.iconbtneliminarCita = new FontAwesome.Sharp.IconPictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.iconbtnlimpiarCita = new FontAwesome.Sharp.IconPictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.iconbtnguardarCita = new FontAwesome.Sharp.IconPictureBox();
            this.iconcerrarCita = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnhoraCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnservis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnbuscarclienteCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnagregardatosCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnmodificarCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtneliminarCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnlimpiarCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnguardarCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscarcita
            // 
            this.txtbuscarcita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbuscarcita.Location = new System.Drawing.Point(38, 278);
            this.txtbuscarcita.Name = "txtbuscarcita";
            this.txtbuscarcita.Size = new System.Drawing.Size(211, 20);
            this.txtbuscarcita.TabIndex = 127;
            this.txtbuscarcita.TextChanged += new System.EventHandler(this.txtbuscarcita_TextChanged);
            this.txtbuscarcita.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarcita_KeyUp_1);
            // 
            // lblbuscarEmpleado
            // 
            this.lblbuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblbuscarEmpleado.AutoSize = true;
            this.lblbuscarEmpleado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbuscarEmpleado.Location = new System.Drawing.Point(35, 254);
            this.lblbuscarEmpleado.Name = "lblbuscarEmpleado";
            this.lblbuscarEmpleado.Size = new System.Drawing.Size(132, 16);
            this.lblbuscarEmpleado.TabIndex = 126;
            this.lblbuscarEmpleado.Text = "Filtrar por nombre :";
            // 
            // dgvdatosCita
            // 
            this.dgvdatosCita.AllowUserToAddRows = false;
            this.dgvdatosCita.AllowUserToDeleteRows = false;
            this.dgvdatosCita.AllowUserToResizeColumns = false;
            this.dgvdatosCita.AllowUserToResizeRows = false;
            this.dgvdatosCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvdatosCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatosCita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.dgvdatosCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatosCita.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdatosCita.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdatosCita.ColumnHeadersHeight = 40;
            this.dgvdatosCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosCita.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdatosCita.EnableHeadersVisualStyles = false;
            this.dgvdatosCita.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvdatosCita.Location = new System.Drawing.Point(38, 304);
            this.dgvdatosCita.Name = "dgvdatosCita";
            this.dgvdatosCita.ReadOnly = true;
            this.dgvdatosCita.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosCita.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdatosCita.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdatosCita.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdatosCita.RowTemplate.Height = 30;
            this.dgvdatosCita.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvdatosCita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosCita.Size = new System.Drawing.Size(730, 214);
            this.dgvdatosCita.TabIndex = 101;
            this.dgvdatosCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatosCita_CellClick);
            this.dgvdatosCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatosCita_CellContentClick);
            this.dgvdatosCita.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvdatosCita_DataBindingComplete);
            // 
            // txtfechaCita
            // 
            this.txtfechaCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfechaCita.Location = new System.Drawing.Point(264, 81);
            this.txtfechaCita.Name = "txtfechaCita";
            this.txtfechaCita.Size = new System.Drawing.Size(72, 20);
            this.txtfechaCita.TabIndex = 124;
            this.txtfechaCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfechaCita.TextChanged += new System.EventHandler(this.txtfechaCita_TextChanged_1);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(856, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 123;
            this.label13.Text = "No llenar";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(769, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "Clave Cita";
            // 
            // txtidCita
            // 
            this.txtidCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtidCita.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtidCita.Location = new System.Drawing.Point(772, 78);
            this.txtidCita.Name = "txtidCita";
            this.txtidCita.ReadOnly = true;
            this.txtidCita.Size = new System.Drawing.Size(133, 20);
            this.txtidCita.TabIndex = 121;
            // 
            // dateTimefechaCita
            // 
            this.dateTimefechaCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimefechaCita.Location = new System.Drawing.Point(38, 81);
            this.dateTimefechaCita.Name = "dateTimefechaCita";
            this.dateTimefechaCita.Size = new System.Drawing.Size(199, 20);
            this.dateTimefechaCita.TabIndex = 120;
            this.dateTimefechaCita.Value = new System.DateTime(2021, 11, 5, 1, 25, 19, 0);
            this.dateTimefechaCita.ValueChanged += new System.EventHandler(this.dateTimefechaCita_ValueChanged);
            // 
            // txthorafinCita
            // 
            this.txthorafinCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthorafinCita.Location = new System.Drawing.Point(143, 196);
            this.txthorafinCita.Name = "txthorafinCita";
            this.txthorafinCita.Size = new System.Drawing.Size(94, 20);
            this.txthorafinCita.TabIndex = 116;
            this.txthorafinCita.TextChanged += new System.EventHandler(this.txthorafinCita_TextChanged_1);
            // 
            // txthorainicioCita
            // 
            this.txthorainicioCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthorainicioCita.Location = new System.Drawing.Point(38, 196);
            this.txthorainicioCita.Name = "txthorainicioCita";
            this.txthorainicioCita.Size = new System.Drawing.Size(94, 20);
            this.txthorainicioCita.TabIndex = 115;
            this.txthorainicioCita.TextChanged += new System.EventHandler(this.txthorainicioCita_TextChanged_1);
            // 
            // txtprecioservicioCita
            // 
            this.txtprecioservicioCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecioservicioCita.Location = new System.Drawing.Point(400, 196);
            this.txtprecioservicioCita.Name = "txtprecioservicioCita";
            this.txtprecioservicioCita.Size = new System.Drawing.Size(81, 20);
            this.txtprecioservicioCita.TabIndex = 114;
            this.txtprecioservicioCita.TextChanged += new System.EventHandler(this.txtprecioservicioCita_TextChanged);
            // 
            // txttiposervicioCita
            // 
            this.txttiposervicioCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttiposervicioCita.Location = new System.Drawing.Point(264, 196);
            this.txttiposervicioCita.Name = "txttiposervicioCita";
            this.txttiposervicioCita.Size = new System.Drawing.Size(133, 20);
            this.txttiposervicioCita.TabIndex = 113;
            this.txttiposervicioCita.TextChanged += new System.EventHandler(this.txttiposervicioCita_TextChanged_1);
            // 
            // txtapellidomclienteCita
            // 
            this.txtapellidomclienteCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellidomclienteCita.Location = new System.Drawing.Point(772, 196);
            this.txtapellidomclienteCita.Name = "txtapellidomclienteCita";
            this.txtapellidomclienteCita.Size = new System.Drawing.Size(133, 20);
            this.txtapellidomclienteCita.TabIndex = 112;
            this.txtapellidomclienteCita.TextChanged += new System.EventHandler(this.txtapellidomclienteCita_TextChanged_1);
            // 
            // txtapellidoclienteCita
            // 
            this.txtapellidoclienteCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtapellidoclienteCita.Location = new System.Drawing.Point(636, 196);
            this.txtapellidoclienteCita.Name = "txtapellidoclienteCita";
            this.txtapellidoclienteCita.Size = new System.Drawing.Size(133, 20);
            this.txtapellidoclienteCita.TabIndex = 111;
            this.txtapellidoclienteCita.TextChanged += new System.EventHandler(this.txtapellidoclienteCita_TextChanged_1);
            // 
            // txtnombreclienteCita
            // 
            this.txtnombreclienteCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombreclienteCita.Location = new System.Drawing.Point(500, 196);
            this.txtnombreclienteCita.Name = "txtnombreclienteCita";
            this.txtnombreclienteCita.Size = new System.Drawing.Size(133, 20);
            this.txtnombreclienteCita.TabIndex = 110;
            this.txtnombreclienteCita.TextChanged += new System.EventHandler(this.txtnombreclienteCita_TextChanged_1);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(397, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 109;
            this.label11.Text = "Precio";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(262, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(769, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 106;
            this.label10.Text = "Apellido Materno";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(633, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 105;
            this.label9.Text = "Apellido Paterno";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(497, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(140, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 100;
            this.label3.Text = "Hora Fin";
            // 
            // lblCRUD
            // 
            this.lblCRUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCRUD.AutoSize = true;
            this.lblCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRUD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCRUD.Location = new System.Drawing.Point(331, 33);
            this.lblCRUD.Name = "lblCRUD";
            this.lblCRUD.Size = new System.Drawing.Size(262, 29);
            this.lblCRUD.TabIndex = 98;
            this.lblCRUD.Text = "Registre una nueva cita";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(35, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 94;
            this.label2.Text = "Hora Inicio";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Seleccione la Fecha";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(40, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "Definir hora";
            // 
            // iconbtnhoraCita
            // 
            this.iconbtnhoraCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnhoraCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnhoraCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnhoraCita.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconbtnhoraCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnhoraCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnhoraCita.IconSize = 34;
            this.iconbtnhoraCita.Location = new System.Drawing.Point(38, 119);
            this.iconbtnhoraCita.Name = "iconbtnhoraCita";
            this.iconbtnhoraCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnhoraCita.TabIndex = 128;
            this.iconbtnhoraCita.TabStop = false;
            this.iconbtnhoraCita.Click += new System.EventHandler(this.iconbtnhoraCita_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(266, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "Agregar Servicio";
            // 
            // iconbtnservis
            // 
            this.iconbtnservis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnservis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnservis.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnservis.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.iconbtnservis.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnservis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnservis.IconSize = 34;
            this.iconbtnservis.Location = new System.Drawing.Point(264, 119);
            this.iconbtnservis.Name = "iconbtnservis";
            this.iconbtnservis.Size = new System.Drawing.Size(37, 34);
            this.iconbtnservis.TabIndex = 130;
            this.iconbtnservis.TabStop = false;
            this.iconbtnservis.Click += new System.EventHandler(this.iconbtnservis_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(502, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 133;
            this.label15.Text = "Agregar Cliente";
            // 
            // iconbtnbuscarclienteCita
            // 
            this.iconbtnbuscarclienteCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnbuscarclienteCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnbuscarclienteCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnbuscarclienteCita.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconbtnbuscarclienteCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnbuscarclienteCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnbuscarclienteCita.IconSize = 34;
            this.iconbtnbuscarclienteCita.Location = new System.Drawing.Point(500, 119);
            this.iconbtnbuscarclienteCita.Name = "iconbtnbuscarclienteCita";
            this.iconbtnbuscarclienteCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnbuscarclienteCita.TabIndex = 134;
            this.iconbtnbuscarclienteCita.TabStop = false;
            this.iconbtnbuscarclienteCita.Click += new System.EventHandler(this.iconbtnbuscarclienteCita_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(834, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 136;
            this.label6.Text = "Agregar Datos";
            // 
            // iconbtnagregardatosCita
            // 
            this.iconbtnagregardatosCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnagregardatosCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnagregardatosCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnagregardatosCita.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconbtnagregardatosCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnagregardatosCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnagregardatosCita.IconSize = 34;
            this.iconbtnagregardatosCita.Location = new System.Drawing.Point(832, 242);
            this.iconbtnagregardatosCita.Name = "iconbtnagregardatosCita";
            this.iconbtnagregardatosCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnagregardatosCita.TabIndex = 135;
            this.iconbtnagregardatosCita.TabStop = false;
            this.iconbtnagregardatosCita.Click += new System.EventHandler(this.iconbtnagregardatosCita_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(834, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 138;
            this.label7.Text = "Modificar";
            // 
            // iconbtnmodificarCita
            // 
            this.iconbtnmodificarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnmodificarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnmodificarCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnmodificarCita.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconbtnmodificarCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnmodificarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnmodificarCita.IconSize = 34;
            this.iconbtnmodificarCita.Location = new System.Drawing.Point(832, 304);
            this.iconbtnmodificarCita.Name = "iconbtnmodificarCita";
            this.iconbtnmodificarCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnmodificarCita.TabIndex = 137;
            this.iconbtnmodificarCita.TabStop = false;
            this.iconbtnmodificarCita.Click += new System.EventHandler(this.iconbtnmodificarCita_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(834, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 140;
            this.label16.Text = "Cancelar operación";
            // 
            // iconbtneliminarCita
            // 
            this.iconbtneliminarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtneliminarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtneliminarCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtneliminarCita.IconChar = FontAwesome.Sharp.IconChar.History;
            this.iconbtneliminarCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtneliminarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtneliminarCita.IconSize = 34;
            this.iconbtneliminarCita.Location = new System.Drawing.Point(832, 365);
            this.iconbtneliminarCita.Name = "iconbtneliminarCita";
            this.iconbtneliminarCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtneliminarCita.TabIndex = 139;
            this.iconbtneliminarCita.TabStop = false;
            this.iconbtneliminarCita.Click += new System.EventHandler(this.iconbtneliminarCita_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(834, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 142;
            this.label17.Text = "Limpiar";
            // 
            // iconbtnlimpiarCita
            // 
            this.iconbtnlimpiarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnlimpiarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnlimpiarCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnlimpiarCita.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconbtnlimpiarCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnlimpiarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnlimpiarCita.IconSize = 34;
            this.iconbtnlimpiarCita.Location = new System.Drawing.Point(832, 426);
            this.iconbtnlimpiarCita.Name = "iconbtnlimpiarCita";
            this.iconbtnlimpiarCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnlimpiarCita.TabIndex = 141;
            this.iconbtnlimpiarCita.TabStop = false;
            this.iconbtnlimpiarCita.Click += new System.EventHandler(this.iconbtnlimpiarCita_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(827, 530);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 144;
            this.label18.Text = "Guardar";
            // 
            // iconbtnguardarCita
            // 
            this.iconbtnguardarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnguardarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnguardarCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnguardarCita.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconbtnguardarCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnguardarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnguardarCita.IconSize = 54;
            this.iconbtnguardarCita.Location = new System.Drawing.Point(824, 485);
            this.iconbtnguardarCita.Name = "iconbtnguardarCita";
            this.iconbtnguardarCita.Size = new System.Drawing.Size(60, 54);
            this.iconbtnguardarCita.TabIndex = 143;
            this.iconbtnguardarCita.TabStop = false;
            this.iconbtnguardarCita.Click += new System.EventHandler(this.iconbtnguardarCita_Click);
            // 
            // iconcerrarCita
            // 
            this.iconcerrarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconcerrarCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconcerrarCita.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconcerrarCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconcerrarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcerrarCita.Location = new System.Drawing.Point(872, 2);
            this.iconcerrarCita.Name = "iconcerrarCita";
            this.iconcerrarCita.Size = new System.Drawing.Size(33, 32);
            this.iconcerrarCita.TabIndex = 147;
            this.iconcerrarCita.TabStop = false;
            this.iconcerrarCita.Click += new System.EventHandler(this.iconcerrarCita_Click);
            // 
            // FormCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(940, 551);
            this.Controls.Add(this.iconcerrarCita);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.iconbtnguardarCita);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.iconbtnlimpiarCita);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.iconbtneliminarCita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconbtnmodificarCita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iconbtnagregardatosCita);
            this.Controls.Add(this.iconbtnbuscarclienteCita);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconbtnservis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.iconbtnhoraCita);
            this.Controls.Add(this.txtbuscarcita);
            this.Controls.Add(this.lblbuscarEmpleado);
            this.Controls.Add(this.dgvdatosCita);
            this.Controls.Add(this.txtfechaCita);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtidCita);
            this.Controls.Add(this.dateTimefechaCita);
            this.Controls.Add(this.txthorafinCita);
            this.Controls.Add(this.txthorainicioCita);
            this.Controls.Add(this.txtprecioservicioCita);
            this.Controls.Add(this.txttiposervicioCita);
            this.Controls.Add(this.txtapellidomclienteCita);
            this.Controls.Add(this.txtapellidoclienteCita);
            this.Controls.Add(this.txtnombreclienteCita);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCRUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCita";
            this.Text = "FormCita";
            this.Load += new System.EventHandler(this.FormCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnhoraCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnservis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnbuscarclienteCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnagregardatosCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnmodificarCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtneliminarCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnlimpiarCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnguardarCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbuscarcita;
        private System.Windows.Forms.Label lblbuscarEmpleado;
        internal System.Windows.Forms.DataGridView dgvdatosCita;
        public System.Windows.Forms.TextBox txtfechaCita;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtidCita;
        private System.Windows.Forms.DateTimePicker dateTimefechaCita;
        internal System.Windows.Forms.TextBox txthorafinCita;
        internal System.Windows.Forms.TextBox txthorainicioCita;
        internal System.Windows.Forms.TextBox txtprecioservicioCita;
        internal System.Windows.Forms.TextBox txttiposervicioCita;
        internal System.Windows.Forms.TextBox txtapellidomclienteCita;
        internal System.Windows.Forms.TextBox txtapellidoclienteCita;
        internal System.Windows.Forms.TextBox txtnombreclienteCita;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCRUD;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconPictureBox iconbtnhoraCita;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconbtnservis;
        private System.Windows.Forms.Label label15;
        private FontAwesome.Sharp.IconPictureBox iconbtnbuscarclienteCita;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconbtnagregardatosCita;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconPictureBox iconbtnmodificarCita;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconPictureBox iconbtneliminarCita;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconPictureBox iconbtnlimpiarCita;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconPictureBox iconbtnguardarCita;
        private FontAwesome.Sharp.IconPictureBox iconcerrarCita;
    }
}