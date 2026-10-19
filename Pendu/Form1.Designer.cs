namespace Pendu
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
            this.btnMot = new System.Windows.Forms.Button();
            this.textMot = new System.Windows.Forms.TextBox();
            this.TextDeviner = new System.Windows.Forms.TextBox();
            this.btnDeviner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DejaEntrer = new System.Windows.Forms.Label();
            this.MotCacher = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMot
            // 
            this.btnMot.BackColor = System.Drawing.Color.Green;
            this.btnMot.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMot.Location = new System.Drawing.Point(220, 124);
            this.btnMot.Name = "btnMot";
            this.btnMot.Size = new System.Drawing.Size(84, 28);
            this.btnMot.TabIndex = 0;
            this.btnMot.Text = "ENTRER";
            this.btnMot.UseVisualStyleBackColor = false;
            this.btnMot.Click += new System.EventHandler(this.button1_Click);
            // 
            // textMot
            // 
            this.textMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textMot.Location = new System.Drawing.Point(191, 80);
            this.textMot.Name = "textMot";
            this.textMot.Size = new System.Drawing.Size(147, 38);
            this.textMot.TabIndex = 1;
            // 
            // TextDeviner
            // 
            this.TextDeviner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TextDeviner.Location = new System.Drawing.Point(227, 257);
            this.TextDeviner.Name = "TextDeviner";
            this.TextDeviner.Size = new System.Drawing.Size(77, 38);
            this.TextDeviner.TabIndex = 3;
            // 
            // btnDeviner
            // 
            this.btnDeviner.BackColor = System.Drawing.Color.Green;
            this.btnDeviner.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeviner.Location = new System.Drawing.Point(227, 301);
            this.btnDeviner.Name = "btnDeviner";
            this.btnDeviner.Size = new System.Drawing.Size(77, 26);
            this.btnDeviner.TabIndex = 2;
            this.btnDeviner.Text = "ENTRER";
            this.btnDeviner.UseVisualStyleBackColor = false;
            this.btnDeviner.Click += new System.EventHandler(this.btnDeviner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(204, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deviner une lettre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(204, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot à Chercher";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DejaEntrer
            // 
            this.DejaEntrer.AutoSize = true;
            this.DejaEntrer.Location = new System.Drawing.Point(6, 18);
            this.DejaEntrer.Name = "DejaEntrer";
            this.DejaEntrer.Size = new System.Drawing.Size(40, 13);
            this.DejaEntrer.TabIndex = 7;
            this.DejaEntrer.Text = "A, B, C";
            // 
            // MotCacher
            // 
            this.MotCacher.AutoSize = true;
            this.MotCacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MotCacher.Location = new System.Drawing.Point(227, 186);
            this.MotCacher.Name = "MotCacher";
            this.MotCacher.Size = new System.Drawing.Size(77, 31);
            this.MotCacher.TabIndex = 8;
            this.MotCacher.Text = "-------";
            this.MotCacher.Click += new System.EventHandler(this.MotCacher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DejaEntrer);
            this.groupBox1.Location = new System.Drawing.Point(66, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 38);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEJA ESSAYER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(554, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MotCacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextDeviner);
            this.Controls.Add(this.btnDeviner);
            this.Controls.Add(this.textMot);
            this.Controls.Add(this.btnMot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMot;
        private System.Windows.Forms.TextBox textMot;
        private System.Windows.Forms.TextBox TextDeviner;
        private System.Windows.Forms.Button btnDeviner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DejaEntrer;
        private System.Windows.Forms.Label MotCacher;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

