using CS_ADV_4.FiFa;
using CS_ADV_4.Youtube;
using System.Collections;


namespace CS_ADV_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (1) Event driven Programming

            #region Event EX 01  
            ////--------------------------------------------------------------------------------------------
            //Ball ball = new Ball() { id = 1 };
            //--------------------------------------------------------------------------------------------
            //Console.WriteLine(ball.ToString());
            //Console.WriteLine("\n");
            //--------------------------------------------------------------------------------------------
            /*ball.Location = new Location() { x = 1 , y = 2 , z = 3 };*/

            //Console.WriteLine(ball.ToString());
            //Console.WriteLine("\n");

            //--------------------------------------------------------------------------------------------
            //Player player1 = new Player() { name = "omar", teamName = "zamalek" };
            //Player player2 = new Player() { name = "ahmed", teamName = "zamalek" };

            //Player player3 = new Player() { name = "hassan", teamName = "ahly" };
            //Player player4 = new Player() { name = "mohamed", teamName = "ahly" };

            //Player player5 = new Player() { name = "salah", teamName = "ahly" };

            //Refree refree = new Refree()
            //{
            //    name = "Ibrahim-Noor-Eldein"
            //};
            //--------------------------------------------------------------------------------------------

            //ball.Location = new Location() { x = 1, y = 2, z = 3 };
            //--------------------------------------------------------------------------------------------
            //ball.BallLocationChanging += player1.run;
            //ball.BallLocationChanging += player2.run;
            //ball.BallLocationChanging += player3.run;
            //ball.BallLocationChanging += player4.run;

            //ball.BallLocationChanging += refree.look;
            //--------------------------------------------------------------------------------------------

            //ball.Location = new Location() { x = 1, y = 1, z = 1 };
            //Console.WriteLine("\n");

            //Console.WriteLine(ball.ToString());
            //Console.WriteLine("\n");
            //--------------------------------------------------------------------------------------------
            //Console.WriteLine("after change palyer1 with player5 => ");
            //ball.BallLocationChanging -= player1.run;
            //ball.BallLocationChanging += player5.run;
            //--------------------------------------------------------------------------------------------
            //ball.Location = new Location() { x = 2, y = 5, z = 3 };
            //--------------------------------------------------------------------------------------------


            #endregion


            #region Event EX 02 
            // Channel channel = new Channel() { name = "ABC" };

            // channel.addVideo(new Video() { title = "title1" , description = "desc1" });


            //Subscriber subscriber1 = new Subscriber() { name = "sub1" };
            //Subscriber subscriber2 = new Subscriber() { name = "sub2" };
            //Subscriber subscriber3 = new Subscriber() { name = "sub3" };
            //Subscriber subscriber4 = new Subscriber() { name = "sub4" };


            // channel.videadded += subscriber1.notify;
            // channel.videadded += subscriber2.notify;
            // channel.videadded += subscriber3.notify;

            // channel.addVideo(new Video() { title = "title2", description = "desc2" });





            #endregion



            // (2) Collections: built in data structure in C#

            // HashTables: 
            // 1- generic
            // 2- non-generic



            #region[ Non - Generic] Collections HashTables "hashTable" 


            //Hashtable note = new Hashtable();

            //Console.WriteLine(note.Count);  // 0
            //Console.WriteLine("\n");


            //note.Add(123, "omar");
            //note.Add(111, "mona");
            //note.Add(222, "yasser");


            //foreach (DictionaryEntry item in note)
            //{
            //    Console.WriteLine($"key: {item.Key} , value: {item.Value}");
            //}






            #endregion



            #region [Generic] Collections HashTables  "Dictionary" 

            //Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            //keyValuePairs.Add(1, "omar");
            //keyValuePairs.Add(2, "ahmed");
            //keyValuePairs.Add(3, "mona");


            //foreach (KeyValuePair<int,string> item in keyValuePairs)
            //{
            //    Console.WriteLine($"{ item.Key}");
            //    Console.WriteLine($"{item.Value}");
            //}

            #endregion


        }
    }
}
