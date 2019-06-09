using System;

namespace person
{

    class Person<T>
    {

        public T name; //field
        private static int code = 222;
        public int child;
        public int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 10)
                    age = value;
            }
        }
        public Person(T name)
        {
            age = 1;
            this.name = name;
        }
        public T Name //property
        {
            get { return name; }
            set { name = value; }
        }

        public void Alert()
        {
            Console.WriteLine("My name is " + name);
        }
    }
}