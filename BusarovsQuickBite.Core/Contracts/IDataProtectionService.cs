namespace BusarovsQuickBite.Core.Contracts;

public interface IDataProtectionService
{
    string Encrypt(string key);
    string Decrypt(string key);
}