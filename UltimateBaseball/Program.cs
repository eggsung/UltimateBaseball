using System;

namespace UltimateBaseball
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //환영 메시지 출력 (splash screen)
            ShowWelcomeMessage();

            // 랜덤한 정답을 생성한다.
            int[] answers = GenerateAnswers();

            int[] guesses = new int[3];
            string[] inputMessages = { "> 첫 번째 숫자를 입력하시오.", "> 두 번째 숫자를 입력하시오.", "> 세 번째 숫자를 입력하시오." };
            
            while (true)
            {
                // 추측을 입력받는다.
                InputGuesses(guesses, inputMessages);

                // 입력받은 추측을 출력한다.
                ShowGuesses(guesses);

                // 추측의 유효성을 검사한다.
                if (IsInvaildGuesses(guesses))
                {
                    Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
                    continue;
                }

                // 결과을 계산한다.
                Result result = CalculateResult(answers, guesses);

                // 결과를 출력한다.
                ShowResult(result);
 
                // 정답이면 게임을 끝낸다.
                if (result.Strike == 3)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
