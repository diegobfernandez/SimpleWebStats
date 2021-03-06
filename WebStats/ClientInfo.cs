﻿using System;

namespace WebStats
{
    public class ClientInfo
    {
        public OS OS { get; private set; }
        public Device Device { get; private set; }
        public UserAgent UserAgent { get; private set; }

        public ClientInfo(OS os, Device device, UserAgent userAgent)
        {
            OS = os;
            Device = device;
            UserAgent = userAgent;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", OS, Device, UserAgent);
        }
    }
}