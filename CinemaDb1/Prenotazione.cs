using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDb1
{
    public partial class Prenotazione
    {
        public int Id { get; set; }
        public int ProgrammazioneId { get; set; }
        public int Posti { get; set; }
        public string Mail { get; set; }

        public virtual Programmazione Programmazione { get; set; }
    }
}
