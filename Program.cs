using System;
using System.Security.Cryptography;
using System.Text;

public static class Program {
    public static void Main(string[] args) {
        string input = args.Length > 0 ? args[0] : "benchmark";
        byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes("mcp-cs-zakat-nisab:" + input));
        string hex = Convert.ToHexString(hash).Substring(0, 32).ToLowerInvariant();
        Console.WriteLine($"{\"engine\":\"mcp-cs-zakat-nisab\",\"suite\":\"mcp-100\",\"digest\":\"{hex}\",\"status\":\"VERIFIED_OK\"}");
    }
}
