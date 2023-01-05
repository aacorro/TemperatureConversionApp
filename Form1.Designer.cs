namespace TempConversion
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_farhenheight = new System.Windows.Forms.TextBox();
			this.txt_celsius = new System.Windows.Forms.TextBox();
			this.txt_kelvin = new System.Windows.Forms.TextBox();
			this.bnt_fahrenheight = new System.Windows.Forms.Button();
			this.bnt_celsius = new System.Windows.Forms.Button();
			this.bnt_kelvin = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label1.Location = new System.Drawing.Point(102, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fahrenheight";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label2.Location = new System.Drawing.Point(154, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Celsius";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
			this.label3.Location = new System.Drawing.Point(164, 271);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kelvin";
			// 
			// txt_farhenheight
			// 
			this.txt_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_farhenheight.Location = new System.Drawing.Point(279, 115);
			this.txt_farhenheight.Name = "txt_farhenheight";
			this.txt_farhenheight.Size = new System.Drawing.Size(145, 32);
			this.txt_farhenheight.TabIndex = 3;
			// 
			// txt_celsius
			// 
			this.txt_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_celsius.Location = new System.Drawing.Point(279, 191);
			this.txt_celsius.Name = "txt_celsius";
			this.txt_celsius.Size = new System.Drawing.Size(145, 32);
			this.txt_celsius.TabIndex = 4;
			// 
			// txt_kelvin
			// 
			this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_kelvin.Location = new System.Drawing.Point(279, 265);
			this.txt_kelvin.Name = "txt_kelvin";
			this.txt_kelvin.Size = new System.Drawing.Size(145, 32);
			this.txt_kelvin.TabIndex = 5;
			// 
			// bnt_fahrenheight
			// 
			this.bnt_fahrenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt_fahrenheight.Location = new System.Drawing.Point(468, 114);
			this.bnt_fahrenheight.Name = "bnt_fahrenheight";
			this.bnt_fahrenheight.Size = new System.Drawing.Size(94, 33);
			this.bnt_fahrenheight.TabIndex = 6;
			this.bnt_fahrenheight.Text = "Convert";
			this.bnt_fahrenheight.UseVisualStyleBackColor = true;
			this.bnt_fahrenheight.Click += new System.EventHandler(this.bnt_farhenheight_Click);
			// 
			// bnt_celsius
			// 
			this.bnt_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt_celsius.Location = new System.Drawing.Point(468, 190);
			this.bnt_celsius.Name = "bnt_celsius";
			this.bnt_celsius.Size = new System.Drawing.Size(94, 33);
			this.bnt_celsius.TabIndex = 7;
			this.bnt_celsius.Text = "Convert";
			this.bnt_celsius.UseVisualStyleBackColor = true;
			this.bnt_celsius.Click += new System.EventHandler(this.bnt_celsius_Click);
			// 
			// bnt_kelvin
			// 
			this.bnt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt_kelvin.Location = new System.Drawing.Point(468, 264);
			this.bnt_kelvin.Name = "bnt_kelvin";
			this.bnt_kelvin.Size = new System.Drawing.Size(94, 33);
			this.bnt_kelvin.TabIndex = 8;
			this.bnt_kelvin.Text = "Convert";
			this.bnt_kelvin.UseVisualStyleBackColor = true;
			this.bnt_kelvin.Click += new System.EventHandler(this.bnt_kelvin_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_reset.Location = new System.Drawing.Point(279, 361);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(145, 42);
			this.btn_reset.TabIndex = 9;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(136, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(426, 35);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "Temperature Conversion Calculator";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.bnt_kelvin);
			this.Controls.Add(this.bnt_celsius);
			this.Controls.Add(this.bnt_fahrenheight);
			this.Controls.Add(this.txt_kelvin);
			this.Controls.Add(this.txt_celsius);
			this.Controls.Add(this.txt_farhenheight);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_farhenheight;
		private System.Windows.Forms.TextBox txt_celsius;
		private System.Windows.Forms.TextBox txt_kelvin;
		private System.Windows.Forms.Button bnt_fahrenheight;
		private System.Windows.Forms.Button bnt_celsius;
		private System.Windows.Forms.Button bnt_kelvin;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.TextBox textBox1;
	}
}

