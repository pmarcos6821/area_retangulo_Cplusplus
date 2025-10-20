namespace Potenciacao_base_expoente
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
            btnCalcular = new Button();
            lblResultado = new Label();
            txtBase = new TextBox();
            txtExpoente = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(133, 104);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(384, 173);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(118, 32);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(133, 170);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(200, 39);
            txtBase.TabIndex = 2;
            // 
            // txtExpoente
            // 
            txtExpoente.Location = new Point(133, 215);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(200, 39);
            txtExpoente.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 170);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 4;
            label1.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 6;
            label3.Text = "Expoente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtExpoente);
            Controls.Add(txtBase);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Potenciação base expoente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtBase;
        private TextBox txtExpoente;
        private Label label1;
        private Label label3;
    }
}
