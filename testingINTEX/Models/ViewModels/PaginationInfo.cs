﻿namespace testingINTEX.Models.ViewModels
{    public class PaginationInfo
     {
         public int TotalItems { get; set; }
         public int ItemsPerPage { get; set; }   
         public int CurrentPage { get; set; }
         public int TotalPages => (int)(Math.Ceiling((decimal)TotalItems / ItemsPerPage));
     }

    //this class holds the information for how we want to divide out the books between pages

}
