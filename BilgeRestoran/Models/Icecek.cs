﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeRestoran.Models
{
    public class Icecek : BaseEntity
    {
       
        public override string ToString()
        {
            return $"{Isim} => {Fiyat:C2}";
        }
    }
}
