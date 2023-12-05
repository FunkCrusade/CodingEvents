using System;
using CodeEvents.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeEvents.Data
{
    public class EventDbContext : DbContext
	{

		public DbSet<Event> Events { get; set; } 


		public EventDbContext(DbContextOptions<EventDbContext> options): base (options)
		{
		}
	}
}

