namespace EmailSATE
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbPlantilla = new System.Windows.Forms.ComboBox();
            this.lblPlantilla = new System.Windows.Forms.Label();
            this.lblDestinatarios = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.tbDestinatarios = new System.Windows.Forms.TextBox();
            this.tbAsunto = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviar Emails";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(948, 515);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbPlantilla
            // 
            this.cbPlantilla.FormattingEnabled = true;
            this.cbPlantilla.Items.AddRange(new object[] {
            "Equipaje Perdido",
            "Equipaje Nivel 1000"});
            this.cbPlantilla.Location = new System.Drawing.Point(48, 93);
            this.cbPlantilla.Name = "cbPlantilla";
            this.cbPlantilla.Size = new System.Drawing.Size(121, 21);
            this.cbPlantilla.TabIndex = 3;
            this.cbPlantilla.Text = "Seleccionar";
            this.cbPlantilla.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPlantilla
            // 
            this.lblPlantilla.AutoSize = true;
            this.lblPlantilla.Location = new System.Drawing.Point(45, 68);
            this.lblPlantilla.Name = "lblPlantilla";
            this.lblPlantilla.Size = new System.Drawing.Size(43, 13);
            this.lblPlantilla.TabIndex = 4;
            this.lblPlantilla.Text = "Plantilla";
            // 
            // lblDestinatarios
            // 
            this.lblDestinatarios.AutoSize = true;
            this.lblDestinatarios.Location = new System.Drawing.Point(45, 136);
            this.lblDestinatarios.Name = "lblDestinatarios";
            this.lblDestinatarios.Size = new System.Drawing.Size(68, 13);
            this.lblDestinatarios.TabIndex = 5;
            this.lblDestinatarios.Text = "Destinatarios";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(45, 168);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(40, 13);
            this.lblAsunto.TabIndex = 6;
            this.lblAsunto.Text = "Asunto";
            // 
            // tbDestinatarios
            // 
            this.tbDestinatarios.Location = new System.Drawing.Point(161, 136);
            this.tbDestinatarios.Name = "tbDestinatarios";
            this.tbDestinatarios.Size = new System.Drawing.Size(100, 20);
            this.tbDestinatarios.TabIndex = 7;
            // 
            // tbAsunto
            // 
            this.tbAsunto.Location = new System.Drawing.Point(161, 168);
            this.tbAsunto.Name = "tbAsunto";
            this.tbAsunto.Size = new System.Drawing.Size(100, 20);
            this.tbAsunto.TabIndex = 8;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(45, 209);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "Mensaje";
            // 
            // tbMensaje
            // 
            this.tbMensaje.Location = new System.Drawing.Point(161, 209);
            this.tbMensaje.Multiline = true;
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(400, 250);
            this.tbMensaje.TabIndex = 10;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(948, 558);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmacion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 605);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.tbAsunto);
            this.Controls.Add(this.tbDestinatarios);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblDestinatarios);
            this.Controls.Add(this.lblPlantilla);
            this.Controls.Add(this.cbPlantilla);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Enviar Emails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbPlantilla;
        private System.Windows.Forms.Label lblPlantilla;
        private System.Windows.Forms.Label lblDestinatarios;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.TextBox tbDestinatarios;
        private System.Windows.Forms.TextBox tbAsunto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.Label lblConfirmacion;
    }
}

