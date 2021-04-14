
namespace GuessMelodyWF
{
    partial class FMessage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMessage));
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_message.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.lbl_message.Location = new System.Drawing.Point(60, 9);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(109, 33);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Игрок 0";
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yes.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_yes.Location = new System.Drawing.Point(12, 45);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(110, 35);
            this.btn_yes.TabIndex = 8;
            this.btn_yes.Text = "Да";
            this.btn_yes.UseVisualStyleBackColor = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.Color.Salmon;
            this.btn_no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_no.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_no.Location = new System.Drawing.Point(128, 45);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(110, 35);
            this.btn_no.TabIndex = 9;
            this.btn_no.Text = "Нет";
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_timer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.Location = new System.Drawing.Point(175, 9);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(30, 33);
            this.lbl_timer.TabIndex = 13;
            this.lbl_timer.Text = "0";
            // 
            // lbl_answer
            // 
            this.lbl_answer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_answer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_answer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_answer.Location = new System.Drawing.Point(0, 83);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(246, 53);
            this.lbl_answer.TabIndex = 14;
            this.lbl_answer.Text = "Показать ответ";
            this.lbl_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_answer.Click += new System.EventHandler(this.lbl_answer_Click);
            // 
            // FMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelodyWF.Properties.Resources._22198976_music_seamless_background;
            this.ClientSize = new System.Drawing.Size(246, 136);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbl_message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сообщение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMessage_FormClosed);
            this.Load += new System.EventHandler(this.FMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        public System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
        public System.Windows.Forms.Label lbl_answer;
    }
}