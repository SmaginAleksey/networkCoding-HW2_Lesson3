namespace ДЗ2_Задача3_Клиент
{
    partial class Client
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
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.radioButtonAI = new System.Windows.Forms.RadioButton();
            this.radioButtonHuman = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMain.Location = new System.Drawing.Point(0, 78);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(508, 224);
            this.textBoxMain.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 52);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(400, 20);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 34);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Connect";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Tomato;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.ForeColor = System.Drawing.Color.Maroon;
            this.buttonStop.Location = new System.Drawing.Point(312, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 34);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Disconnect";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(418, 52);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 20);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // radioButtonAI
            // 
            this.radioButtonAI.AutoSize = true;
            this.radioButtonAI.Location = new System.Drawing.Point(422, 29);
            this.radioButtonAI.Name = "radioButtonAI";
            this.radioButtonAI.Size = new System.Drawing.Size(41, 17);
            this.radioButtonAI.TabIndex = 10;
            this.radioButtonAI.Text = "ИИ";
            this.radioButtonAI.UseVisualStyleBackColor = true;
            this.radioButtonAI.CheckedChanged += new System.EventHandler(this.radioButtonAI_CheckedChanged);
            // 
            // radioButtonHuman
            // 
            this.radioButtonHuman.AutoSize = true;
            this.radioButtonHuman.Checked = true;
            this.radioButtonHuman.Location = new System.Drawing.Point(422, 12);
            this.radioButtonHuman.Name = "radioButtonHuman";
            this.radioButtonHuman.Size = new System.Drawing.Size(69, 17);
            this.radioButtonHuman.TabIndex = 11;
            this.radioButtonHuman.TabStop = true;
            this.radioButtonHuman.Text = "Человек";
            this.radioButtonHuman.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 302);
            this.Controls.Add(this.radioButtonAI);
            this.Controls.Add(this.radioButtonHuman);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RadioButton radioButtonAI;
        private System.Windows.Forms.RadioButton radioButtonHuman;
    }
}

