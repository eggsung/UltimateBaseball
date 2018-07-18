﻿using System;

namespace UltimateBaseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-------------------------------------------------------+");
			Console.WriteLine("|\t\t궁극의 숫자 야구 게임\t\t\t|");
			Console.WriteLine("+-------------------------------------------------------+");
			Console.WriteLine("| 컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다.\t|");
            Console.WriteLine("| 각 숫자는 0~9 중에 하나며 중복되는 숫자는 없습니다.\t|");
            Console.WriteLine("| 모든 숫자와 위치를 맞히면 승리합니다.\t\t\t|");
            Console.WriteLine("| 숫자와 순서가 둘 다 맞으면 스트라이크입니다.\t\t|");
			Console.WriteLine("| 숫자만 맞고 순서가 틀리면 볼입니다.\t\t\t|");
			Console.WriteLine("| 숫자가 틀리면 아웃입니다.\t\t\t\t|");
			Console.WriteLine("+-------------------------------------------------------+");

			Console.WriteLine("> 수비수가 고른 숫자");
			int number1 = 3;
			int number2 = 1;
			int number3 = 9;
			Console.WriteLine(number1);
			Console.WriteLine(number2);
			Console.WriteLine(number3);

			Console.WriteLine("> 첫 번째 숫자를 입력하시오.");
			int guess1 = int.Parse(Console.ReadLine());
			Console.WriteLine("> 두 번째 숫자를 입력하시오.");
			int guess2 = int.Parse(Console.ReadLine());
			Console.WriteLine("> 세 번째 숫자를 입력하시오.");
			int guess3 = int.Parse(Console.ReadLine());

			Console.WriteLine("> 공격수가 고른 숫자");
			Console.WriteLine(guess1);
			Console.WriteLine(guess2);
			Console.WriteLine(guess3);

            if (guess1 == guess2 || guess2 == guess3 || guess1 == guess3)
            {
                Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
            }
            else
            {
                int strikeCount = 0;
                int ballCount = 0;
                // 첫 번째 숫자 비교
                if (guess1 == number1)
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess1 == number2 || guess1 == number3)
                {
                    ballCount = ballCount + 1;
                }

                // 두 번째 숫자 비교
                if (guess2 == number2)
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess2 == number1 || guess2 == number3)
                {
                    ballCount = ballCount + 1;
                }

                //세 번째 숫자 비교
                if (guess3 == number3)
                {
                    strikeCount = strikeCount + 1;
                }
                else if (guess3 == number1 || guess3 == number2)
                {
                    ballCount = ballCount + 1;
                }

                Console.WriteLine("스트라이크:  ");
                Console.WriteLine(strikeCount);
                Console.WriteLine("볼:  ");
                Console.WriteLine(ballCount);
                Console.WriteLine("아웃:  ");
                Console.WriteLine(3 - strikeCount - ballCount);
            }
        }
    }
}
