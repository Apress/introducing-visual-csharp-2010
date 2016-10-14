
namespace DataApp.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies EmployeeMetadata as the class
    // that carries additional metadata for the Employee class.
    [MetadataTypeAttribute(typeof(Employee.EmployeeMetadata))]
    public partial class Employee {

        // This class allows you to attach custom attributes to properties
        // of the Employee class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class EmployeeMetadata {

            // Metadata classes are not meant to be instantiated.
            private EmployeeMetadata() {
            }

            public string Address { get; set; }

            public Nullable<DateTime> BirthDate { get; set; }

            public string City { get; set; }

            public string Country { get; set; }

            public Employee Employee1 { get; set; }

            public int EmployeeID { get; set; }

            public EntityCollection<Employee> Employees1 { get; set; }

            public string Extension { get; set; }

            public string FirstName { get; set; }

            public Nullable<DateTime> HireDate { get; set; }

            public string HomePhone { get; set; }

            public string LastName { get; set; }

            public string Notes { get; set; }

            public EntityCollection<Order> Orders { get; set; }

            public byte[] Photo { get; set; }

            public string PhotoPath { get; set; }

            public string PostalCode { get; set; }

            public string Region { get; set; }

            public Nullable<int> ReportsTo { get; set; }

            public EntityCollection<Territory> Territories { get; set; }

            public string Title { get; set; }

            public string TitleOfCourtesy { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies OrderMetadata as the class
    // that carries additional metadata for the Order class.
    [MetadataTypeAttribute(typeof(Order.OrderMetadata))]
    public partial class Order {

        // This class allows you to attach custom attributes to properties
        // of the Order class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class OrderMetadata {

            // Metadata classes are not meant to be instantiated.
            private OrderMetadata() {
            }

            public Customer Customer { get; set; }

            public string CustomerID { get; set; }

            public Employee Employee { get; set; }

            public Nullable<int> EmployeeID { get; set; }

            public Nullable<decimal> Freight { get; set; }

            public EntityCollection<Order_Detail> Order_Details { get; set; }

            public Nullable<DateTime> OrderDate { get; set; }

            public int OrderID { get; set; }

            public Nullable<DateTime> RequiredDate { get; set; }

            public string ShipAddress { get; set; }

            public string ShipCity { get; set; }

            public string ShipCountry { get; set; }

            public string ShipName { get; set; }

            public Nullable<DateTime> ShippedDate { get; set; }

            public Shipper Shipper { get; set; }

            public string ShipPostalCode { get; set; }

            public string ShipRegion { get; set; }

            public Nullable<int> ShipVia { get; set; }
        }
    }
}
