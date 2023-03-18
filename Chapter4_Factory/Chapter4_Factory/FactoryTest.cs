using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Factory
{
    class FactoryTest
    {
        public static void exec()
        {
            PizzaStore nyStore = new NYPizzaStore();
            //PizzaStore CaliStore = new CaliforniaPizzaStore();

            Pizza pizza = nyStore.orderPizza("チーズ");
            Console.WriteLine("イーサンの注文は" + pizza.getNmae());
            Console.WriteLine("");
            //pizza = CaliStore.orderPizza("チーズ");
            //Console.WriteLine("ジョエルの注文は" + pizza.getNmae());
        }

    }
}
