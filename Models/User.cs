using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class User{

    [StringLength(20)]
    [Required]
    public string? UserName {get;set;}

     [StringLength(110, MinimumLength=20)]
     [Required]
     public string? FullName {get;set;}

      [StringLength(11)]
      [Required]
      public string? phoneNumber {get;set;}

       public string? email {get;set;}

    [StringLength(16)]
    [Required]
    private string? Password {get; set;}


}
