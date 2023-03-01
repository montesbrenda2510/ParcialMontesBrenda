
namespace parcialcubo.windows
{
    partial class formularioCuboAE
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
            this.aristalabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rellenolabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trazolabel = new System.Windows.Forms.Label();
            this.cuntinuocheckBox = new System.Windows.Forms.CheckBox();
            this.rayascheckBox = new System.Windows.Forms.CheckBox();
            this.puntocheckBox = new System.Windows.Forms.CheckBox();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // aristalabel
            // 
            this.aristalabel.AutoSize = true;
            this.aristalabel.Location = new System.Drawing.Point(34, 32);
            this.aristalabel.Name = "aristalabel";
            this.aristalabel.Size = new System.Drawing.Size(36, 13);
            this.aristalabel.TabIndex = 0;
            this.aristalabel.Text = "Arista ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rellenolabel
            // 
            this.rellenolabel.AutoSize = true;
            this.rellenolabel.Location = new System.Drawing.Point(34, 65);
            this.rellenolabel.Name = "rellenolabel";
            this.rellenolabel.Size = new System.Drawing.Size(43, 13);
            this.rellenolabel.TabIndex = 2;
            this.rellenolabel.Text = "Relleno";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // trazolabel
            // 
            this.trazolabel.AutoSize = true;
            this.trazolabel.Location = new System.Drawing.Point(34, 103);
            this.trazolabel.Name = "trazolabel";
            this.trazolabel.Size = new System.Drawing.Size(34, 13);
            this.trazolabel.TabIndex = 4;
            this.trazolabel.Text = "Trazo";
            // 
            // cuntinuocheckBox
            // 
            this.cuntinuocheckBox.AutoSize = true;
            this.cuntinuocheckBox.Location = new System.Drawing.Point(106, 102);
            this.cuntinuocheckBox.Name = "cuntinuocheckBox";
            this.cuntinuocheckBox.Size = new System.Drawing.Size(68, 17);
            this.cuntinuocheckBox.TabIndex = 5;
            this.cuntinuocheckBox.Text = "Continuo";
            this.cuntinuocheckBox.UseVisualStyleBackColor = true;
            // 
            // rayascheckBox
            // 
            this.rayascheckBox.AutoSize = true;
            this.rayascheckBox.Location = new System.Drawing.Point(192, 103);
            this.rayascheckBox.Name = "rayascheckBox";
            this.rayascheckBox.Size = new System.Drawing.Size(56, 17);
            this.rayascheckBox.TabIndex = 5;
            this.rayascheckBox.Text = "Rayas";
            this.rayascheckBox.UseVisualStyleBackColor = true;
            // 
            // puntocheckBox
            // 
            this.puntocheckBox.AutoSize = true;
            this.puntocheckBox.Location = new System.Drawing.Point(269, 103);
            this.puntocheckBox.Name = "puntocheckBox";
            this.puntocheckBox.Size = new System.Drawing.Size(59, 17);
            this.puntocheckBox.TabIndex = 5;
            this.puntocheckBox.Text = "Puntos";
            this.puntocheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(246, 155);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(82, 62);
            this.cancelarbutton.TabIndex = 6;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(37, 155);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(82, 62);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formularioCuboAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 281);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.puntocheckBox);
            this.Controls.Add(this.rayascheckBox);
            this.Controls.Add(this.cuntinuocheckBox);
            this.Controls.Add(this.trazolabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rellenolabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aristalabel);
            this.Name = "formularioCuboAE";
            this.Text = "formularioCuboAE";
            this.Load += new System.EventHandler(this.formularioCuboAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aristalabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rellenolabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label trazolabel;
        private System.Windows.Forms.CheckBox cuntinuocheckBox;
        private System.Windows.Forms.CheckBox rayascheckBox;
        private System.Windows.Forms.CheckBox puntocheckBox;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}