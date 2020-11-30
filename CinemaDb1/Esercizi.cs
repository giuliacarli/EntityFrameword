using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CinemaDb1
{
    public class Esercizi
    {
        //Lettura film
        public static void getMovies()
        {


            using (var cxt = new CinemaDbContext())
            {
                //var films =
                //    from m in cxt.Movies
                //    select m;

                foreach(var film in cxt.Movies)
                {
                    Console.WriteLine("ID: {0}, Titolo: {1}", film.Id, film.Titolo);
                }

            }
        }



        //Aggiungere un film
        public static void insertMovie(Movie m)
        {
            using (var cxt = new CinemaDbContext())
            {
                cxt.Movies.Add(m);

                cxt.SaveChanges();
            }
        }



        //Eliminare un film - Modalità Connessa
        public static void DeleteMovie()
        {
            using (var context = new CinemaDbContext())
            {
                var f = context.Movies.Find(8); // mi restituisce l'istanza di quell'oggetto
                Console.WriteLine("Sto eliminando il film: {0}", f.Titolo);

                context.Movies.Remove(f);
                context.SaveChanges();
            }
        }



        //Eliminare film - Modalità Disconnessa
        public static void DeleteMovieDisconnected()
        {
            var f = new Movie();

            using (var context = new CinemaDbContext())
            {
                f = context.Movies.Find(12);
            }
            //...//
            using (var context = new CinemaDbContext())
            {
                context.Entry<Movie>(f).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

    }
}
