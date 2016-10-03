<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="L2Calc.Pages.Listing" 
    MasterPageFile="~/Pages/Store.Master"%>

<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">

     <%
         foreach (L2Calc.Models.Armor armor in GetArmors())
         {
             DropDownList1.Items.Add(armor.Name);
             DropDownList1.Font.Bold = true;
         }
         %>
        <%
         foreach (L2Calc.Models.Weapon weapon in GetWeapons())
         {
             DropDownList2.Items.Add(weapon.Name);
         }
             %>
        <%
         foreach (L2Calc.Models.CountOfEnchant count in GetCount())
         {
             DropDownList3.Items.Add(count.Count.ToString());
         }
             %>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
    </div>
    
</asp:Content>
