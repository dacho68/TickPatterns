using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickerPatterns.Common;

namespace TickerPatterns.Patterns
{
  public class TwoTicksPattern : BasePattern
  {
    private LinkedList<CandleTick> mBuffer;
    public TwoTicksPattern()
    {
      mBuffer = new LinkedList<CandleTick>();
    }

    public void OnMatch(Func<bool> iFunc)
    {

    }

    protected override CandleTick Evaluate(CandleTick iInput)
    {
      if (mBuffer.Count>= 2)
      {
        mBuffer.RemoveFirst();
      }
      mBuffer.AddLast(iInput);

      double wMax;
      double wMin;
      int i = 0;
      foreach (var wItem in mBuffer)
      {

        i++;
      }
      var wCandleTick = new CandleTick();
      return wCandleTick;

    }
  }
}
