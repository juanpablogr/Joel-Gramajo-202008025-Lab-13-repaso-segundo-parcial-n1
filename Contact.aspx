<%@ Page Title="Editar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Editar alumnos.</h3>
    <p>Seleccione la universidad:&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="38px" Width="302px">
        </asp:DropDownList>
    </p>
    <p>Ingrese el carné del alumno:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="276px"></asp:TextBox>
    </p>
    <p>
        <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Editar" Width="261px" OnClick="Button1_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Nombre:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="336px" Enabled="False"></asp:TextBox>
    </p>
    <p>
        Apellido:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="338px" Enabled="False"></asp:TextBox>
    </p>
    <p>
        Dirección:&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="329px" Enabled="False"></asp:TextBox>
    </p>
    <p>
        Nueva fecha de nacimiento:&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="259px" Enabled="False" TextMode="Date"></asp:TextBox>
    &nbsp;Actual:
        <asp:Label ID="Label1" runat="server" Text="----"></asp:Label>
    </p>
    <p>
        Carné:
        <asp:TextBox ID="TextBox6" runat="server" Width="356px" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Button CssClass="btn btn-success" ID="Button2" runat="server" Text="Guardar cambios" Enabled="False" OnClick="Button2_Click" />
    </p>
</asp:Content>
