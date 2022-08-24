
namespace MATES
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.signo = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.OP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Coin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.hability = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(284, 24);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(260, 42);
            this.txtNum.TabIndex = 0;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(86, 26);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(32, 36);
            this.num1.TabIndex = 1;
            this.num1.Text = "0";
            // 
            // signo
            // 
            this.signo.AutoSize = true;
            this.signo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signo.Location = new System.Drawing.Point(124, 26);
            this.signo.Name = "signo";
            this.signo.Size = new System.Drawing.Size(36, 36);
            this.signo.TabIndex = 2;
            this.signo.Text = "+";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(166, 26);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(32, 36);
            this.num2.TabIndex = 3;
            this.num2.Text = "0";
            // 
            // OP
            // 
            this.OP.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OP.ForeColor = System.Drawing.Color.Black;
            this.OP.Location = new System.Drawing.Point(262, 100);
            this.OP.Name = "OP";
            this.OP.Size = new System.Drawing.Size(326, 58);
            this.OP.TabIndex = 4;
            this.OP.Text = "Comprobar";
            this.OP.UseVisualStyleBackColor = true;
            this.OP.Click += new System.EventHandler(this.num1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(30, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Monedas:";
            // 
            // Coin
            // 
            this.Coin.AutoSize = true;
            this.Coin.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coin.Location = new System.Drawing.Point(737, 9);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(24, 26);
            this.Coin.TabIndex = 7;
            this.Coin.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(30, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "About the Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hability
            // 
            this.hability.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hability.ForeColor = System.Drawing.Color.Black;
            this.hability.Location = new System.Drawing.Point(624, 45);
            this.hability.Name = "hability";
            this.hability.Size = new System.Drawing.Size(155, 113);
            this.hability.TabIndex = 9;
            this.hability.Text = "10$ Coin\r\nAdivinar el resultado de una respuesta\r\n";
            this.hability.UseVisualStyleBackColor = true;
            this.hability.Visible = false;
            this.hability.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(262, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(326, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dev Mode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 227);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hability);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OP);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.signo);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.txtNum);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label signo;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Button OP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Coin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button hability;
        private System.Windows.Forms.Button button3;
    }
}

