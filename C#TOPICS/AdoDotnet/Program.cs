// See https://aka.ms/new-console-template for more information
using AdoDotnet;

string connectionstring = "Server =DESKTOP-M6I5G2C\\SQLEXPRESS; Database =MainDb; User Id= hasib; Password = 999111 ;";

DataUtility data = new DataUtility(connectionstring);

/*var sql = "insert into Students([Name],Cgpa,DateOfBirth) values('hasib',3.33,'2022-01-23')";

data.AddData(sql);
*/
var query = "select * from students";
var values = data.GetData(query);

foreach (var item in values)
{
    foreach (var key in item.Keys)
    {
        Console.WriteLine($"{key} ={item[key]}");
    }
}
