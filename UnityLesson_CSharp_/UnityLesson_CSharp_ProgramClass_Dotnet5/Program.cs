//파란색 글자 : 키워드, 예약어

//using
//1. 미리 짜여진 코드 덩어리
//2. 우선순의 차순위인 함수를 일반적으로 호출할 때
using System;

// namespace 키워드
// 클래스간의 이름 충돌을 방지하면서 코드를 한 공간으로 묶는 기능.
namespace UnityLesson_CSharp_ProgramClass_Dotnet5 /*프로젝트이름*/
{
    //Main 함수가 Program 클래스 안에 들어있는 이유
    //객체지향프로그래밍 컨셉을 지키기 위함
    internal class Program
    {
        //Main함수 
        //.exe (실행 파일) 을 실행하면 제일 처음 호출되는 함수

        //static(정적) <-> dynamic(동적)
        //소프트웨어에서 메모리에 할당이 가능한 지 여부로 구분
        //static정의하면 유일무이한 개념이된다.

        //void : '아무것도 없음' 을 뜻한다.
        //함수에서는 반환형이 없다.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
