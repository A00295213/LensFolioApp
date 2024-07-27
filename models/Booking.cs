using System;



public class Booking 
{
    public int BookingId{get; set;}// identifier foe the Booking
    public int PhotographerId{get; set;}//identifier foe the photographer
    public int ClientId{get; set;}//identifier for the Client
    public string Status {get; set;}// Status of the booking
    public DateTime BookingDate{get; set;}//Date when booking was made
    public DateTime ScheduleDate{get; set;}// Scheduled date of booking
   
}