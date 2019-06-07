using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Models
{
    public class Block
    {
        public int Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<Transaction> Transactions { get; set; }
        public int Proof { get; set; }
        public string PreviousHash { get; set; }
        public string HASH { get; set; }

     
        public override string ToString()
        {
            return $"{Index} [{TimeStamp.ToString("yyyy-MM-dd HH:mm:ss")}] Proof: {Proof} | PrevHash : {PreviousHash} | Hash : {HASH}";
        }

    }
    
}
