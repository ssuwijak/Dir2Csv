namespace FileScanner
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			textBox1 = new TextBox();
			button2 = new Button();
			button3 = new Button();
			button1 = new Button();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(526, 218);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Target";
			// 
			// groupBox2
			// 
			groupBox2.Location = new Point(165, 268);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(200, 100);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "groupBox2";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 69);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Both;
			textBox1.Size = new Size(498, 132);
			textBox1.TabIndex = 0;
			// 
			// button2
			// 
			button2.Location = new Point(135, 40);
			button2.Name = "button2";
			button2.Size = new Size(150, 23);
			button2.TabIndex = 1;
			button2.Text = "select a folder list file";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(416, 40);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 2;
			button3.Text = "clear";
			button3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(12, 40);
			button1.Name = "button1";
			button1.Size = new Size(117, 23);
			button1.TabIndex = 3;
			button1.Text = "select a folder";
			button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 19);
			label1.Name = "label1";
			label1.Size = new Size(327, 15);
			label1.TabIndex = 4;
			label1.Text = "enter the path from the button or directly type in the textbox";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Button button1;
		private Button button3;
		private Button button2;
		private TextBox textBox1;
		private GroupBox groupBox2;
		private Label label1;
	}
}
