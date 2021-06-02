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
        public Klient NotExistingClient { get; set; }
        public ClientDoesNotExistException() : base() { }
        public ClientDoesNotExistException(string message) : base(message) { }
        public ClientDoesNotExistException(string message, Exception e) : base(message, e) { }

        public ClientDoesNotExistException(Klient notExistingClient) : base()
        {
            NotExistingClient = notExistingClient;
        }
    }
    public class WrongIndexException : Exception
    {
        public int WrongIndex { get; set; }
        public WrongIndexException() : base() { }
        public WrongIndexException(string message) : base(message) { }
        public WrongIndexException(string message, Exception e) : base(message, e) { }

        public WrongIndexException(string message, int wrongIndex) : base(message)
        {
            WrongIndex = wrongIndex;
        }
    }
}
