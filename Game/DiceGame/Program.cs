using System;
using System.Collections.Generic;

namespace DiceGame
{
    internal class Program
    {

        //static은 초기 세팅, 연산할 때 사용할것은 보통 Main함수에 작성

        //값들이 변할수 있는 것들으 변수로 생성해놓고 바꿀때 수고로움을 덜기위해

        static private int totalTile = 20; //칸의 갯수         
        static private int totalDiceNumber = 20; //총 주사위 갯수        
        static private Random random;

        static void Main(string[] args)
        {
            int previousTileIndex = 0; //이전 칸의 인덱스 : 샛별점수 누적시 이전, 현재 인덱스 사이에 샛별칸있었는지 조사할려고
            int currentTileIndex = 0; //현재 플레이어 위치 인덱스
            int currentStarPoint = 0; //현재 샛별점수
            TileMap map = new TileMap();

            map.MapSetup(totalTile); //맵 생성 
            //주사위 굴릴때마다 주사위 감소

            int currentDiceNum = totalDiceNumber; //초기화

            //주사위 게임 시작, 

            while (currentDiceNum > 0)
            {
                int diceValue = RollADice();
                currentDiceNum--;
                currentTileIndex += diceValue;
                //현재칸이 최대칸을 넘어가버렸을때

                if (currentTileIndex > totalTile)
                {
                    currentTileIndex -= totalTile;
                }

                Console.WriteLine($"현재 플레이어 위치 : {currentTileIndex}");

                //현재 칸의 정보 받아옴

                TileInfo info = map.dic_map.GetValueOrDefault(currentTileIndex); //dic_map가져오고 인덱스입력

                if (info == null) //해당 칸의 정보를 받지 못했다.
                {
                    Console.WriteLine($"Failed to get tileinfo. num : {currentTileIndex}");
                    return; //main함수가 void형인데 return을 사용했다는 것은 즉시반환, 함수를 끝내겠다.라는 의미

                }
                //플레이어가 샛별칸을 지났는지 체크

                if (currentTileIndex / 5 > previousTileIndex / 5)
                {
                    //지나온 샛별칸의 인덱스를 가져오기

                    int passedStarTileIndex = currentTileIndex / 5 * 5;
                    TileInfo_star tileInfo_star = (TileInfo_star)map.dic_map.GetValueOrDefault(passedStarTileIndex);

                    //자식을 부모에 인스턴스화 가능 
                    //부모를 자식에 인스턴스화 불가능 - 강제로 캐스팅해서 함 (형변환) ~~~ as TileInfo_star 도 캐스팅

                    if (tileInfo_star != null)
                    {
                        currentStarPoint += tileInfo_star.starValue; //starValue사용할 수 있는 것은 TileIfro_star로 강제 캐스팅했기때문
                    }

                }
                info.TileEvent(); //칸의 이벤트 호출


                previousTileIndex = currentTileIndex; //다음 주사위 던지기전에 이전인덱스에 저장
                Console.WriteLine($"현재 샛별 점수 : {currentStarPoint}");
                Console.WriteLine($"남은 주사위 : {currentDiceNum}");
            }
            Console.WriteLine($"Game Finished ! You got total {currentStarPoint} stars");

        }

        static int RollADice() //int 반환형
        {

            //엔터키 입력 - 난수생성 - DisplayDice로 주사위출력 - diceValue 리턴 - 남은주사위갯수 차감
            // - 플레이어 주사위눈금만큼 전진
            string userInput = "Default";

            while (userInput != "")  //사용자가 enter입력 외에 입력시 while 계속 반복
            {
                Console.WriteLine(" Roll a dice ! Press enter");
                userInput = Console.ReadLine();
            }

            random = new Random(); //인스턴스화
            int diceValue = random.Next(1, 7);
            Console.WriteLine($"DiceValue : {diceValue}");
            DisplayDice(diceValue);
            return diceValue;

        }
        static void DisplayDice(int DiceValue) //주사위 모양 출력
        {
            switch (DiceValue)

            {

                case 1:

                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("└───────────┘");

                    break;

                case 2:

                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");

                    break;

                case 3:

                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");

                    break;

                case 4:

                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");

                    break;

                case 5:

                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");

                    break;

                case 6:

                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");

                    break;

                default:

                    break;

            }
        }

    }

}