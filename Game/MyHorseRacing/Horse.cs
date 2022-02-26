using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRacingHorse
{
    internal class Horse : Program
    {
        public bool IsFinished=false;
        private Random random;
        public int horsedistance=0;
        public string horsename;

        public int RandomRunning()
        {
            random = new Random();
            int Distance = random.Next(10, 20 + 1);
            return Distance;

        }
    }
}

/* List로 Horse형 5마리 말 만들기
 *List<Horse> horses = new List<Horse>();
 *for(int i=0; i<5;i++)
 *{
 *Horse tmphorses = new Horse();
 *horses.Add(tmphorses);
 *horses[i].horsename=$"{i+1}번 말"
 *
 *int count=0;
 *반복실행 
 *While(horses.Count>0)
 *{
 *Thread.Sleep(1000);
 *count++;
 *Console.WriteLine($"======={count}초======="};
 *for(int i=0; i<5; i++)
 *{
 * if(horses[i].horsedistance<200)
 *   {
 *   horses[i].horsedistance+=horses[i].RandomRunning();
 *   }
 *   if(horses[i].horsedistance<200)
 *     {
 *     Console.WriteLine($"{horses[i].horsename}");
 *     Console.WriteLine($"{horses[i].horsedistance}");
 *     }else if (horses[i].horsedistance>=200)
 *     {
 *     Console.WriteLine($"{horses[i].horsename}도착");
 *         if(horses[i].IsFinished==false)
 *         {
 *         ranklist[i].Add(horses[i].horsename);
 *         horses[i].IsFinished=true;
 *         }
 *     }
 *     
 *     
 *}
 *
 *}
*/