using System;
using System.Threading;

namespace Full_GRASP_And_SOLID;
    public class Reloj : TimerClient
    {
        private Recipe _adaptee;
        public void TimeOut()
        {
            Console.WriteLine("Timer: Calentitas las milanesas.");
        }
        public Reloj(Recipe adaptee)
        {
            this._adaptee = adaptee;
            _adaptee.SetCooked();
        }
    }