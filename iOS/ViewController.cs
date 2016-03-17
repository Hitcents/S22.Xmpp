using System;
using UIKit;
using Sharp.Xmpp.Client;
using Sharp.Xmpp.Im;
using Sharp.Xmpp;
using System.IO;

namespace iOS
{
    public partial class ViewController : UIViewController
    {
        private XmppClient client;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            try
            {
                string[] secrets = File.ReadAllText("Secrets.txt").Split(',');

                client = new XmppClient(secrets[0], secrets[1], secrets[2]);
                client.Connect();
                client.SetStatus(Availability.Online);

                client.Message += OnMessage;

                _textView.Text += "Connected as " + client.Jid + "\n";

                _send.TouchUpInside += (sender, e) => 
                {
                    Jid to = new Jid(secrets[0], secrets[3]);
                    client.SendMessage(to, _textField.Text, type: MessageType.Chat);
                    _textView.Text += "SENT: " + _textField.Text;
                    _textField.Text = string.Empty;
                };
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }

        private void OnMessage(object sender, MessageEventArgs e)
        {
            BeginInvokeOnMainThread(() => _textView.Text += e.Jid.Node + ": " + e.Message.Body + "\n");
        }
    }
}

