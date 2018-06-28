using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace Demo.WebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
            Console.WriteLine("This should run every time there is a message in the queue");
            Console.WriteLine(message);
            log.WriteLine(message);
        }

        public static void FiveSecondTask([TimerTrigger("*/5 *  * * * *")] TimerInfo timer)
        {
            Console.WriteLine("This should run every 5 seconds");
        }
    }
}
