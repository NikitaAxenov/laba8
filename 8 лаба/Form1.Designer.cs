namespace _8_лаба
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
            this.yesOrNoLabel = new System.Windows.Forms.Label();
            this.predictionLabel = new System.Windows.Forms.Label();
            this.yesOrNoBtn = new System.Windows.Forms.Button();
            this.predictionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesOrNoLabel
            // 
            this.yesOrNoLabel.AutoSize = true;
            this.yesOrNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yesOrNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesOrNoLabel.Location = new System.Drawing.Point(350, 31);
            this.yesOrNoLabel.Name = "yesOrNoLabel";
            this.yesOrNoLabel.Size = new System.Drawing.Size(88, 31);
            this.yesOrNoLabel.TabIndex = 0;
            this.yesOrNoLabel.Text = "Ответ";
            this.yesOrNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // predictionLabel
            // 
            this.predictionLabel.AutoSize = true;
            this.predictionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.predictionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predictionLabel.Location = new System.Drawing.Point(350, 164);
            this.predictionLabel.Name = "predictionLabel";
            this.predictionLabel.Size = new System.Drawing.Size(88, 31);
            this.predictionLabel.TabIndex = 1;
            this.predictionLabel.Text = "Ответ";
            this.predictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesOrNoBtn
            // 
            this.yesOrNoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yesOrNoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesOrNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesOrNoBtn.Location = new System.Drawing.Point(25, 23);
            this.yesOrNoBtn.Name = "yesOrNoBtn";
            this.yesOrNoBtn.Size = new System.Drawing.Size(250, 45);
            this.yesOrNoBtn.TabIndex = 2;
            this.yesOrNoBtn.Text = "Да или Нет";
            this.yesOrNoBtn.UseVisualStyleBackColor = false;
            this.yesOrNoBtn.Click += new System.EventHandler(this.yesOrNoBtn_Click);
            // 
            // predictionBtn
            // 
            this.predictionBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.predictionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.predictionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predictionBtn.Location = new System.Drawing.Point(25, 156);
            this.predictionBtn.Name = "predictionBtn";
            this.predictionBtn.Size = new System.Drawing.Size(288, 45);
            this.predictionBtn.TabIndex = 3;
            this.predictionBtn.Text = "Предсказание";
            this.predictionBtn.UseVisualStyleBackColor = false;
            this.predictionBtn.Click += new System.EventHandler(this.predictionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 450);
            this.Controls.Add(this.predictionBtn);
            this.Controls.Add(this.yesOrNoBtn);
            this.Controls.Add(this.predictionLabel);
            this.Controls.Add(this.yesOrNoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yesOrNoLabel;
        private System.Windows.Forms.Label predictionLabel;
        private System.Windows.Forms.Button yesOrNoBtn;
        private System.Windows.Forms.Button predictionBtn;
    }
}

