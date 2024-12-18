using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }//go through list
    public SelectList? Genres { get; set; }//select base on genre
    public string? MovieGenre { get; set; }//set movie genre
    public string? SearchString { get; set; }//compare with search result
}