using S22.Xmpp.Client;
using S22.Xmpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S22.Xmpp.Im;

namespace XmppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var client = new XmppClient(args[0], args[1], args[2]))
                {
                    client.Connect();
                    client.SetStatus(Availability.Online);

                    client.Message += OnMessage;

                    Console.WriteLine("Connected as " + client.Jid);

                    string line;
                    while ((line = Console.ReadLine()) != null)
                    {
                        Jid to = new Jid("something.com", "someone");
                        client.SendMessage(to, line, type: MessageType.Chat);
                    }

                    client.SetStatus(Availability.Offline);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }

            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }

        private static void OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Jid.Node + ": " + e.Message.Body);
        }
    }
}
