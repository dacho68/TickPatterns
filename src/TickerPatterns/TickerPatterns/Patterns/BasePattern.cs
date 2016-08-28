using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickerPatterns.Common;
using System.Reactive.Linq;

namespace TickerPatterns.Patterns
{
  abstract public class BasePattern
  {
    protected IObservable<CandleTick> mOutStream;
    protected IObservable<CandleTick> mInStream;

    public IObservable<CandleTick> Output { get { return mOutStream; } }

    public IObservable<CandleTick> Input 
    { 
      get
      {
        return mInStream;
      }
      set
      {
        mOutStream = mInStream.Select(Evaluate);
      } 
    }

    abstract protected CandleTick Evaluate(CandleTick iInput);

  }
}
