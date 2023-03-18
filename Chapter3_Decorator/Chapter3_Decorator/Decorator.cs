using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Decorator
{
    public abstract class Beverage
    {
        protected string description { get; set; } = "不明な飲み物";

        public abstract string getDescription();
        public abstract double cost();

    }

    public abstract class CondimentDecorator : Beverage
    {        
        override public abstract string getDescription();
    }

    //コンポーネント１
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "エスプレッソ";
        }

        public override string getDescription()
        {
            return description;
        }


        override public double cost()
        {
            return 1.99;
        }
    }

    //コンポーネント２
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "ハウスブレンドコーヒー";
        }
        public override string getDescription()
        {
            return description;
        }

        public override double cost()
        {
            return .89;
        }
    }

    //コンポーネント３
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "ダークローストコーヒー";
        }
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 2.01;
        }
    }

    //デコレーター１
    public class Mocha : CondimentDecorator
    {
        protected Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public string getDescription()
        {
            return this.beverage.getDescription() + ", モカ";
        }

        override public double cost()
        {
            return .20 + this.beverage.cost(); 
        }
    }

    //デコレーター２
    public class Soy : CondimentDecorator
    {
        protected Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public string getDescription()
        {
            return beverage.getDescription() + ", 豆乳";
        }

        override public double cost()
        {
            return .33 + beverage.cost();
        }

    }

    //デコレーター３
    public class Whip : CondimentDecorator
    {
        protected Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        override public string getDescription()
        {
            return beverage.getDescription() + ", ホイップ";
        }

        override public double cost()
        {
            return .55 + beverage.cost();
        }
    }

}