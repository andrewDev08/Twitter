using System;
//20230923_AndrewHorton_Exercise3.1
class Program {
  public static void Main (string[] args) {
    int characterLimit = 140;
    
    Console.WriteLine("Please enter the tweet: ");
    string tweet = Console.ReadLine();

    if ( tweet.Length > characterLimit )
    {
      Console.WriteLine("Rejected");
    }
    else
    {
      Console.WriteLine("Posted");
    }
  }
}