using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp.DyreTyper
{
    /// <summary>
    /// Fisk klasse som alle fisk skal arve fra
    /// </summary>
    public class Fisk : Dyr
    {
        /// <summary>
        /// Constructor for insekt
        /// </summary>
        /// <param name="navn">navnet på dyretypen</param>
        public Fisk(string navn) : base(navn)
        {
        }
    }
}
