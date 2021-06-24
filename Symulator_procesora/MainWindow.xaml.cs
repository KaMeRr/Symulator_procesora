﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Symulator_procesora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Text_ax.Text = string.Empty;
            Text_bx.Text = string.Empty;
            Text_cx.Text = string.Empty;
            Text_dx.Text = string.Empty;

            Text_ah.Text = string.Empty;
            Text_al.Text = string.Empty;
            Text_bh.Text = string.Empty;
            Text_bl.Text = string.Empty;
            Text_ch.Text = string.Empty;
            Text_cl.Text = string.Empty;
            Text_dh.Text = string.Empty;
            Text_dl.Text = string.Empty;
        }

        //private void textBox1_Validating(object sender, CancelEventArgs e)
        //{
        //    char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        //    foreach (char character in textBox1.Text.ToUpper().ToArray())
        //    {
        //        if (!allowedChars.Contains(character))
        //        {
        //            System.Windows.Forms.MessageBox.Show(string.Format("'{0}' is not a hexadecimal character", character));
        //            e.Cancel = true;
        //        }
        //    }
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Zerowanie_Click(object sender, RoutedEventArgs e)
        {
            Text_ax.Text = "0000";
            Text_bx.Text = "0000";
            Text_cx.Text = "0000";
            Text_dx.Text = "0000";
                   
            Text_ah.Text = "00";
            Text_al.Text = "00";
            Text_bh.Text = "00";
            Text_bl.Text = "00";
            Text_ch.Text = "00";
            Text_cl.Text = "00";
            Text_dh.Text = "00";
            Text_dl.Text = "00";
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            //Random AX
            Random random = new Random();
            int num1 = random.Next(0, 17);
            int num2 = random.Next(0, 17);
            int num3 = random.Next(0, 17);
            int num4 = random.Next(0, 17);
            string randomHex1 = num1.ToString("X");
            string randomHex2 = num2.ToString("X");
            string randomHex3 = num3.ToString("X");
            string randomHex4 = num4.ToString("X");
            Text_ax.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_ah.Text = randomHex1 + randomHex2;
            Text_al.Text = randomHex3 + randomHex4;

            //Random BX
            num1 = random.Next(0, 17);
            num2 = random.Next(0, 17);
            num3 = random.Next(0, 17);
            num4 = random.Next(0, 17);
            randomHex1 = num1.ToString("X");
            randomHex2 = num2.ToString("X");
            randomHex3 = num3.ToString("X");
            randomHex4 = num4.ToString("X");
            Text_bx.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_bh.Text = randomHex1 + randomHex2;
            Text_bl.Text = randomHex3 + randomHex4;

            //Random CX
            num1 = random.Next(0, 17);
            num2 = random.Next(0, 17);
            num3 = random.Next(0, 17);
            num4 = random.Next(0, 17);
            randomHex1 = num1.ToString("X");
            randomHex2 = num2.ToString("X");
            randomHex3 = num3.ToString("X");
            randomHex4 = num4.ToString("X");
            Text_cx.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_ch.Text = randomHex1 + randomHex2;
            Text_cl.Text = randomHex3 + randomHex4;

            //Random DX
            num1 = random.Next(0, 17);
            num2 = random.Next(0, 17);
            num3 = random.Next(0, 17);
            num4 = random.Next(0, 17);
            randomHex1 = num1.ToString("X");
            randomHex2 = num2.ToString("X");
            randomHex3 = num3.ToString("X");
            randomHex4 = num4.ToString("X");
            Text_dx.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_dh.Text = randomHex1 + randomHex2;
            Text_dl.Text = randomHex3 + randomHex4;
        }

        public void Push_Click(object sender, RoutedEventArgs e)
        {
            string pushAX = Text_ax.Text;
            string pushBX = Text_ax.Text;
            string pushCX = Text_ax.Text;
            string pushDX = Text_ax.Text;

            string pushAH = Text_ax.Text;
            string pushAL = Text_ax.Text;
            string pushBH = Text_ax.Text;
            string pushBL = Text_ax.Text;
            string pushCH = Text_ax.Text;
            string pushCL = Text_ax.Text;
            string pushDH = Text_ax.Text;
            string pushDL = Text_ax.Text;
        }


        private void Pop_Click(object sender, RoutedEventArgs e)
        {
            Text_ax.Text = pushAX;
            string pushAX = Text_ax.Text;
            string pushBX = Text_ax.Text;
            string pushCX = Text_ax.Text;
            string pushDX = Text_ax.Text;

            string pushAH = Text_ax.Text;
            string pushAL = Text_ax.Text;
            string pushBH = Text_ax.Text;
            string pushBL = Text_ax.Text;
            string pushCH = Text_ax.Text;
            string pushCL = Text_ax.Text;
            string pushDH = Text_ax.Text;
            string pushDL = Text_ax.Text;
        }
    }
}
