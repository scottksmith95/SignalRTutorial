using System.Collections.Generic;
using SignalR.Hubs;

namespace SignalRTutorial.Hubs
{
    public class TagHub : Hub
    {
        static List<string> _tags = new List<string>();

        static TagHub()
        {
            _tags.Add("c#");
            _tags.Add(".NET");
            _tags.Add("SignalR");
        }

        public void getTags()
        {
            //Call the initTags method on the calling client
            Caller.initTags(_tags);
        }

        public void setTag(string tag)
        {
            //Add the new tag to the list of tags
            _tags.Add(tag);

            //Call the addTag method on all connected clients
            Clients.addTag(tag);
        }
    }
}