using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    internal class Author
    {
        private string v1;
        private int v2;
        private string likes;
        private string name;

        public Author(string v1, int v2)
        {
            List<Author> author = new List<Author>
                                {
                                    new Author("Josh" + " likes", 65),
                                    new Author("Don" + " likes", 71),
                                    new Author("Lewis" + " likes", 200)
                                };
            Console.WriteLine("Showing the author " + "name" + name);



            author.ForEach(delegate (Author author)
            {
                Console.WriteLine(author.Name + " - " + author.likes + author.Message);

                string[] newAuthors = { "New Author1", "New Author2", "New Author3" };
                // Insert array at position 2
                author.InsertRange(2, newAuthors);
            });
            this.v1 = v1;
            this.v2 = v2;
        }

        private void InsertRange(int v, string[] newAuthors)
        {
            throw new NotImplementedException();
        }

        public string Name { get; private set; }
        public string Message { get; private set; }
    }
}