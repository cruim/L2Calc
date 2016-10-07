using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using L2Calc.Models;
using L2Calc.Models.Entities;
using L2Calc.Models.Repository;

namespace L2Calc.Pages
{
    public partial class D_S80 : System.Web.UI.Page
    {
        private LowArmorRepository armorRepository = new LowArmorRepository();
        private LowWeaponRepository weaponRepository = new LowWeaponRepository();
        private CountRepository countRepository = new CountRepository();

        private static int x;
        private static int z;
        private static int w;

        protected IEnumerable<LowArmor> GetArmors()
        {
            return armorRepository.Armors
                .OrderBy(a => a.Name);

        }
        protected IEnumerable<LowWeapon> GetWeapons()
        {
            return weaponRepository.LowWeapons
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

                //DropDownListOfCount.DataSource = GetCount();
                //DropDownListOfCount.DataTextField = "Count";
                //DropDownListOfCount.DataValueField = "Id";
                //DropDownListOfCount.DataBind();
                foreach (CountOfEnchant count in GetCount())
                {
                    DropDownListOfCount.Items.Add(count.Count.ToString());
                }
                //DropDownListOfCount.DataTextField = "Count";
                //DropDownListOfCount.DataValueField = "Id";
                //DropDownListOfCount.DataBind();

                //add a select text at the first position
                DropDownListOfWeapon.Items.Insert(0, new ListItem("Выберите Оружие", "-1", true));
                DropDownListOfArmor.Items.Insert(0, new ListItem("Выберите Доспех", "-1", true));
                DropDownListOfCount.Items.Insert(0, new ListItem("Уровень модификации", "-1", true));

            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {


            if (RadioButtonOfWeapon.Checked && DropDownListOfWeapon.SelectedItem.Text != "Выберите Оружие")
            {
                EnchantFunctionOfWeapon(ref x, ref z);
                x = 0;
                z = 0;
            }
            if (RadioButtonOfArmor.Checked && DropDownListOfArmor.SelectedItem.Text != "Выберите Доспех")
            {
                EnchantFunctionOfArmor(ref w);
                w = 0;
            }


        }



        public void EnchantFunctionOfWeapon(ref int g, ref int k)
        {
            string name = DropDownListOfWeapon.SelectedItem.Text;

            List<LowWeapon> weaponList = GetWeapons().Where(x => x.Name == name).ToList();

            LowWeapon weapon = weaponList[0];
            int basePAttack = weapon.BasePAttack;
            int baseMAttack = weapon.BaseMAttack;
            var countOfEnchant = Convert.ToInt32(DropDownListOfCount.SelectedItem.Text);
            //уровень модификации, выбранный в DropDownListOfCount

            var oneClickEnchantPAttack = weapon.SortOfWeapon;
            //базовая прибавка патаки

            int oneClickEnchantMAttack = weapon.MAIncrement; //базовая прибавка матаки

            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant

            if (countOfEnchant == 0)
            {
                Literal1.Text = weapon.Name + " +" + countOfEnchant + " Физическая атака " + basePAttack +
                                        " Магическая Атака " + baseMAttack + "<br />";
            }
            else
            {
                for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (countOfIteration > countOfEnchant)
                        {
                            var finalPAttack = basePAttack + g;
                            var finalMAttack = baseMAttack + k;
                            Literal1.Text = weapon.Name + " +" + countOfEnchant + " Физическая атака " + finalPAttack +
                                            " Магическая Атака " + finalMAttack + "<br />";
                            return;
                        }

                        if (i > 2) { i = 2; }

                        g = g + oneClickEnchantPAttack * i;
                        k = k + oneClickEnchantMAttack * i;
                        countOfIteration++;

                    }
                }
            }

        }

        public void EnchantFunctionOfArmor(ref int g)
        {
            string name = DropDownListOfArmor.SelectedItem.Text;

            List<LowArmor> armorList = GetArmors().Where(x => x.Name == name).ToList();

            LowArmor armor = armorList[0];

            var countOfEnchant = Convert.ToInt32(DropDownListOfCount.SelectedValue); //уровень модификации

            var oneClickEnchantPDeff = 1; //базовая прибавка защиты

            int countOfIteration = 1; //счетчик, позволяющий прервать цикл при countOfIteration > countOfEnchant

            var basePDeff = armor.BasePDeff;

            if (countOfEnchant == 0)
            {
                Literal1.Text = armor.Name + " +" + countOfEnchant + " Физическая защита " + basePDeff + "<br/>";
            }
            else 
            {
                for (int i = 1; i <= countOfEnchant; i++) //i - увеличивает коэффициент каждого четвертого шага на 1
                {

                    if (countOfIteration > countOfEnchant)
                    {
                        var finalPDeff = basePDeff + g;
                        Literal1.Text = armor.Name + " +" + countOfEnchant + " Физическая защита " + finalPDeff +
                                        "<br/>";
                        return;
                    }
                    if (i > 3) { i = 3; }

                    if (armor.SortOfArmor == 1 && countOfIteration > 4)
                    {
                        oneClickEnchantPDeff = 3;
                    }
                    if (armor.SortOfArmor == 2 && countOfIteration > 3)
                    {
                        oneClickEnchantPDeff = 3;
                    }

                    g = g + oneClickEnchantPDeff;
                    countOfIteration++;


                }


            }
            }

        }
    }
