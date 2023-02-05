using System;

namespace PersonClass
{
    class Person
    {
        public string fullName;
        public int age;

        public Person()
        {
            fullName = "Brat Bratan";
            age = 0;
        }

        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }

        public void move()
        {
            Console.WriteLine("Человек " + fullName + " движется");
        }

        public void talk()
        {
            Console.WriteLine("Человек " + fullName + " говорит");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Bratishka Bratan", 30);

            person1.move();
            person1.talk();

            person2.move();
            person2.talk();

            Console.ReadLine();
        }
    }
}