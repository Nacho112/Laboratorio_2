
namespace DesafioIntegrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.checkBoxManga = new System.Windows.Forms.CheckBox();
            this.checkBoxBermuda = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonPrecioFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Prenda";
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Location = new System.Drawing.Point(63, 44);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCamisa.TabIndex = 1;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisa";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            this.radioButtonCamisa.CheckedChanged += new System.EventHandler(this.radioButtonCamisa_CheckedChanged);
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Location = new System.Drawing.Point(63, 84);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPantalon.TabIndex = 2;
            this.radioButtonPantalon.TabStop = true;
            this.radioButtonPantalon.Text = "Pantalon";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            this.radioButtonPantalon.CheckedChanged += new System.EventHandler(this.radioButtonPantalon_CheckedChanged);
            // 
            // checkBoxManga
            // 
            this.checkBoxManga.AutoSize = true;
            this.checkBoxManga.Location = new System.Drawing.Point(177, 44);
            this.checkBoxManga.Name = "checkBoxManga";
            this.checkBoxManga.Size = new System.Drawing.Size(87, 17);
            this.checkBoxManga.TabIndex = 3;
            this.checkBoxManga.Text = "Manga Corta";
            this.checkBoxManga.UseVisualStyleBackColor = true;
            // 
            // checkBoxBermuda
            // 
            this.checkBoxBermuda.AutoSize = true;
            this.checkBoxBermuda.Location = new System.Drawing.Point(177, 84);
            this.checkBoxBermuda.Name = "checkBoxBermuda";
            this.checkBoxBermuda.Size = new System.Drawing.Size(68, 17);
            this.checkBoxBermuda.TabIndex = 4;
            this.checkBoxBermuda.Text = "Bermuda";
            this.checkBoxBermuda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calidad de Prenda";
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(63, 182);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(68, 17);
            this.radioButtonStandard.TabIndex = 6;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(174, 182);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(65, 17);
            this.radioButtonPremium.TabIndex = 7;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(32, 252);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 11;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(177, 251);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 12;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // buttonPrecioFinal
            // 
            this.buttonPrecioFinal.Location = new System.Drawing.Point(12, 289);
            this.buttonPrecioFinal.Name = "buttonPrecioFinal";
            this.buttonPrecioFinal.Size = new System.Drawing.Size(295, 65);
            this.buttonPrecioFinal.TabIndex = 13;
            this.buttonPrecioFinal.Text = "Calcular Precio Final";
            this.buttonPrecioFinal.UseVisualStyleBackColor = true;
            this.buttonPrecioFinal.Click += new System.EventHandler(this.buttonPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 364);
            this.Controls.Add(this.buttonPrecioFinal);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonPremium);
            this.Controls.Add(this.radioButtonStandard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxBermuda);
            this.Controls.Add(this.checkBoxManga);
            this.Controls.Add(this.radioButtonPantalon);
            this.Controls.Add(this.radioButtonCamisa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCamisa;
        private System.Windows.Forms.RadioButton radioButtonPantalon;
        private System.Windows.Forms.CheckBox checkBoxManga;
        private System.Windows.Forms.CheckBox checkBoxBermuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonPrecioFinal;
    }
}

