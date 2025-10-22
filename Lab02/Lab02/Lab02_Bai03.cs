using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        string inputFilePath = @"..\..\..\I_O_File\input3.txt";
        string outputFilePath = @"..\..\..\I_O_File\output3.txt";
        List<string> outputLines = new List<string>();

        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show($"Không tìm thấy file '{inputFilePath}'", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                contentReadFile.Text = File.ReadAllText(inputFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static double EvaluateExpression(string expression)
        {
            // QUAN TRỌNG: Thay thế các dấu dash đặc biệt thành dấu trừ thông thường
            expression = expression.Replace('–', '-'); // En dash (U+2013)
            expression = expression.Replace('—', '-'); // Em dash (U+2014)
            expression = expression.Replace('−', '-'); // Minus sign (U+2212)
            expression = expression.Replace(" ", "");

            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                // Xử lý số (bao gồm cả số thập phân và số âm)
                if (char.IsDigit(expression[i]) || expression[i] == '.' ||
                    (expression[i] == '-' && (i == 0 || expression[i - 1] == '(' || IsOperator(expression[i - 1]))))
                {
                    string numberStr = "";

                    // Xử lý dấu âm
                    if (expression[i] == '-')
                    {
                        numberStr += expression[i];
                        i++;
                    }

                    // Đọc phần số
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        numberStr += expression[i];
                        i++;
                    }
                    values.Push(double.Parse(numberStr));
                    i--;
                }
                else if (expression[i] == '(')
                {
                    ops.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                        char op = ops.Pop();
                        double right = values.Pop();
                        double left = values.Pop();
                        values.Push(ApplyOperation(op, left, right));
                    }
                    ops.Pop();
                }
                else if (IsOperator(expression[i]))
                {
                    while (ops.Count > 0 && HasPrecedence(ops.Peek(), expression[i]))
                    {
                        char op = ops.Pop();
                        double right = values.Pop();
                        double left = values.Pop();
                        values.Push(ApplyOperation(op, left, right));
                    }
                    ops.Push(expression[i]);
                }
            }

            while (ops.Count > 0)
            {
                char op = ops.Pop();
                double right = values.Pop();
                double left = values.Pop();
                values.Push(ApplyOperation(op, left, right));
            }

            return values.Pop();
        }

        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        public static bool HasPrecedence(char op1, char op2)
        {
            if (op1 == '(' || op1 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return true;
            if ((op1 == '*' || op1 == '/') && (op2 == '*' || op2 == '/'))
                return true;
            if ((op1 == '+' || op1 == '-') && (op2 == '+' || op2 == '-'))
                return true;

            return false;
        }

        public static double ApplyOperation(char op, double left, double right)
        {
            switch (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/':
                    if (right == 0) throw new DivideByZeroException("Không thể chia cho 0.");
                    return left / right;
            }
            return 0;
        }
        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {
                outputLines.Clear();
                string[] lines = File.ReadAllLines(inputFilePath);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        try
                        {
                            double result = Math.Round(EvaluateExpression(line),1);
                            outputLines.Add($"{line} = {result}");
                        }
                        catch 
                        {
                            outputLines.Add($"{line} = Lỗi");
                        }
                    }
                }

                File.WriteAllLines(outputFilePath, outputLines);
                contentWriteFile.Text = File.ReadAllText(outputFilePath);

                MessageBox.Show("Xử lý thành công! Kết quả đã được ghi vào output3.txt.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}