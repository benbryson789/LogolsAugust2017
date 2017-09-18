using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training8
{
    public class EventPublisher
    {
        public event EventHandler<CustomEventArgs> PersonAdded;

        public void RaiseEvent()
        {

            if(PersonAdded != null)
            {
                CustomEventArgs e = new CustomEventArgs("event raised");
                PersonAdded(this, e);
            }
        }
    }
}
