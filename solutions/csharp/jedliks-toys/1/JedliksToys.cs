class RemoteControlCar
{
    int _distanceDriven = 0;
    int _ledPercentage = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";
    
    public string BatteryDisplay() => _ledPercentage > 0 ? $"Battery at {_ledPercentage}%" : "Battery empty";

    public void Drive()
    {
        if(_ledPercentage > 0)
        {
            _distanceDriven += 20;
            _ledPercentage -= 1;
        }
    }
}
