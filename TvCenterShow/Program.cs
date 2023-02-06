using TvCenterShow.Helpers;
using TvCenterShow.Logic;

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("**************************************The Tv ShowApplication*************************************");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine();
Console.WriteLine("**********************Choise an Option Please read the next directions***************************");
Console.WriteLine("1. Filter The Tv Show By Id,Pease Type The Tv Show 'Id'");
Console.WriteLine("2. List all The Tv Show, Please Type:'list' as Parameter");
Console.WriteLine("3. List all The Favorites Tv Show, Please Type:'favorites' as Parameter");
Console.WriteLine("4. Type 'exit' to Close the Application");
Console.WriteLine();
Console.WriteLine("List of available Tv Shows sorted alphabetically");
Console.WriteLine(TvShowLogic.ShowInitialListData());
Console.WriteLine("\nType the option:");
string input = Console.ReadLine();
while (input != "exit")
{

    try
    {
        if(int.TryParse(input, out int id))
        {           
            var result = TvShowLogic.FindTvShowById(id);
            if (result != null)
            {
                Console.WriteLine($"{result.Id}   {result.Show}   {GlobalHelper.setBoolToString(result.IsFavorite)}");
            }
            else
            {  
                Console.WriteLine("The TvShow is not Found, Try Again");
            }
           
        }
        else if (input == "list")
        {           
            Console.WriteLine("The Tv Show List:");
            var result=TvShowLogic.ShowInitialListData();
            Console.WriteLine(result);

        }
        else if (input == "favorites")
        {
            
           
            var result = TvShowLogic.FindTvShowByFavorites(input);
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine("The Tv Show Favorite List:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There are not a Tv Show Favorite item yet");
            }
           
        }
        else
        {
            Console.WriteLine("\nInvalid option.");
        }
        Console.WriteLine("\nType the option:");
        input = Console.ReadLine();

    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}







