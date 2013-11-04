using Newtonsoft.Json;

public class Train
{
	public string TrainNumber {get; set;}
	public int PassengerCount {get; set;}
}

public class JsonController : ApiController {
	
    public Train Get() {
        return new Train{TrainNumber = "3757", 
						PassengerCount = 200};
    }
	
	
}
