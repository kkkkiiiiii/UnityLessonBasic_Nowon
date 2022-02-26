using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    //TileInfo(각 칸들의 정보를 멤버로 가지는 클래스)

    internal class TileInfo
    {
        public int index; //몇번째 칸인지에 대한 정보
        public string name;
        public string discription; //해당칸이 어떤 칸인지 출력할 때 사용

        //해당 칸 도착할 때마다 Main함수에서 사용하는것보다
        //TileInfo의 멤버함수에 접근해서 정보출력하는게 유리

        public virtual void TileEvent()
        {
            Console.WriteLine($"Tile number : {index}, The player is On {name}, {discription}");

        }

    }

}
