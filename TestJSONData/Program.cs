using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

namespace TestJSONData
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic song = new JObject();
            song.SongName = "Love at First Feel";
            song.SongLenght = "3:10";

            foreach (var item in song)
            {
                Console.WriteLine("KeyName:" + item.Name + " Value: " + item.Value.ToString());
            }

            Console.WriteLine("_______________________________________________");

                //jSon string input:
            var jsonString =
                @"{""Name"":""Abhishek"",""Company"":""Infologs"",""Entered"":""2012-0316T00:03:33.245-10:10""}";
            dynamic dynamicObjecy = JValue.Parse(jsonString);

            Console.WriteLine(dynamicObjecy.Name + " | " + dynamicObjecy.Company + " | " + dynamicObjecy.Entered);
            
            Console.WriteLine("_______________________________________________");
            
            // var jsonStringAlbum = @""
            
            Console.ReadKey();
        }
    }
}