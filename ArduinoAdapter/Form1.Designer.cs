namespace ArduinoAdapter
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_doConnect = new System.Windows.Forms.Button();
            this.lbl_select_port = new System.Windows.Forms.Label();
            this.txt_PortNumber = new System.Windows.Forms.TextBox();
            this.arduinoSerialInterface = new System.IO.Ports.SerialPort(this.components);
            this.txt_command = new System.Windows.Forms.TextBox();
            this.btn_sendCommand = new System.Windows.Forms.Button();
            this.tmr_arduino_reader = new System.Windows.Forms.Timer(this.components);
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_doDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_doConnect
            // 
            this.btn_doConnect.Location = new System.Drawing.Point(211, 4);
            this.btn_doConnect.Name = "btn_doConnect";
            this.btn_doConnect.Size = new System.Drawing.Size(109, 23);
            this.btn_doConnect.TabIndex = 0;
            this.btn_doConnect.Text = "Подключение";
            this.btn_doConnect.UseVisualStyleBackColor = true;
            this.btn_doConnect.Click += new System.EventHandler(this.btn_doConnect_Click);
            // 
            // lbl_select_port
            // 
            this.lbl_select_port.AutoSize = true;
            this.lbl_select_port.Location = new System.Drawing.Point(12, 9);
            this.lbl_select_port.Name = "lbl_select_port";
            this.lbl_select_port.Size = new System.Drawing.Size(86, 13);
            this.lbl_select_port.TabIndex = 1;
            this.lbl_select_port.Text = "Выберите порт:";
            // 
            // txt_PortNumber
            // 
            this.txt_PortNumber.Location = new System.Drawing.Point(105, 6);
            this.txt_PortNumber.Name = "txt_PortNumber";
            this.txt_PortNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_PortNumber.TabIndex = 2;
            this.txt_PortNumber.Text = "COM4";
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(12, 32);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(562, 20);
            this.txt_command.TabIndex = 3;
            // 
            // btn_sendCommand
            // 
            this.btn_sendCommand.Location = new System.Drawing.Point(580, 30);
            this.btn_sendCommand.Name = "btn_sendCommand";
            this.btn_sendCommand.Size = new System.Drawing.Size(75, 23);
            this.btn_sendCommand.TabIndex = 4;
            this.btn_sendCommand.Text = "Отправить";
            this.btn_sendCommand.UseVisualStyleBackColor = true;
            this.btn_sendCommand.Click += new System.EventHandler(this.btn_sendCommand_Click);
            // 
            // tmr_arduino_reader
            // 
            this.tmr_arduino_reader.Enabled = true;
            this.tmr_arduino_reader.Interval = 500;
            this.tmr_arduino_reader.Tick += new System.EventHandler(this.tmr_arduino_reader_Tick);
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(12, 59);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.Size = new System.Drawing.Size(634, 218);
            this.txt_log.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(612, 268);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(28, 18);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_doDisconnect
            // 
            this.btn_doDisconnect.Enabled = false;
            this.btn_doDisconnect.Location = new System.Drawing.Point(327, 4);
            this.btn_doDisconnect.Name = "btn_doDisconnect";
            this.btn_doDisconnect.Size = new System.Drawing.Size(93, 23);
            this.btn_doDisconnect.TabIndex = 7;
            this.btn_doDisconnect.Text = "Отключение";
            this.btn_doDisconnect.UseVisualStyleBackColor = true;
            this.btn_doDisconnect.Click += new System.EventHandler(this.btn_doDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 289);
            this.Controls.Add(this.btn_doDisconnect);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.btn_sendCommand);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.txt_PortNumber);
            this.Controls.Add(this.lbl_select_port);
            this.Controls.Add(this.btn_doConnect);
            this.Name = "Form1";
            this.Text = "Arduino Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doConnect;
        private System.Windows.Forms.Label lbl_select_port;
        private System.Windows.Forms.TextBox txt_PortNumber;
        private System.IO.Ports.SerialPort arduinoSerialInterface;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.Button btn_sendCommand;
        private System.Windows.Forms.Timer tmr_arduino_reader;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_doDisconnect;
    }
}

