using System;
namespace FunWithMusic
{ // start of namespace
    class Program {// start of class 

        enum Genre
        { //start of enum
            Electronic,
            VaporWave,
            HipHop,
            Metal,
            Country
        } // end of enum 
        struct Music

        {// start of struct

            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private string Genre;

            
            public void setTitle(string title)
            {// start of title void
                Title = title;
            }// end of title void 
            public void setArtist(string artist)
            {// start of artist void
                Artist = artist;
            }// end of artist void 

            public void setAlbum(string album)
            {// start of album void
                Album = album;
            }// end of album void 

            public void setLength(string length)
            {// start of album void
                Length = length;
            }// end of album void 

            public void setGenre(string genre)
            {// start of album void
                Genre = genre;
            }// end of album void 

            public string Display() {// start of display 
            
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;


            }// end of display 



        }// end of struct 



        static void Main(string[] args)
        {//main method 
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());

            Music[] collection = new Music[size];
            try
            { // start of try
                for (int i = 0; i < size; i++)
                {// start of for
                    Console.WriteLine("What is the title of your favorite song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album of the song?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length of the song?");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What is the Genre of the song?");
                    collection[i].setGenre(Console.ReadLine());
                   




                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {// start of for
                    Console.WriteLine($"{collection[i].Display()}");
                }

            }






        }//end of main method 
   }// end of class 
} // end of namespace 