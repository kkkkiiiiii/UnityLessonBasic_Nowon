using System;

namespace UnityLesson_CSharp_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");            

            PrintHelloWorld();

            PrintSomething("aaa");  //소괄호 안 내용 - 매개변수(parameter)
            bool tmpIsFinished = false;  //tmp 임시의
            tmpIsFinished = PrintSomethingAndReturnIsFinished("bbbbbb");
            Console.WriteLine(tmpIsFinished);
        }
        //반환형 함수이름(인자 자료형 인자이름, 인자자료형 인자이름 ..)

        /*{
             함수 연산 내용
             retrun 반환할 내용
        }*/

        //인자x, 반환x
        //Main함수가 static(정적)으로 정의, 함수 호출하기 위해선 호출할 함수도 static으로 선언되어야 한다.
        static void PrintHelloWorld()  
        {
            Console.WriteLine("Hello World!!!");            
        }

        //인자 0, 반환 x
        static void PrintSomething(string something) //여기 소괄호 안 내용- 인자, Main함수로 부터 문자열 'aaa'를 파라미터(매개변수)로 받음
        {
            Console.WriteLine(something);
        }
        //인자 0, 반환 0
        static bool PrintSomethingAndReturnIsFinished(string something)
        {
            bool isFinished = false;  //변수가 함수안에서 정의된다. (지역변수) 함수 내에서만 연산
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;
        }
    }
}
