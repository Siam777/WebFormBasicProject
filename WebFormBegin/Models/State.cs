using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormBegin.Models
{
    public class State
    {
        public List<StateFee> ServiceAreaStateFee = new List<StateFee>();
        public decimal OutOfAreaFee { get; private set; }

        public State()
        {
            ServiceAreaStateFee.Add(new StateFee("Washington","WA",8.99m));
            ServiceAreaStateFee.Add(new StateFee("Oregon", "OR", 2.99m));
            ServiceAreaStateFee.Add(new StateFee("California", "CA", 16.99m));
            ServiceAreaStateFee.Add(new StateFee("Idaho", "ID", 3.99m));
            ServiceAreaStateFee.Add(new StateFee("Nevada", "NV", 5.99m));
            ServiceAreaStateFee.Add(new StateFee("Arizona", "Az", 2.99m));
            ServiceAreaStateFee.Add(new StateFee("Montana", "MT", 8.99m));
            ServiceAreaStateFee.Add(new StateFee("Wyoming", "WY", 4.99m));
            ServiceAreaStateFee.Add(new StateFee("Utah", "UT", 7.99m));
            ServiceAreaStateFee.Add(new StateFee("Colorado", "CO", 2.99m));

            OutOfAreaFee = 49.99m;
        }
        public decimal GetFeeForState(string twoLetterCode)
        {
            var state = ServiceAreaStateFee.FirstOrDefault(t => t.TwoLetterCode.Equals(twoLetterCode.ToUpper()));
            return state != null ? state.Fee : OutOfAreaFee;
        }
    }
}