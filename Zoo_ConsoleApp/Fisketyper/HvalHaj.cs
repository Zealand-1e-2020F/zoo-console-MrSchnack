using System;
using System.Collections.Generic;
using System.Text;
using Zoo_ConsoleApp.DyreTyper;
using Zoo_ConsoleApp.Interface;

namespace Zoo_ConsoleApp.Fisketyper
{
    public class HvalHaj : Fisk, IRovDyr 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="navn"></param>
        public HvalHaj(string navn) : base(navn)
        {
        }

        public bool ErRovDyr()
        {
            return true;
        }
    }
}
