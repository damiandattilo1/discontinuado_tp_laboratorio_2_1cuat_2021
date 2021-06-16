
namespace Formulario
{
    partial class Form1
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
            this.elegirClase = new System.Windows.Forms.ComboBox();
            this.eficiencia1 = new System.Windows.Forms.ComboBox();
            this.eficiencia2 = new System.Windows.Forms.ComboBox();
            this.id1 = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.caracteristica1 = new System.Windows.Forms.ComboBox();
            this.caracteristica2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elegirClase
            // 
            this.elegirClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elegirClase.FormattingEnabled = true;
            this.elegirClase.Location = new System.Drawing.Point(363, 61);
            this.elegirClase.Name = "elegirClase";
            this.elegirClase.Size = new System.Drawing.Size(121, 24);
            this.elegirClase.TabIndex = 0;
            // 
            // eficiencia1
            // 
            this.eficiencia1.BackColor = System.Drawing.SystemColors.Window;
            this.eficiencia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eficiencia1.FormattingEnabled = true;
            this.eficiencia1.Location = new System.Drawing.Point(363, 175);
            this.eficiencia1.Name = "eficiencia1";
            this.eficiencia1.Size = new System.Drawing.Size(121, 24);
            this.eficiencia1.TabIndex = 1;
            this.eficiencia1.Tag = "";
            // 
            // eficiencia2
            // 
            this.eficiencia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eficiencia2.FormattingEnabled = true;
            this.eficiencia2.Location = new System.Drawing.Point(363, 286);
            this.eficiencia2.Name = "eficiencia2";
            this.eficiencia2.Size = new System.Drawing.Size(121, 24);
            this.eficiencia2.TabIndex = 2;
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(161, 175);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(100, 22);
            this.id1.TabIndex = 3;
            this.id1.TextChanged += new System.EventHandler(this.id1_TextChanged);
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(160, 286);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(100, 22);
            this.id2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "btnOperar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caracteristica1
            // 
            this.caracteristica1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caracteristica1.FormattingEnabled = true;
            this.caracteristica1.Location = new System.Drawing.Point(576, 173);
            this.caracteristica1.Name = "caracteristica1";
            this.caracteristica1.Size = new System.Drawing.Size(121, 24);
            this.caracteristica1.TabIndex = 6;
            this.caracteristica1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // caracteristica2
            // 
            this.caracteristica2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caracteristica2.FormattingEnabled = true;
            this.caracteristica2.Location = new System.Drawing.Point(576, 286);
            this.caracteristica2.Name = "caracteristica2";
            this.caracteristica2.Size = new System.Drawing.Size(121, 24);
            this.caracteristica2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione un producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione caracteristica 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione caracteristica 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione Eficiencia Energetica 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seleccione Eficiencia Energetica 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese  ID 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingrese ID 2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caracteristica2);
            this.Controls.Add(this.caracteristica1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.eficiencia2);
            this.Controls.Add(this.eficiencia1);
            this.Controls.Add(this.elegirClase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox elegirClase;
        private System.Windows.Forms.ComboBox eficiencia1;
        private System.Windows.Forms.ComboBox eficiencia2;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox caracteristica1;
        private System.Windows.Forms.ComboBox caracteristica2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

