using System;
using System.Threading.Tasks;

namespace AsterNet.Standard.Dispatchers
{
    sealed class AsyncDispatcher : IAriDispatcher
    {
        public void Dispose()
        {

        }

        public async void QueueAction(Action action)
        {
            await Task.Run(action);
        }
    }

}
