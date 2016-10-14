
namespace DataApp.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the NorthwindEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class EmployeeDomainServices : LinqToEntitiesDomainService<NorthwindEntities> {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Employees' query.
        public IQueryable<Employee> GetEmployees() {
            return this.ObjectContext.Employees;
        }

        public void InsertEmployee(Employee employee) {
            if ((employee.EntityState != EntityState.Detached)) {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(employee, EntityState.Added);
            } else {
                this.ObjectContext.Employees.AddObject(employee);
            }
        }

        public void UpdateEmployee(Employee currentEmployee) {
            this.ObjectContext.Employees.AttachAsModified(currentEmployee, this.ChangeSet.GetOriginal(currentEmployee));
        }

        public void DeleteEmployee(Employee employee) {
            if ((employee.EntityState == EntityState.Detached)) {
                this.ObjectContext.Employees.Attach(employee);
            }
            this.ObjectContext.Employees.DeleteObject(employee);
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Orders' query.
        public IQueryable<Order> GetOrders() {
            return this.ObjectContext.Orders;
        }

        public void InsertOrder(Order order) {
            if ((order.EntityState != EntityState.Detached)) {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(order, EntityState.Added);
            } else {
                this.ObjectContext.Orders.AddObject(order);
            }
        }

        public void UpdateOrder(Order currentOrder) {
            this.ObjectContext.Orders.AttachAsModified(currentOrder, this.ChangeSet.GetOriginal(currentOrder));
        }

        public void DeleteOrder(Order order) {
            if ((order.EntityState == EntityState.Detached)) {
                this.ObjectContext.Orders.Attach(order);
            }
            this.ObjectContext.Orders.DeleteObject(order);
        }
    }
}


