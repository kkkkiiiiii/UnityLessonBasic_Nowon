using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
                                    //Creature가 부모클래스가 되는 것
    internal class Human : Creature ,ITwoLeggedWalker//Human은 Creature에 대한 모든 변수들을 상속받음 
    {
        public float height;
        public float heightGrowthSpeed = 0.00003f;
        public float weightGrowthSpeed = 0.00002f;
        

        // overrride : 부모의 virtual 키워드가 붙은 함수를 재정의 하는 키워드
        public override void Breath() //재정의된 Breath
        {
            base.Breath(); // base -> Creature을 말하는것
            height += 0.00004f;
            weight += 0.00002f;
            //height += heightGrowthSpeed; 이런 식으로 하면 자식class에서 override할 필요없이
            //weight += weightGrowthSpeed; 멤버 변수에 접근해 초기화후 바꿔서 참조할 수 있다. 
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }
}
