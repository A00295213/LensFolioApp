using System;
using System.Collections.Generic;


public class Portfolio 
{
    public int PortfolioId{get; set;}//identifier foe the photographer
    public string Title {get; set;}// name of photographer
   
    public string Description {get; set;}// email of photographer
    public int photographerId {get; set;}// bio of photographer
    
    public List<Photos> Photos {get; set;}// portfolios created by photographer

    public bool IsPublic{get; set;}

}