using System.Text.Json.Serialization;

namespace Projekt_6
{
    [TransactionInfo("Andrii", 2.3)]
    internal class Transaction
    {
        private string _privateField = "This is a private field";
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Currency { get; set; }

        [JsonPropertyName("sender_full_name")]
        public string? SenderName { get; set; }
        [JsonIgnore]
        public string? SecretCode { get; set; }

        public Transaction(int id, decimal amount, string? currency, string? senderName, string? secretCode)
        {
            Id = id;
            Amount = amount;
            Currency = currency;
            SenderName = senderName;
            SecretCode = secretCode;
        }
    }
}
