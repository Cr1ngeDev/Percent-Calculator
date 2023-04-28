using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Counting
    {
        public string Number1 { get; private set; }
        public string Number2 { get; private set; }
        public int task { get; private set; }
        public int index { get; private set; }
        public Counting(string num, string number, int index, int task)
        {
            Number1 = num;
            Number2 = number;
            this.index = index;
            this.task = task;
        }
        private string CheckTextBoxAndCount()
        {
            double FinalRes = 0;
            string StrNum = "no_data";
            if(index == 0)
            {
                if(Number1 != "" || Number2 != "")
                {
                    bool Percentres1 = double.TryParse(Number1, out double PerNum);
                    bool NumRes2 = double.TryParse(Number2, out double JustNumber);
                    if(Percentres1 != true || NumRes2 != true) 
                    {
                        MessageBox.Show("You entered not a number!");
                    }
                    else
                    {
                        if(task == 1)
                        {
                            FinalRes = Math.Round((JustNumber * (PerNum / 100)),1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                        else if(task == 3)
                        {
                            FinalRes = Math.Round((JustNumber * (1 + (PerNum / 100))), 1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                        else if(task ==4)
                        {
                            FinalRes = Math.Round((JustNumber * (1 - (PerNum / 100))), 1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                        else if(task == 7)
                        {
                            FinalRes = Math.Round((JustNumber * (100 / PerNum)),1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                    }
                }
            }
            else if (index ==1)
            {
                if(Number1 != "" || Number2!="")
                {
                    bool NumRes1 = double.TryParse(Number1, out double Num1);
                    bool NumRes2 = double.TryParse(Number2, out double Num2);
                    if (NumRes1 != true || NumRes2 != true)
                    {
                        MessageBox.Show("You entered not a number!");
                    }
                    else
                    {
                        if(task == 2)
                        {
                            FinalRes = Math.Round(((Num1 / Num2) * 100),1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                        else if(task == 5)
                        {
                            FinalRes = Math.Round(((Num1/Num2) * 100-100),1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                        else if(task == 6)
                        {
                            FinalRes = Math.Round((100 - (Num2 / Num1) * 100),1);
                            StrNum = Convert.ToString(FinalRes);
                        }
                    }
                }
            }
            return StrNum;
        }
        public string GetAnswer()
        {
            string Answer = CheckTextBoxAndCount();
            return Answer;
        }
    }
}
