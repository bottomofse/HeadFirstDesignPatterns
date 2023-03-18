using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Factory
{
    abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
        public abstract Pizza createPizza(string type);
    }

    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza? pizza = null;
            PizzaIngredientFactory factory = new NYPizzaIngredientFactory();

            if (type.Equals("チーズ"))
            {
                pizza = new NYStyleCheesePizza(factory);
                pizza.setName("ニューヨークスタイルチーズピザ");
            }
            else if (type.Equals("ペパロニ"))
            {
                //pizza = new NYStylePepperoniPizza();
            }
            else if (type.Equals("クラム"))
            {
                //pizza = new NYStyleClamPizza();
            }
            else if (type.Equals("野菜"))
            {
                //pizza = new NYStyleVeggiePizza();
            }
            return pizza;
        }
    }
    /*
    class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza? pizza = null;
            PizzaIngredientFactory factory = new California
            if (type.Equals("チーズ"))
            {
                pizza = new CaliforniaCheesePizza();
            }
            else if (type.Equals("ペパロニ"))
            {
                //pizza = new CaliforniaPepperoniPizza();
            }
            else if (type.Equals("クラム"))
            {
                //pizza = new CaliforniaClamPizza();
            }
            else if (type.Equals("野菜"))
            {
                //pizza = new CaliforniaVeggiePizza();
            }
            return pizza;
        }
    }
    */
    /*
    class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("チーズ"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("ペパロニ"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("クラム"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("野菜"))
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }*/


    abstract class Pizza
    {
        protected string name { get; set; }
        protected Dough dough { get; set; }
        protected Sauce sauce { get; set; }

        protected List<Veggy> veggies { get; set; } = new List<Veggy>();
        protected Cheese cheese { get; set;}
        protected Pepperoni pepperoni { get; set; }
        protected Clam clam { get; set; }
        abstract public void prepare();

        public void bake()
        {
            Console.WriteLine("350度で25分焼く");
        }
        public void cut()
        {
            Console.WriteLine("ピザを扇形に切り分ける");
        }
        public void box()
        {
            Console.WriteLine("PizzaStoreの正式な箱にピザを入れる");
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getNmae()
        {
            return name;
        }
    }

    class NYStyleCheesePizza : Pizza
    {
        private PizzaIngredientFactory factory;
        public NYStyleCheesePizza(PizzaIngredientFactory factory)
        {
            this.factory = factory;
            name = "ニューヨークスタイルのソース＆チーズピザ";
        }
        public override void prepare()
        {
            Console.WriteLine(name + "をした処理");
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            veggies = factory.createVeggies();
            pepperoni = factory.createPepperoni();
            clam = factory.createClam();
        }
    }

    class CaliforniaCheesePizza : Pizza
    {
        private PizzaIngredientFactory factory;
        public CaliforniaCheesePizza(PizzaIngredientFactory factory)
        {
            this.factory = factory;
            name = "カリフォルニアスタイルのディープディッシュチーズピザ";
        }

        public void cut()
        {
            Console.WriteLine("ピザを四角形に切り分ける");
        }

        public override void prepare()
        {
            Console.WriteLine(name + "をした処理");
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            veggies = factory.createVeggies();
            pepperoni = factory.createPepperoni();
            clam = factory.createClam();
        }
    }

    interface PizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public List<Veggy> createVeggies();
        public Pepperoni createPepperoni();
        public Clam createClam();
    }

    class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggy> createVeggies()
        {
            return new List<Veggy>(){new Garlic(), new Onion(), new Mashroom(), new RedPepper()};
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clam createClam()
        {
            return new FreshClam();
        }

        class California : PizzaIngredientFactory
        {
            public Dough createDough()
            {
                return new ThickCrustDough();
            }
            public Sauce createSauce()
            {
                return new PlamTomatoSauce();
            }
            public Cheese createCheese()
            {
                return new Mozzarella();
            }
            public List<Veggy> createVeggies()
            {
                return new List<Veggy>() { new BlackOlives(), new Spinach(), new EggPlant()};
            }
            public Pepperoni createPepperoni()
            {
                return new SlicedPepperoni();
            }
            public Clam createClam()
            {
                return new FrozenClam();
            }
        }

    }

    interface Dough
    {
    }
    class ThinCrustDough : Dough { }
    class ThickCrustDough : Dough { }

    interface Sauce
    {
    }
    class MarinaraSauce : Sauce { }
    class PlamTomatoSauce : Sauce { }

    interface Cheese
    {
    }
    class ReggianoCheese : Cheese { }
    class Mozzarella : Cheese { }

    interface Veggy
    {
    }
    class Garlic : Veggy { }
    class Onion : Veggy { }
    class Mashroom : Veggy { }
    class RedPepper : Veggy { }
    class BlackOlives : Veggy { }
    class Spinach : Veggy { }
    class EggPlant : Veggy { }

    interface Pepperoni
    {
    }
    class SlicedPepperoni : Pepperoni { }
    
    interface Clam
    {
    }
    class FreshClam : Clam { }
    class FrozenClam : Clam { }
}
