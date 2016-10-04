<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" Inherits="L2Calc.Controls.CategoryList" %>
<%@ Import Namespace="L2Calc.Models" %>

<%= CreateHomeLinkHtml() %>

<% foreach (var category in GetCategories()) {
       Response.Write(CreateLinkHtml(category.Name));       
}%>