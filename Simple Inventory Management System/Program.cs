using Simple_Inventory_Management_System.Domain;
using System;


class Program
{
    static void Main()
    {
        Inventory inventory = new();

        while (true)
        {
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Edit a product");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("5. Search for a product");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1 - 6): ");
            int userChoice;
            if (!int.TryParse(Console.ReadLine(), out userChoice))
            {
                Console.WriteLine("Invalid input...Please enter a number only (1-6)\n");
                continue;
            }

            switch (userChoice)
            {
                case 1:
                    string productName;
                    while (true)
                    {
                        Console.Write("Enter the product name: ");
                        productName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(productName)) 
                        {
                            Console.WriteLine("Invalid name input...Please enter a valid product name (not empty)\n");
                        }
                        else
                        {
                            break;
                        }
                    }
                    decimal productPrice;
                    while (true)
                    {
                        Console.Write("Enter the product price: ");
                        if (decimal.TryParse(Console.ReadLine(), out productPrice))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid price input...Please enter a valid number for the price (numeric)\n");
                        }
                    }
                    int productQuantity; 
                    while (true)
                    {
                        Console.Write("Enter the product quantity: ");
                        if (!int.TryParse(Console.ReadLine(), out productQuantity))
                        {
                            Console.WriteLine("Invalid input for quantity...Please enter a valid number for the quantity (numeric)\n"); 
                        }
                        else 
                        {
                            break;
                        }
                        
                    }
                    inventory.AddProduct(new Product(productName.Trim(), productPrice, productQuantity));
                    break;

                case 2:
                    inventory.ViewProducts();
                    break;
                case 3:
                    string oldName;
                    while (true)
                    {
                        Console.Write("Enter the product name you want to edit: ");
                        oldName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(oldName))
                        {
                            Console.WriteLine("Invalid name input...Please enter a valid product name (not empty)\n");
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (inventory.IsThere(oldName))
                    {
                        Console.Write("Enter the new name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new price: ");
                        decimal newPrice = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter new quantity: ");
                        int newQuantity = int.Parse(Console.ReadLine());

                        inventory.EditProduct(oldName, newName, newPrice, newQuantity);
                        Console.WriteLine("Product updated");
                    }
                    else
                    {
                        Console.WriteLine("Product is not found");
                    }
                    break;
                case 4:
                    Console.Write("Enter the product name you want to delete: ");
                    string deleteName = Console.ReadLine();
                    if (inventory.DeleteProduct(deleteName))
                    {
                        Console.WriteLine("Product deleted");
                    }
                    else
                    {
                        Console.WriteLine("Product is not found");
                    }
                    break;
            }
        }

    }
}