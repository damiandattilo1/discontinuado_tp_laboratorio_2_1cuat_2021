
namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(36, 345);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(324, 77);
            this.btnConvertirABinario.TabIndex = 0;
            this.btnConvertirABinario.Text = "Convertir a binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(527, 234);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(189, 78);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(36, 234);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(223, 78);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(52, 119);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(207, 22);
            this.txtNumero1.TabIndex = 5;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(527, 119);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(244, 22);
            this.txtNumero2.TabIndex = 6;
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(339, 117);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 24);
            this.cmbOperador.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(375, 46);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(93, 17);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "RESULTADO";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(317, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 78);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Location = new System.Drawing.Point(456, 352);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(260, 63);
            this.btnConvertirADecimal.TabIndex = 10;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConvertirABinario);
            this.Name = "FormCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConvertirADecimal;
    }
}

