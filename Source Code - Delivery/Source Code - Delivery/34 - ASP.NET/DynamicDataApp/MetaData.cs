using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DynamicDataApp {

    [DisplayName("Sales Staff")]
    [ScaffoldTable(true)]
    public class EmployeeMetaData {

        [ScaffoldColumn(false)]
        public object BirthDate { get; set; }

        [DisplayName("First Name")]
        public object FirstName { get; set; }

        [DisplayName("Last Name")]
        public object LastName { get; set; }
    }

    [ScaffoldTable(true)]
    public class OrderMetaData {
    }

    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee {
    }

    [MetadataType(typeof(OrderMetaData))]
    public partial class Order {
    }
}