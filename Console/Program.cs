using Sharp.Xmpp;
using Sharp.Xmpp.Client;
using Sharp.Xmpp.Im;
using System;
using System.IO;

namespace XmppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] secrets = File.ReadAllText("Secrets.txt").Split(',');

                using (var client = new XmppClient(secrets[0], secrets[1], secrets[2]))
                {
                    client.Connect();
                    client.SetStatus(Availability.Online);

                    client.Message += OnMessage;

                    Console.WriteLine("Connected as " + client.Jid);

                    string line;
                    while ((line = Console.ReadLine()) != null)
                    {
                        Jid to = new Jid(secrets[0], secrets[3]);
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
