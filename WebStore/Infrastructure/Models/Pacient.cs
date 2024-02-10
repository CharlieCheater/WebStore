using System;

namespace WebStore.Infrastructure.Models
{
	public class Pacient
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string SurName { get; set; }
		public string Patronymic { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime Birthday { get; set; }
		public bool Gender { get; set; }
		public string WorkPlace { get; set; }
		public string WorkPost { get; set; }
	}
	public class PacientViewModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string SurName { get; set; }
		public string Patronymic { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime? Birthday { get; set; }
		public bool Gender { get; set; }
		public string WorkPlace { get; set; }
		public string WorkPost { get; set; }
	}
}
