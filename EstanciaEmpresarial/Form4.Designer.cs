namespace EstanciaEmpresarial
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GuardarEstancia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFfin = new System.Windows.Forms.DateTimePicker();
            this.dtp_Finicio = new System.Windows.Forms.DateTimePicker();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.TxtProyecto = new System.Windows.Forms.TextBox();
            this.txtNombre_Empresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.GuardarEstancia);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtpFfin);
            this.groupBox1.Controls.Add(this.dtp_Finicio);
            this.groupBox1.Controls.Add(this.txtDireccionEmpresa);
            this.groupBox1.Controls.Add(this.txtResponsable);
            this.groupBox1.Controls.Add(this.TxtProyecto);
            this.groupBox1.Controls.Add(this.txtNombre_Empresa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Estancia";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(412, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 67);
            this.button2.TabIndex = 18;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GuardarEstancia
            // 
            this.GuardarEstancia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuardarEstancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuardarEstancia.Location = new System.Drawing.Point(14, 336);
            this.GuardarEstancia.Name = "GuardarEstancia";
            this.GuardarEstancia.Size = new System.Drawing.Size(165, 67);
            this.GuardarEstancia.TabIndex = 17;
            this.GuardarEstancia.Text = "Guardar";
            this.GuardarEstancia.UseVisualStyleBackColor = false;
            this.GuardarEstancia.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstanciaEmpresarial.Properties.Resources.empresa;
            this.pictureBox1.Location = new System.Drawing.Point(434, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFfin
            // 
            this.dtpFfin.Location = new System.Drawing.Point(224, 154);
            this.dtpFfin.Name = "dtpFfin";
            this.dtpFfin.Size = new System.Drawing.Size(171, 22);
            this.dtpFfin.TabIndex = 15;
            // 
            // dtp_Finicio
            // 
            this.dtp_Finicio.Location = new System.Drawing.Point(224, 105);
            this.dtp_Finicio.Name = "dtp_Finicio";
            this.dtp_Finicio.Size = new System.Drawing.Size(171, 22);
            this.dtp_Finicio.TabIndex = 14;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(224, 250);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(171, 22);
            this.txtDireccionEmpresa.TabIndex = 12;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(224, 205);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(171, 22);
            this.txtResponsable.TabIndex = 11;
            // 
            // TxtProyecto
            // 
            this.TxtProyecto.Location = new System.Drawing.Point(224, 66);
            this.TxtProyecto.Name = "TxtProyecto";
            this.TxtProyecto.Size = new System.Drawing.Size(171, 22);
            this.TxtProyecto.TabIndex = 8;
            // 
            // txtNombre_Empresa
            // 
            this.txtNombre_Empresa.Location = new System.Drawing.Point(224, 29);
            this.txtNombre_Empresa.Name = "txtNombre_Empresa";
            this.txtNombre_Empresa.Size = new System.Drawing.Size(171, 22);
            this.txtNombre_Empresa.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion De La Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Responsable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha De Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proyecto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre De La Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "RFC";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(224, 296);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(171, 22);
            this.txtRFC.TabIndex = 20;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 433);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Estancia Empresarial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.TextBox TxtProyecto;
        private System.Windows.Forms.TextBox txtNombre_Empresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpFfin;
        private System.Windows.Forms.DateTimePicker dtp_Finicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GuardarEstancia;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label7;
    }
}