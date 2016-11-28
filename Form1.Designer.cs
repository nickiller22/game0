namespace games
{
    public partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.my_player_skill = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.my_player_name = new System.Windows.Forms.Label();
            this.my_player_money = new System.Windows.Forms.Label();
            this.my_player_age = new System.Windows.Forms.Label();
            this.my_player_strength = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_home_out = new System.Windows.Forms.Button();
            this.btn_home_bath = new System.Windows.Forms.Button();
            this.btn_home_kitchen = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать новую игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.my_player_skill);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.my_player_name);
            this.panel1.Controls.Add(this.my_player_money);
            this.panel1.Controls.Add(this.my_player_age);
            this.panel1.Controls.Add(this.my_player_strength);
            this.panel1.Location = new System.Drawing.Point(952, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 307);
            this.panel1.TabIndex = 5;
            // 
            // my_player_skill
            // 
            this.my_player_skill.AutoSize = true;
            this.my_player_skill.Location = new System.Drawing.Point(3, 119);
            this.my_player_skill.Name = "my_player_skill";
            this.my_player_skill.Size = new System.Drawing.Size(41, 13);
            this.my_player_skill.TabIndex = 10;
            this.my_player_skill.Text = "Навык";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::games.Properties.Resources._3c5165ccece6a484db859527e191becb;
            this.pictureBox1.Location = new System.Drawing.Point(6, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // my_player_name
            // 
            this.my_player_name.AutoSize = true;
            this.my_player_name.Location = new System.Drawing.Point(3, 7);
            this.my_player_name.Name = "my_player_name";
            this.my_player_name.Size = new System.Drawing.Size(67, 13);
            this.my_player_name.TabIndex = 5;
            this.my_player_name.Text = "Имя игрока";
            // 
            // my_player_money
            // 
            this.my_player_money.AutoSize = true;
            this.my_player_money.Location = new System.Drawing.Point(3, 93);
            this.my_player_money.Name = "my_player_money";
            this.my_player_money.Size = new System.Drawing.Size(45, 13);
            this.my_player_money.TabIndex = 8;
            this.my_player_money.Text = "Деньги";
            // 
            // my_player_age
            // 
            this.my_player_age.AutoSize = true;
            this.my_player_age.Location = new System.Drawing.Point(3, 35);
            this.my_player_age.Name = "my_player_age";
            this.my_player_age.Size = new System.Drawing.Size(49, 13);
            this.my_player_age.TabIndex = 6;
            this.my_player_age.Text = "Возраст";
            // 
            // my_player_strength
            // 
            this.my_player_strength.AutoSize = true;
            this.my_player_strength.Location = new System.Drawing.Point(3, 65);
            this.my_player_strength.Name = "my_player_strength";
            this.my_player_strength.Size = new System.Drawing.Size(32, 13);
            this.my_player_strength.TabIndex = 7;
            this.my_player_strength.Text = "Сила";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_home_out);
            this.panel2.Controls.Add(this.btn_home_bath);
            this.panel2.Controls.Add(this.btn_home_kitchen);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 97);
            this.panel2.TabIndex = 10;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(3, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(155, 23);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Дом";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Visible = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_home_out
            // 
            this.btn_home_out.Location = new System.Drawing.Point(3, 71);
            this.btn_home_out.Name = "btn_home_out";
            this.btn_home_out.Size = new System.Drawing.Size(155, 23);
            this.btn_home_out.TabIndex = 3;
            this.btn_home_out.Text = "Выйти на улицу";
            this.btn_home_out.UseVisualStyleBackColor = true;
            this.btn_home_out.Visible = false;
            // 
            // btn_home_bath
            // 
            this.btn_home_bath.Location = new System.Drawing.Point(3, 48);
            this.btn_home_bath.Name = "btn_home_bath";
            this.btn_home_bath.Size = new System.Drawing.Size(155, 23);
            this.btn_home_bath.TabIndex = 2;
            this.btn_home_bath.Text = "В ванную";
            this.btn_home_bath.UseVisualStyleBackColor = true;
            this.btn_home_bath.Visible = false;
            // 
            // btn_home_kitchen
            // 
            this.btn_home_kitchen.Location = new System.Drawing.Point(3, 25);
            this.btn_home_kitchen.Name = "btn_home_kitchen";
            this.btn_home_kitchen.Size = new System.Drawing.Size(155, 23);
            this.btn_home_kitchen.TabIndex = 1;
            this.btn_home_kitchen.Text = "На кухню";
            this.btn_home_kitchen.UseVisualStyleBackColor = true;
            this.btn_home_kitchen.Visible = false;
            this.btn_home_kitchen.Click += new System.EventHandler(this.btn_home_kitchen_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(170, 37);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 671);
            this.webBrowser1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label my_player_name;
        private System.Windows.Forms.Label my_player_money;
        private System.Windows.Forms.Label my_player_age;
        private System.Windows.Forms.Label my_player_strength;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label my_player_skill;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_home_out;
        public System.Windows.Forms.Button btn_home_bath;
        public System.Windows.Forms.Button btn_home_kitchen;
        public System.Windows.Forms.Button btn_home;
    }
}

