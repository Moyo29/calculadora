using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Calculadora : Form
	{
		double primero;
		double segundo;
		string operador;

		public Calculadora()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			operador = "+";
			primero = Double.Parse(txtScreen.Text);
			txtScreen.Clear(); 
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "4";
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "5";
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			operador = "-";
			primero = Double.Parse(txtScreen.Text);
			txtScreen.Clear();
		}

		private void Button14_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "9";
		}

		private void BtnN0_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "0";
		}

		private void TxtScreen_TextChanged(object sender, EventArgs e)
		{

		}

		private void BtnN1_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "1";
		}

		private void BtnN2_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "2";
		}

		private void BtnN3_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "3";
		}

		private void BtnN6_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "6";
		}

		private void BtnN7_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "7";
		}

		private void BtnN8_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + "8";
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			txtScreen.Text = txtScreen.Text + ".";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnDiv_Click(object sender, EventArgs e)
		{
			operador = "/";
			primero = Double.Parse(txtScreen.Text);
			txtScreen.Clear();
		}

		private void BtnMult_Click(object sender, EventArgs e)
		{
			operador = "*";
			primero = Double.Parse(txtScreen.Text);
			txtScreen.Clear();
		}
	}
}
