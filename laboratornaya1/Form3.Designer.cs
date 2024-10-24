namespace laboratornaya1
{
    partial class Form3
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
            this.OkeyButtonTar = new System.Windows.Forms.Button();
            this.CancelButtonTar = new System.Windows.Forms.Button();
            this.textBox1NAME = new System.Windows.Forms.TextBox();
            this.textBox2TYPE = new System.Windows.Forms.TextBox();
            this.textBox3PRICE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkeyButtonTar
            // 
            this.OkeyButtonTar.Location = new System.Drawing.Point(585, 185);
            this.OkeyButtonTar.Name = "OkeyButtonTar";
            this.OkeyButtonTar.Size = new System.Drawing.Size(119, 95);
            this.OkeyButtonTar.TabIndex = 0;
            this.OkeyButtonTar.Text = "oK";
            this.OkeyButtonTar.UseVisualStyleBackColor = true;
            this.OkeyButtonTar.Click += new System.EventHandler(this.OkeyButtonTar_Click);
            // 
            // CancelButtonTar
            // 
            this.CancelButtonTar.Location = new System.Drawing.Point(585, 302);
            this.CancelButtonTar.Name = "CancelButtonTar";
            this.CancelButtonTar.Size = new System.Drawing.Size(119, 91);
            this.CancelButtonTar.TabIndex = 1;
            this.CancelButtonTar.Text = "Отмена";
            this.CancelButtonTar.UseVisualStyleBackColor = true;
            this.CancelButtonTar.Click += new System.EventHandler(this.CancelButtonTar_Click);
            // 
            // textBox1NAME
            // 
            this.textBox1NAME.Location = new System.Drawing.Point(205, 29);
            this.textBox1NAME.Name = "textBox1NAME";
            this.textBox1NAME.Size = new System.Drawing.Size(331, 26);
            this.textBox1NAME.TabIndex = 2;
            // 
            // textBox2TYPE
            // 
            this.textBox2TYPE.Location = new System.Drawing.Point(205, 76);
            this.textBox2TYPE.Name = "textBox2TYPE";
            this.textBox2TYPE.Size = new System.Drawing.Size(330, 26);
            this.textBox2TYPE.TabIndex = 3;
            // 
            // textBox3PRICE
            // 
            this.textBox3PRICE.Location = new System.Drawing.Point(204, 126);
            this.textBox3PRICE.Name = "textBox3PRICE";
            this.textBox3PRICE.Size = new System.Drawing.Size(331, 26);
            this.textBox3PRICE.TabIndex = 4;
            this.textBox3PRICE.TextChanged += new System.EventHandler(this.textBox3PRICE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3PRICE);
            this.Controls.Add(this.textBox2TYPE);
            this.Controls.Add(this.textBox1NAME);
            this.Controls.Add(this.CancelButtonTar);
            this.Controls.Add(this.OkeyButtonTar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkeyButtonTar;
        private System.Windows.Forms.Button CancelButtonTar;
        private System.Windows.Forms.TextBox textBox2TYPE;
        private System.Windows.Forms.TextBox textBox3PRICE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox1NAME;
    }
}