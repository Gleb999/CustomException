using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        public class CarIsDeadException : ApplicationException
        {
            /*public void Accelerate (int delta)
            {
                CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName),
                    "You have a lead foot", DataTime.Now);
                ex.HelpLink = "http://www.CarsRus.com";
                throw ex;
            }
            private string messageDetails = String.Empty;*/

            public DateTime ErrorTimeStamp { get; set; }
            public string CauseOfError { get; set; }
            
            public CarIsDeadException() { }
            public CarIsDeadException(string message, string cause, DateTime time)
            :base(message){
                CauseOfError = cause;
                ErrorTimeStamp = time;
            }

            public override string Message
            {
                get
                {
                    return string.Format("Car Error Messaqe: {0}", messageDetails);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            Console.ReadLine();

        }
    }
}
