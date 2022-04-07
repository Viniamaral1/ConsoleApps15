using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// Vinicius DO amaral
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private readonly List<MessagePost> messages;
        private readonly List<PhotoPost> photos;
        private object message;

        public static object AddPost { get; private set; }
        public static object NewPost { get; private set; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            messages = new List<MessagePost>();


            photos = new List<PhotoPost>();
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            messages.Add(message);
        }

        internal static void Run()
        {
            //NewsFeed.Run();
            MainMenu.Run();



        }










        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            photos.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (MessagePost message in messages)
            {
                message.Display();
                Console.WriteLine();   // empty line between posts
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                photo.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        class Post  // base class (parent) 
        {
            public string newpost = "Add Post";

            public string DisplayPost { get; internal set; }

            public object AddMessage { get; private set; }
            public object Remove { get; private set; }
            public object Like { get; private set; }
            public object Unlike { get; private set; }

            internal void NewPost()
            {

            }

            public void Question()
            {
                Console.Write(" Would you like to go again y/n > ");
                string retry = Console.ReadLine();
                if (retry.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    Run();
                }
                else if (retry.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Write(" Hope you had a pleasant experiance. ");
                }
            }

            public override string ToString()
            {
                return string.Format(newpost, AddPost, Remove, DisplayPost, Like, Unlike);




            }

            public class Post1
            {
                public Post1(string message, string photomessage)
                {
                    if (message == null)
                        throw new ArgumentNullException(nameof(message));
                    else if (string.IsNullOrWhiteSpace(message))
                        throw new ArgumentException();
                    Message = message;

                    if (photomessage == null)
                        throw new ArgumentNullException(nameof(photomessage));
                    else if (string.IsNullOrWhiteSpace(photomessage))
                        throw new ArgumentException();
                    Photomessage = photomessage;


                }

                public string Message { get; }

                public string Photomessage { get; }

                public int Year { get; }

                public override string ToString() => $" {Message} {Photomessage}";
            }






            class Program
            {
                private static readonly string newPost;
                private static readonly string name;

                public static object NewPost { get; private set; }
                public static int Choice { get; private set; }
                public static object Get { get; private set; }
                public static double MessagePost { get; private set; }
                public static double PhotoPost { get; private set; }
                public static double Message { get; private set; }
                public static object message { get; private set; }
                public static object Continue { get; private set; }
                public static object NewMessage { get; private set; }
                public static object Comments { get; private set; }
                public static object Comment { get; private set; }
                public static object NoComments { get; private set; }

                private static void Main(string[] args)
                {


                    {


                        Console.WriteLine(" ======================================");
                        Console.WriteLine(" Be Welcome to the News Feed App004 by Vinicius do Amaral");
                        Console.WriteLine(" Would like to Add a new Use, Yes or No?");
                        Console.WriteLine(" ======================================");


                        string NewUser = Console.ReadLine();
                        if (NewUser.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine("What is your name?");
                            var name = Console.ReadLine();
                            var currentDate = DateTime.Now;
                            Console.WriteLine($"{Environment.NewLine}Hello, {name} you have been registered, on {currentDate:d} at {currentDate:t}!");

                            Console.Write($"{Environment.NewLine}Press any key to continue...");
                            Console.ReadKey(true);

                            Run();
                        }
                        else if (NewUser.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.Write(" Do you have a existent use, Yes or no? ");
                        }

                        Console.Clear();
                        Console.WriteLine("Welcome to the App Post. Please select the fuction> ");
                        Console.WriteLine(" 1 Add a new PostMessage");
                        Console.WriteLine(" 2 Add a new Photo");
                        Console.WriteLine(" 3  Display all the posts with comments and likes");
                        Console.WriteLine(" 4  Choose an Author");
                        Console.WriteLine(" 5  Remove a post");
                        Console.WriteLine(" 6  Add a comment");
                        Console.WriteLine(" 7  Like or Unlike a Post");
                        Console.WriteLine(" 8  Exit         ");
                    }







                    Choice = Convert.ToInt32(Console.ReadLine());
                    if (Choice == 8)
                    {
                        Console.WriteLine("Thanks for using this app. See you soon  ");
                        Console.Write($"{Environment.NewLine}Press any key to end...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        switch (Choice)
                        {
                            case 1:

                                Console.WriteLine("Type your message >  ");


                                {
                                    MessagePost = Convert.ToDouble(MessagePost);
                                    var message = Console.ReadLine();
                                    var currentDate = DateTime.Now;
                                    Console.WriteLine($"{Environment.NewLine}You have added the following message, {message} , on {currentDate:d} at {currentDate:t}!");






                                    Console.WriteLine("Please write any comments for this post");
                                    string Comments = Console.ReadLine();


                                    var Comment = Console.ReadLine();
                                    Console.WriteLine($"{Environment.NewLine}You have added the following comment, {Comments} , on {currentDate:d} at {currentDate:t}!");




                                    Console.Write(" No more comments added ");

                                    Console.Write($"{Environment.NewLine}Press any key to continue...");
                                    Console.ReadKey(true);


                                    Console.WriteLine("You have added a post message");
                                    break;




                                }











                            case 2:
                                {
                                    Console.WriteLine("Chose the picture/ file you would like to upload and press enter  ");
                                    AddPhoto();

                                    Console.WriteLine(" Remember the file should be in JPG or JPEG");
                                    string filename = Console.ReadLine();
                                    var currentDate = DateTime.Now;
                                    Console.WriteLine($"{Environment.NewLine}You have added the following picture, {filename} , on {currentDate:d} at {currentDate:t}!");


                                    Console.WriteLine("You have added a new Photo message");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("  Displaying all the posts with comments and likes");
                                    string post = Console.ReadLine();
                                    var currentDate = DateTime.Now;
                                    Console.WriteLine($"{Environment.NewLine}No post has been added to the  {post} on {currentDate:d} at {currentDate:t}!");

                                    Console.WriteLine(" No comments at the moment");

                                    Console.WriteLine("Press any key to end the function ...");
                                    Console.ReadLine();
                                    break;
                                }

                            case 4:
                                List<Author> author = new List<Author>
                                {
                                    new Author("Josh" + " amount of likes",  0 ),
                                    new Author("Don" + " amount of likes",   0 ),
                                    new Author("Lewis" + " amount of likes", 0 )
                                };
                                Console.WriteLine("Showing the author " + "name" + name);



                                author.ForEach(delegate (Author author)
                                {
                                    Console.WriteLine(author.Name + " - " + author.likes + author.Message);

                                    string[] newAuthors = { "New Author1", "New Author2", "New Author3" };

                                    author.InsertRange(2, newAuthors);
                                });







                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();
                                break;


                            case 5:
                                Console.WriteLine("Would like to remove a post");


                                Console.WriteLine("Please, select the post you would like remove");
                                Console.ReadLine();
                                break;
                            case 6:
                                {
                                    Console.WriteLine("Adding a comment to a post");

                                    Console.WriteLine("Please write any comments for the post");
                                    string Comments = Console.ReadLine();


                                    var currentDate = DateTime.Now;

                                    Console.WriteLine($"{Environment.NewLine}You have added the following comment, {Comments} , on {currentDate:d} at {currentDate:t}!");




                                    Console.Write(" No more comments added ");

                                    Console.Write($"{Environment.NewLine}Press any key to continue...");

                                    Console.ReadKey(true);




                                    Console.ReadLine();
                                    break;
                                }
                            case 7:
                                { 
                                Console.WriteLine("Would like to like or unlike a post? Press enter to continue...");


                                Console.WriteLine("Please, select the post you would like to give a like or dislike.");
                                Console.ReadLine();
                                break;
                                }

                            default:
                                //if a number other than 1-6 is entered, request
                                //user to enter a number in that range
                                //wait for them to press enter, then call
                                //the menu again
                                Console.WriteLine("Please enter a number 1-6.");
                                Console.WriteLine("Press enter to continue...");
                                Console.ReadLine();

                                break;


                        }


                        var random = new Random();
                        var authors = new List<Author>();
                        int index = random.Next(authors.Count);

                    }



                }


            }


            private static void AddPhoto()
            {
                string value = Console.ReadLine();
            }

            private class Author
            {
                public string Name { get; set; }

                public double Likes { get; set; }

                public int likes { get; set; }
                public string Message { get; internal set; }

                public Author(string name, int likes)
                {
                    this.Name = name;
                    this.likes = likes;
                }

                internal void InsertRange(int v, string[] newAuthors)
                {
                    //return.this();
                }

            }





        }




























    }
}

  





