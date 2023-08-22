namespace ДЗ2_Задача3_Сервер
{
    partial class Server
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.radioButtonHuman = new System.Windows.Forms.RadioButton();
            this.radioButtonAI = new System.Windows.Forms.RadioButton();
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
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(400, 20);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(418, 52);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 20);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Tomato;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.ForeColor = System.Drawing.Color.Maroon;
            this.buttonStop.Location = new System.Drawing.Point(312, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 34);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
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
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // radioButtonHuman
            // 
            this.radioButtonHuman.AutoSize = true;
            this.radioButtonHuman.Checked = true;
            this.radioButtonHuman.Location = new System.Drawing.Point(423, 12);
            this.radioButtonHuman.Name = "radioButtonHuman";
            this.radioButtonHuman.Size = new System.Drawing.Size(69, 17);
            this.radioButtonHuman.TabIndex = 9;
            this.radioButtonHuman.TabStop = true;
            this.radioButtonHuman.Text = "Человек";
            this.radioButtonHuman.UseVisualStyleBackColor = true;
            // 
            // radioButtonAI
            // 
            this.radioButtonAI.AutoSize = true;
            this.radioButtonAI.Location = new System.Drawing.Point(423, 29);
            this.radioButtonAI.Name = "radioButtonAI";
            this.radioButtonAI.Size = new System.Drawing.Size(41, 17);
            this.radioButtonAI.TabIndex = 9;
            this.radioButtonAI.Text = "ИИ";
            this.radioButtonAI.UseVisualStyleBackColor = true;
            this.radioButtonAI.CheckedChanged += new System.EventHandler(this.radioButtonAI_CheckedChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 302);
            this.Controls.Add(this.radioButtonAI);
            this.Controls.Add(this.radioButtonHuman);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RadioButton radioButtonHuman;
        private System.Windows.Forms.RadioButton radioButtonAI;
    }
}

