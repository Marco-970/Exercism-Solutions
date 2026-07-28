using System.Text.RegularExpressions;
public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string _newYorkPattern = @"^(212)";
            string _fakePattern = @".{3}-555.*";
            Regex _newYorkRegex = new Regex(_newYorkPattern);
            Regex _fakeRegex = new Regex(_fakePattern);
            return (_newYorkRegex.IsMatch(phoneNumber), _fakeRegex.IsMatch(phoneNumber),         phoneNumber.Substring(phoneNumber.Length - 4));
        }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
