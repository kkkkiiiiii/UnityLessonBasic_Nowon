using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DiceGame
{
    //TileInfo_Star(샛별칸을 위한 클래스.TileInfo 를
    //상속받고 샛별칸에 대한 특수 정보를 멤버로 추가함)

    internal class TileInfo_star : TileInfo
    {
        public int starValue = 3;

        public override void TileEvent()
        {
            base.TileEvent();
            starValue++;     //starValue가 3, 4, 5 이렇게 증가하면서 증가
        }
    }
}