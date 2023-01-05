using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void bnt_farhenheight_Click(object sender, EventArgs e)
		{
			float f = 0;

			try
			{
				f = float.Parse(txt_farhenheight.Text);
			}
			catch 
			{
				MessageBox.Show("Try only numbers");
			}

			float c = 5f / 9f * (f - 32);
			float k = c - 273;

			txt_celsius.Text = c.ToString();
			txt_kelvin.Text = k.ToString();
		}

		private void bnt_celsius_Click(object sender, EventArgs e)
		{
			float c = 0;

			try
			{
				c = float.Parse(txt_celsius.Text);
			}
			catch
			{
				MessageBox.Show("Try only numbers");
			}

			float f = (9f / 5f) * c  + 32;
			float k = c + 273;

			txt_farhenheight.Text = f.ToString();
			txt_kelvin.Text= k.ToString();
		}

		private void bnt_kelvin_Click(object sender, EventArgs e)
		{
			float k = 0;

			try
			{
				k = float.Parse(txt_kelvin.Text);
			}
			catch
			{
				MessageBox.Show("Try only numbers");
			}

			float f = 9 / 5f * (k - 273) + 32;
			float c = k - 273;

			txt_farhenheight.Text = f.ToString();
			txt_celsius.Text = c.ToString();
		}

		private void btn_reset_Click(object sender, EventArgs e)
		{
			txt_farhenheight.Text = "";
			txt_celsius.Text = "";
			txt_kelvin.Text = "";

		}
	}
}
