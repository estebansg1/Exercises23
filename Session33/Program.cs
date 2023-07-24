
Service service1 = new Service("S001", "Service 1", 100.0m);
Service service2 = new Service("S002", "Service 2", 150.0m);
Service service3 = new Service("S003", "Service 3", 200.0m);

Product product1 = new Product("P001", "Product 1", 50.0m, "pcs", 10);
Product product2 = new Product("P002", "Product 2", 75.0m, "kg", 5);
Product product3 = new Product("P003", "Product 3", 100.0m, "liters", 2.5);

decimal totalTaxes = service1.CalcTax() + service2.CalcTax() + service3.CalcTax() +
					product1.CalcTax() + product2.CalcTax() + product3.CalcTax();

Console.WriteLine("Total taxes: " + totalTaxes);