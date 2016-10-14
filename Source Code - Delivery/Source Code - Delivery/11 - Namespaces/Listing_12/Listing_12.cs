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

            // create a new instance of the Product class
            Product p = new Product();
        }
    }
}