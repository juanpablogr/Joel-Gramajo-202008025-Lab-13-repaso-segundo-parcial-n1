<%@ Page Title="Leer datos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>universidad </h3>
    <p>Seleccione la universidad a mostrar:&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="282px" AutoPostBack="True" OnTextChanged="DropDownList1_TextChanged">
        </asp:DropDownList>
    </p>
    <p>Seleccione el grupo de personas a mostrar:
        <asp:DropDownList ID="DropDownList2" runat="server" Height="23px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="239px" AutoPostBack="True" OnTextChanged="DropDownList2_TextChanged">
            <asp:ListItem>Alumnos</asp:ListItem>
            <asp:ListItem>Profesores</asp:ListItem>
            <asp:ListItem>Administrativos</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </p>
    <p>&nbsp;</p>
    </asp:Content>
