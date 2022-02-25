using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOORSE
{
    internal class Horse 
    {
        public int horsedistance=0;
        private Random random; //난수 생성용 변수
        public string horsename;
        

        
        public int RandomRunning()
        {
            random = new Random(); //난수 생성용 인스턴스
            int DIStance = random.Next(10, 20 +1); //10~ 20중 랜덤한 정수
                        
            //Console.WriteLine($"Distance : {DIStance}"); 
            //Horse클래스에 작성하면 랜덤으로 나오는 정수 10~20의 정수만 콘솔에 출력
            //실제로 더해지는 값을 출력하기 위해선 program클래스에 하는게 맞음
            
            return DIStance;
        }        
        
    }    
}
