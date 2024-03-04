namespace BusarovsQuckBite.Contracts;

public interface IDataProtectionService
{
    string Encrypt(string key);
    string Decrypt(string key);
}