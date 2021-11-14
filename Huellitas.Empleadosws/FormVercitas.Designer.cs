
namespace Huellitas.Empleadosws
{
    partial class FormVercitas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconbtnverCitas = new FontAwesome.Sharp.IconPictureBox();
            this.txtbuscarnombreCliente = new System.Windows.Forms.TextBox();
            this.dateTimeVerCitas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechaRegistro = new System.Windows.Forms.TextBox();
            this.dgvverCitas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEcanceladaCita = new System.Windows.Forms.Button();
            this.btnEinasistenciaCita = new System.Windows.Forms.Button();
            this.btnEpendienteCita = new System.Windows.Forms.Button();
            this.btnEatendidaCita = new System.Windows.Forms.Button();
            this.txtclaveCita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iconbtnrefrescarCitas = new FontAwesome.Sharp.IconPictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iconbtnmodificarcita = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconbtnabrirformCita = new FontAwesome.Sharp.IconPictureBox();
            this.iconcerrarVerCita = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconbtncitasHoy = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnverCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvverCitas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnrefrescarCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnmodificarcita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnabrirformCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrarVerCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtncitasHoy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.iconbtnverCitas);
            this.groupBox1.Controls.Add(this.txtbuscarnombreCliente);
            this.groupBox1.Controls.Add(this.dateTimeVerCitas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizar Citas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(220, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(368, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buscar por nombre del cliente";
            // 
            // iconbtnverCitas
            // 
            this.iconbtnverCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnverCitas.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnverCitas.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconbtnverCitas.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnverCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnverCitas.IconSize = 34;
            this.iconbtnverCitas.Location = new System.Drawing.Point(222, 51);
            this.iconbtnverCitas.Name = "iconbtnverCitas";
            this.iconbtnverCitas.Size = new System.Drawing.Size(37, 34);
            this.iconbtnverCitas.TabIndex = 60;
            this.iconbtnverCitas.TabStop = false;
            this.iconbtnverCitas.Click += new System.EventHandler(this.iconbtnverCitas_Click);
            // 
            // txtbuscarnombreCliente
            // 
            this.txtbuscarnombreCliente.Location = new System.Drawing.Point(372, 58);
            this.txtbuscarnombreCliente.Name = "txtbuscarnombreCliente";
            this.txtbuscarnombreCliente.Size = new System.Drawing.Size(167, 20);
            this.txtbuscarnombreCliente.TabIndex = 5;
            this.txtbuscarnombreCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarnombreCliente_KeyUp);
            // 
            // dateTimeVerCitas
            // 
            this.dateTimeVerCitas.Location = new System.Drawing.Point(7, 58);
            this.dateTimeVerCitas.Name = "dateTimeVerCitas";
            this.dateTimeVerCitas.Size = new System.Drawing.Size(200, 20);
            this.dateTimeVerCitas.TabIndex = 1;
            this.dateTimeVerCitas.ValueChanged += new System.EventHandler(this.dateTimeVerCitas_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una fecha para ver las citas ";
            // 
            // txtfechaRegistro
            // 
            this.txtfechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfechaRegistro.Location = new System.Drawing.Point(525, 169);
            this.txtfechaRegistro.Name = "txtfechaRegistro";
            this.txtfechaRegistro.ReadOnly = true;
            this.txtfechaRegistro.Size = new System.Drawing.Size(101, 20);
            this.txtfechaRegistro.TabIndex = 3;
            // 
            // dgvverCitas
            // 
            this.dgvverCitas.AllowUserToAddRows = false;
            this.dgvverCitas.AllowUserToDeleteRows = false;
            this.dgvverCitas.AllowUserToResizeColumns = false;
            this.dgvverCitas.AllowUserToResizeRows = false;
            this.dgvverCitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvverCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvverCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.dgvverCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvverCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvverCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvverCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvverCitas.ColumnHeadersHeight = 40;
            this.dgvverCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvverCitas.EnableHeadersVisualStyles = false;
            this.dgvverCitas.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvverCitas.Location = new System.Drawing.Point(12, 209);
            this.dgvverCitas.Name = "dgvverCitas";
            this.dgvverCitas.ReadOnly = true;
            this.dgvverCitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvverCitas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvverCitas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvverCitas.RowTemplate.Height = 30;
            this.dgvverCitas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvverCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvverCitas.Size = new System.Drawing.Size(916, 297);
            this.dgvverCitas.TabIndex = 47;
            this.dgvverCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvverCitas_CellClick);
            this.dgvverCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvverCitas_CellFormatting);
            this.dgvverCitas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvverCitas_DataBindingComplete);
            this.dgvverCitas.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvverCitas_RowPrePaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEcanceladaCita);
            this.groupBox2.Controls.Add(this.btnEinasistenciaCita);
            this.groupBox2.Controls.Add(this.btnEpendienteCita);
            this.groupBox2.Controls.Add(this.btnEatendidaCita);
            this.groupBox2.Controls.Add(this.txtclaveCita);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(618, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 117);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cambiar estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave de la cita seleccionada ";
            // 
            // btnEcanceladaCita
            // 
            this.btnEcanceladaCita.BackColor = System.Drawing.Color.Gray;
            this.btnEcanceladaCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEcanceladaCita.Location = new System.Drawing.Point(231, 87);
            this.btnEcanceladaCita.Margin = new System.Windows.Forms.Padding(1);
            this.btnEcanceladaCita.Name = "btnEcanceladaCita";
            this.btnEcanceladaCita.Size = new System.Drawing.Size(75, 23);
            this.btnEcanceladaCita.TabIndex = 4;
            this.btnEcanceladaCita.Text = "Cancelada";
            this.btnEcanceladaCita.UseVisualStyleBackColor = false;
            this.btnEcanceladaCita.Click += new System.EventHandler(this.btnEcanceladaCita_Click);
            // 
            // btnEinasistenciaCita
            // 
            this.btnEinasistenciaCita.BackColor = System.Drawing.Color.Maroon;
            this.btnEinasistenciaCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEinasistenciaCita.Location = new System.Drawing.Point(231, 62);
            this.btnEinasistenciaCita.Margin = new System.Windows.Forms.Padding(1);
            this.btnEinasistenciaCita.Name = "btnEinasistenciaCita";
            this.btnEinasistenciaCita.Size = new System.Drawing.Size(75, 23);
            this.btnEinasistenciaCita.TabIndex = 3;
            this.btnEinasistenciaCita.Text = "Inasistencia";
            this.btnEinasistenciaCita.UseVisualStyleBackColor = false;
            this.btnEinasistenciaCita.Click += new System.EventHandler(this.btnEinasistenciaCita_Click);
            // 
            // btnEpendienteCita
            // 
            this.btnEpendienteCita.BackColor = System.Drawing.Color.Yellow;
            this.btnEpendienteCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEpendienteCita.Location = new System.Drawing.Point(231, 37);
            this.btnEpendienteCita.Margin = new System.Windows.Forms.Padding(1);
            this.btnEpendienteCita.Name = "btnEpendienteCita";
            this.btnEpendienteCita.Size = new System.Drawing.Size(75, 23);
            this.btnEpendienteCita.TabIndex = 2;
            this.btnEpendienteCita.Text = "Pendiente";
            this.btnEpendienteCita.UseVisualStyleBackColor = false;
            this.btnEpendienteCita.Click += new System.EventHandler(this.btnEpendienteCita_Click);
            // 
            // btnEatendidaCita
            // 
            this.btnEatendidaCita.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEatendidaCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEatendidaCita.Location = new System.Drawing.Point(231, 12);
            this.btnEatendidaCita.Margin = new System.Windows.Forms.Padding(1);
            this.btnEatendidaCita.Name = "btnEatendidaCita";
            this.btnEatendidaCita.Size = new System.Drawing.Size(75, 23);
            this.btnEatendidaCita.TabIndex = 1;
            this.btnEatendidaCita.Text = "Atendida";
            this.btnEatendidaCita.UseVisualStyleBackColor = false;
            this.btnEatendidaCita.Click += new System.EventHandler(this.btnEatendidaCita_Click);
            // 
            // txtclaveCita
            // 
            this.txtclaveCita.Location = new System.Drawing.Point(7, 58);
            this.txtclaveCita.Name = "txtclaveCita";
            this.txtclaveCita.Size = new System.Drawing.Size(167, 20);
            this.txtclaveCita.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(310, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Citas registradas para la día:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Citas pendientes del día";
            // 
            // iconbtnrefrescarCitas
            // 
            this.iconbtnrefrescarCitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnrefrescarCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnrefrescarCitas.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnrefrescarCitas.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconbtnrefrescarCitas.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnrefrescarCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnrefrescarCitas.IconSize = 34;
            this.iconbtnrefrescarCitas.Location = new System.Drawing.Point(12, 146);
            this.iconbtnrefrescarCitas.Name = "iconbtnrefrescarCitas";
            this.iconbtnrefrescarCitas.Size = new System.Drawing.Size(37, 34);
            this.iconbtnrefrescarCitas.TabIndex = 62;
            this.iconbtnrefrescarCitas.TabStop = false;
            this.iconbtnrefrescarCitas.Click += new System.EventHandler(this.iconbtnrefrescarCitas_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(698, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Modificar Cita";
            // 
            // iconbtnmodificarcita
            // 
            this.iconbtnmodificarcita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnmodificarcita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnmodificarcita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnmodificarcita.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconbtnmodificarcita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnmodificarcita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnmodificarcita.IconSize = 34;
            this.iconbtnmodificarcita.Location = new System.Drawing.Point(696, 146);
            this.iconbtnmodificarcita.Name = "iconbtnmodificarcita";
            this.iconbtnmodificarcita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnmodificarcita.TabIndex = 64;
            this.iconbtnmodificarcita.TabStop = false;
            this.iconbtnmodificarcita.Click += new System.EventHandler(this.iconbtnmodificarcita_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(804, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Registrar una nueva Cita";
            // 
            // iconbtnabrirformCita
            // 
            this.iconbtnabrirformCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtnabrirformCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtnabrirformCita.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtnabrirformCita.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconbtnabrirformCita.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtnabrirformCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnabrirformCita.IconSize = 34;
            this.iconbtnabrirformCita.Location = new System.Drawing.Point(887, 146);
            this.iconbtnabrirformCita.Name = "iconbtnabrirformCita";
            this.iconbtnabrirformCita.Size = new System.Drawing.Size(37, 34);
            this.iconbtnabrirformCita.TabIndex = 66;
            this.iconbtnabrirformCita.TabStop = false;
            this.iconbtnabrirformCita.Click += new System.EventHandler(this.iconbtnabrirformCita_Click);
            // 
            // iconcerrarVerCita
            // 
            this.iconcerrarVerCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrarVerCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconcerrarVerCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconcerrarVerCita.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconcerrarVerCita.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.iconcerrarVerCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcerrarVerCita.IconSize = 23;
            this.iconcerrarVerCita.Location = new System.Drawing.Point(905, 3);
            this.iconcerrarVerCita.Name = "iconcerrarVerCita";
            this.iconcerrarVerCita.Size = new System.Drawing.Size(23, 26);
            this.iconcerrarVerCita.TabIndex = 148;
            this.iconcerrarVerCita.TabStop = false;
            this.iconcerrarVerCita.Click += new System.EventHandler(this.iconcerrarVerCita_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(165, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 150;
            this.label7.Text = "Citas del día";
            // 
            // iconbtncitasHoy
            // 
            this.iconbtncitasHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconbtncitasHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.iconbtncitasHoy.ForeColor = System.Drawing.Color.OrangeRed;
            this.iconbtncitasHoy.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconbtncitasHoy.IconColor = System.Drawing.Color.OrangeRed;
            this.iconbtncitasHoy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtncitasHoy.IconSize = 34;
            this.iconbtncitasHoy.Location = new System.Drawing.Point(165, 146);
            this.iconbtncitasHoy.Name = "iconbtncitasHoy";
            this.iconbtncitasHoy.Size = new System.Drawing.Size(37, 34);
            this.iconbtncitasHoy.TabIndex = 149;
            this.iconbtncitasHoy.TabStop = false;
            this.iconbtncitasHoy.Click += new System.EventHandler(this.iconbtncitasHoy_Click);
            // 
            // FormVercitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(940, 551);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconbtncitasHoy);
            this.Controls.Add(this.iconcerrarVerCita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iconbtnabrirformCita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconbtnmodificarcita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconbtnrefrescarCitas);
            this.Controls.Add(this.txtfechaRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvverCitas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVercitas";
            this.Text = "FormVercitas";
            this.Load += new System.EventHandler(this.FormVercitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnverCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvverCitas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnrefrescarCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnmodificarcita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtnabrirformCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrarVerCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconbtncitasHoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeVerCitas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEcanceladaCita;
        private System.Windows.Forms.Button btnEinasistenciaCita;
        private System.Windows.Forms.Button btnEpendienteCita;
        private System.Windows.Forms.Button btnEatendidaCita;
        private System.Windows.Forms.TextBox txtclaveCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfechaRegistro;
        public System.Windows.Forms.DataGridView dgvverCitas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbuscarnombreCliente;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconPictureBox iconbtnverCitas;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconbtnrefrescarCitas;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox iconbtnmodificarcita;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconbtnabrirformCita;
        private FontAwesome.Sharp.IconPictureBox iconcerrarVerCita;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconPictureBox iconbtncitasHoy;
    }
}