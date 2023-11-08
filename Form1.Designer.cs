namespace Lab3_Sophie_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.nudB2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudA2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnCalculation2 = new System.Windows.Forms.Button();
            this.lbResult2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(332, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCalculation);
            this.tabPage1.Controls.Add(this.nudC);
            this.tabPage1.Controls.Add(this.lbResult);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudA);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(324, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCalculation2);
            this.tabPage2.Controls.Add(this.lbResult2);
            this.tabPage2.Controls.Add(this.nudB2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nudA2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(324, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number A:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(176, 22);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(120, 26);
            this.nudA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number B:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(176, 69);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 26);
            this.nudB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number C:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudC
            // 
            this.nudC.Location = new System.Drawing.Point(176, 117);
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(120, 26);
            this.nudC.TabIndex = 1;
            // 
            // nudB2
            // 
            this.nudB2.Location = new System.Drawing.Point(174, 103);
            this.nudB2.Name = "nudB2";
            this.nudB2.Size = new System.Drawing.Size(120, 26);
            this.nudB2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number B:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudA2
            // 
            this.nudA2.Location = new System.Drawing.Point(174, 56);
            this.nudA2.Name = "nudA2";
            this.nudA2.Size = new System.Drawing.Size(120, 26);
            this.nudA2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number A:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(93, 326);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(136, 28);
            this.btnCalculation.TabIndex = 2;
            this.btnCalculation.Text = "Розрахувати";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Location = new System.Drawing.Point(3, 270);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(315, 25);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Результат:";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculation2
            // 
            this.btnCalculation2.Location = new System.Drawing.Point(93, 326);
            this.btnCalculation2.Name = "btnCalculation2";
            this.btnCalculation2.Size = new System.Drawing.Size(136, 28);
            this.btnCalculation2.TabIndex = 7;
            this.btnCalculation2.Text = "Розрахувати";
            this.btnCalculation2.UseVisualStyleBackColor = true;
            this.btnCalculation2.Click += new System.EventHandler(this.btnCalculation2_Click);
            // 
            // lbResult2
            // 
            this.lbResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult2.Location = new System.Drawing.Point(3, 270);
            this.lbResult2.Name = "lbResult2";
            this.lbResult2.Size = new System.Drawing.Size(315, 25);
            this.lbResult2.TabIndex = 6;
            this.lbResult2.Text = "Результат:";
            this.lbResult2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(22, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(315, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 444);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalculation2;
        private System.Windows.Forms.Label lbResult2;
        private System.Windows.Forms.NumericUpDown nudB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudA2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }
}

