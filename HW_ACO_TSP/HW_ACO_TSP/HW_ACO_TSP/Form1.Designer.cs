namespace HW_ACO_TSP
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecay = new System.Windows.Forms.TextBox();
            this.nAnt = new System.Windows.Forms.Label();
            this.txtnAnt = new System.Windows.Forms.TextBox();
            this.txtPheromone_Evaporation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult_Best_Cost = new System.Windows.Forms.TextBox();
            this.txtResult_Best = new System.Windows.Forms.TextBox();
            this.LoadData_Button = new System.Windows.Forms.Button();
            this.Run_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.Location = new System.Drawing.Point(26, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Beta";
            // 
            // txtBeta
            // 
            this.txtBeta.Font = new System.Drawing.Font("굴림", 15F);
            this.txtBeta.Location = new System.Drawing.Point(258, 103);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(263, 30);
            this.txtBeta.TabIndex = 38;
            this.txtBeta.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.Location = new System.Drawing.Point(26, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Pheromone_Evaporation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(26, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Alpha";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Font = new System.Drawing.Font("굴림", 15F);
            this.txtAlpha.Location = new System.Drawing.Point(258, 67);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(263, 30);
            this.txtAlpha.TabIndex = 35;
            this.txtAlpha.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(26, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Decay";
            // 
            // txtDecay
            // 
            this.txtDecay.Font = new System.Drawing.Font("굴림", 15F);
            this.txtDecay.Location = new System.Drawing.Point(258, 179);
            this.txtDecay.Name = "txtDecay";
            this.txtDecay.Size = new System.Drawing.Size(263, 30);
            this.txtDecay.TabIndex = 31;
            this.txtDecay.Text = "0.05";
            // 
            // nAnt
            // 
            this.nAnt.AutoSize = true;
            this.nAnt.Font = new System.Drawing.Font("굴림", 15F);
            this.nAnt.Location = new System.Drawing.Point(26, 34);
            this.nAnt.Name = "nAnt";
            this.nAnt.Size = new System.Drawing.Size(47, 20);
            this.nAnt.TabIndex = 28;
            this.nAnt.Text = "nAnt";
            // 
            // txtnAnt
            // 
            this.txtnAnt.Font = new System.Drawing.Font("굴림", 15F);
            this.txtnAnt.Location = new System.Drawing.Point(258, 31);
            this.txtnAnt.Name = "txtnAnt";
            this.txtnAnt.Size = new System.Drawing.Size(263, 30);
            this.txtnAnt.TabIndex = 29;
            this.txtnAnt.Text = "10000";
            // 
            // txtPheromone_Evaporation
            // 
            this.txtPheromone_Evaporation.Font = new System.Drawing.Font("굴림", 15F);
            this.txtPheromone_Evaporation.Location = new System.Drawing.Point(258, 215);
            this.txtPheromone_Evaporation.Name = "txtPheromone_Evaporation";
            this.txtPheromone_Evaporation.Size = new System.Drawing.Size(263, 30);
            this.txtPheromone_Evaporation.TabIndex = 39;
            this.txtPheromone_Evaporation.Text = "0.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(548, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "BestSolution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F);
            this.label5.Location = new System.Drawing.Point(719, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cost";
            // 
            // txtResult_Best_Cost
            // 
            this.txtResult_Best_Cost.Font = new System.Drawing.Font("굴림", 15F);
            this.txtResult_Best_Cost.Location = new System.Drawing.Point(831, 101);
            this.txtResult_Best_Cost.Name = "txtResult_Best_Cost";
            this.txtResult_Best_Cost.Size = new System.Drawing.Size(109, 30);
            this.txtResult_Best_Cost.TabIndex = 41;
            // 
            // txtResult_Best
            // 
            this.txtResult_Best.Font = new System.Drawing.Font("굴림", 15F);
            this.txtResult_Best.Location = new System.Drawing.Point(698, 34);
            this.txtResult_Best.Name = "txtResult_Best";
            this.txtResult_Best.Size = new System.Drawing.Size(489, 30);
            this.txtResult_Best.TabIndex = 40;
            // 
            // LoadData_Button
            // 
            this.LoadData_Button.Location = new System.Drawing.Point(65, 304);
            this.LoadData_Button.Name = "LoadData_Button";
            this.LoadData_Button.Size = new System.Drawing.Size(216, 59);
            this.LoadData_Button.TabIndex = 44;
            this.LoadData_Button.Text = "LoadData";
            this.LoadData_Button.UseVisualStyleBackColor = true;
            this.LoadData_Button.Click += new System.EventHandler(this.LoadData_Button_Click);
            // 
            // Run_Button
            // 
            this.Run_Button.Enabled = false;
            this.Run_Button.Location = new System.Drawing.Point(406, 304);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(216, 59);
            this.Run_Button.TabIndex = 45;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.Run_Button);
            this.Controls.Add(this.LoadData_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult_Best_Cost);
            this.Controls.Add(this.txtResult_Best);
            this.Controls.Add(this.txtPheromone_Evaporation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDecay);
            this.Controls.Add(this.nAnt);
            this.Controls.Add(this.txtnAnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecay;
        private System.Windows.Forms.Label nAnt;
        private System.Windows.Forms.TextBox txtnAnt;
        private System.Windows.Forms.TextBox txtPheromone_Evaporation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult_Best_Cost;
        private System.Windows.Forms.TextBox txtResult_Best;
        private System.Windows.Forms.Button LoadData_Button;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

