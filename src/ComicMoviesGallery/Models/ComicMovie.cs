
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicMoviesGallery.Models
{
    public class ComicMovie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }

        public string DisplayText
        {
            get
            {
                return MovieTitle;
            }
        }

        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return MovieTitle.Replace(" ", "-")
                    .ToLower() + ".jpg";
            }
        }
    }
}