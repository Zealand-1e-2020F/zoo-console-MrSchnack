using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp.DyreTyper
{
    /// <summary>
    /// Insekt klasse som alle insketer skal arve fra
    /// </summary>
    public class Insekt : Dyr
    {
        /// <summary>
        /// Constructor for insekt
        /// </summary>
        /// <param name="navn">navnet på dyretypen</param>
        public Insekt(string navn) : base(navn)
        {
        }
    }
}
