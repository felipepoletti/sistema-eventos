﻿namespace DeRole.Services.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public decimal Price { get; set; }
        public string EventDescription { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string? AddressComplement { get; set; }
        public int UserId { get; set; }
        public string EventType { get; set; }
    }
}
