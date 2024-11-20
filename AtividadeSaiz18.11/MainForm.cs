/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 18/11/2024
 * Hora: 19:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atividadeSaiz18._1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	//Botão de salvar
	richTextBox1.SaveFile("funcionarios.txt", RichTextBoxStreamType.PlainText);
	MessageBox.Show("Arquivo salvo com sucesso");
		}
		void Button6Click(object sender, EventArgs e)
		{
			//2 botão de salvar
			richTextBox2.SaveFile("gastos.txt", RichTextBoxStreamType.PlainText);
			MessageBox.Show("Arquivo salvo com sucesso");
		}
		void Button2Click(object sender, EventArgs e)
		{
	//Abrir
	richTextBox1.LoadFile("funcionarios.txt", RichTextBoxStreamType.PlainText);
		}
		void Button3Click(object sender, EventArgs e)
		{
	//Limpar 
	richTextBox1.Clear();
		}
		void Button7Click(object sender, EventArgs e)
		{
			//Limpar segundo richBox
	richTextBox2.Clear();
		}
		void Button4Click(object sender, EventArgs e)
		{
	// adicionar 
	richTextBox1.Text += textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + "\n";
	textBox1.Clear();
	textBox2.Clear();
	textBox3.Clear();
		}
		
		
		void Button5Click(object sender, EventArgs e)
		{
			//calcular media
			int[] valores= new int[50];
			for(int i=0; i<50; i++){
				string linha= richTextBox1.Lines[i];
				string[] dados= linha.Split('|');
				valores[i]= int.Parse(dados[2]);
			}
			int soma= valores[0] + valores[1] +valores[2] + valores[3] +valores[4] + valores[5] +valores[6] + valores[7] +valores[8] + valores[9] +valores[10] 
				+ valores[11] +valores[12] + valores[13] +valores[14] + valores[15] +valores[16] + valores[17] +valores[18] + valores[19] +valores[20]
				+ valores[21] +valores[22] + valores[23] +valores[24] + valores[25] +valores[26] + valores[27] +valores[28] + valores[29] +valores[30] 
				+ valores[31] +valores[32] + valores[33] +valores[34] + valores[35] +valores[36] + valores[37] +valores[38] + valores[39] +valores[40] 
				+ valores[41] +valores[42] + valores[43] +valores[44] + valores[45] +valores[46] + valores[47] +valores[48] + valores[49];
			textBox4.Text= soma.ToString("C");
			
			}
	

		}
	}
