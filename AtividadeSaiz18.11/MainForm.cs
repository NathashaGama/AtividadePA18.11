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
			richTextBox1.Text += textBox1.Text + "|" + textBox2.Text + "|"+ textBox3.Text + "\n";
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("funcionários.txt", RichTextBoxStreamType. PlainText);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			  richTextBox1.LoadFile("funcionários.txt", RichTextBoxStreamType.PlainText);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			int somaTotal =0;
			int contador = 0;
			
			string[] linhas = richTextBox1.Lines;
			
			for (int i=0; i < linhas.Length; i++)
			{
				if (string.IsNullOrWhiteSpace(linhas[i]))
				continue;
				
				string[] partes= linhas[2].Split('|');
				if (partes.Length >= 3)
				{
					try
					{
						int valor= int.Parse(partes [2].Trim());
						
						somaTotal+= valor;
						contador++;
					}
					catch
					  {
					  	MessageBox.Show("Erro ao processar o valor na linha: {linhas[i]}");
					  }
				
				}else
				  {
				 	MessageBox.Show("Linha inválida encontrada: {linhas[i]}"); 
				  }
			}
				textBox4.Text= somaTotal.ToString("C"); 
			
				int media= contador > 0 ? somaTotal / contador: 0;
				textBox5.Text = media.ToString("C"); 
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			string[] linhas= richTextBox1.Lines;

			int media;
			string mediaText= textBox5.Text.Replace("R$","").Trim();
			
			if (!int. TryParse(textBox5.Text.Trim(), out media))
			 {
			  MessageBox.Show("Por favor, calcule a média antes de usar este botão.");
			  return;
			}
			string dadosAcimaMedia= "";
			
			for (int i=0; i < linhas.Length; i++)
			  {
			  if (string.IsNullOrWhiteSpace(linhas[i]))
			continue;
			
			  string[] partes=linhas[i].Split(',');
			
			if (partes.Length >= 3)
			   {
			   try
			    {
			   	int valor= int.Parse(partes[2].Trim());
			   	if (valor>media)
			   	{
			   		dadosAcimaMedia += linhas[i] + Environment. NewLine;
			     }
			
			    }
			    catch
			     {
			      MessageBox.Show("Erro ao processar o valor na linha {i+1}: {linhas[i]}");
			     }
			
			   }
			  }
			richTextBox2.Text= dadosAcimaMedia;
		}
	}	
}