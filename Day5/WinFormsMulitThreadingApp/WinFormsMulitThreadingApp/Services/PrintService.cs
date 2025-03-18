using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMulitThreadingApp.Services
{
    class PrintService
    {
        public void Print() {

            DateTime statTime = DateTime.Now;
            TimeSpan futureTime = TimeSpan.FromSeconds(10);


            while (DateTime.Now-statTime < futureTime) { 
            
                Debug.WriteLine($"Printing...time {DateTime.Now.ToString("hh:mm:ss")}");

            }
                   
        
        }



        public void PrintViaThread() { 
        
            Thread thead = new Thread(Print);

            thead.Start();
        }

        public void PrintViaTask()
        {

            Task.Run(Print);
        }
        public Task PrintViaTaskAwaitable()
        {

            return Task.Run(Print);
        }

        public Task<string> PrintViaTaskAwaitableResult()
        {

            return Task.Run(() => { 
                Print();
                return "Print completed Cashpor@amdin";

            });
        }
    }
}
