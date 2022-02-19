using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Dog :Creature, IFourLeggedWalker
    {
        public float tailLength;

        public void FourLeggedWalk()
        {
            Console.WriteLine("네 발로 걷는다");
        }
    }
   
}
