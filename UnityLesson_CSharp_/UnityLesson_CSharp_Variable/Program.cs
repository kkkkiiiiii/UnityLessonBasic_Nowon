using System;

namespace UnityLesson_CSharp_Variable
{
    class Person
    {
        // 나이(정수형), 키(부동소숫점형), 여자인가?(논리형), 성별 문자(문자형), 이름(문자열형)   
        // 필드 : 자료형, 변수이름(대소문자 구분)으로 구성
        int age;
        float height;
        bool isShe;
        char genderChar;
        string name;
        // Person 클래스의 멤버 변수 ( 멤버 변수 )

        // bit (비트) 한 자리 이진수 (0과 1, 정보처리의 최소 단위)
        // 1byte (바이트) = 8bit ( CPU의 데이터 처리 최소 단위 )
        // 4byte = 4 * 8bit = 32bit  2^(32)표현 가능
        // bool 1byte 논리 (모든 bit가 0일때 거짓), char 1byte, int 4byte정수, float 4byte실수, string (문자수 * 2byte)
        // bool 1byte 논리: 참, 거짓구분을 위해 1bit처리가능하지만 cpu처리방식을 따라가 1byte의 크기를 가진다.
        // double 8byte 실수, long 8byte 정수
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
        }
    }
}
