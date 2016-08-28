using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickerPatterns.Common
{
  public class CandleTick
  {
    public DateTime Date { get; set; }
    public double Open { get; set; }
    public double High { get; set; }
    public double Low { get; set; }
    public double Close { get; set; }
    public double Volume { get; set; }

    public static double Epsilon = 0.0001; 

    public CandleTickType Type
    {
      get 
      {
        if ((Open - Close) > Epsilon)
        {
          return CandleTickType.White;
        }
        else if  ((Close - Open) > Epsilon)
        {
          return CandleTickType.Black;
        }
        return CandleTickType.Doji;
      }
    }
  }
}
