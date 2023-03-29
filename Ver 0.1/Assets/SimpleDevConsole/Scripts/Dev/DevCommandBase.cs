using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DigitalCircuits.Core.DevTools
{
    public class DevCommandBase
    {
        public string _commandID;
        public string _commandDescription;
        public string _commandFormat;

        public string CommandID { get { return _commandID; } }
        public string CommandDescription { get { return _commandDescription; } }
        public string CommandFormat { get { return _commandFormat; } }

        public DevCommandBase(string id, string description, string format)
        {
            _commandID = id;
            _commandDescription = description;
            _commandFormat = format;
        }
    }

    public class DevCommand : DevCommandBase
    {
        private Action command;

        public DevCommand(string id, string description, string format, Action command) : base(id, description, format)
        {
            this.command = command;
        }

        public void Invoke()
        {
            command.Invoke();
        }
    }

    public class DevCommand<T1> : DevCommandBase
    {
        private Action<T1> command;

        public DevCommand(string id, string description, string format, Action<T1> command) : base(id, description, format)
        {
            this.command = command;
        }

        public void Invoke(T1 value)
        {
            command.Invoke(value);
        }
    }
}