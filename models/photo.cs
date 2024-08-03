using System;



public class Photo
{
    public int PhotoId{get; set;}//unique identifier foe the photo
    public string Title {get; set;}// Title of photo
   
    public string Description {get; set;}// Description of the photo
    public int PortfolioId {get; set;}// Id for the portfolio containing this photo

    public DateTime UploadDate {get; set;} // indicates the date when the photo was uploaded
    
    public string PhotosUrl {get; set;}// This is the Url of the photo file

    public bool IsSharedOnSocialMedia{get; set;} // it indicates that if photo is uploaded on socialmedia

}