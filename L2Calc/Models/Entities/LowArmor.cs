using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Entities
{
    public class LowArmor
    {
        public int Id { get; set; }
        public string Name { get; set; } //имя предмета, отображается в выпадающем комбобоксе
        public int BasePDeff { get; set; } //базовая защита доспеха

        public int SortOfArmor { get; set; }
    }
}