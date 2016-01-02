using System;
using AppKit;

namespace MacLib
{
    public class MyClass
    {
        public MyClass ()
        {
            NSApplication.Init ();

            Console.WriteLine ("Shared app: {0}", NSApplication.SharedApplication);
        }
    }
}

