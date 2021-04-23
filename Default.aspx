<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Joel_Gramajo_202008025_Lab_13_repaso_segundo_parcial_n1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CONTROL DE PERSONAS</h1>
        <p class="lead">Para ingresar personas por favor complete la siguiente información:</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Datos genéricos</h2>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Universidad:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="177px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="177px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Width="177px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Dirección:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Width="177px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Fecha de nacimiento:"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>Datos específicos</h2>
            <p>
                Seleccione el rol de la persona a ingresar:</p>
            <p>
                <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Alumno" Width="260px" />
            </p>
            <p>
                <asp:Button CssClass="btn btn-primary" ID="Button2" runat="server" OnClick="Button2_Click" Text="Profesor" Width="260px" />
            </p>
            <p>
                <asp:Button CssClass="btn btn-primary" ID="Button3" runat="server" OnClick="Button3_Click" Text="Administrativo" Width="260px" />
            </p>
        </div>
        <div class="col-md-4">
            <p>
                <asp:Label ID="Label6" runat="server" Text="Carné:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="Id profesor:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label8" runat="server" Text="Título universitario:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label9" runat="server" Text="Número IGSS:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label10" runat="server" Text="Profesión:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label11" runat="server" Text="Fecha de inicio de labores:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox11" runat="server" TextMode="Date"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label12" runat="server" Text="Fecha de fin de labores:"></asp:Label>
            &nbsp;
                <asp:TextBox ID="TextBox12" runat="server" TextMode="Date"></asp:TextBox>
            </p>
            <p>
                <asp:Button CssClass="btn btn-warning" ID="Button4" runat="server" Text="Guardar datos" OnClick="Button4_Click" />
            </p>
        </div>
    </div>

</asp:Content>
