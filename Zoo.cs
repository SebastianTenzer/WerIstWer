using System;

public class Zoo
{
	protected List<Animal> AnimalList;


	public Zoo()
	{
		AnimalList = new List<Animal>();
	}


	public WriteToJson()
	{

		string json = JsonConvert.SerializeObject(AnimalList);


		foreach (var item in AnimalList)
        {

			
		}
		//string json = JsonConvert.SerializeObject(account, Formatting.Indented);

		Console.WriteLine(json);
	}



	public LoadFromJson()
    {


    }





}
