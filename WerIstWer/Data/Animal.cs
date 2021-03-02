using System;
namespace WerIstWer.Data
{

	public class Animal
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }

		//public Bitmap Picture { get; set; }

		public Animal Partner { get; set; }


		public Animal()
		{
			FirstName = "";
			LastName = "";
			//Picture = null;
			Partner = null;
		}


	}

}