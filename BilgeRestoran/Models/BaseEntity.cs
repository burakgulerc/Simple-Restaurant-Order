using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestoran.Models
{
    public abstract class BaseEntity
    {
        decimal _fiyat;

        public string Isim { get; set; }
        public decimal Fiyat { get; set; }

    }
}
