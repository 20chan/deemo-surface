using System;
using System.Threading;
using Hook;

namespace deemo_surface {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            var waiter = new ManualResetEvent(false);
            Console.CancelKeyPress += (o, e) => {
                e.Cancel = true;
                waiter.Set();
            };

            RegisterEvents();

            MouseHook.HookStart();
            waiter.WaitOne();
            MouseHook.HookEnd();
        }

        static void RegisterEvents() {
            MouseHook.MouseDown += (ty, x, y) => {
                Console.WriteLine($"{ty}, {x}, {y}");
                return true;
            };
        }
    }
}