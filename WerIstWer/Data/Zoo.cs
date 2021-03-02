using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WerIstWer.Data
{
	public class Zoo
	{
		protected List<Data.Animal> AnimalList;


		public Zoo()
		{
			AnimalList = new List<Data.Animal>();
		}

		public void AddNewItem(Data.Animal newAnimal)
        {
			AnimalList.Add(newAnimal);
			WriteToJson();
		}


		public void WriteToJson()
		{
			string json = JsonConvert.SerializeObject(AnimalList);


			foreach (var item in AnimalList)
			{


			}
			//string json = JsonConvert.SerializeObject(account, Formatting.Indented);

			Console.WriteLine(json);
		}



		public void LoadFromJson()
		{


		}





	}
}
