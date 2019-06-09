using System;

namespace shapes
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw Shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Cicle");
        }
    }
}
namespace abShapes
{
    abstract class aShape
    {
        protected string name;
        public abstract void Draw();
        public void getName()
        {
            Console.WriteLine("my name");
        }
        public aShape(string name)
        {
            this.name = name;
        }
    }
    class aCircle : aShape
    {
        public aCircle(string name) : base(name)
        {
            //WORK BOTH
            this.name = name + "baseaddedasdsa";
            // base.name = name + "baseadded";
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Abstract Circle: " + this.name);
        }
    }
}