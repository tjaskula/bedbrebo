using System;
using System.Collections.Generic;
using BedBrebo.Domain.Core;

namespace BedBrebo.Infrastructure.Messaging
{
    public class CommandDispatcher
    {
        private readonly Dictionary<Type, Action<ICommand>> _dictionary = new Dictionary<Type, Action<ICommand>>();

        public void Subscribe<T>(Action<T> commandHandler) where T : ICommand
        {
            _dictionary.Add(typeof(T), x => commandHandler((T)x));
        }

        public void Dispatch(ICommand command)
        {
            Action<ICommand> handler;
            if (!_dictionary.TryGetValue(command.GetType(), out handler))
            {
                throw new Exception("cannot map " + command.GetType());
            }
            handler(command);
        }
    }
}