
namespace Appointments
{
    public interface IPerson
    {
        string ID { get; set; }

        string GetFullName(); 
    }
}
