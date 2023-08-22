namespace ParcialTema1Windows
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LargoText = new TextBox();
            AnchoText = new TextBox();
            AlturaText = new TextBox();
            button1 = new Button();
            label4 = new Label();
            contadorLable = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 99);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "largo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 156);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "ancho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 203);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "altura";
            // 
            // LargoText
            // 
            LargoText.Location = new Point(35, 124);
            LargoText.Name = "LargoText";
            LargoText.Size = new Size(100, 23);
            LargoText.TabIndex = 3;
            // 
            // AnchoText
            // 
            AnchoText.Location = new Point(34, 177);
            AnchoText.Name = "AnchoText";
            AnchoText.Size = new Size(100, 23);
            AnchoText.TabIndex = 4;
            // 
            // AlturaText
            // 
            AlturaText.Location = new Point(34, 221);
            AlturaText.Name = "AlturaText";
            AlturaText.Size = new Size(100, 23);
            AlturaText.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(181, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 277);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad de Prismas:";
            // 
            // contadorLable
            // 
            contadorLable.AutoSize = true;
            contadorLable.Location = new Point(154, 278);
            contadorLable.Name = "contadorLable";
            contadorLable.Size = new Size(38, 15);
            contadorLable.TabIndex = 8;
            contadorLable.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 450);
            Controls.Add(contadorLable);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(AlturaText);
            Controls.Add(AnchoText);
            Controls.Add(LargoText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LargoText;
        private TextBox AnchoText;
        private TextBox AlturaText;
        private Button button1;
        private Label label4;
        private Label contadorLable;
    }
}