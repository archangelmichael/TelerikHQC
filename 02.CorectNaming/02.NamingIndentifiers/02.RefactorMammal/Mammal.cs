using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMammal
{
    class Mammal
    {
        enum Gender { Male, Female };

        class Human
        {
            public Gender HumanGender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void CreateHuman(int personID)
        {
            Human adamTheFirstMan = new Human();

            adamTheFirstMan.Age = personID;
            if (personID % 2 == 0)
            {
                adamTheFirstMan.Name = "Adam";
                adamTheFirstMan.HumanGender = Gender.Male;
            }
            else
            {
                adamTheFirstMan.Name = "Eve";
                adamTheFirstMan.HumanGender = Gender.Female;
            }
        }

    }
}
