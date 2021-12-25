using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelByH.Models
{
    public class MathBase
    {
        public Signal lgr( Signal signal, double? baseLog = null)
        {
            var logBase = baseLog ?? 2;
            var newS = signal.SampleList.Select(i => (decimal)Math.Log((double)i, logBase)).ToList();
            return new Signal { SampleList = newS };
        }
        
    }
}
