using System;
using System.Collections.Generic;


public class Photographer 
{
    public int PhotographerId{get; set;}//identifier foe the photographer
    public string Name {get; set;}// name of photographer
   
    public string Email {get; set;}// email of photographer
    public string Bio {get; set;}// bio of photographer
    public string ProfilePictureUrl {get; set;}// profile picture of photographer
    public List<Portfolio> Portfolios {get; set;}// portfolios created by photographer

}