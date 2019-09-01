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
		Clases.ClsSuma obj = new Clases.ClsSuma();
		Clases.ClsResta obj2 = new Clases.ClsResta();
		Clases.ClsMultiplicaccion obj3 = new Clases.ClsMultiplicaccion();
		Clases.ClsDivicion obj4 = new Clases.ClsDivicion();
		Clases.ClsPorcentaje obj5 = new Clases.ClsPorcentaje();

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
		private void Button1_Click_1(object sender, EventArgs e)
		{
			operador = "%";
			primero = Double.Parse(txtScreen.Text);
			txtScreen.Clear();
		}

		private void BtnIgual_Click(object sender, EventArgs e)
		{
			segundo = double.Parse(txtScreen.Text);

			double Sum;
			double Res;
			double Mul;
			double Div;
			double Por;

			switch(operador)
			{
				case "+":
					Sum = obj.Sumar((primero), (segundo));
					txtScreen.Text = Sum.ToString();
					break;

				case "-":
					Res = obj2.Restar((primero), (segundo));
					txtScreen.Text = Res.ToString();
					break;

				case "/":
					Div = obj4.Dividir((primero), (segundo));
					txtScreen.Text = Div.ToString();
					break;

				case "*":
					Mul = obj3.Multiplicar((primero), (segundo));
					txtScreen.Text = Mul.ToString();
					break;
				case "%":
					Por = obj5.Porcentaje((primero), (segundo));
					txtScreen.Text = Por.ToString();
					break;

			}
		}

		private void BtnBorrar_Click(object sender, EventArgs e)
		{
			if (txtScreen.Text.Length == 1)
				txtScreen.Text = "";
			else
				txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
		}

		private void BtnLimpiar_Click(object sender, EventArgs e)
		{
			txtScreen.Clear();
		}

		
	}
}
