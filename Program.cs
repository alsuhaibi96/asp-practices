// string []fraudulentOrderIDs=  ["A123","B456","C789"];
// // fraudulentOrderIDs[0]="A123";
// // fraudulentOrderIDs[1]="B456";
// // fraudulentOrderIDs[2]="C789";

// int arrayCount=fraudulentOrderIDs.Length;

// Console.WriteLine($"the count of the array elements is {arrayCount}");

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// string []  names= {"Ali","Saleh","Saad"};

// foreach (string name in names)
// {
//     Console.WriteLine($"Name : {name}");
// }



// int [] inventory= {20,30,40};
// int sum=0;
// int bin=0;

// foreach (int item in inventory)
// {
//     sum+=item;
//     bin++;
//        Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
// }

// Console.WriteLine($"sum : {sum}");

string [] fruadulentOrders={"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach(string item in fruadulentOrders)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
