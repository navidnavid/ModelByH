using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelByH.Models
{
    public class ModifySignal
    {
        private Signal Signal;
        private Signal SignalMod;
        public Signal ModItemsByItem(Signal signal, Signal signalMod, ArithmeticType arithmeticType)
        {
            Signal = signal;
            SignalMod = signalMod;
            var modSignal = new Signal();
            switch (arithmeticType) 
            {
                case ArithmeticType.ADD:
                    AddByItem();
                    break;
                case ArithmeticType.SUB:
                    SubByItem();
                    break;

            }
                
            return modSignal;
        }

        private Signal SubByItem()
        {
            var res = new Signal();
            for (int i = 0; i < Signal.SampleList.Count; i++)
            {
                res.SampleList.Add(Signal.SampleList[i] - SignalMod.SampleList[i]);
            }
            return res;
        }
        private Signal AddByItem()
        {
            var res = new Signal();
            for (int i = 0; i < Signal.SampleList.Count; i++)
            {
                res.SampleList.Add(Signal.SampleList[i] + SignalMod.SampleList[i]);
            }
            return res;

        }


    }
    public class Signal
    {
        public Signal( )
        {
            SampleList = new List<decimal>();
        }

        public List<decimal> SampleList { get; set; }
    }
}
