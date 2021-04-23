<%@ Page Title="Eliminar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1.Eliminar" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Seleccione una universidad:
        <asp:DropDownList ID="DropDownList1" runat="server" Height="41px" Width="517px">
        </asp:DropDownList>
    </p>
    <p>Seleccione un grupo de personas:
        <asp:DropDownList ID="DropDownList2" runat="server" Height="31px" Width="479px">
            <asp:ListItem>Alumnos</asp:ListItem>
            <asp:ListItem>Profesores</asp:ListItem>
            <asp:ListItem>Administrativos</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>Ingrese el identificador a buscar (carné, id de profesor o número de IGSS):&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="214px"></asp:TextBox>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button CssClass="btn btn-danger" ID="Button1" runat="server" Text="Borrar" Width="318px" OnClick="Button1_Click" />
    </p>
    <p>&nbsp;</p>
    </asp:Content>

