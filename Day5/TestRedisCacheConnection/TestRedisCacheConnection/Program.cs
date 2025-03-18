

using StackExchange.Redis;

ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(connectionString);


 void SetKey() {

    IDatabase db = connection.GetDatabase();
    db.StringSet("company1", "Cashpor");
    Console.WriteLine("company1 set to Cashpor");

}

void GetKey()
{
    IDatabase db = connection.GetDatabase();
    if(db.KeyExists("company1"))
    {
        Console.WriteLine("Cache hit..");
        Console.WriteLine(db.StringGet("company1"));
    }
    else
    {
        Console.WriteLine("Cache misss.");
    }
    
}

//SetKey();
GetKey();

Console.WriteLine("connection successful");