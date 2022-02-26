using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dictionary와 //i는 int형, tileinfo_star은 TileInfo_star형으로 다름 질문

namespace DiceGame
{
    //TileMap(맵을 세팅하고 맵에대한 정보를 가지고 있을 클래스)
    //게임 시작시 맵을 생성하고 (칸들 생성) 맵에 대한 정보를 가지고 있을 클래스
    internal class TileMap
    {
        public Dictionary<int, TileInfo> dic_map = new Dictionary<int, TileInfo>(); //함수 내에 말고 멤버로 만듬
        //부모클래스를 상속받음. override로 int형과 TileInfo형으로 동시에 저장이 가능하다 
        //Dictonary의 mapInfo에 저장할것
        //객체를 인스턴스화 시킬때 부모를 인스턴스화가능하다, 한 Dictionary에 넣을 수 있다.

        public void MapSetup(int maxTileNum) //칸을 몇개만들지를 입력받아서 만드는 함수
        {

            for (int i = 1; i <= maxTileNum; i++)
            {
                //TileInfo를 인스턴스화 반복할 것, 칸 maxTileNum개수만큼 만들기
                //5배수칸일경우 TileInfo_star로 만들어야함 (샛별칸)
                if (i % 5 == 0) //index번호가 0부터 시작하기때문에 i+1로, 0번째 칸은 샛별칸으로 포함하지않음
                {
                    TileInfo_star tileinfo_star = new TileInfo_star();
                    tileinfo_star.index = i;
                    tileinfo_star.name = "Star";
                    tileinfo_star.discription = "This is star tile";
                    dic_map.Add(i, tileinfo_star); //i는 int형, tileinfo_star은 TileInfo_star형으로 다름
                }
                else //5배수 아닌 칸은 Tileinfo로 생성
                {
                    TileInfo tileinfo = new TileInfo();
                    tileinfo.index = i; //0번 ~ maxTileNum-1 생성
                    tileinfo.name = "Dummy";
                    tileinfo.discription = "This is dummy tile";
                    dic_map.Add(i, tileinfo);
                }
            }
            Console.WriteLine($"Maps setup complete. Max tile num : {maxTileNum}");
        }
    }
}