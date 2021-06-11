using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace COKPOProject
{
    public class ClientDoesNotExistException : Exception
    {
        public Klient NotExistingClient { get; }

        public ClientDoesNotExistException(Klient notExistingClient) : base()
        {
            NotExistingClient = notExistingClient;
        }
    }
    public class WrongIndexException : Exception
    {
        public int WrongIndex { get; }

        public WrongIndexException(string message, int wrongIndex) : base(message)
        {
            WrongIndex = wrongIndex;
        }
    }
    public class WrongCardNumberException : Exception
    {
        public string WrongCardNumber { get; }

        public WrongCardNumberException(string message, string wrongNumber) : base(message)
        {
            WrongCardNumber = wrongNumber;
        }
    }
    public class BankomatCardNotSupportedException : Exception
    {
        public Karta WrongCard { get; }

        public BankomatCardNotSupportedException(string message, Karta wrongCard) : base(message)
        {
            WrongCard = wrongCard;
        }
    }
}
