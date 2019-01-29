using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Jan19
{
    class Movie
    {
        static string sci = "Scifi";
        static string ani = "Animated";
        static string dra = "Drama";
        static string hor = "Horror";

        public Movie()
        {
            Title = "";
            Category = "";
        }
        public Movie(string t, int c)
        {
            Title = t;

            switch (c)
            {
                case 1:
                    Category = sci;
                    break;
                case 2:
                    Category = ani;
                    break;
                case 3:
                    Category = dra;
                    break;
                case 4:
                    Category = hor;
                    break;
            }

        }
        public string Title { get; set; }
        public string Category { get; set; }

        public void PrintAni()
        {
            if (Category == ani)
            {
                Console.WriteLine(Title);
            }
        }
        public void PrintDra()
        {
            if (Category == dra)
            {
                Console.WriteLine(Title);
            }
        }
        public void PrintHor()
        {
            if (Category == hor)
            {
                Console.WriteLine(Title);
            }

        }
        public void PrintSci()
        {
            if (Category == sci)
            {
                Console.WriteLine(Title);
            }
        }

    }

}
