
namespace TareaDeProgramacion
{
    partial class Form11
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btncapicua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ingrese un numero";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnumero.Location = new System.Drawing.Point(270, 156);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(183, 33);
            this.txtnumero.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vamos a ver si el numero es capicua";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(189, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ocultar ejercicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Transparent;
            this.lblresultado.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.Location = new System.Drawing.Point(88, 326);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(22, 21);
            this.lblresultado.TabIndex = 23;
            this.lblresultado.Text = "--";
            // 
            // btncapicua
            // 
            this.btncapicua.BackColor = System.Drawing.Color.White;
            this.btncapicua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncapicua.Location = new System.Drawing.Point(195, 250);
            this.btncapicua.Name = "btncapicua";
            this.btncapicua.Size = new System.Drawing.Size(128, 53);
            this.btncapicua.TabIndex = 24;
            this.btncapicua.Text = "Ver si es capicua";
            this.btncapicua.UseVisualStyleBackColor = false;
            this.btncapicua.Click += new System.EventHandler(this.btncapicua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(64, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 48);
            this.label4.TabIndex = 26;
            this.label4.Text = "Realizar un programa que imprima si un \r\nnúmero es capicúa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ejercicio 10: Número Capicúa";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(515, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncapicua);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label3);
            this.Name = "Form11";
            this.Text = "Ejercicio 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btncapicua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}