static class AssemblyLine
{
    const int CARS_PER_HOUR = 221;
    public static double SuccessRate(int speed) => 
    speed == 0 ? 0 :  speed <= 4 ? 1 : speed <= 8 ? 0.9: speed == 9 ? 0.8: speed == 10 ? 0.77 : 0;    
    
    public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * speed *CARS_PER_HOUR;
    
    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed)/60;
}
