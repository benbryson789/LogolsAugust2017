using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training8
{
    public class EventSubscriber
    {
        private EventPublisher Pub;

        public EventSubscriber(EventPublisher pub)
        {
            Pub = pub;
            Pub.PersonAdded += new EventHandler<CustomEventArgs>(WriteMessage);
        }

        private void WriteMessage(object sender, CustomEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        public void Detach()
        {
            Pub.PersonAdded -= WriteMessage;
            Pub = null;
        }
    }
}
