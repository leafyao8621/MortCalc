namespace MortCalc
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "计算结果";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(32, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(721, 31);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Period,
            this.Balance,
            this.PrincipalPayment,
            this.InterestPayment});
            this.dataGridView1.Location = new System.Drawing.Point(32, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(721, 225);
            this.dataGridView1.TabIndex = 5;
            // 
            // Period
            // 
            this.Period.HeaderText = "期数";
            this.Period.MinimumWidth = 8;
            this.Period.Name = "Period";
            this.Period.Width = 150;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "余额";
            this.Balance.MinimumWidth = 8;
            this.Balance.Name = "Balance";
            this.Balance.Width = 150;
            // 
            // PrincipalPayment
            // 
            this.PrincipalPayment.HeaderText = "本金支付";
            this.PrincipalPayment.MinimumWidth = 8;
            this.PrincipalPayment.Name = "PrincipalPayment";
            this.PrincipalPayment.Width = 150;
            // 
            // InterestPayment
            // 
            this.InterestPayment.HeaderText = "利息支付";
            this.InterestPayment.MinimumWidth = 8;
            this.InterestPayment.Name = "InterestPayment";
            this.InterestPayment.Width = 150;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "贷款计算 - 可变 - 计算结果";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Period;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn PrincipalPayment;
        private DataGridViewTextBoxColumn InterestPayment;
    }
}