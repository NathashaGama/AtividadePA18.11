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
		void Button4Click(object sender, EventArgs e)
		{
	// adicionar 
	richTextBox1.Text += textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + "\n";
	textBox1.Clear();
	textBox2.Clear();
	textBox3.Clear();
		}
		void Button1Click(object sender, EventArgs e)
		{
	//Botão de salvar
	richTextBox1.SaveFile("funcionarios.txt", RichTextBoxStreamType.PlainText);
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
		void Button6Click(object sender, EventArgs e)
		{
			//2 botão de salvar
			richTextBox2.SaveFile("gastos.txt", RichTextBoxStreamType.PlainText);
			MessageBox.Show("Arquivo salvo com sucesso");
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			//Limpar segundo richBox
	richTextBox2.Clear();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
		// soma do total
			double total= 0;
			int cont= 0;
		// pegar linha 
			string[] linhas = richTextBox1.Lines;
			
			for (int i= 0; i<linhas.Length; i++){
		//tirar linhas sem dados
			if(string.IsNullOrWhiteSpace(linhas[i])) continue;
	
		//pegar dado
			string[] dado1= linhas[i].Split('|');
	
			if (dado1.Length>=3)
			{
				try
				{
					double valor= double.Parse(dado1[1].Trim());
					total += valor;
					cont++; 
				}
				catch
				{
					// pra o caso de dar errado
					MessageBox.Show("Erro ao processar o valor na linha {i=1}: {linhas[i]}");
				}
			}else
			{
				MessageBox.Show("Linha inválida encontrada: {limhas[i]}");
			}
}
			textBox4.Text= total.ToString("C");
			
			//calculo da média
			double media= cont>0 ? total/cont : 0;
			
			// exibir
			textBox5.Text= media.ToString("C");
			}
	
		
		void Button8Click(object sender, EventArgs e)
		{
			
		}
			}
			}
