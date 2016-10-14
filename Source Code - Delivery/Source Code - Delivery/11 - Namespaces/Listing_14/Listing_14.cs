using BillingSystem;
using OrderSystem;
using BillingProduct = BillingSystem.Product;
using OrderProduct = OrderSystem.Product;

namespace AuditSystem {

    class Audit {

        public static void Main(string[] args) {

            // create a new instance of a type from 
            // the BillingSystem namespace
            Bill b = new Bill();

            // create a new instance of a type from 
            // the OrderSystem namespace
            Order o = new Order();

            // create instances of each of the Product classes
            BillingProduct p1 = new BillingProduct();
            OrderProduct p2 = new OrderProduct();
        }
    }
}