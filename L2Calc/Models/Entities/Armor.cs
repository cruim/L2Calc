using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models
{
    public class Armor
    {
        public int Id { get; set; }
        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BasePDeff { get; set; } //базовая защита доспеха
        public decimal BlessOrSimple { get; set; } //имеет величину 1 или 1.5, является коэффициентом базовой прибавки
    }
}