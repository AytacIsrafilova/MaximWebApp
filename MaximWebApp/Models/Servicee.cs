namespace MaximWebApp.Models
{
	public class Servicee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImgUrl { get; set; }
		public List<Servicee> servicees { get; set; }
	}
}
