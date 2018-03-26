namespace capa_presentacion
{
    partial class ModificarTweet
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnTodos = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.rBtnFecha = new System.Windows.Forms.RadioButton();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.rBtnTexto = new System.Windows.Forms.RadioButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaAntiguo = new System.Windows.Forms.TextBox();
            this.txtTweetAntiguo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaNuevo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTweetNuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.toolSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 12);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(696, 124);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnTodos);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.rBtnFecha);
            this.groupBox1.Controls.Add(this.txtTexto);
            this.groupBox1.Controls.Add(this.rBtnTexto);
            this.groupBox1.Location = new System.Drawing.Point(56, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrado:";
            // 
            // rBtnTodos
            // 
            this.rBtnTodos.AutoSize = true;
            this.rBtnTodos.Location = new System.Drawing.Point(15, 25);
            this.rBtnTodos.Name = "rBtnTodos";
            this.rBtnTodos.Size = new System.Drawing.Size(70, 17);
            this.rBtnTodos.TabIndex = 4;
            this.rBtnTodos.TabStop = true;
            this.rBtnTodos.Text = "Ver todos";
            this.rBtnTodos.UseVisualStyleBackColor = true;
            this.rBtnTodos.CheckedChanged += new System.EventHandler(this.rBtnTodos_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 134);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // rBtnFecha
            // 
            this.rBtnFecha.AutoSize = true;
            this.rBtnFecha.Location = new System.Drawing.Point(15, 108);
            this.rBtnFecha.Name = "rBtnFecha";
            this.rBtnFecha.Size = new System.Drawing.Size(58, 17);
            this.rBtnFecha.TabIndex = 2;
            this.rBtnFecha.TabStop = true;
            this.rBtnFecha.Text = "Fecha:";
            this.rBtnFecha.UseVisualStyleBackColor = true;
            this.rBtnFecha.CheckedChanged += new System.EventHandler(this.rBtnFecha_CheckedChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(18, 78);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(192, 20);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // rBtnTexto
            // 
            this.rBtnTexto.AutoSize = true;
            this.rBtnTexto.Location = new System.Drawing.Point(15, 55);
            this.rBtnTexto.Name = "rBtnTexto";
            this.rBtnTexto.Size = new System.Drawing.Size(52, 17);
            this.rBtnTexto.TabIndex = 0;
            this.rBtnTexto.TabStop = true;
            this.rBtnTexto.Text = "Texto";
            this.rBtnTexto.UseVisualStyleBackColor = true;
            this.rBtnTexto.CheckedChanged += new System.EventHandler(this.rBtnTexto_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(497, 423);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(589, 423);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Programada:";
            // 
            // txtFechaAntiguo
            // 
            this.txtFechaAntiguo.Location = new System.Drawing.Point(458, 155);
            this.txtFechaAntiguo.Name = "txtFechaAntiguo";
            this.txtFechaAntiguo.ReadOnly = true;
            this.txtFechaAntiguo.Size = new System.Drawing.Size(114, 20);
            this.txtFechaAntiguo.TabIndex = 8;
            // 
            // txtTweetAntiguo
            // 
            this.txtTweetAntiguo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTweetAntiguo.Location = new System.Drawing.Point(338, 201);
            this.txtTweetAntiguo.Multiline = true;
            this.txtTweetAntiguo.Name = "txtTweetAntiguo";
            this.txtTweetAntiguo.ReadOnly = true;
            this.txtTweetAntiguo.Size = new System.Drawing.Size(326, 61);
            this.txtTweetAntiguo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tweet:";
            // 
            // txtFechaNuevo
            // 
            this.txtFechaNuevo.Location = new System.Drawing.Point(432, 287);
            this.txtFechaNuevo.Name = "txtFechaNuevo";
            this.txtFechaNuevo.Size = new System.Drawing.Size(140, 20);
            this.txtFechaNuevo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nueva Fecha: ";
            // 
            // txtTweetNuevo
            // 
            this.txtTweetNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTweetNuevo.Location = new System.Drawing.Point(338, 340);
            this.txtTweetNuevo.Multiline = true;
            this.txtTweetNuevo.Name = "txtTweetNuevo";
            this.txtTweetNuevo.Size = new System.Drawing.Size(326, 61);
            this.txtTweetNuevo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nuevo Tweet:";
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSLabel});
            this.barraStatus.Location = new System.Drawing.Point(0, 480);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(721, 22);
            this.barraStatus.TabIndex = 15;
            // 
            // toolSLabel
            // 
            this.toolSLabel.Name = "toolSLabel";
            this.toolSLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ModificarTweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.txtTweetNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTweetAntiguo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaAntiguo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Name = "ModificarTweet";
            this.Text = "ModificarTweet";
            this.Load += new System.EventHandler(this.ModificarTweet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton rBtnFecha;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RadioButton rBtnTexto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaAntiguo;
        private System.Windows.Forms.TextBox txtTweetAntiguo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTweetNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolSLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rBtnTodos;
    }
}