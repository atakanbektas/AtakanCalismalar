﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGames
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        private string welcomeMessage;
        private int i = 0;

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            grpGiris.Top = this.Bottom;

            welcomeMessage = "Bu programın kullanım amacı temel işlem bilgilerinizi hızlandırmak, sayısal işlemlerde seri düşünebilmenizi sağlamaktır. \n\nToplama Çıkarma ve Çarpma işlemlerini ne kadar hızlı çözüp cevaplarsanız, o kadar puan kazanırsınız!\n\nDenemek için lütfen aşağıdan giriş yapınız.\nEğer hesabınız yoksa öncelikle kayıt olunuz.!";
            tmrWelcome.Start();
        }

        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            if (i >= welcomeMessage.Length - 1)
            {
                grpGiris.Visible = true;                
                tmrMoveGroupBox.Start();
                tmrWelcome.Stop();

            }
            lblWelcomeMessage.Text += welcomeMessage[i++];


        }

        private void tmrMoveGroupBox_Tick(object sender, EventArgs e)
        {
            if (this.Height <= grpGiris.Bottom+40) grpGiris.Top -= 5;

            

            else tmrMoveGroupBox.Stop();

        }
    }
}
