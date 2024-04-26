// Initialize variables
int sodaStock = 100;
int sodaMinStock = 40;
int chipsStock = 40;
int chipsMinStock = 20;
int candyStock = 60;
int candyMinStock = 40;

Console.WriteLine("Welcome to the restocking tool.\r\n");


// Ask Soda stock
Console.WriteLine("How many Sodas have been sold today? " + sodaStock + " are in stock");
int sodasSold = int.Parse(Console.ReadLine());

if (sodasSold > sodaStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted");
}
else 
{
    sodaStock -= sodasSold;
    Console.WriteLine("There are " + sodaStock + " Sodas left");
}

// Ask Chips stock
Console.WriteLine("How many Chips have been sold today? " + chipsStock + " are in stock");
int chipsSold = int.Parse(Console.ReadLine());

if (chipsSold > chipsStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted");
}
else
{
    chipsStock -= chipsSold;
    Console.WriteLine("There are " + chipsStock + " Chips left");
}

// Ask Candy stock
Console.WriteLine("How many Candy have been sold today? " + candyStock + " are in stock");
int candySold = int.Parse(Console.ReadLine());

if (candySold > candyStock)
{
    Console.WriteLine("The value is too high. Stock not adjusted");
}
else
{
    candyStock -= candySold;
    Console.WriteLine("There are " + candyStock + " Candy left");
}


// Check what needs to be restocked
string[] needRestock = ["", "", ""];
if (sodaStock <= sodaMinStock)
{
    needRestock[0] = "Soda";
}
if (chipsStock <= chipsMinStock)
{
    needRestock[1] = "Chips";
}
if (candyStock <= candyMinStock)
{
    needRestock[2] = "Candy";
}

if (needRestock[0] == "" && needRestock[1] == "" && needRestock[2] == "")
{
    Console.WriteLine("Thank you for filling out the values. Nothing needs to be restocked!\r\nGoodbye!");
} else
{
    Console.Write("Thank you for filling out the values. ");
    Console.Write("{0}", string.Join(", ", needRestock));
    Console.Write(" needs to be restocked.\r\nGoodbye!");
}

