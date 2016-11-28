using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace games
{
    public partial class Form1 : Form
    {
        player player1 = new player();//создаем нового игрока
        player Hikayama = new player();//создаем нового игрока

        public Form1()
        {
            InitializeComponent();

        }

        static string s_status = "start"; //точка старта игры -- тоесть статус игры


        public void button1_Click(object sender, EventArgs e)
        {
            /*Наш игрок*/
            player1.name = "Kagami Taiga"; player1.link_profile = Environment.CurrentDirectory + "/img/players/myteam/kuroko.jpg";
            player1.strength = 14; player1.age = 16;
            player1.info(player1, my_player_name, my_player_age, my_player_strength, my_player_money, my_player_skill); //передаем объект player1 и ссылку на объект label1; вызываем метод player.info()
                                                                                                                        /*Наш игрок*/
            game game_obj = new game();
            if (s_status == "start") game_obj.start_game(button1.Text, button1); //передаем текст кнопки в метод start_game
            label1.Text = webBrowser1.Document.Url.LocalPath;
        }


        class player
        {
            public string name;
            public int age = 17, strength = 12;
            public float money = 5000;
            public int skill = 0;
            public string link_profile = "";


            public void buy(string obj, int buymoney) //покупаем вещи
            {
                if (money > buymoney && obj == "труханы")
                {
                    money -= 300;
                }
            }

            public void info(player playerobj, params Label[] label) // ссылку на object игрока и параметры на object label 
            {
                label[0].Text = string.Format("Имя игрока: {0}", name); // в label1.text присваиваем имя от игрока
                label[1].Text = string.Format("Возраст: {0}", age); // в label2.text присваиваем возраст от игрока
                label[2].Text = string.Format("Сила: {0}", strength); // в label3.text присваиваем strength от игрока
                label[3].Text = string.Format("Деньги: {0}", money); // в label4.text присваиваем деньги от игрока
                label[4].Text = string.Format("Навык: {0}", skill); // в label4.text присваиваем skill от игрока

            }
        }

        class game
        {
            // Form1 form1 = new Form1();

            public void start_game(string s, Button btns)
            {
                if (s == "Далее")
                {
                    (Application.OpenForms[0] as Form1).webBrowser1.Navigate(Environment.CurrentDirectory + "\\dialogs\\start game\\start_game_1.html");
                    btns.Text = "Идти домой";
                }
                if (s == "Идти домой")
                {
                    (Application.OpenForms[0] as Form1).webBrowser1.Navigate(Environment.CurrentDirectory + "\\dialogs\\home\\home.html");
                    (Application.OpenForms[0] as Form1).button1.Visible = false;
                    (Application.OpenForms[0] as Form1).btn_home.Visible = true;
                    (Application.OpenForms[0] as Form1).btn_home_bath.Visible = true;
                    (Application.OpenForms[0] as Form1).btn_home_kitchen.Visible = true;
                    (Application.OpenForms[0] as Form1).btn_home_out.Visible = true;
                }

                if (s == "Начать новую игру")
                {
                    (Application.OpenForms[0] as Form1).webBrowser1.Navigate(Environment.CurrentDirectory + "\\dialogs\\start game\\start_game.html");
                    btns.Text = "Далее";
                }
            }

            public void kitchen() //кухня
            {

                (Application.OpenForms[0] as Form1).webBrowser1.Navigate(Environment.CurrentDirectory + "\\dialogs\\home\\kitchen\\kitchen.html");
                (Application.OpenForms[0] as Form1).btn_home.Visible = true;
                (Application.OpenForms[0] as Form1).btn_home_bath.Visible = false;
                (Application.OpenForms[0] as Form1).btn_home_kitchen.Visible = false;
                (Application.OpenForms[0] as Form1).btn_home_out.Visible = false;
            }
        }

        public void btn_home_kitchen_Click(object sender, EventArgs e)
        {
            game Kitchen = new game();
            Kitchen.kitchen();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            (Application.OpenForms[0] as Form1).webBrowser1.Navigate(Environment.CurrentDirectory + "\\dialogs\\home\\home.html");
            (Application.OpenForms[0] as Form1).btn_home.Visible = true;
            (Application.OpenForms[0] as Form1).btn_home_bath.Visible = true;
            (Application.OpenForms[0] as Form1).btn_home_kitchen.Visible = true;
            (Application.OpenForms[0] as Form1).btn_home_out.Visible = true;
        }
    }
}
