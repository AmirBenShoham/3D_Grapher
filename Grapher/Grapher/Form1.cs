using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grapher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static BinTreeNode<string> BuildTreeOfParser(String str)
        {
            BinTreeNode<string> tr = null;
            int Brackets = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (str[i] == '+' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
                else
                    if (str[i] == '-' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    if (i != 0)
                        tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                    else
                        tr.SetLeft(BuildTreeOfParser("0"));
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (str[i] == '*' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
                else
                    if (str[i] == '/' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (str[i] == '^' && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str[i].ToString());
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 1, str.Length - i - 1)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ')')
                    Brackets++;
                if (str[i] == '(')
                    Brackets--;
                if (i < str.Length - 3 && str.Substring(i, 3) == "cos" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "sin" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "tan" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "sec" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "csc" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "cot" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 6 && str.Substring(i, 3) == "arcsin" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 6 && str.Substring(i, 3) == "arccos" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "abs" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                }
                else if (i < str.Length - 3 && str.Substring(i, 3) == "log" && tr == null && Brackets == 0)
                {
                    tr = new BinTreeNode<string>(str.Substring(i, 3));
                    tr.SetRight(BuildTreeOfParser(str.Substring(i + 3)));
                    tr.SetLeft(BuildTreeOfParser(str.Substring(0, i)));
                }
            }

            if (tr == null && str[0] != '(')
            {
                tr = new BinTreeNode<string>(str);
            }
            if (str[0] == '(' && tr == null)
            {
                return BuildTreeOfParser(str.Substring(1, str.Length - 2));
            }

            return tr;
        }
        static double CalculateTreeOfParser(BinTreeNode<string> t, double x, double y)
        {
            if (t != null)
                if (t.GetInfo() == "+")
                    return CalculateTreeOfParser(t.GetLeft(), x, y) + CalculateTreeOfParser(t.GetRight(), x, y);
                else if (t.GetInfo() == "-")
                    return CalculateTreeOfParser(t.GetLeft(), x, y) - CalculateTreeOfParser(t.GetRight(), x, y);
                else if (t.GetInfo() == "*")
                    return CalculateTreeOfParser(t.GetLeft(), x, y) * CalculateTreeOfParser(t.GetRight(), x, y);
                else if (t.GetInfo() == "/")
                    return CalculateTreeOfParser(t.GetLeft(), x, y) / CalculateTreeOfParser(t.GetRight(), x, y);
                else if (t.GetInfo() == "^")
                    return Math.Pow(CalculateTreeOfParser(t.GetLeft(), x, y), CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "cos")
                    return Math.Cos(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "sin")
                    return Math.Sin(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "tan")
                    return Math.Tan(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "sec")
                    return 1 / Math.Cos(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "csc")
                    return 1 / Math.Sin(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "cot")
                    return 1 / Math.Tan(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "arcsin")
                    return Math.Asin(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "arccos")
                    return Math.Acos(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "arctan")
                    return Math.Atan(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "log")
                    return Math.Log(CalculateTreeOfParser(t.GetRight(), x, y), CalculateTreeOfParser(t.GetLeft(), x, y));
                else if (t.GetInfo() == "abs")
                    return Math.Abs(CalculateTreeOfParser(t.GetRight(), x, y));
                else if (t.GetInfo() == "PI")
                    return Math.PI;
                else if (t.GetInfo() == "e")
                    return Math.E;
                else
                    if (t.GetInfo() == "x")
                    return x;
                else
                    if (t.GetInfo() == "y")
                    return y;
            return double.Parse(t.GetInfo());
        }
        static string CleanDef(string str)
        {
            string CleanedDef = "";
            int Brackets = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    CleanedDef += Char.ToLower(str[i]);
                }
                else if (str[i] == '(')
                {
                    Brackets++;
                    CleanedDef += '(';
                }
                else if (str[i] == ')')
                {
                    Brackets--;
                    if (Brackets < 0)
                    {
                        return "$Error$";
                    }
                    CleanedDef += ')';
                }
                else if (str[i] == '{' || str[i] == '[')
                {
                    CleanedDef += '(';
                    Brackets++;
                }
                else if (str[i] == '}' || str[i] == ']')
                {
                    CleanedDef += ')';
                    Brackets--;
                    if (Brackets < 0)
                    {
                        return "$Error$";
                    }
                }
                else if (str[i] != ' ')
                {
                    CleanedDef += str[i];
                }

            }
            if (Brackets != 0)
            {
                return "$Error$";
            }

            return CleanedDef;
        }

        bool restart = false;
        PointF[] point = new PointF[4];
        SolidBrush b = new SolidBrush(Color.Green);
        bool error = false;

        double min = 999999;
        double max = -999999;

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap Bitmap = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(Bitmap);
            if (restart)
            {
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, panel1.Width, panel1.Height);
                min = 999999;
                max = -999999;
            }
            else
            {
                restart = true;
            }

            BinTreeNode<string> z;
            if (CleanDef(FunctionTB.Text) != "$Error$")
            {
                try
                {
                    z = BuildTreeOfParser(CleanDef(FunctionTB.Text));
                }
                catch
                {
                    MessageBox.Show("The functions contains an error");
                    error = true;
                    z = BuildTreeOfParser("5");
                }
                if (!error)
                {
                    double[,] ver = new double[panel1.Width * 2, panel1.Height * 2];
                    double Alpha = 2;
                    double accur = 0.3;
                    double zoom = 7;

                    try
                    {
                        accur = double.Parse(Accuracy.Text);
                    }
                    catch { };
                    try
                    {
                        zoom = double.Parse(Zoom.Text);
                    }
                    catch { };
                    try
                    {
                        Alpha = double.Parse(Angle.Text);
                    }
                    catch { };
                    try
                    {
                        for (double x = 0; x < panel1.Width * 2; x++)
                        {
                            for (double y = 0; y < panel1.Height * 2; y++)
                            {
                                ver[(int)x, (int)y] = CalculateTreeOfParser(z, (x - panel1.Width) * accur, (y - panel1.Height) * accur);
                                if (ver[(int)x, (int)y] > max)
                                {
                                    max = ver[(int)x, (int)y];
                                }
                                if (ver[(int)x, (int)y] < min)
                                {
                                    min = ver[(int)x, (int)y];
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The functions contains an error");
                        error = true;
                    }

                    if (!error)
                    {
                        double[,] Xtag = new double[panel1.Width * 2, panel1.Height * 2];
                        double[,] Ytag = new double[panel1.Width * 2, panel1.Height * 2];

                        for (int x = 0; x < panel1.Width * 2; x++)
                        {
                            for (int y = 0; y < panel1.Height * 2; y++)
                            {
                                Xtag[x, y] = (x - panel1.Width) * zoom + (-0.5) * (y - panel1.Height) * Math.Cos(Alpha) * zoom;
                                Ytag[x, y] = ver[x, y] * zoom + (-0.5) * (y - panel1.Height) * Math.Sin(Alpha) * zoom;
                            }
                        }

                        //for (int i = 0; i < panel1.Height * 2 - 1; i++)
                        //{
                        //    for (int j = 0; j < panel1.Width * 2 - 1; j++)
                        //    {
                        //        if (((panel1.Width / 2 + Xtag[j, i] > -10 && panel1.Width / 2 + Xtag[j, i] < panel1.Width + 10) &&
                        //            (panel1.Height / 2 - Ytag[j, i] > -10 && panel1.Height / 2 - Ytag[j, i] < panel1.Height + 10)) &&
                        //            ((panel1.Width / 2 + Xtag[j + 1, i] > -10 && panel1.Width / 2 + Xtag[j + 1, i] < panel1.Width + 10) &&
                        //            (panel1.Height / 2 - Ytag[j + 1, i] > -10 && panel1.Height / 2 - Ytag[j + 1, i] < panel1.Height + 10)))

                        //            g.DrawLine(Pens.Green,
                        //            panel1.Width / 2 + (float)Xtag[j, i],
                        //            panel1.Height / 2 - (float)Ytag[j, i],
                        //            panel1.Width / 2 + (float)Xtag[j + 1, i],
                        //            panel1.Height / 2 - (float)Ytag[j + 1, i]
                        //            );
                        //        if (((panel1.Width / 2 + Xtag[j, i] > -10 && panel1.Width / 2 + Xtag[j, i] < panel1.Width + 10) &&
                        //            (panel1.Height / 2 - Ytag[j, i] > -10 && panel1.Height / 2 - Ytag[j, i] < panel1.Height + 10)) &&
                        //            ((panel1.Width / 2 + Xtag[j, i + 1] > -10 && panel1.Width / 2 + Xtag[j, i + 1] < panel1.Width + 10) &&
                        //            (panel1.Height / 2 - Ytag[j, i + 1] > -10 && panel1.Height / 2 - Ytag[j, i + 1] < panel1.Height + 10)))

                        //            g.DrawLine(Pens.Green,
                        //            panel1.Width / 2 + (float)Xtag[j, i],
                        //            panel1.Height / 2 - (float)Ytag[j, i],
                        //            panel1.Width / 2 + (float)Xtag[j, i + 1],
                        //            panel1.Height / 2 - (float)Ytag[j, i + 1]
                        //        );
                        //    }
                        //}

                        for (int i = 0; i < panel1.Height * 2 - 1; i++)
                        {
                            for (int j = 0; j < panel1.Width * 2 - 1; j++)
                            {
                                if (((panel1.Width / 2 + Xtag[j, i] > -10 && panel1.Width / 2 + Xtag[j, i] < panel1.Width + 10) &&
                                (panel1.Height / 2 - Ytag[j, i] > -10 && panel1.Height / 2 - Ytag[j, i] < panel1.Height + 10)) ||
                                ((panel1.Width / 2 + Xtag[j + 1, i] > -10 && panel1.Width / 2 + Xtag[j + 1, i] < panel1.Width + 10) &&
                                (panel1.Height / 2 - Ytag[j + 1, i] > -10 && panel1.Height / 2 - Ytag[j + 1, i] < panel1.Height + 10)) ||
                                ((panel1.Width / 2 + Xtag[j, i + 1] > -10 && panel1.Width / 2 + Xtag[j, i + 1] < panel1.Width + 10) &&
                                (panel1.Height / 2 - Ytag[j, i + 1] > -10 && panel1.Height / 2 - Ytag[j, i + 1] < panel1.Height + 10)) ||
                                ((panel1.Width / 2 + Xtag[j + 1, i + 1] > -10 && panel1.Width / 2 + Xtag[j + 1, i + 1] < panel1.Width + 10) &&
                                (panel1.Height / 2 - Ytag[j + 1, i + 1] > -10 && panel1.Height / 2 - Ytag[j + 1, i + 1] < panel1.Height + 10)))
                                {
                                    point[0] = new PointF(panel1.Width / 2 + (float)Xtag[j, i], panel1.Height / 2 - (float)Ytag[j, i]);
                                    point[1] = new PointF(panel1.Width / 2 + (float)Xtag[j + 1, i], panel1.Height / 2 - (float)Ytag[j + 1, i]);
                                    point[2] = new PointF(panel1.Width / 2 + (float)Xtag[j + 1, i + 1], panel1.Height / 2 - (float)Ytag[j + 1, i + 1]);
                                    point[3] = new PointF(panel1.Width / 2 + (float)Xtag[j, i + 1], panel1.Height / 2 - (float)Ytag[j, i + 1]);

                                    int color = (int)(255 * (ver[j, i] - min) / (max - min));

                                    b.Color = Color.FromArgb(255 - color, 0, color);

                                    g.FillPolygon(b, point);
                                }
                            }
                        }
                        panel1.BackgroundImage = Bitmap;
                    }
                }


            }
            else
            {
                MessageBox.Show("The function contains an error");
            }
        }
    }
}
