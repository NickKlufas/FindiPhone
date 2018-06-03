using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Newtonsoft.Json;
using RestSharp;

namespace FindPhone
{
    class Program
    {
        static Iphone[] arrayOfPhones = new Iphone[] {
                new Iphone("https://www.apple.com/shop/pickup-message-recommendations?cppart=ATT/US&location=32137&product=MQAJ2LL/A", "Silver 256GB iPhone X"),
                new Iphone("https://www.apple.com/shop/pickup-message-recommendations?cppart=ATT/US&location=32137&product=MQAM2LL/A", "Black 256GB iPhone X"),
                new Iphone("https://www.apple.com/shop/pickup-message-recommendations?cppart=ATT/US&location=32137&product=MQAJ2LL/A", "Silver 64GB iPhone X"),
                new Iphone("https://www.apple.com/shop/pickup-message-recommendations?cppart=ATT/US&location=32137&product=MQAK2LL/A", "Silver 256GB iPhone X")
            };

        static void Main(string[] args)
        {
            // Create a timer
            Timer myTimer = new System.Timers.Timer();
            // Tell the timer what to do when it elapses
            myTimer.Elapsed += new ElapsedEventHandler(InvokeTheCalls);
            // Set it to go off every 20 seconds
            myTimer.Interval = 20000;
            // And start it        
            myTimer.Enabled = true;

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            //RestResponse<AppleResponse> response2 = client.Execute<AppleResponse>(request);
            Console.ReadLine();
        }

        public static void InvokeTheCalls(object source, ElapsedEventArgs e)
        {
            foreach (Iphone iphone in arrayOfPhones)
            {
                Console.WriteLine("Checking for: " + iphone.Model);
                checkForPhone(iphone);
            }
        }

        public static void checkForPhone(Iphone iphone)
        {
            var client = new RestClient(iphone.Url);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            var appleObject = JsonConvert.DeserializeObject<AppleResponse>(content);

            if (appleObject.Body.PickupMessage.NotAvailableNearOneStore != "Not available today at the nearest store.")
            {
                // Beep infinitely.
                for (int i = 0; i < int.MaxValue; i++)
                {
                    Console.Beep();
                }
            }

            Console.WriteLine("None available");
        }

        public class Iphone
        {
            public Iphone(string url, string model)
            {
                this.Url = url;
                this.Model = model;
            }
            public string Url { get; set; }
            public string Model { get; set; }
        }
    }
}
