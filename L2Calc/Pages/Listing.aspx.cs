using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using L2Calc.Models;
using L2Calc.Models.Repository;

namespace L2Calc.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private ArmorRepository armorRepository = new ArmorRepository();
        private WeaponRepository weaponRepository = new WeaponRepository();
        private CountRepository countRepository = new CountRepository();

        protected IEnumerable<Armor> GetArmors()
        {
            return armorRepository.Armors
                .OrderBy(a => a.Name);
            
        }
        protected IEnumerable<Weapon> GetWeapons()
        {
            return weaponRepository.Weapons
                .OrderBy(a => a.Name);

        }
        protected IEnumerable<CountOfEnchant> GetCount()
        {
            return countRepository.Counts;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}