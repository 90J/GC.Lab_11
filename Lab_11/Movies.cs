using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class TheMovieList
    {
        public TheMovieList(string userInput, string v)
        {
            ArrayList movieList = new ArrayList();
            {
                movieList.Add(new TheMovieList("scifi", "Sharktopus"));
                movieList.Add(new TheMovieList("animated", "Shrek"));
                movieList.Add(new TheMovieList("drama", "Dead Poets Society"));
                movieList.Add(new TheMovieList("horror", "The Notebook"));
                movieList.Add(new TheMovieList("scifi", "Sharknado"));
                movieList.Add(new TheMovieList("animated", "Aladin"));
                movieList.Add(new TheMovieList("drama", "St. Elmo's Fire"));
                movieList.Add(new TheMovieList("horror", "Killer Clowns from Space"));
                movieList.Add(new TheMovieList("scifi", "Lavalanchula"));
                movieList.Add(new TheMovieList("animated", "Toy Story"));
            };

            //get movies from list
            

        }

    }
}
