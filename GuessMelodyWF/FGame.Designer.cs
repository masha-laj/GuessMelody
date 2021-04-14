namespace GuessMelodyWF
{
    partial class FGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.btn_next = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_counter1 = new System.Windows.Forms.Label();
            this.lbl_counter2 = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_contin = new System.Windows.Forms.Button();
            this.lbl_song_count = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mus_dur = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next.Location = new System.Drawing.Point(12, 173);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(167, 44);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Следующая песня";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(490, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(36, 32);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Игрок 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(374, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Игрок 2:";
            // 
            // lbl_counter1
            // 
            this.lbl_counter1.AutoSize = true;
            this.lbl_counter1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_counter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_counter1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_counter1.Location = new System.Drawing.Point(134, 76);
            this.lbl_counter1.Name = "lbl_counter1";
            this.lbl_counter1.Size = new System.Drawing.Size(30, 33);
            this.lbl_counter1.TabIndex = 5;
            this.lbl_counter1.Text = "0";
            this.lbl_counter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_counter1_MouseClick);
            // 
            // lbl_counter2
            // 
            this.lbl_counter2.AutoSize = true;
            this.lbl_counter2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_counter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_counter2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_counter2.Location = new System.Drawing.Point(496, 76);
            this.lbl_counter2.Name = "lbl_counter2";
            this.lbl_counter2.Size = new System.Drawing.Size(30, 33);
            this.lbl_counter2.TabIndex = 6;
            this.lbl_counter2.Text = "0";
            this.lbl_counter2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_counter1_MouseClick);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pause.Location = new System.Drawing.Point(185, 173);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(167, 44);
            this.btn_pause.TabIndex = 7;
            this.btn_pause.Text = "Пауза";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_contin
            // 
            this.btn_contin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_contin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_contin.Location = new System.Drawing.Point(358, 173);
            this.btn_contin.Name = "btn_contin";
            this.btn_contin.Size = new System.Drawing.Size(167, 44);
            this.btn_contin.TabIndex = 8;
            this.btn_contin.Text = "Продолжить";
            this.btn_contin.UseVisualStyleBackColor = false;
            this.btn_contin.Click += new System.EventHandler(this.btn_contin_Click);
            // 
            // lbl_song_count
            // 
            this.lbl_song_count.AutoSize = true;
            this.lbl_song_count.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_song_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_song_count.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_song_count.Location = new System.Drawing.Point(374, 9);
            this.lbl_song_count.Name = "lbl_song_count";
            this.lbl_song_count.Size = new System.Drawing.Size(30, 33);
            this.lbl_song_count.TabIndex = 9;
            this.lbl_song_count.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(476, 34);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(167, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Осталось песен:";
            // 
            // lbl_mus_dur
            // 
            this.lbl_mus_dur.AutoSize = true;
            this.lbl_mus_dur.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_mus_dur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_mus_dur.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_mus_dur.Location = new System.Drawing.Point(496, 124);
            this.lbl_mus_dur.Name = "lbl_mus_dur";
            this.lbl_mus_dur.Size = new System.Drawing.Size(30, 33);
            this.lbl_mus_dur.TabIndex = 12;
            this.lbl_mus_dur.Text = "0";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Image = global::GuessMelodyWF.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.Location = new System.Drawing.Point(13, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(41, 33);
            this.btn_back.TabIndex = 13;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelodyWF.Properties.Resources._22198976_music_seamless_background;
            this.ClientSize = new System.Drawing.Size(538, 230);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_mus_dur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_song_count);
            this.Controls.Add(this.btn_contin);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.lbl_counter2);
            this.Controls.Add(this.lbl_counter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_next);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Угадай мелодию";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGame_FormClosed);
            this.Load += new System.EventHandler(this.FGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_counter1;
        private System.Windows.Forms.Label lbl_counter2;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_contin;
        private System.Windows.Forms.Label lbl_song_count;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mus_dur;
        private System.Windows.Forms.Button btn_back;
    }
}