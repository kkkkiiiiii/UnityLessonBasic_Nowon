using System;
using System.Collections.Generic; //List로 하기 위해
//상속과 다형성, 오버라이드, 인터페이스
namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();            
            for(int i = 0; i < 10; i++)
            {
                creature.Breath();
            }
            Console.WriteLine(creature.age);

            Human human = new Human();
            for (int i = 0; i < 10; i++)
            {
                human.Breath();
            }
            Console.WriteLine(human.age);
            Console.WriteLine($"height { human.height}, weight : {human.weight}");

            BlackPerson blackperson = new BlackPerson();
            YellowPerson yellowperson = new YellowPerson();
            WhitePerson whiteperson = new WhitePerson();


            for (int i = 0; i < 10; i++)
            {
                blackperson.Breath();
                yellowperson.Breath();
                whiteperson.Breath();
            }
            Console.WriteLine($"The Black  height {blackperson.height}, weight {blackperson.weight}");            
            Console.WriteLine($"The Yellow height {yellowperson.height}, weight {yellowperson.weight}");             
            Console.WriteLine($"The White  height {whiteperson.height}, weight {whiteperson.weight}");



            Dog dog = new Dog();
            dog.tailLength = 1f;

            //각 인종 20명, 두 발로 걷기
            List<WhitePerson> whitePeople = new List<WhitePerson>();
            List<BlackPerson> blackPeople= new List<BlackPerson>();
            List<YellowPerson> yellowPeople = new List<YellowPerson>();
            for (int i = 0; i < 20; i++)
            {
                WhitePerson tmpMan = new WhitePerson();
                whitePeople.Add(tmpMan);
            }
            for (int i = 0; i < 20; i++)
            {
                BlackPerson tmpMan = new BlackPerson();
                blackPeople.Add(tmpMan);
            }
            for (int i = 0; i < 20; i++)
            {
                YellowPerson tmpMan = new YellowPerson();
                yellowPeople.Add(tmpMan);
            }
            foreach (var item in whitePeople)
            {
                item.TwoLeggedWalk();
            }
            foreach (var item in blackPeople) 
            {
                item.TwoLeggedWalk();
            }
            foreach (var item in yellowPeople)
            {
                item.TwoLeggedWalk();
            }

            Human testHuman = new WhitePerson(); //WhitePerson을 Human으로 인스턴스화했다. WhitePerson객체를 Human으로 객체화했다.
            testHuman.Breath(); //Human클래스의 Breath(); 일것이다.
            Console.WriteLine($"{testHuman.height} {testHuman.weight}"); //어떤 Breath();가 나올까?
        }
    }
}
