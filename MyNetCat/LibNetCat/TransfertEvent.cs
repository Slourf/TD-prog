#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace LibNetCat
{
    public class TransfertEvent : EventArgs
    {
        /// <summary>
        /// Nom du fichier.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Status de progression. (0 => 1)
        /// </summary>
        public double Progress { get; set; }

        /// <summary>
        /// Est finis ?
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// Est-ce une réception ?
        /// </summary>
        public bool Inbound { get; private set; }

        /// <param name="name">Nom du fichier</param>
        /// <param name="inbound">Est-ce une réception ?</param>
        public TransfertEvent(string name, bool inbound = true)
        {
            Name = name;
            Progress = 0;
            Inbound = true;
            Done = false;
        }
    }
}
