class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = CreateVideoWithComments("How to concatenate strings in Python", 300);
        Video video2 = CreateVideoWithComments("Unboxing an Iphone 15 Pro Max", 180);
        Video video3 = CreateVideoWithComments("Tutorial: Top 10 best VPNs to use in 2023", 450);

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());

            if (video.GetNumComments() > 0)
            {
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
                }
            }

            Console.WriteLine("\n");
        }
    }

    static Video CreateVideoWithComments(string title, int length)
    {
        Console.Write($"Enter the author's name for the video '{title}': ");
        string author = Console.ReadLine();

        Video video = new Video(title, author, length);

        Console.WriteLine($"Enter three comments for the video '{title}':");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Comment {i + 1} - Commenter's Name: ");
            string commenterName = Console.ReadLine();
            Console.Write($"Comment {i + 1} - Comment Text: ");
            string commentText = Console.ReadLine();

            video.AddComment(commenterName, commentText);
        }

        return video;
    }
}
