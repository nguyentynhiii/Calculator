
namespace Calculator
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
            this.bttinh = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttinh
            // 
            this.bttinh.Location = new System.Drawing.Point(223, 268);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(75, 50);
            this.bttinh.TabIndex = 0;
            this.bttinh.Text = "Cộng ";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(223, 68);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(213, 22);
            this.txtA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "So A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "So B:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(223, 126);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(213, 22);
            this.txtB.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(223, 184);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(213, 22);
            this.txtKQ.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ket qua:";
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(335, 268);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 50);
            this.btTru.TabIndex = 0;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.ClientSizeChanged += new System.EventHandler(this.btTru_ClientSizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.bttinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTru;
    }
}

