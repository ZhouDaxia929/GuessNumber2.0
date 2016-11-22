namespace GuessNumber2._0 {
    partial class PlayerToPC {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb22 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(168, 84);
            this.tb1.Margin = new System.Windows.Forms.Padding(5);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(164, 29);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(617, 84);
            this.tb2.Margin = new System.Windows.Forms.Padding(5);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(164, 29);
            this.tb2.TabIndex = 1;
            // 
            // tb11
            // 
            this.tb11.HideSelection = false;
            this.tb11.Location = new System.Drawing.Point(80, 173);
            this.tb11.Margin = new System.Windows.Forms.Padding(5);
            this.tb11.Multiline = true;
            this.tb11.Name = "tb11";
            this.tb11.ReadOnly = true;
            this.tb11.Size = new System.Drawing.Size(271, 210);
            this.tb11.TabIndex = 2;
            // 
            // tb22
            // 
            this.tb22.Location = new System.Drawing.Point(453, 173);
            this.tb22.Margin = new System.Windows.Forms.Padding(5);
            this.tb22.Multiline = true;
            this.tb22.Name = "tb22";
            this.tb22.ReadOnly = true;
            this.tb22.Size = new System.Drawing.Size(271, 210);
            this.tb22.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "玩家输入本次猜测：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "PC生成本次猜测：";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(359, 128);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 32);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "提交";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(196, 22);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(172, 32);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "显示随机生成的数字";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(391, 28);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(250, 21);
            this.lb3.TabIndex = 8;
            this.lb3.Text = "只有实在想不出来可以点击啊！！";
            // 
            // PlayerToPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 457);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb22);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlayerToPC";
            this.Text = "PlayerToPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label lb3;
    }
}