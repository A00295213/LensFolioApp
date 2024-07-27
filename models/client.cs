using System;



public class Client 
{
    public int ClientId{get; set;}//identifier foe the Client
    public string Name {get; set;}// name of Client
   
    public string Email {get; set;}// email of Client
    public string PhoneNumber {get; set;}// PhoneNumber of photographer
    public List<Bookings> Bookings {get; set;}// portfolios created by photographer

}