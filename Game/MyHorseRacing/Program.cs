using System;
using System.Collections.Generic; //List사용
using System.Threading;  //Thread.Sleep 사용ㅇ

namespace MyRacingHorse
{
    internal class Program
    {
        private static List<string> ranklist = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("다섯마리의 말 생성 !");
            List<Horse> horses = new List<Horse>();
            for (int i = 0; i < 5; i++)
            {
                Horse tmphorses = new Horse(); //말 인스턴스화
                horses.Add(tmphorses);
                horses[i].horsename = $"{i + 1}번 말";
            }

            Console.WriteLine("시작하려면 엔터를 누르세요");
            Console.ReadLine();
            Console.WriteLine("경주 시작~");
            int count = 0;

            while (horses.Count > 0)
            {
                Thread.Sleep(1000);
                count++;
                Console.WriteLine($"=============={count}초==============");
                for (int i = 0; i < 5; i++)
                {
                    if (horses[i].horsedistance < 200)
                    {
                        horses[i].horsedistance += horses[i].RandomRunning();
                        if (horses[i].horsedistance < 200)
                        {
                            Console.WriteLine($" {horses[i].horsename}");
                            Console.WriteLine($" {horses[i].horsedistance}");
                        }
                        else if (horses[i].horsedistance >= 200)
                        {
                            Console.WriteLine($"{horses[i].horsename} 도착");

                            if (horses[i].IsFinished == false)
                            {
                                ranklist.Add(horses[i].horsename);
                                horses[i].IsFinished = true;
                            }
                        }
                    }
                }
                Console.WriteLine();

                if (horses[0].horsedistance >= 200 && horses[1].horsedistance >= 200 && horses[2].horsedistance >= 200 &&
                    horses[3].horsedistance >= 200 && horses[4].horsedistance >= 200)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("경기 종료");
                    Console.WriteLine();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{i + 1}위 : {ranklist[i]}");
                    }
                    break;
                }
            }
        }
    }
}
