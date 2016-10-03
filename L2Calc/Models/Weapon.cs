using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BaseMAttack { get; set; } //базовая матака оружия
        public int BasePAttack { get; set; } //базовая патака оружия
        public int SortOfWeapon { get; set; } //имеет 3 вида, используется для определения базовой прибавки при модификации
        public decimal BlessOrSimple { get; set; } //имеет величину 1 или 1.5, является коэффициентом базовой прибавки
    }
}