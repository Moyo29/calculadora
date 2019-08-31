namespace WindowsFormsApp1
{
	partial class Calculadora
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
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnN7 = new System.Windows.Forms.Button();
			this.btnN4 = new System.Windows.Forms.Button();
			this.btnN1 = new System.Windows.Forms.Button();
			this.btnN0 = new System.Windows.Forms.Button();
			this.btnN2 = new System.Windows.Forms.Button();
			this.btnN5 = new System.Windows.Forms.Button();
			this.btnN8 = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.btnN3 = new System.Windows.Forms.Button();
			this.btnN6 = new System.Windows.Forms.Button();
			this.btnN9 = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnMult = new System.Windows.Forms.Button();
			this.txtScreen = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSuma
			// 
			this.btnSuma.BackColor = System.Drawing.Color.Tomato;
			this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSuma.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuma.Location = new System.Drawing.Point(18, 67);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(64, 60);
			this.btnSuma.TabIndex = 0;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = false;
			this.btnSuma.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btnN7
			// 
			this.btnN7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN7.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN7.Location = new System.Drawing.Point(18, 133);
			this.btnN7.Name = "btnN7";
			this.btnN7.Size = new System.Drawing.Size(64, 60);
			this.btnN7.TabIndex = 1;
			this.btnN7.Text = "7";
			this.btnN7.UseVisualStyleBackColor = false;
			this.btnN7.Click += new System.EventHandler(this.BtnN7_Click);
			// 
			// btnN4
			// 
			this.btnN4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN4.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN4.Location = new System.Drawing.Point(18, 199);
			this.btnN4.Name = "btnN4";
			this.btnN4.Size = new System.Drawing.Size(64, 60);
			this.btnN4.TabIndex = 2;
			this.btnN4.Text = "4";
			this.btnN4.UseVisualStyleBackColor = false;
			this.btnN4.Click += new System.EventHandler(this.Button3_Click);
			// 
			// btnN1
			// 
			this.btnN1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN1.Location = new System.Drawing.Point(18, 265);
			this.btnN1.Name = "btnN1";
			this.btnN1.Size = new System.Drawing.Size(64, 60);
			this.btnN1.TabIndex = 3;
			this.btnN1.Text = "1";
			this.btnN1.UseVisualStyleBackColor = false;
			this.btnN1.Click += new System.EventHandler(this.BtnN1_Click);
			// 
			// btnN0
			// 
			this.btnN0.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN0.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN0.Location = new System.Drawing.Point(18, 331);
			this.btnN0.Name = "btnN0";
			this.btnN0.Size = new System.Drawing.Size(134, 60);
			this.btnN0.TabIndex = 4;
			this.btnN0.Text = "0";
			this.btnN0.UseVisualStyleBackColor = false;
			this.btnN0.Click += new System.EventHandler(this.BtnN0_Click);
			// 
			// btnN2
			// 
			this.btnN2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN2.Location = new System.Drawing.Point(88, 265);
			this.btnN2.Name = "btnN2";
			this.btnN2.Size = new System.Drawing.Size(64, 60);
			this.btnN2.TabIndex = 8;
			this.btnN2.Text = "2";
			this.btnN2.UseVisualStyleBackColor = false;
			this.btnN2.Click += new System.EventHandler(this.BtnN2_Click);
			// 
			// btnN5
			// 
			this.btnN5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN5.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN5.Location = new System.Drawing.Point(88, 199);
			this.btnN5.Name = "btnN5";
			this.btnN5.Size = new System.Drawing.Size(64, 60);
			this.btnN5.TabIndex = 7;
			this.btnN5.Text = "5";
			this.btnN5.UseVisualStyleBackColor = false;
			this.btnN5.Click += new System.EventHandler(this.Button8_Click);
			// 
			// btnN8
			// 
			this.btnN8.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN8.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN8.Location = new System.Drawing.Point(88, 133);
			this.btnN8.Name = "btnN8";
			this.btnN8.Size = new System.Drawing.Size(64, 60);
			this.btnN8.TabIndex = 6;
			this.btnN8.Text = "8";
			this.btnN8.UseVisualStyleBackColor = false;
			this.btnN8.Click += new System.EventHandler(this.BtnN8_Click);
			// 
			// btnResta
			// 
			this.btnResta.BackColor = System.Drawing.Color.Tomato;
			this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnResta.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResta.Location = new System.Drawing.Point(88, 67);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(64, 60);
			this.btnResta.TabIndex = 5;
			this.btnResta.Text = "-";
			this.btnResta.UseVisualStyleBackColor = false;
			this.btnResta.Click += new System.EventHandler(this.Button10_Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button11.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.Location = new System.Drawing.Point(158, 331);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(64, 60);
			this.button11.TabIndex = 14;
			this.button11.Text = ".";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.Button11_Click);
			// 
			// btnN3
			// 
			this.btnN3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN3.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN3.Location = new System.Drawing.Point(158, 265);
			this.btnN3.Name = "btnN3";
			this.btnN3.Size = new System.Drawing.Size(64, 60);
			this.btnN3.TabIndex = 13;
			this.btnN3.Text = "3";
			this.btnN3.UseVisualStyleBackColor = false;
			this.btnN3.Click += new System.EventHandler(this.BtnN3_Click);
			// 
			// btnN6
			// 
			this.btnN6.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN6.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN6.Location = new System.Drawing.Point(158, 199);
			this.btnN6.Name = "btnN6";
			this.btnN6.Size = new System.Drawing.Size(64, 60);
			this.btnN6.TabIndex = 12;
			this.btnN6.Text = "6";
			this.btnN6.UseVisualStyleBackColor = false;
			this.btnN6.Click += new System.EventHandler(this.BtnN6_Click);
			// 
			// btnN9
			// 
			this.btnN9.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnN9.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN9.Location = new System.Drawing.Point(158, 133);
			this.btnN9.Name = "btnN9";
			this.btnN9.Size = new System.Drawing.Size(64, 60);
			this.btnN9.TabIndex = 11;
			this.btnN9.Text = "9";
			this.btnN9.UseVisualStyleBackColor = false;
			this.btnN9.Click += new System.EventHandler(this.Button14_Click);
			// 
			// btnDiv
			// 
			this.btnDiv.BackColor = System.Drawing.Color.Tomato;
			this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDiv.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.Location = new System.Drawing.Point(158, 67);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(64, 60);
			this.btnDiv.TabIndex = 10;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = false;
			this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
			// 
			// btnIgual
			// 
			this.btnIgual.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnIgual.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIgual.Location = new System.Drawing.Point(228, 265);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(64, 126);
			this.btnIgual.TabIndex = 18;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = false;
			this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.Yellow;
			this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBorrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.Location = new System.Drawing.Point(228, 199);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(64, 60);
			this.btnBorrar.TabIndex = 17;
			this.btnBorrar.Text = "←";
			this.btnBorrar.UseVisualStyleBackColor = false;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLimpiar.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(228, 133);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(64, 60);
			this.btnLimpiar.TabIndex = 16;
			this.btnLimpiar.Text = "CE";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnMult
			// 
			this.btnMult.BackColor = System.Drawing.Color.Tomato;
			this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMult.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMult.Location = new System.Drawing.Point(228, 67);
			this.btnMult.Name = "btnMult";
			this.btnMult.Size = new System.Drawing.Size(64, 60);
			this.btnMult.TabIndex = 15;
			this.btnMult.Text = "*";
			this.btnMult.UseVisualStyleBackColor = false;
			this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
			// 
			// txtScreen
			// 
			this.txtScreen.BackColor = System.Drawing.SystemColors.ControlDark;
			this.txtScreen.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtScreen.Location = new System.Drawing.Point(18, 15);
			this.txtScreen.Name = "txtScreen";
			this.txtScreen.ReadOnly = true;
			this.txtScreen.Size = new System.Drawing.Size(274, 46);
			this.txtScreen.TabIndex = 19;
			this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtScreen.TextChanged += new System.EventHandler(this.TxtScreen_TextChanged);
			// 
			// Calculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 396);
			this.Controls.Add(this.txtScreen);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnMult);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.btnN3);
			this.Controls.Add(this.btnN6);
			this.Controls.Add(this.btnN9);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnN2);
			this.Controls.Add(this.btnN5);
			this.Controls.Add(this.btnN8);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnN0);
			this.Controls.Add(this.btnN1);
			this.Controls.Add(this.btnN4);
			this.Controls.Add(this.btnN7);
			this.Controls.Add(this.btnSuma);
			this.Name = "Calculadora";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnN7;
		private System.Windows.Forms.Button btnN4;
		private System.Windows.Forms.Button btnN1;
		private System.Windows.Forms.Button btnN0;
		private System.Windows.Forms.Button btnN2;
		private System.Windows.Forms.Button btnN5;
		private System.Windows.Forms.Button btnN8;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button btnN3;
		private System.Windows.Forms.Button btnN6;
		private System.Windows.Forms.Button btnN9;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnIgual;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnMult;
		private System.Windows.Forms.TextBox txtScreen;
	}
}

