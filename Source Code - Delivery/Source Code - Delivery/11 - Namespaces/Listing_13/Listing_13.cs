using BillingSystem;
using OrderSystem;

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
            BillingSystem.Product p1 = new BillingSystem.Product();
            OrderSystem.Product p2 = new OrderSystem.Product(); 
        }
    }
}