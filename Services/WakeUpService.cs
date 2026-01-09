namespace TwoToFour.Services
{
    public class WakeUpService
    {
        public string CalculateWakeUp(string userName, string wakeUpTime)
        {
            return $"{userName} woke up at {wakeUpTime}.";
        }
    }
}