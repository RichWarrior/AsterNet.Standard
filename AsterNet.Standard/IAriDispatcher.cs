using System;

namespace AsterNet.Standard
{
    interface IAriDispatcher : IDisposable
    {
        void QueueAction(Action action);
    }
}
