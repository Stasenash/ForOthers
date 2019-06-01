using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitedMessagesStack
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private string[] str = new[] { "Разучивает с бродячим менестрелем песню",
                                        "Так интенсивно бился в конвульсиях от прилетевшей молнии, что изрядно поколотил монстра",
                                        "Наспор залез в берлогу к медведю",
                                        "Косит дрынь-траву",
                                        "Полетал на ковре",
                                        "Проснулся возле затухающего костра",
                                        "Разливает эль феям",
                                        "Строит храм богу нашему Сёмге в стакане"};
        private Queue<string> messages = new Queue<string>();
        private Stack<string> reversMessages = new Stack<string>();
        private int limit = 10;

        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbMessages.Clear();
            AddEvent();
        }

        private void AddEvent()
        {
            AddToQueue(GetEvent());
            foreach (var m in messages)
                reversMessages.Push(m);
            foreach (var m in reversMessages)
                tbMessages.Text += m + Environment.NewLine;
            reversMessages.Clear();   
        }

        private string GetEvent()
        {
            var timeNow = DateTime.Now.ToShortTimeString();
            return ">"+timeNow + " - " + str[rnd.Next(0, str.Length)];
        }

        private void AddToQueue(string message)
        {
            messages.Enqueue(message);
            RemoveOferflow();
        }

        private void RemoveOferflow()
        {
            if (messages.Count > limit)
                messages.Dequeue();
        }
        
    }
}
