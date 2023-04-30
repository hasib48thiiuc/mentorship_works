using Inventory_Management;
using System.Drawing;
using System.Xml.Linq;

Console.WriteLine("Welcome to Inventory Management System");

List<Inventory> Items= new List<Inventory>();
 string AddItem()
          {
    Inventory item=new Inventory();

    item.Id = Items.Count;

    Console.Write("Enter Name= ");

    item.Name = (Console.ReadLine());
    foreach(Inventory i in Items)
    {
        if(item.Name==i.Name)
        {
            return ("Item Already Added");
            Items.RemoveAt(item.Id);
            
        }
    }
    
    Console.Write("Enter Quantity");

    item.Quantity = int.Parse(Console.ReadLine());

    Console.Write("Enter Price=");

    item.price = int.Parse(Console.ReadLine());


    Items.Add(item);
    return ("item added successfully");
               }
void ShowItem()
{
    foreach(Inventory item in Items)
    {
        Console.WriteLine($"Item Id ={item.Id+1} ,Item Name ={item.Name} ,Item Quantity={item.Quantity},Item Price ={item.price}");
    }
}
void UpdateItem(string name,int quant)
{
    foreach (Inventory item in Items)
    {
      if(item.Name==name)
        {
            item.Quantity = quant;
        }


    }
    Console.WriteLine("Update Succesfull");
}
void SearchItembyid(int id)
{
    bool flag = false;
    if(id>Items.Count)
    {
        flag = true;
    }
    foreach (Inventory item in Items)
    {
        if(flag==true)
        {
            flag = false;
            break;
        }

        
        if (item.Id == id-1 )
        {
            Console.WriteLine("ITEM FOUND,your item details are given below.");
            Console.WriteLine($"Item Id ={item.Id+1} ,Item Name ={item.Name} ,Item Quantity={item.Quantity},Item Price ={item.price}");
            flag = true;
            break;
        }

    }
    if(flag==false)
    {
        Console.WriteLine($"Your Searched ID='{id}' not found in the inventory,please provide the correct ID");
    }
}
void RemoveItem(string name)
{
    bool flag = false;
    foreach (Inventory i in Items)
    {
        if (i.Name == name)
        {
            flag = true;
            Items.RemoveAt(i.Id);
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Item Removed Succesfully"+Console.BackgroundColor);
            break;

        }


    }
    if(flag==false)
    {
        Console.WriteLine("Your item not found");
    }
}
void SearchItembyName(string name)
{
    int coun = 0;
    
    foreach (Inventory item in Items)
    {

        coun++;

        if (item.Name == name)
        {
            Console.WriteLine("ITEM FOUND,your item details are given below.");
            Console.WriteLine($"Item Id ={item.Id+1} ,Item Name ={item.Name} ,Item Quantity={item.Quantity},Item Price ={item.price}");
            break;
        }
    }
    if(coun>=Items.Count)
    {
        Console.WriteLine($"Your Searched item = '{name}' not found in the inventory,please provide the correct name");
    }
}

while (true)
{

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine("Please Chose Your Option");
    Console.WriteLine("Press 1 For Adding new Item");
    Console.WriteLine("Press 2 For Updating Quantity of any Item");
    Console.WriteLine("Press 3 For Dispalying Detail");
    Console.WriteLine("Press 4 for Search By ID/Name");
    Console.WriteLine("Press 5 for Removing an item from inventory");
    Console.WriteLine("Press 6 to exit");
    Console.WriteLine();
    Console.WriteLine();

    int n = int.Parse(Console.ReadLine());

    if (n==1)
    {
        string ans=AddItem();
        Console.WriteLine(ans);
        Console.WriteLine();

    }
    if (n == 2)
    {
        Console.WriteLine("enter item name you want to update");
        string Name = Console.ReadLine();
        Console.WriteLine("enter update quantity");
        int x = int.Parse(Console.ReadLine());
        UpdateItem(Name, x);
    }
    if (n==3)
    {
        ShowItem();
    }
    if(n==4)
    {
        Console.WriteLine("Press 1 To Search By ID,Press 2 to search by Name");
        int m = Convert.ToInt32(Console.ReadLine());
        if(m==1)
        {
            Console.WriteLine("Provide the Id");

            int a = int.Parse(Console.ReadLine());

            SearchItembyid(a);
        }
        else if(m==2)
        {
            Console.WriteLine("Provide the Name You want to search");

            string QueryName = Console.ReadLine();
            SearchItembyName(QueryName);
        }
    }
    if(n==5)
    {
        Console.WriteLine("Provide item name to remove");

        string nam = Console.ReadLine();
        RemoveItem(nam);
    }
    

    if(n==6)
    {
        break;
    }
}
