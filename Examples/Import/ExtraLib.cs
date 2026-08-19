//====================================================================
// Custom Library
//====================================================================

namespace ExtraLib {
  public static class UtilityClass {
    // Calculate the list of prime numbers using the Sieve of Eratosthenes
    public static int[] GetPrimeNumbers(int max) {
      var composite = new bool[max + 1];
      if (max >= 2) {
        for (var p = 2; ; ++p) {
          var p2 = p * p;
          if (p2 <= max) {
            if (!composite[p]) {
              for (int i = p2; i <= max; i += p)
                composite[i] = true;
            }
          }
          else
            break;
        }

        int count = 0;
        for (int i = 2; i <= max; i++) {
          if (!composite[i])
            ++count;
        }
        var r = new int[count];
        count = 0;

        for (int i = 2; i <= max; i++) {
          if (!composite[i])
            r[count++] = i;
        }
        return r;
      }
      return [];
    }

    public static double[] GetDoubleValues(int count) {
      var d = new double[count];
      for (int i = 0; i < count; ++i)
        d[i] = i * i;
      return d;
    }

    public static void MultiplyValues(double[] a, double m) {
      for (int i = 0; i < a.Length; ++i)
        a[i] = a[i] * m;
    }

    public static byte[] GetByteValues(int count) {
      var d = new byte[count];
      for (int i = 0; i < count; ++i)
        d[i] = (byte)(i * i);
      return d;
    }

    public static DateTime GetDateValue(in DateTime d, ref DateTime d2, out DateTime d3) {
      d3 = d;
      d2 = d;
      return d;
    }
  }

  public class BadgeClass {
    public string   Name;
    public DateTime Date;
    public Guid     Id;
    public int      Number;
    public int[]    IntArray;
        
    public BadgeClass(string name, int i, Guid id) {
      Name     = name;
      Number   = i;
      Id       = id;
      Date     = DateTime.Now;
      IntArray = [1, 2, 3, 4];
    }

    public string Description => string.Format("{0}-{1}, Id: {2}", Name, Number, Id);


    public double[] GetDoubleValues() {
      var d = new double[Number];
      for (int i = 0; i < Number; ++i)
        d[i] = i * i;
      return d;
    }
  }
}
//==========================================================================


