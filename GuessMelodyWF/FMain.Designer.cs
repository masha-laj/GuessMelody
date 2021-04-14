namespace GuessMelodyWF
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_memo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(77, 116);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(238, 57);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "ИГРАТЬ";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Location = new System.Drawing.Point(77, 179);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(238, 57);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "НАСТРОЙКИ";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(77, 242);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(238, 57);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "ВЫХОД";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_memo
            // 
            this.btn_memo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_memo.Location = new System.Drawing.Point(77, 53);
            this.btn_memo.Name = "btn_memo";
            this.btn_memo.Size = new System.Drawing.Size(238, 57);
            this.btn_memo.TabIndex = 3;
            this.btn_memo.Text = "ПАМЯТКА";
            this.btn_memo.UseVisualStyleBackColor = false;
            this.btn_memo.Click += new System.EventHandler(this.btn_memo_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelodyWF.Properties.Resources._22198976_music_seamless_background;
            this.ClientSize = new System.Drawing.Size(392, 353);
            this.Controls.Add(this.btn_memo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_play);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_memo;
    }
}

