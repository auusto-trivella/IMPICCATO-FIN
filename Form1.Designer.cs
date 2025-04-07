namespace IMPICCATO_FIN
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
            exit = new Button();
            tent = new Label();
            textBox1 = new TextBox();
            fac = new Button();
            med = new Button();
            dif = new Button();
            lSbagliate = new Label();
            jolly = new Label();
            scritLettera = new TextBox();
            scritParola = new TextBox();
            lettera = new Button();
            parola = new Button();
            punteggio = new Label();
            trat = new Label();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(1038, 12);
            exit.Name = "exit";
            exit.Size = new Size(126, 73);
            exit.TabIndex = 0;
            exit.Text = "ESCI";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // tent
            // 
            tent.AutoSize = true;
            tent.Location = new Point(281, 95);
            tent.Name = "tent";
            tent.Size = new Size(82, 15);
            tent.TabIndex = 1;
            tent.Text = "TENTATIVI--->";
            tent.Click += tentativi_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(892, 496);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // fac
            // 
            fac.Location = new Point(713, 108);
            fac.Name = "fac";
            fac.Size = new Size(75, 23);
            fac.TabIndex = 3;
            fac.Text = "FACILE";
            fac.UseVisualStyleBackColor = true;
            fac.Click += fac_Click;
            // 
            // med
            // 
            med.Location = new Point(810, 108);
            med.Name = "med";
            med.Size = new Size(75, 23);
            med.TabIndex = 4;
            med.Text = "MEDIA";
            med.UseVisualStyleBackColor = true;
            med.Click += med_Click;
            // 
            // dif
            // 
            dif.Location = new Point(915, 108);
            dif.Name = "dif";
            dif.Size = new Size(75, 23);
            dif.TabIndex = 5;
            dif.Text = "DIFFICILE";
            dif.UseVisualStyleBackColor = true;
            dif.Click += dif_Click;
            // 
            // lSbagliate
            // 
            lSbagliate.AutoSize = true;
            lSbagliate.Location = new Point(281, 116);
            lSbagliate.Name = "lSbagliate";
            lSbagliate.Size = new Size(86, 15);
            lSbagliate.TabIndex = 6;
            lSbagliate.Text = "LETTERE USATE";
            lSbagliate.Click += lSbagliate_Click;
            // 
            // jolly
            // 
            jolly.AutoSize = true;
            jolly.Location = new Point(281, 144);
            jolly.Name = "jolly";
            jolly.Size = new Size(38, 15);
            jolly.TabIndex = 7;
            jolly.Text = "JOLLY";
            jolly.Click += jolly_Click;
            // 
            // scritLettera
            // 
            scritLettera.Location = new Point(383, 314);
            scritLettera.Name = "scritLettera";
            scritLettera.Size = new Size(100, 23);
            scritLettera.TabIndex = 8;
            scritLettera.TextChanged += scritLettera_TextChanged;
            // 
            // scritParola
            // 
            scritParola.Location = new Point(667, 314);
            scritParola.Name = "scritParola";
            scritParola.Size = new Size(100, 23);
            scritParola.TabIndex = 9;
            // 
            // lettera
            // 
            lettera.Location = new Point(394, 271);
            lettera.Name = "lettera";
            lettera.Size = new Size(75, 23);
            lettera.TabIndex = 11;
            lettera.Text = "MANDA";
            lettera.UseVisualStyleBackColor = true;
            lettera.Click += lettera_Click;
            // 
            // parola
            // 
            parola.Location = new Point(680, 271);
            parola.Name = "parola";
            parola.Size = new Size(75, 23);
            parola.TabIndex = 12;
            parola.Text = "MANDA";
            parola.UseVisualStyleBackColor = true;
            parola.Click += parola_Click;
            // 
            // punteggio
            // 
            punteggio.AutoSize = true;
            punteggio.Location = new Point(281, 70);
            punteggio.Name = "punteggio";
            punteggio.Size = new Size(94, 15);
            punteggio.TabIndex = 13;
            punteggio.Text = "PUNTEGGIO--->";
            punteggio.Click += punteggio_Click;
            // 
            // trat
            // 
            trat.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trat.Location = new Point(466, 169);
            trat.Name = "trat";
            trat.Size = new Size(193, 70);
            trat.TabIndex = 14;
            trat.Text = "label1";
            trat.Click += trat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 591);
            Controls.Add(trat);
            Controls.Add(punteggio);
            Controls.Add(parola);
            Controls.Add(lettera);
            Controls.Add(scritParola);
            Controls.Add(scritLettera);
            Controls.Add(jolly);
            Controls.Add(lSbagliate);
            Controls.Add(dif);
            Controls.Add(med);
            Controls.Add(fac);
            Controls.Add(textBox1);
            Controls.Add(tent);
            Controls.Add(exit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label tent;
        private TextBox textBox1;
        private Button fac;
        private Button med;
        private Button dif;
        private Label lSbagliate;
        private Label jolly;
        private TextBox scritLettera;
        private TextBox scritParola;
        private Button lettera;
        private Button parola;
        private Label punteggio;
        private Label trat;
    }
}
