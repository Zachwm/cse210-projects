using System;

class zmProgram
{
    static void Main()
    {
        // Create videos and add comments
        zmVideo zmVideo1 = new zmVideo("$1 vs $10,000,000 Job!", "MrBeast", 938);
        zmVideo1.AddComment("@Karl", "Huge props to the editors, they are insane");
        zmVideo1.AddComment("@xdjh47", "Lazar being here feels so random but it makes me so happy and Im here for it");
        zmVideo1.AddComment("@hakimalasatyr", "The amount of commitment and time this man puts into entertaining his viewers is insane");

        zmVideo zmVideo2 = new zmVideo("YouTube Regrets Banning Ad Block", "Mini Money Docs™", 293);
        zmVideo2.AddComment("@SquirrelGamez", "Fun Fact: their ToS doesn't even mention adblockers so them saying those violate their terms is a lie.");
        zmVideo2.AddComment("@etherraichu", "The sad part is that they don't even understand the problem.  The reasons things got so bad is that they keep demanding more from users and creators while also treating us badly.");
        zmVideo2.AddComment("@ababcb3005", "It's not just the quantity of the ads, but the quality as well. Scams, phishing, malware, you name it. I'm not taking that risk.");

        zmVideo zmVideo3 = new zmVideo("The Christmas Duck Song", "forrestfire101", 194);
        zmVideo3.AddComment("@Vailskibum", "I never thought I'd see the day.");
        zmVideo3.AddComment("@dabalr389", "I cant believe it has been 14 years since the duck song came out. Insane.");
        zmVideo3.AddComment("@pizzaissogoodright5076", "14 years later and the duck still got the moves!");

        // Create a list of videos
        List<zmVideo> zmVideos = new List<zmVideo> { zmVideo1, zmVideo2, zmVideo3 };

        // Display information for each video
        foreach (var zmVideo in zmVideos)
        {
            Console.WriteLine($"Title: {zmVideo.zmTitle}");
            Console.WriteLine($"Author: {zmVideo.zmAuthor}");
            Console.WriteLine($"Length: {zmVideo.zmLength} seconds");
            Console.WriteLine($"Number of Comments: {zmVideo.zmComments.Count()}");
            
            // Display all comments for the video
            Console.WriteLine("Comments:");
            foreach (var comment in zmVideo.zmComments)
            {
                Console.WriteLine($"- {comment.zmCommenter}: {comment.zmText}");  
            }
            Console.WriteLine();
            Console.Write("Press enter to continue: ");  
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}