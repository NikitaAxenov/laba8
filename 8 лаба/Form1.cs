using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_лаба
{
    public partial class Form1 : Form
    {
        const double b = 4294967299;
        const double m = 9223372036854775808;
        double xNext = b;
        double xBefore, xNow;
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 20; i++)
            {
                xBefore = xNext;
                xNext = (b * xBefore) % m;
                xNow = xNext / m;
            }
        }

        private void predictionBtn_Click(object sender, EventArgs e)
        {
            xBefore = xNext;
            xNext = (b * xBefore) % m;
            xNow = xNext / m;
            if (xNow < 0.05)
                predictionLabel.Text = "Бесспорно";
            else if (xNow >= 0.05 && xNow < 0.1)
                predictionLabel.Text = "Предрешено";
            else if (xNow >= 0.1 && xNow < 0.15)
                predictionLabel.Text = "Никаких сомнений";
            else if (xNow >= 0.15 && xNow < 0.2)
                predictionLabel.Text = "Определённо да";
            else if (xNow >= 0.2 && xNow < 0.25)
                predictionLabel.Text = "Можешь быть уверен в этом";
            else if (xNow >= 0.25 && xNow < 0.3)
                predictionLabel.Text = "Мне кажется — «да»";
            else if (xNow >= 0.3 && xNow < 0.35)
                predictionLabel.Text = "Вероятнее всего";
            else if (xNow >= 0.35 && xNow < 0.4)
                predictionLabel.Text = "Хорошие перспективы";
            else if (xNow >= 0.4 && xNow < 0.45)
                predictionLabel.Text = "Знаки говорят — «да»";
            else if (xNow >= 0.45 && xNow < 0.5)
                predictionLabel.Text = "Да";
            else if (xNow >= 0.5 && xNow < 0.55)
                predictionLabel.Text = "Пока не ясно, попробуй снова";
            else if (xNow >= 0.55 && xNow < 0.6)
                predictionLabel.Text = "Спроси позже";
            else if (xNow >= 0.6 && xNow < 0.65)
                predictionLabel.Text = "Лучше не рассказывать";
            else if (xNow >= 0.65 && xNow < 0.7)
                predictionLabel.Text = "Сейчас нельзя предсказать";
            else if (xNow >= 0.7 && xNow < 0.75)
                predictionLabel.Text = "Сконцентрируйся и спроси опять";
            else if (xNow >= 0.75 && xNow < 0.8)
                predictionLabel.Text = "Даже не думай";
            else if (xNow >= 0.8 && xNow < 0.85)
                predictionLabel.Text = "Мой ответ — «нет»";
            else if (xNow >= 0.85 && xNow < 0.9)
                predictionLabel.Text = "По моим данным — «нет»";
            else if (xNow >= 0.9 && xNow < 0.95)
                predictionLabel.Text = "Перспективы не очень хорошие";
            else if (xNow >= 0.95 && xNow < 1)
                predictionLabel.Text = "Весьма сомнительно";
        }

        private void yesOrNoBtn_Click(object sender, EventArgs e)
        {
            xBefore = xNext;
            xNext = (b * xBefore) % m;
            xNow = xNext / m;
            if (xNow < 0.5)
                yesOrNoLabel.Text = "Нет";
            else
                yesOrNoLabel.Text = "Да";
        }
    }
}
