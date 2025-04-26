class RemoteControlCar
{
    private int speed;
    private int batteryDrained;
    private int distanceDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrained){
        this.speed = speed;
        this.batteryDrained = batteryDrained;
    }
    public bool BatteryDrained() => battery < batteryDrained;

    public int DistanceDriven() => distanceDriven;

    public void Drive(){
        battery -= batteryDrained;
        if (battery >= 0){ 
            distanceDriven += speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance){
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()){
            car.Drive();
            if (car.DistanceDriven() >= distance){
                return true;
            }
        }
        return false;
    }
}
