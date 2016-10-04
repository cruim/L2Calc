using System;
using System.Collections.Generic;
using System.Data;
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

        private static int x;
        private static int z;
        private static int w;

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



        protected void RadioButtonOfWeapon_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonOfWeapon.Checked)
            {
                DropDownListOfWeapon.Enabled = true;
                DropDownListOfArmor.Enabled = false;
                RadioButtonOfArmor.Checked = false;

            }
        }

        protected void RadioButtonOfArmor_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonOfArmor.Checked)
            {
                DropDownListOfArmor.Enabled = true;
                DropDownListOfWeapon.Enabled = false;
                RadioButtonOfWeapon.Checked = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //check for postback
            if (!IsPostBack)
            {
                //fill the dropdown
                DropDownListOfWeapon.DataSource = GetWeapons();
                DropDownListOfWeapon.DataTextField = "Name";
                DropDownListOfWeapon.DataValueField = "Id";
                DropDownListOfWeapon.DataBind();

                DropDownListOfArmor.DataSource = GetArmors();
                DropDownListOfArmor.DataTextField = "Name";
                DropDownListOfArmor.DataValueField = "Id";
                DropDownListOfArmor.DataBind();

                foreach (CountOfEnchant count in GetCount())
                {
                    DropDownListOfCount.Items.Add(count.Count.ToString());
                }
                DropDownListOfCount.DataTextField = "Count";
                DropDownListOfCount.DataValueField = "Id";
                //DropDownListOfCount.DataBind();

                //add a select text at the first position
                DropDownListOfWeapon.Items.Insert(0, new ListItem("Select a weapon", "-1", true));
                DropDownListOfArmor.Items.Insert(0, new ListItem("Select a armor", "-1", true));
                DropDownListOfCount.Items.Insert(0, new ListItem("Select a count", "-1", true));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonOfWeapon.Checked)
            {
                EnchantFunctionOfWeapon(ref x, ref z);
            }
            if (RadioButtonOfArmor.Checked)
            {
                EnchantFunctionOfArmor(ref w);
            }
            
        }



        public void EnchantFunctionOfWeapon(ref int g, ref int k)
        {
            int Id = Convert.ToInt32(DropDownListOfWeapon.SelectedValue);

            List<Weapon> weaponList = GetWeapons().Where(x => x.Id == Id).ToList();

            Weapon weapon = weaponList[0];

            var countOfEnchant = Convert.ToInt32(DropDownListOfCount.SelectedItem.Value); //уровень модификации, выбранный в DropDownListOfCount

            var oneClickEnchantPAttack = (int)Math.Ceiling(weapon.SortOfWeapon * weapon.BlessOrSimple); //базовая прибавка патаки

            int oneClickEnchantMAttack = (int)Math.Ceiling(5 * weapon.BlessOrSimple); //базовая прибавка матаки

            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant



            for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
            {
                for (int j = 0; j < 3; j++)
                {
                    if (countOfIteration > countOfEnchant)
                    {
                        return;
                    }

                    g = g + oneClickEnchantPAttack * i;
                    k = k + oneClickEnchantMAttack * i;
                    countOfIteration++;

                }
                int basePAttack = weapon.BasePAttack;
                int baseMAttack = weapon.BaseMAttack;
                int finalPAttack = basePAttack + g; //базовое значение физ.атаки + изменения от модификации
                int finalMAttack = baseMAttack + k;
                Literal1.Text = weapon.Name + " +" + countOfEnchant + " Физическая атака " + finalPAttack + " Магическая Атака " + finalMAttack + "<br />";
            }
        }

        public void EnchantFunctionOfArmor(ref int g)
        {
            int Id = Convert.ToInt32(DropDownListOfArmor.SelectedValue);

            List<Armor> armorList = GetArmors().Where(x => x.Id == Id).ToList();

            Armor armor = armorList[0];

            int countOfEnchant = Convert.ToInt32(DropDownListOfCount.SelectedValue); //уровень модификации

            var oneClickEnchantPDeff = (int)Math.Ceiling(2 * armor.BlessOrSimple); //базовая прибавка защиты

            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant



            for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
            {
                for (int j = 0; j < 3; j++)
                {
                    if (countOfIteration > countOfEnchant)
                    {
                        return;
                    }
                    if (i > 3) { i = 3; }
                    g = g + oneClickEnchantPDeff * i;
                    countOfIteration++;
                }
                int basePDeff = armor.BasePDeff;
                int finalPDeff = basePDeff + w;
                Literal1.Text = armor.Name + " +" + countOfEnchant + " Физическая защита " + finalPDeff + "<br/>";
            }
        }
    }
}