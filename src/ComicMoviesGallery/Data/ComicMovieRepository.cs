using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicMoviesGallery.Models;

namespace ComicMoviesGallery.Data
{
    public class ComicMovieRepository
    {
        private static ComicMovie[] _comicMovies = new ComicMovie[]
        {
            new ComicMovie()
            {
                Id = 1,
                MovieTitle = "SpiderMan",
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Milad Mirkarimi", Role = "Director" },
                    new Artist() { Name = "Uzair Ilahi", Role = "Actor" },
                    new Artist() { Name = "Sharee Lane", Role = "Writer" }
                   
                    
                }
            },
            new ComicMovie()
            {
                Id = 2,
                MovieTitle = "DeadPool",
                
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Milad Mirkarimi", Role = "Director" },
                    new Artist() { Name = "Uzair Ilahi", Role = "Actor" },
                    new Artist() { Name = "Sharee Lane", Role = "Writer" }
           
                },
    
            },
            new ComicMovie()
            {
                Id = 3,
                MovieTitle = "Avengers",
          
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Milad Mirkarimi", Role = "Director" },
                    new Artist() { Name = "Uzair Ilahi", Role = "Actor"},
                    new Artist() { Name = "Sharee Lane", Role = "Writer"}
            
                },
            }
        };

        public ComicMovie[] GetComicMovies()
        {
            return _comicMovies;
        }

        public ComicMovie GetComicMovie(int id)
        {
            ComicMovie comicMovieToReturn = null;

            foreach (var comicMovie in _comicMovies)
            {
                if (comicMovie.Id == id)
                {
                    comicMovieToReturn = comicMovie;

                    break;
                }
            }

            return comicMovieToReturn;
        }
    }
}