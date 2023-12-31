﻿using System;
namespace CodeEvents.Models
{
	public class Event
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? ContactEmail { get; set; }
		public string? EventLocation { get; set; }

		public int Id { get; set; }

		public Event()
		{
		}

		public Event(string name, string description, string contactEmail, string eventLocationl)
		{
			Name = name;
			Description = description;
			ContactEmail = contactEmail;
			EventLocation = EventLocation;
		}

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
			return obj is Event @event && Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

