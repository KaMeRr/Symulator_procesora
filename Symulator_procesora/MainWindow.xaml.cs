using System;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string pushAX = string.Empty;
        public string pushBX = string.Empty;
        public string pushCX = string.Empty;
        public string pushDX = string.Empty;

        public string pushAH = string.Empty;
        public string pushAL = string.Empty;
        public string pushBH = string.Empty;
        public string pushBL = string.Empty;
        public string pushCH = string.Empty;
        public string pushCL = string.Empty;
        public string pushDH = string.Empty;
        public string pushDL = string.Empty;

        public string MOV_a = string.Empty;
        public string MOV_b = string.Empty;
        public string XCHG_a = string.Empty;
        public string XCHG_b = string.Empty;



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };


            foreach (char character in Text_ax.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_ax.Text = Text_ax.Text.Substring(0, Text_ax.Text.Length - 1);
                }
            }
            foreach (char character in Text_bx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_bx.Text = Text_bx.Text.Substring(0, Text_bx.Text.Length - 1);
                }
            }
            foreach (char character in Text_cx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_cx.Text = Text_cx.Text.Substring(0, Text_cx.Text.Length - 1);
                }
            }
            foreach (char character in Text_dx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_dx.Text = Text_dx.Text.Substring(0, Text_dx.Text.Length - 1);
                }
            }

            // Text_ah.Text = Text_ax.Text.Substring(1, 2);
            //  Text_al.Text = Text_ax.Text.Substring(3);

            //if (Text_ax.Text.Length >= 2)
            //{
            //    char[] ax = Text_ax.Text.ToCharArray();
            //    Text_ah.Text = new string(ax, 0, 2);

            //}
            //if (Text_ax.Text.Length == 4)
            //{
            //    char[] ax = Text_ax.Text.ToCharArray();
            //    Text_al.Text = new string(ax, 2, 2);
            //}
        }


        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {





        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            foreach (char character in Text_ah.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_ah.Text = Text_ah.Text.Substring(0, Text_ah.Text.Length - 1);
                }
            }
            foreach (char character in Text_al.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_al.Text = Text_al.Text.Substring(0, Text_al.Text.Length - 1);
                }
            }
            foreach (char character in Text_bh.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_bh.Text = Text_bh.Text.Substring(0, Text_bh.Text.Length - 1);
                }
            }
            foreach (char character in Text_bl.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_bl.Text = Text_bl.Text.Substring(0, Text_bl.Text.Length - 1);
                }
            }
            foreach (char character in Text_ch.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_ch.Text = Text_ch.Text.Substring(0, Text_ch.Text.Length - 1);
                }
            }
            foreach (char character in Text_cl.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_cl.Text = Text_cl.Text.Substring(0, Text_cl.Text.Length - 1);
                }
            }
            foreach (char character in Text_dh.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_dh.Text = Text_dh.Text.Substring(0, Text_dh.Text.Length - 1);
                }
            }
            foreach (char character in Text_dl.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show($"{character} nie jest wartością hexadecymalną!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
                    Text_dl.Text = Text_dl.Text.Substring(0, Text_dl.Text.Length - 1);
                }
            }

            Text_ax.Text = Text_ah.Text + Text_al.Text;
            Text_bx.Text = Text_bh.Text + Text_bl.Text;
            Text_cx.Text = Text_ch.Text + Text_cl.Text;
            Text_dx.Text = Text_dh.Text + Text_dl.Text;
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}

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
            int num1 = random.Next(0, 16);
            int num2 = random.Next(0, 16);
            int num3 = random.Next(0, 16);
            int num4 = random.Next(0, 16);
            string randomHex1 = num1.ToString("X");
            string randomHex2 = num2.ToString("X");
            string randomHex3 = num3.ToString("X");
            string randomHex4 = num4.ToString("X");
            Text_ax.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_ah.Text = randomHex1 + randomHex2;
            Text_al.Text = randomHex3 + randomHex4;

            //Random BX
            num1 = random.Next(0, 16);
            num2 = random.Next(0, 16);
            num3 = random.Next(0, 16);
            num4 = random.Next(0, 16);
            randomHex1 = num1.ToString("X");
            randomHex2 = num2.ToString("X");
            randomHex3 = num3.ToString("X");
            randomHex4 = num4.ToString("X");
            Text_bx.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_bh.Text = randomHex1 + randomHex2;
            Text_bl.Text = randomHex3 + randomHex4;

            //Random CX
            num1 = random.Next(0, 16);
            num2 = random.Next(0, 16);
            num3 = random.Next(0, 16);
            num4 = random.Next(0, 16);
            randomHex1 = num1.ToString("X");
            randomHex2 = num2.ToString("X");
            randomHex3 = num3.ToString("X");
            randomHex4 = num4.ToString("X");
            Text_cx.Text = randomHex1 + randomHex2 + randomHex3 + randomHex4;
            Text_ch.Text = randomHex1 + randomHex2;
            Text_cl.Text = randomHex3 + randomHex4;

            //Random DX
            num1 = random.Next(0, 16);
            num2 = random.Next(0, 16);
            num3 = random.Next(0, 16);
            num4 = random.Next(0, 16);
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
            pushAX = Text_ax.Text;
            pushBX = Text_bx.Text;
            pushCX = Text_cx.Text;
            pushDX = Text_dx.Text;

            pushAH = Text_ah.Text;
            pushAL = Text_al.Text;
            pushBH = Text_bh.Text;
            pushBL = Text_bl.Text;
            pushCH = Text_ch.Text;
            pushCL = Text_cl.Text;
            pushDH = Text_dh.Text;
            pushDL = Text_dl.Text;
        }


        private void Pop_Click(object sender, RoutedEventArgs e)
        {
            Text_ax.Text = pushAX;
            Text_bx.Text = pushBX;
            Text_cx.Text = pushCX;
            Text_dx.Text = pushDX;

            Text_ah.Text = pushAH;
            Text_al.Text = pushAL;
            Text_bh.Text = pushBH;
            Text_bl.Text = pushBL;
            Text_ch.Text = pushCH;
            Text_cl.Text = pushCL;
            Text_dh.Text = pushDH;
            Text_dl.Text = pushDL;

        }
        //////////////////////////////////////////////////////////////////////////////////////////
        private void MOV_Click(object sender, RoutedEventArgs e)
        {
            MOV_b = MOV_a;

            if (c_ax.IsChecked == true)
            {
                Text_ax.Text = MOV_b;
            }
            else if (c_bx.IsChecked == true)
            {
                Text_bx.Text = MOV_b;
            }
            else if (c_cx.IsChecked == true)
            {
                Text_cx.Text = MOV_b;
            }
            else if (c_dx.IsChecked == true)
            {
                Text_dx.Text = MOV_b;
            }
            else if (c_ah.IsChecked == true)
            {
                Text_ah.Text = MOV_b;
            }
            else if (c_al.IsChecked == true)
            {
                Text_al.Text = MOV_b;
            }
            else if (c_bh.IsChecked == true)
            {
                Text_bh.Text = MOV_b;
            }
            else if (c_bl.IsChecked == true)
            {
                Text_bl.Text = MOV_b;
            }
            else if (c_ch.IsChecked == true)
            {
                Text_ch.Text = MOV_b;
            }
            else if (c_cl.IsChecked == true)
            {
                Text_cl.Text = MOV_b;
            }
            else if (c_dh.IsChecked == true)
            {
                Text_dh.Text = MOV_b;
            }
            else if (c_dl.IsChecked == true)
            {
                Text_dl.Text = MOV_b;
            }

        }
        private void XCHG_Click(object sender, RoutedEventArgs e)
        {

        }
        ///////////////////////////////////////////////////////////////////////////////////////
        private void b_ax_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_ax.Text;
            XCHG_a = Text_ax.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;

        }
        private void b_bx_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_bx.Text;
            XCHG_a = Text_bx.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }

        private void b_cx_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_cx.Text;
            XCHG_a = Text_cx.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }

        private void b_dx_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_dx.Text;
            XCHG_a = Text_dx.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }

        private void c_ax_Checked(object sender, RoutedEventArgs e)
        {
            MOV_b = Text_ax.Text;
            XCHG_b = Text_ax.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }



        private void c_bx_Checked(object sender, RoutedEventArgs e)
        {
            MOV_b = Text_bx.Text;
            XCHG_b = Text_bx.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }

        private void c_cx_Checked(object sender, RoutedEventArgs e)
        {
            MOV_b = Text_cx.Text;
            XCHG_b = Text_cx.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }

        private void c_dx_Checked(object sender, RoutedEventArgs e)
        {
            MOV_b = Text_dx.Text;
            XCHG_b = Text_dx.Text;


            //Uncheck zadania 2
            b_ah.IsChecked = false;
            b_al.IsChecked = false;
            b_bh.IsChecked = false;
            b_bl.IsChecked = false;
            b_ch.IsChecked = false;
            b_cl.IsChecked = false;
            b_dh.IsChecked = false;
            b_dl.IsChecked = false;
            c_ah.IsChecked = false;
            c_al.IsChecked = false;
            c_bh.IsChecked = false;
            c_bl.IsChecked = false;
            c_ch.IsChecked = false;
            c_cl.IsChecked = false;
            c_dh.IsChecked = false;
            c_dl.IsChecked = false;
        }


        //////////////////////////////////////////////////////////////////////////////////


        private void b_ah_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_ah.Text;
            XCHG_a = Text_ah.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_al_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_al.Text;
            XCHG_a = Text_al.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_bh_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_bh.Text;
            XCHG_a = Text_bh.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_bl_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_bl.Text;
            XCHG_a = Text_bl.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_ch_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_ch.Text;
            XCHG_a = Text_ch.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_cl_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_cl.Text;
            XCHG_a = Text_cl.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_dh_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_dh.Text;
            XCHG_a = Text_dh.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }

        private void b_dl_Checked(object sender, RoutedEventArgs e)
        {
            MOV_a = Text_dl.Text;
            XCHG_a = Text_dl.Text;


            //Uncheck zadania 1
            b_ax.IsChecked = false;
            b_bx.IsChecked = false;
            b_cx.IsChecked = false;
            b_dx.IsChecked = false;
            c_ax.IsChecked = false;
            c_bx.IsChecked = false;
            c_cx.IsChecked = false;
            c_dx.IsChecked = false;
        }


        /// /////////////////////////////////////////////////


        private void c_ah_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_al_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_bh_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_bl_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_ch_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_cl_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_dh_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void c_dl_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
