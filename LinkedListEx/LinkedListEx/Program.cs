using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Customer customer = new Customer();
            List<Customer> list = new List<Customer>();
            /*
                        var finalresults = from customer in getAllCustomers()
                                           group customer by customer.City into k
                                           select new { City = k.Key, count = k.Count() };

                        foreach (var item in finalresults)
                        {
                            Console.WriteLine($"In city {item.City} there is {item.count} no of Customer");
                        }
            */
            /*var customerOrders = from customer in getAllCustomers()
                                 join
                                  order in getAllOrders()
                                 on customer.customerId equals order.customerId
                                 select new { CustomerId = customer.customerId,
                                 OrderId=order.OrderId ,OrderDate=order.OrderDate,deliveryDate=order.RequiredDate,quantity=order.Quantity,Cust_Name=customer.Name};
            foreach (var customer in customerOrders)
            {
                Console.WriteLine($"customer {customer.Cust_Name} has placed the order on {customer.OrderDate} with the orderId {customer.OrderId} ,deliver date is {customer.deliveryDate} with the quantity {customer.quantity}");


            }*/
            /* var productOrder = from customer in getAllCustomers()
                                join
                                order in getAllOrders()
                                on customer.customerId equals order.customerId
                                join
                               product in getAllProducts()
                               on order.productId equals product.productId
                                select new { CustonerId = customer.customerId, OrderDate=order.OrderDate,deliveryDate=order.RequiredDate,Quantity=order.Quantity,orderId=order.OrderId,Cust_name=customer.Name,ProductName=product.ProductName ,
                                    productId=product.productId,totalprice=order.Quantity*product.UnitPrice};

             foreach (var item in productOrder)
             {
                 Console.WriteLine($"customer {item.Cust_name} has placed the order on {item.OrderDate} with order id {item.orderId} deliver date is {item.deliveryDate} total price is {item.totalprice} for product {item.ProductName} and product id is {item.productId} with the quantity { item.Quantity}");
             }*/

            var EmpOrderShift = from customer in getAllCustomers()
                                join
                                order in getAllOrders()
                                on customer.customerId equals order.customerId
                                join
                                product in getAllProducts()
                                on order.productId equals product.productId
                                join
                                emp in getAllEmployee()
                                on order.EmpId equals emp.EmployeeId
                                select new { empName=emp.EmployeeName,empId=emp.EmployeeId,productId=product.productId,productName=product.ProductName};
            foreach (var emp in EmpOrderShift) {
                Console.WriteLine($"Employee { emp.empName} has employee id is {emp.empId} placed product id is {emp.productId} of product {emp.productName}");

            }



            Console.ReadKey();
          
        }
        private static List<Customer> getAllCustomers()
        {
            return new List<Customer>()
                {
                    new Customer() {customerId =1,Name="Neha",City="pune" },
                      new Customer() {customerId =2,Name="Archana",City="pune" },
                        new Customer() {customerId =3,Name="Minal",City="Mumbai" },
                          new Customer() {customerId=4,Name="nikita",City="Mumbai" },
                            new Customer() {customerId=5,Name="Priya",City="Thule" }

                };
        }

        private static List<Order> getAllOrders()
        {
            return new List<Order>() { 
                new Order(){OrderId=1,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=3,customerId=1,productId=1,EmpId=1},
                 new Order(){OrderId=2,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=4,customerId=1,productId=2,EmpId= 1},
                 new Order(){OrderId=3,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=3,customerId=2,productId=2,EmpId=2},
                 new Order(){OrderId=4,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=5,customerId=2,productId=3,EmpId=3},
                 new Order(){OrderId=5,OrderDate=DateTime.Now,RequiredDate=DateTime.Now.AddDays(1),Quantity=3,customerId=4,productId=1,EmpId=2},




            };
        }
        private static List<Product> getAllProducts()
        {
            return new List<Product>() 
            {
                new Product() { productId=1,ProductName="shoes",UnitPrice=1000},
                new Product() { productId=2,ProductName="oppo",UnitPrice=25000},
                new Product() { productId=3,ProductName="Book",UnitPrice=250},
                new Product() { productId=4,ProductName="Dell",UnitPrice=35000}
            };
         }
        private static List<Employee> getAllEmployee()
        {
            return new List<Employee>() 
            { 
               new Employee (){ EmployeeId=1,EmployeeName="Archana"},
                new Employee (){ EmployeeId=2,EmployeeName="neha"},
                 new Employee (){ EmployeeId=3,EmployeeName="Nikita"},

            };
        }

    }
}
