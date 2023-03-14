using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("すべての鴨は浮かびます。");
        }

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }

    public interface FlyBehavior
    {
        public void fly();
    }

    public class FlyWIthWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("飛んでいます！！");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("飛べません。");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("ロケットで飛んでいます！");
        }

    }

    public interface QuackBehavior
    {
        public void quack();
    }

    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("ガーガー");
        }
    }

    public class MuteQuak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<<沈黙>>");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("キューキュー");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWIthWings();
        }

        override public void display()
        {
            Console.WriteLine("本物のマガモです。");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyNoWay();
        }
        public override void display()
        {
            Console.WriteLine("模型の鴨です。");
        }
    }

}
