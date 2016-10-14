using B = BillingSystem;
using O = OrderSystem;

namespace AuditSystem {

    class Audit {

        public static void Main(string[] args) {

            // create a new instance of a type from 
            // the BillingSystem namespace
            B.Bill b = new B.Bill();

            // create a new instance of a type from 
            // the OrderSystem namespace
            O.Order o = new O.Order();

            // create instances of each of the Product classes
            B.Product p1 = new B.Product();
            O.Product p2 = new O.Product();
        }
    }
}