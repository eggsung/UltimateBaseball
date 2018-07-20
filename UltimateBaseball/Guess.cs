﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBaseball
{
    class Guess : Foo
    {
        protected override string GetShowText()
        {
           return "> 공격수가 고른 숫자";
        }
        public void Input()
        {
            _numbers = new int[3];
            string[] inputMessages = {
                "> 첫 번째 숫자를 입력하시오.",
                "> 두 번째 숫자를 입력하시오.",
                "> 세 번째 숫자를 입력하시오." };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(inputMessages[i]);
                _numbers[i] = int.Parse(Console.ReadLine());
            }
        }

       
        public bool IsInvaild()
        {
            return _numbers[0] == _numbers[1] || _numbers[0] == _numbers[2] || _numbers[1] == _numbers[2];
        }

    }
}
