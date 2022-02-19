using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Creature
    {
        //기본적으로 private적용, 다른 클래스에서 참조해야 할 경우에만 public을 사용해야한다.
        public string DNA;
        public float age;
        public float weight;


        //함수 오버라이드 숨쉴때마다 키, 몸무게 증가하는 코드 추가하고싶다 새로 만들수없다.
        //부모클래스의 모든 멤버 변수에 virtual을 사용하는 것 아님. 정말 필요한 경우만 사용
        //재정의필요성이 있는 경우에만 사용

        // virtual 키워드: 해당 함수를 오버라이딩 가능하도록 해준다.

        virtual public void Breath() //숨쉴때 마다 나이 증가
        {
            age++;
        }
    }
}
