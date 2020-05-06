using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.Write("개");
                    break;
                case 3:
                    Console.Write("돼지");
                    break;
                case 4:
                    Console.Write("쥐");
                    break;
                case 5:
                    Console.Write("소");
                    break;
                case 6:
                    Console.Write("호랑이");
                    break;
                case 7:
                    Console.Write("토끼");
                    break;
                case 8:
                    Console.Write("용");
                    break;
                case 9:
                    Console.Write("뱀");
                    break;
                case 10:
                    Console.Write("말");
                    break;
                case 11:
                    Console.Write("양");
                    break;
                case 0:
                    Console.Write("원숭이");
                    break;
                default:
                    Console.Write("다시 입력하세요");
                    break;
            }
        }
    }
}
