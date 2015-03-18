﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational.Singleton
{
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
            
        }

        public static Singleton Instance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}
