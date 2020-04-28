

namespace UnitTest
{
    public interface IService
    {
        int Id { get; set; }
        string Name { get; set; }
        string SendSms(string text);
    }
}