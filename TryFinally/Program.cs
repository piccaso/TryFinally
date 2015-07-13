using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFinally {

    class Program {
        static void Main(string[] args) {
            int i = int.Parse(args[0]);
            try {
                iWillThrowUp(ref i);
            } catch(Exception e) {
                Console.WriteLine("EX:" + e.Message);
            }
            Console.WriteLine("i:" + i.ToString());
        }
        static void iWillThrowUp(ref int i) {
            try {
                if(i>0 || i<0) throw new Exception("OMG!");
            } finally {
                i++;
            }
        }
    }
}
