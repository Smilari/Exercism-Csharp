public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        phoneNumber.Trim();
        return (phoneNumber.StartsWith("212"), phoneNumber.Substring(4).StartsWith("555"), phoneNumber.Substring(phoneNumber.Length - 4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
