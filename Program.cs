using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_ConstEnumNullableVar
{
    class Program
    {
        enum Weapon { SWORD, STAFF, GUN, AXE, BOW };

        static void Main(string[] args)
        {
            int? inv = null;
            Console.WriteLine(inv.HasValue);

            Weapon select = Weapon.SWORD;

            inv = (int)select;
            Console.WriteLine(inv.HasValue);
            Console.WriteLine(inv.Value);

        }
    }
}
