using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models
{
    public class LowWeapon
    {
        public int Id { get; set; }
        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BaseMAttack { get; set; } //базовая матака оружия
        public int BasePAttack { get; set; } //базовая патака оружия
        public int SortOfWeapon { get; set; } //имеет 3 вида, используется для определения базовой прибавки при модификации
        public int MAIncrement { get; set; }
    }
}