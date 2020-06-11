namespace Calculadora
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(101, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(161, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(41, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(101, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(161, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(101, 98);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(54, 48);
            this.division.TabIndex = 9;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.Location = new System.Drawing.Point(161, 98);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(54, 48);
            this.multiplicacion.TabIndex = 10;
            this.multiplicacion.Text = "x";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(234, 98);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(54, 48);
            this.resta.TabIndex = 11;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(234, 152);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(54, 102);
            this.suma.TabIndex = 12;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(41, 314);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(114, 48);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // punto
            // 
            this.punto.Location = new System.Drawing.Point(161, 314);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(54, 48);
            this.punto.TabIndex = 14;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(234, 260);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(54, 102);
            this.Igual.TabIndex = 15;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(41, 48);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(247, 44);
            this.pantalla.TabIndex = 16;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(41, 98);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 48);
            this.button10.TabIndex = 17;
            this.button10.Text = "CE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 395);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.division);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button button10;
    }
}

