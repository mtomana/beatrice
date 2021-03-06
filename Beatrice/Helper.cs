﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatrice
{
    public static class Helper
    {
        public static void Raise(this Action eventHandler)
        {
            if (eventHandler != null)
            {
                eventHandler();
            }
        }

        public static T Raise<T>(this Func<T> eventHandler)
        {
            if (eventHandler != null)
            {
                return eventHandler();
            }
            else
            {
                return default(T);
            }
        }

        public static void Raise<T>(this Action<T> eventHandler, T parameter)
        {
            if (eventHandler != null)
            {
                eventHandler(parameter);
            }

        }
    }
}
