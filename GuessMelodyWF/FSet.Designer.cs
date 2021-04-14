namespace GuessMelodyWF
{
    partial class FSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSet));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_alldirectories = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_player1 = new System.Windows.Forms.ComboBox();
            this.cb_player2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_randomstart = new System.Windows.Forms.CheckBox();
            this.cb_musicduration = new System.Windows.Forms.ComboBox();
            this.cb_gameduration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 225);
            this.listBox1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(3, 234);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 31);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_delete.Location = new System.Drawing.Point(96, 234);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(87, 31);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_alldirectories
            // 
            this.cb_alldirectories.AutoSize = true;
            this.cb_alldirectories.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_alldirectories.Location = new System.Drawing.Point(196, 234);
            this.cb_alldirectories.Name = "cb_alldirectories";
            this.cb_alldirectories.Size = new System.Drawing.Size(193, 19);
            this.cb_alldirectories.TabIndex = 3;
            this.cb_alldirectories.Text = "Обработать вложенные папки";
            this.cb_alldirectories.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.Location = new System.Drawing.Point(293, 323);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 31);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Отменить";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ok.Location = new System.Drawing.Point(293, 286);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 31);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "ОК";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.cb_player1);
            this.groupBox1.Controls.Add(this.cb_player2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_randomstart);
            this.groupBox1.Controls.Add(this.cb_musicduration);
            this.groupBox1.Controls.Add(this.cb_gameduration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // cb_player1
            // 
            this.cb_player1.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.cb_player1.FormattingEnabled = true;
            this.cb_player1.Items.AddRange(new object[] {
            "Q",
            "W",
            "E",
            "R"});
            this.cb_player1.Location = new System.Drawing.Point(222, 19);
            this.cb_player1.Name = "cb_player1";
            this.cb_player1.Size = new System.Drawing.Size(48, 22);
            this.cb_player1.TabIndex = 8;
            this.cb_player1.Text = "Q";
            // 
            // cb_player2
            // 
            this.cb_player2.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.cb_player2.FormattingEnabled = true;
            this.cb_player2.Items.AddRange(new object[] {
            "P",
            "O",
            "I",
            "U"});
            this.cb_player2.Location = new System.Drawing.Point(222, 43);
            this.cb_player2.Name = "cb_player2";
            this.cb_player2.Size = new System.Drawing.Size(48, 22);
            this.cb_player2.TabIndex = 7;
            this.cb_player2.Text = "P";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(171, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Игрок 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Игрок 1";
            // 
            // cb_randomstart
            // 
            this.cb_randomstart.AutoSize = true;
            this.cb_randomstart.BackColor = System.Drawing.Color.AliceBlue;
            this.cb_randomstart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_randomstart.Location = new System.Drawing.Point(9, 71);
            this.cb_randomstart.Name = "cb_randomstart";
            this.cb_randomstart.Size = new System.Drawing.Size(144, 19);
            this.cb_randomstart.TabIndex = 4;
            this.cb_randomstart.Text = "Со случайного места";
            this.cb_randomstart.UseVisualStyleBackColor = false;
            // 
            // cb_musicduration
            // 
            this.cb_musicduration.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_musicduration.FormattingEnabled = true;
            this.cb_musicduration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cb_musicduration.Location = new System.Drawing.Point(117, 43);
            this.cb_musicduration.Name = "cb_musicduration";
            this.cb_musicduration.Size = new System.Drawing.Size(48, 22);
            this.cb_musicduration.TabIndex = 3;
            this.cb_musicduration.Text = "20";
            // 
            // cb_gameduration
            // 
            this.cb_gameduration.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_gameduration.FormattingEnabled = true;
            this.cb_gameduration.Items.AddRange(new object[] {
            "15",
            "30",
            "60",
            "120",
            "180"});
            this.cb_gameduration.Location = new System.Drawing.Point(117, 20);
            this.cb_gameduration.Name = "cb_gameduration";
            this.cb_gameduration.Size = new System.Drawing.Size(48, 22);
            this.cb_gameduration.TabIndex = 2;
            this.cb_gameduration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длительность игры";
            // 
            // FSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(392, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cb_alldirectories);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox cb_alldirectories;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_randomstart;
        private System.Windows.Forms.ComboBox cb_musicduration;
        private System.Windows.Forms.ComboBox cb_gameduration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_player1;
        private System.Windows.Forms.ComboBox cb_player2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}