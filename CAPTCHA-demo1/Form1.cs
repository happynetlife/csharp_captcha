using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPTCHA_demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picVcode.Image = createCaptcha(rndNumber(5));
            picVcode1.Image = createCaptcha(rndStr(5));
            picVcode2.Image = createCaptchaCN(getRndStrGB(4));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            picVcode.Image = createCaptcha(rndNumber(5));
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            picVcode1.Image = createCaptcha(rndStr(5));
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            string str = getRndStrGB(4);
            Bitmap image = createCaptchaCN(str);
            if (image != null)
            {
                picVcode2.Image = image;
            }
        }


        /// <summary>
        /// 生成一个随机字串
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        private string rndStr(int len)
        {
            // 随机数对象
            Random rnd = new Random();
            // 组成字符
            string chars = "123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string str = null;
            for(int i = 0; i < len; i++)
            {
                str += chars.Substring(rnd.Next() % chars.Length, 1);
            }
            return str;
        }

        /// <summary>
        /// 生成一个随数字组成的字符串
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        private string rndNumber(int len)
        {
            // 创建一个随机数对象
            Random rnd = new Random();
            // 产生一个随机数
            string str = null;
            int rndNum = 0;
            for (int i = 0; i < len; i++)
            {
                rndNum = rnd.Next(0, 10);
                str += rndNum;
            }
            return str;
        }

        /// <summary>
        /// 生成验证码图片
        /// </summary>
        private Bitmap createCaptcha(string str)
        {
            // 创建一个随机数对象
            Random rnd = new Random();
            int strLen = str.Length;
            // 创建一个位图对象
            int imgWidth = 139;
            int imgHeight = 50;
            Bitmap bmp = new Bitmap(imgWidth, imgHeight);
            // 创建一个GDI对象
            Graphics g = Graphics.FromImage(bmp);
            // 坐标点
            Point p1, p2;
            // 绘制干扰点
            for (int i = 0; i < 500; i++)
            {
                p1 = new Point(rnd.Next(0, imgWidth), rnd.Next(0, imgHeight));
                // 画点
                bmp.SetPixel(p1.X, p1.Y, Color.Black);
            }
            // 绘制干扰线
            for (int i = 0; i < 20; i++)
            {
                p1 = new Point(rnd.Next(0, imgWidth), rnd.Next(0, imgHeight));
                p2 = new Point(rnd.Next(0, imgWidth), rnd.Next(0, imgHeight));
                // 绘制线条
                g.DrawLine(new Pen(Brushes.Gray), p1, p2);
            }
            // 字体数组
            string[] fonts = { "宋体","微软雅黑","黑体","Consolas","楷体","仿宋","幼圆","隶书"};
            int fontLen = fonts.Length;
            // 颜色数组
            Color[] colors = { Color.Yellow, Color.Red, Color.Blue, Color.Green, Color.Pink, Color.Teal, Color.Aqua };
            int colorLen = colors.Length;
            // 字体字号
            Font font;

            for(int i = 0; i < strLen; i++)
            {
                p1 = new Point(10 + i * 20, rnd.Next(5, 15));
                font = new Font(fonts[rnd.Next(0, fontLen)], rnd.Next(16, 24), FontStyle.Bold);
                // 画字符
                g.DrawString(str[i].ToString(), font, new SolidBrush(colors[rnd.Next(0, colorLen)]), p1);
            }
            
            // 返加位图对象
            return bmp;
        }


        /// <summary>
        /// 生成随机汉字数组
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static object[] CreateCode(int length)
        {
            // 定义字符串存储汉字编码元素
            string[] r = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            // 创建随机对象
            Random rnd = new Random();
            object[] bytes = new object[length];
            // 循环产生字节数组
            int r1, r2, r3, r4;
            string str1, str2, str3, str4;
            byte byte1, byte2;
            byte[] strR;

            for (int i = 0; i < length; i++)
            {
                // 区位码第一位
                r1 = rnd.Next(11, 14);
                str1 = r[r1].Trim();
                // 避免产生相同的字
                rnd = new Random(r1 * unchecked((int)DateTime.Now.Ticks) + i);

                // 区位码第二位
                if(r1 == 13)
                {
                    r2 = rnd.Next(0, 7);
                }
                else
                {
                    r2 = rnd.Next(0, 16);
                }
                str2 = r[r2];
                // 避免重复
                rnd = new Random(r2 * unchecked((int)DateTime.Now.Ticks) + i);

                // 区位码第三位
                r3 = rnd.Next(10, 16);
                str3 = r[r3];

                // 避免重复
                rnd = new Random(r3 * unchecked((int)DateTime.Now.Ticks) + i);

                // 区位码第四位
                if(r3 == 10)
                {
                    r4 = rnd.Next(1, 16);
                }
                else if(r3 == 15)
                {
                    r4 = rnd.Next(0, 15);
                }
                else
                {
                    r4 = rnd.Next(0, 16);
                }
                str4 = r[r4];
                // 字义两个变量存储产生的随机汉字区位码
                byte1 = Convert.ToByte(str1 + str2, 16);
                byte2 = Convert.ToByte(str3 + str4, 16);
                // 将临时变量的汉字区位码存储到字节数组
                strR = new byte[] { byte1, byte2 };
                // 将汉字存储到object数组
                bytes.SetValue(strR, i);
            }
            return bytes;
        }

        /// <summary>
        /// 生成随机的汉字字串
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private string getRndStrGB(int length)
        {
            // 获取gb2312编码页
            Encoding gb = Encoding.GetEncoding("gb2312");
            // 调用产生的随机汉字编码
            object[] bytes = CreateCode(length);
            // 解码汉字
            string str = null;
            for (int i = 0; i < length; i++)
            {
                str += gb.GetString((byte[])Convert.ChangeType(bytes[i], typeof(byte[])));
            }
            // 返回汉字字串
            return str;
        }

        /// <summary>
        /// 生成中文验证码图片
        /// </summary>
        /// <param name="str"></param>
        public Bitmap createCaptchaCN(string str)
        {
            // 判断字串不为空
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            int strLen = str.Length;
            // 创建位图对象
            int imgWidth = (int)Math.Ceiling(strLen * 32.5);
            int imgHeight = 50;
            Bitmap bmp = new Bitmap(imgWidth, imgHeight);
            // 创建绘图对象
            Graphics g = Graphics.FromImage(bmp);
            // 创建随机对象
            Random rnd = new Random();
            // 字体数组
            string[] fonts = { "宋体", "微软雅黑", "黑体", "楷体", "仿宋", "幼圆", "隶书" };
            int fontCount = fonts.Length;
            // 颜色数组
            Color[] colors = { Color.YellowGreen, Color.Red, Color.Blue, Color.Green, Color.DarkCyan, Color.Teal, Color.Black };
            int colorCount = colors.Length;

            try
            {
                // 清空区域
                g.Clear(Color.White);
                // 坐标变量
                Point p1, p2;
                // 画背景线
                for (int i = 0; i < 20; i++)
                {
                    p1 = new Point(rnd.Next(imgWidth), rnd.Next(imgHeight));
                    p2 = new Point(rnd.Next(imgWidth), rnd.Next(imgHeight));
                    // 绘制线条
                    //g.DrawLine(new Pen(Color.FromArgb(rnd.Next())), p1, p2);
                    //g.DrawLine(new Pen(colors[rnd.Next(0, colorCount)]), p1, p2);//随机颜色
                    g.DrawLine(new Pen(Color.Gray), p1, p2);
                }
                // 画干扰点
                for (int i = 0; i < 500; i++)
                {
                    p1 = new Point(rnd.Next(imgWidth), rnd.Next(imgHeight));
                    bmp.SetPixel(p1.X, p1.Y, Color.Black);
                }
                // 画汉字
                Font font;
                // 线性渐变笔刷对象
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, imgWidth, imgHeight), colors[rnd.Next(0, colorCount)], colors[rnd.Next(0, colorCount)], 1.2f, true);
                // 一个一个绘制
                for (int i = 0; i < strLen; i++)
                {
                    // 定义字体字号
                    font = new Font(fonts[rnd.Next(0, fontCount)], rnd.Next(16, 20), FontStyle.Bold);
                    // 绘制汉字
                    g.DrawString(str[i].ToString(), font, brush, 10 + i * 25, rnd.Next(5, 15));
                }
                
                // 绘制边框
                //g.DrawRectangle(new Pen(Color.Silver), 0, 0, imgWidth - 1, imgHeight - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                g.Dispose();
            }
            // 返回位图
            return bmp;
        }
    }
}
