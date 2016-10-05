<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="L2Calc.Pages.Listing"
    MasterPageFile="~/Pages/Store.Master" %>

<%@ Import Namespace="System.Web.Routing" %>

<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">






        <%--<div id="button">>--%>
            
            <asp:DropDownList ID="DropDownListOfWeapon" runat="server" Height="30">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownListOfArmor" runat="server" Height="30" Enabled="False">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownListOfCount" runat="server" Height="30">
            </asp:DropDownList>
        <%--</div>>--%>


        

        <asp:RadioButton ID="RadioButtonOfWeapon" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="RadioButtonOfWeapon_CheckedChanged" Checked="True" />
        <asp:RadioButton ID="RadioButtonOfArmor" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="RadioButtonOfArmor_CheckedChanged" />
        
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" />
       

        <div id="button">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>


        <br />

    </div>

</asp:Content>
