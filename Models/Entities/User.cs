namespace PadraoCamadas.Models.Entities
{
	public class User
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

		public User(int id, string nome, string email, string password)
		{
			Id = id;
			Nome = nome;
			Email = email;
			Password = password;
		}
	}
}