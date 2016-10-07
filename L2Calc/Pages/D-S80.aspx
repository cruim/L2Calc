<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="D-S80.aspx.cs" Inherits="L2Calc.Pages.D_S80" 

MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">


        <h1 >D - S80</h1>



        <%--<div id="button">>--%>
            
            <asp:DropDownList ID="DropDownListOfWeapon" runat="server" Height="30">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownListOfArmor" runat="server" Height="30" Enabled="False">
            </asp:DropDownList>
            <br />
        <br />
            <asp:DropDownList ID="DropDownListOfCount" runat="server" Height="30">
            </asp:DropDownList>
        <%--</div>>--%>


        

        
        
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click" Height="30px" Width="80" />
        <br />
        <br />
       <asp:RadioButton ID="RadioButtonOfWeapon" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="RadioButtonOfWeapon_CheckedChanged" Checked="True" />Оружие&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     
        <asp:RadioButton ID="RadioButtonOfArmor" runat="server" AutoPostBack="True" GroupName="1" OnCheckedChanged="RadioButtonOfArmor_CheckedChanged" /> Доспех

        
            <br />
        <br />

        
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        


        <br />

    </div>

</asp:Content>
