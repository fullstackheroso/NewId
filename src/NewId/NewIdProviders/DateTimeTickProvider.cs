using System;

namespace MassTransit.NewIdProviders
{
    public class DateTimeTickProvider :
        ITickProvider
    {
        public long Ticks => DateTime.UtcNow.Ticks;
    }
}
