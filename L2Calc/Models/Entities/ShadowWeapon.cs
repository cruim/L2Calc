using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Entities
{
    public class ShadowWeapon
    {
        public int Id { get; set; }
        public int Odds { get; set; } //шанс модификации предмета на каждом шаге
    }
}