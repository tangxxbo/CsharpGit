using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i = 0;
            //if (i==0)
            //{
            //    MessageBox.Show("hello,world!");
            //}
            //else
            //{
            //    MessageBox.Show("false11");
            //}
            //int a = 4;
            //switch (a)
            //{
            //    case 1:
            //        MessageBox.Show("这是1");
            //        break;
            //    case 2:
            //        MessageBox.Show("这是2");
            //        break;
            //    case 3:
            //        MessageBox.Show("这是3");
            //        break;
            //    default:
            //        MessageBox.Show("你给出的东西不在条件内");
            //        break;
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    MessageBox.Show("这是第" + (i + 1) + "循环，结果是" + i);
            //}
            //int i = 0;
            //while (i<5)
            //{
            //    MessageBox.Show("这是第" + (i + 1) + "循环，结果是" + i);
            //    i++;
            //}
            //do
            //{
            //    MessageBox.Show("这是第" + (i + 1) + "循环，结果是" + i);
            //    i++;
            //} while (i<5);

            //decimal a = 1.9m;
            //decimal b = 16m;
            //decimal totalless;
            //decimal total;
            //int d = (int)(a * b / 10);
            //decimal es = 0m;
            //for (int i = 0; i < d; i++)
            //{
            //    es += Decimal.Parse((10 * 0.75).ToString());
            //}
            //totalless = ( a * b % 10);
            //total = es + totalless;
            //MessageBox.Show(total.ToString());

            /*Console.WriteLine( Convert.ToInt32(null));*/
           /* string[] schools = {"湖大","中南", "师范", "国防", "湘大", "科大" };
            int i = 0;
            string ss = "";
            bool flag = true;
            while (ss != "湘大")
            {
                if (i >= schools.Length)
                {
                    MessageBox.Show("没有该数据！");
                    flag = false;
                    break;
                }
                ss = schools[i];
                i++;
            }
            if (flag)
            {
                MessageBox.Show("已经找到了" + ss);
            }*/

        }
    }
}
