using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Financial.Entities.Notifications
{
    public class Notifies
    {
        [NotMapped]
        public List<Notifies> NotifiesList { get; set; }
        [NotMapped]
        public string NomePropriedade { get; set; }
        [NotMapped]
        public string Mensagem { get; set; }

        public Notifies()
        {
            NotifiesList = new List<Notifies>();
        }


    }
}
