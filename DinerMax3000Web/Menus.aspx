<%@ Page Title="" Language="C#" MasterPageFile="~/DinerMax3000MasterPage.master" AutoEventWireup="true" CodeFile="Menus.aspx.cs" Inherits="Menus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <asp:GridView ID="gvMenu" CssClass="MenuGridViews" DataSourceID="odsMenu" AutoGenerateColumns="false" OnRowDataBound="gvMenu_RowDataBound" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                   <div class="MenuHeadings"><%#Eval("Name")%></div> 
                    <asp:GridView ID="gvMenuItems" CssClass="MenuGridViews" runat="server"></asp:GridView>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsMenu" runat="server" SelectMethod="GetAllMenus" TypeName="DinerMax3000.Business.Menu"></asp:ObjectDataSource>
</asp:Content>

