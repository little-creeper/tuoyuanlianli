namespace tuoyuanlianli
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
            this.go = new System.Windows.Forms.Button();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(27, 109);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 0;
            this.go.Text = "计算";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(44, 22);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.PlaceholderText = "b";
            this.textBox_b.Size = new System.Drawing.Size(32, 23);
            this.textBox_b.TabIndex = 2;
            this.textBox_b.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(6, 22);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.PlaceholderText = "k";
            this.textBox_k.Size = new System.Drawing.Size(34, 23);
            this.textBox_k.TabIndex = 3;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(6, 22);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.PlaceholderText = "a";
            this.textBox_a.Size = new System.Drawing.Size(32, 23);
            this.textBox_a.TabIndex = 4;
            // 
            // textBox_b2
            // 
            this.textBox_b2.Location = new System.Drawing.Point(46, 22);
            this.textBox_b2.Name = "textBox_b2";
            this.textBox_b2.PlaceholderText = "b";
            this.textBox_b2.Size = new System.Drawing.Size(33, 23);
            this.textBox_b2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_a);
            this.groupBox1.Controls.Add(this.textBox_b);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "椭圆";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_b2);
            this.groupBox2.Controls.Add(this.textBox_k);
            this.groupBox2.Location = new System.Drawing.Point(123, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 65);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "直线";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "输出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "椭圆与直线的奇妙冒险";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button go;
        private TextBox textBox_b;
        private TextBox textBox_k;
        private TextBox textBox_a;
        private TextBox textBox_b2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
    }
}