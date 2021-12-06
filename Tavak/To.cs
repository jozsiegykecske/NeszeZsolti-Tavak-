using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavak
{
  internal class To
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }
    private int terulet;

    public int Terulet
    {
      get { return terulet; }
      set { terulet = value; }
    }
    private string orszag;

    public string Orszag
    {
      get { return orszag; }
      set { orszag = value; }
    }
    private int min;

    public int Min
    {
      get { return min; }
      set { min = value; }
    }
    private int max;

    public int Max
    {
      get { return max; }
      set { max = value; }
    }

    public To(string nev, string felulet, string orszag)
    {
      this.nev = nev;
      if (felulet.Contains('-'))
      {
        int index = felulet.IndexOf('-');
        min = Convert.ToInt32(felulet.Substring(0,index));
        max = Convert.ToInt32(felulet.Substring(index+1,felulet.Length-index-1));
      }
      else
      {
        this.terulet = Convert.ToInt32(felulet);
      }
      
      this.orszag = orszag;
    }
  }
}
