 Console.WriteLine("Class ID: YOUR_CLASS_ID");
        Console.WriteLine("Registration ID: YOUR_REG_ID");
        Console.WriteLine("Name: YOUR_NAME");
        Console.WriteLine("Submission Date: 28-10-2026");

        Console.Write("Enter purchase amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double discountPercent;

        if (amount >= 5000)
        {
            discountPercent = 20;
        }
        else if (amount >= 2000)
        {
            discountPercent = 10;
        }
        else
        {
            discountPercent = 0;
        }

        double discount = amount * discountPercent / 100;
        double finalAmount = amount - discount;

        Console.WriteLine("Discount Percentage: " +
                          discountPercent + "%");

        Console.WriteLine("Discount Amount: " + discount);

        Console.WriteLine("Final Payable Amount: " +
                          finalAmount);
    }
}
