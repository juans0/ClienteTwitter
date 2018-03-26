namespace capa_presentacion
{
    partial class InsertarTwitter
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
            this.foto = new System.Windows.Forms.PictureBox();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnProg = new System.Windows.Forms.RadioButton();
            this.rBtnNew = new System.Windows.Forms.RadioButton();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.listHoras = new System.Windows.Forms.ListBox();
            this.btnTweet = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCaract = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerPublicar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(13, 13);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(49, 50);
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // txtTweet
            // 
            this.txtTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTweet.Location = new System.Drawing.Point(83, 13);
            this.txtTweet.MaxLength = 140;
            this.txtTweet.Multiline = true;
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(533, 96);
            this.txtTweet.TabIndex = 1;
            this.txtTweet.TextChanged += new System.EventHandler(this.txtTweet_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnProg);
            this.groupBox1.Controls.Add(this.rBtnNew);
            this.groupBox1.Location = new System.Drawing.Point(13, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rBtnProg
            // 
            this.rBtnProg.AutoSize = true;
            this.rBtnProg.Location = new System.Drawing.Point(7, 43);
            this.rBtnProg.Name = "rBtnProg";
            this.rBtnProg.Size = new System.Drawing.Size(73, 17);
            this.rBtnProg.TabIndex = 1;
            this.rBtnProg.TabStop = true;
            this.rBtnProg.Text = "Programar";
            this.rBtnProg.UseVisualStyleBackColor = true;
            // 
            // rBtnNew
            // 
            this.rBtnNew.AutoSize = true;
            this.rBtnNew.Location = new System.Drawing.Point(7, 20);
            this.rBtnNew.Name = "rBtnNew";
            this.rBtnNew.Size = new System.Drawing.Size(90, 17);
            this.rBtnNew.TabIndex = 0;
            this.rBtnNew.TabStop = true;
            this.rBtnNew.Text = "Nuevo Tweet";
            this.rBtnNew.UseVisualStyleBackColor = true;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(141, 231);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 3;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Location = new System.Drawing.Point(511, 116);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(61, 13);
            this.lblPalabras.TabIndex = 4;
            this.lblPalabras.Text = "Caracteres:";
            // 
            // listHoras
            // 
            this.listHoras.FormattingEnabled = true;
            this.listHoras.Items.AddRange(new object[] {
            "0:00 AM",
            "0:30 AM",
            "1:00 AM",
            "1:30 AM",
            "2:00 AM",
            "2:30 AM",
            "3:00 AM",
            "3:30 AM",
            "4:00 AM",
            "4:30 AM",
            "5:00 AM",
            "5:30 AM",
            "6:00 AM",
            "6:30 AM",
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "13:00 PM",
            "13:30 PM",
            "14:00 PM",
            "14:30 PM",
            "15:00 PM",
            "15:30 PM",
            "16:00 PM",
            "16:30 PM",
            "17:00 PM",
            "17:30 PM",
            "18:00 PM",
            "18:30 PM",
            "19:00 PM",
            "19:30 PM",
            "20:00 PM",
            "20:30 PM",
            "21:00 PM",
            "21:30 PM",
            "22:00 PM",
            "22:30 PM",
            "23:00 PM",
            "23:30 PM"});
            this.listHoras.Location = new System.Drawing.Point(360, 231);
            this.listHoras.Name = "listHoras";
            this.listHoras.Size = new System.Drawing.Size(120, 95);
            this.listHoras.TabIndex = 5;
            // 
            // btnTweet
            // 
            this.btnTweet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTweet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTweet.Location = new System.Drawing.Point(515, 357);
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.Size = new System.Drawing.Size(101, 36);
            this.btnTweet.TabIndex = 6;
            this.btnTweet.Text = "Tweet";
            this.btnTweet.UseVisualStyleBackColor = false;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(141, 199);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(192, 20);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCaract
            // 
            this.lblCaract.AutoSize = true;
            this.lblCaract.Location = new System.Drawing.Point(580, 116);
            this.lblCaract.Name = "lblCaract";
            this.lblCaract.Size = new System.Drawing.Size(25, 13);
            this.lblCaract.TabIndex = 8;
            this.lblCaract.Text = "140\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha y hora actuales";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(504, 255);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerPublicar
            // 
            this.timerPublicar.Interval = 1000;
            this.timerPublicar.Tick += new System.EventHandler(this.timerPublicar_Tick);
            // 
            // InsertarTwitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 408);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaract);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnTweet);
            this.Controls.Add(this.listHoras);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.foto);
            this.Name = "InsertarTwitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Tweet";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnProg;
        private System.Windows.Forms.RadioButton rBtnNew;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.ListBox listHoras;
        private System.Windows.Forms.Button btnTweet;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCaract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerPublicar;
    }
}