<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFormularios.Master" AutoEventWireup="true" CodeBehind="Formulario3.aspx.cs" Inherits="PaginaMujerLinda.Formulario3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="subtitulo">INGRESO DE LA INFORMACION DE LA VIVIENDA</h2>
    <br>
    <hr>
    <br>
    <div class="container main-container">
                <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label ID="Label9" runat="server" Text="Label">NÚMERO DE DOCUMENTO</asp:Label>
                <asp:TextBox ID="id_numDcto" runat="server" CssClass="form-control" placeHolder="NÚMERO DE DOCUMENTO"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="POR FAVOR, INGRESE EL NÚMERO DE DOCUMENTO" ControlToValidate="id_numDcto"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label10" runat="server" Text="Label">TIPO DE DOCUMENTO</asp:Label>
                <asp:DropDownList ID="tipoId" runat="server">
                    <asp:ListItem Text="CC" Value="0"></asp:ListItem>
                    <asp:ListItem Text="CE" Value="1"></asp:ListItem>
                    <asp:ListItem Text="PASAPORTE" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-row">
            <br>
            <div class="form-group col-md-10">
                <asp:Label ID="Label1" runat="server" Text="Label">TIPO DE VIVIENDA</asp:Label><br />
                <asp:DropDownList ID="tipoVivienda" runat="server">
                    <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                    <asp:ListItem Text="CASA" Value="1"></asp:ListItem>
                    <asp:ListItem Text="PROPIA" Value="2"></asp:ListItem>
                    <asp:ListItem Text="FAMILIAR" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <br>
            <div class="form-group col-md-4">
                <asp:Label ID="Label2" runat="server" Text="Label">SU VIVIENDA ES:</asp:Label><br />
                <asp:DropDownList ID="suViviendaEs" runat="server">
                    <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                    <asp:ListItem Text="ALQUILADA" Value="1"></asp:ListItem>
                    <asp:ListItem Text="PROPIA" Value="2"></asp:ListItem>
                    <asp:ListItem Text="FAMILIAR" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group col-med-10">
            <asp:Label ID="Label3" runat="server" Text="Label">EN EL CASO DE QUE SEA ALGUILER, ¿EL PROPIETARIO DE LA VIVIENDA PERMITE ANIMALES?</asp:Label><br />
            <asp:DropDownList ID="permiteAnimales" runat="server">
                <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                <asp:ListItem Text="SI" Value="1"></asp:ListItem>
                <asp:ListItem Text="NO" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group col-md-12">
            <asp:Label ID="Label4" runat="server" Text="Label">¿TIENE ALGÚN VECINO QUE ESTÉ ESPECIALMENTE EN CONTRA DE QUE HABITEN ANIMALES EN LAS VIVIENDAS CERCANAS?</asp:Label><br />
            <asp:DropDownList ID="vecinoCercano" runat="server">
                <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                <asp:ListItem Text="SI" Value="1"></asp:ListItem>
                <asp:ListItem Text="NO" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group col-md-10">
            <asp:Label ID="Label5" runat="server" Text="Label">¿SU VIVIENDA TIEN PATIO O TERRAZA?</asp:Label><br />
            <asp:DropDownList ID="patioTerraza" runat="server">
                <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                <asp:ListItem Text="SI" Value="1"></asp:ListItem>
                <asp:ListItem Text="NO" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group col-md-10">
            <asp:Label ID="Label6" runat="server" Text="Label">EN QUE PISO VIVE</asp:Label>
            <asp:TextBox ID="pisoVive" runat="server" plaseHolder="INGRESE SU RESPUETA" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="POR FAVOR, INDIQUE EL PISO" ControlToValidate="pisoVive"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group col-md-10">
            <asp:Label ID="Label7" runat="server" Text="Label">¿EXISTE LA POSIBILIDAD DE UNA MUDANZA EN LOS PRÓXIMOS AÑOS?</asp:Label><br />
            <asp:DropDownList ID="mudanza" runat="server">
                <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                <asp:ListItem Text="SI" Value="1"></asp:ListItem>
                <asp:ListItem Text="NO" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group col-md-10">
            <asp:Label ID="Label8" runat="server" Text="Label">¿TIENE PLANES DE VIAJER A CORTO O MEDIANO PLAZO?</asp:Label><br />
            <asp:DropDownList ID="viaje" runat="server">
                <asp:ListItem Text="SELECCIONE UNA OPCIÓN" Value="0"></asp:ListItem>
                <asp:ListItem Text="SI" Value="1"></asp:ListItem>
                <asp:ListItem Text="NO" Value="2"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="SIGUIENTE" CssClass="btn btn-primary" OnClick="siguiente_Click" />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="Formulario4.aspx" runat="server"></asp:HyperLink>
        </div>
    </div>
    <a href="index.jsp">
        <img class="inicio" src="Imagenes/inicio_profe.jpg" alt="Inicio"></a>
</asp:Content>
