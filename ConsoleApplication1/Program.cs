using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    namespace ConsoleApplication1
    {
        class Program
        {
            static void Main(string[] args)
            {
                // 宣告變數
                string result = "";

                double BMI;

                // 讀取資料
                Console.Title = "BMI計算機";

                Console.WriteLine("請輸入身高：");

                string height = Console.ReadLine();

                Console.WriteLine("請輸入体重:");

                string weight = Console.ReadLine();

                // BMI計算 
                double heigh  = double.Parse(height) / 100;

                double hh = heigh * heigh;

                BMI = double.Parse(weight) / hh;

                // 判斷BMI

                if (BMI < 16.5)
                {
                    result = "免役體位";
                }

                else if (16.5 <= BMI && BMI < 17)
                {
                    result = "替代役體位";
                }

                else if (17 <= BMI && BMI <= 31)
                {
                    result = "常備役體位";
                }
           
                else if (31 < BMI && BMI <= 31.5)
                {
                    result = "替代役體位";
                }

                else if (31.5 < BMI)
                {
                    result = "免役體位";
                }

                // 輸出
                Console.WriteLine("您的BMI值是: {0:00} 您的體位是： {1}", BMI, result);

                Console.ReadKey();
            }

        }
    }
}
    