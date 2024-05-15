namespace Atencion_de_pacientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_atender = new Button();
            btn_salir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btn_atender
            // 
            btn_atender.Location = new Point(623, 33);
            btn_atender.Name = "btn_atender";
            btn_atender.Size = new Size(165, 56);
            btn_atender.TabIndex = 0;
            btn_atender.Text = "Atender";
            btn_atender.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(623, 457);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(165, 56);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 33);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 2;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(333, 33);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 3;
            lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 57);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(239, 244);
            lstMedicos.TabIndex = 4;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(333, 57);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(239, 244);
            lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(18, 330);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(554, 183);
            rtbInfoMedico.TabIndex = 6;
            rtbInfoMedico.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btn_salir);
            Controls.Add(btn_atender);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rodrigo Ruiz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_atender;
        private Button btn_salir;
        private Label lblMedicos;
        private Label lblPacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
    }
}
