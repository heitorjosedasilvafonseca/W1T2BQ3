<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CarregaAluno.aspx.cs" Inherits="W1T2BQ3.CarregaAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row" style="margin-top: 15px">
        <div class="col-md-12 text-right">
            <asp:Button ID="btnCarregaAluno" CssClass="btn btn-primary" runat="server" Text="Carrega Dados Aluno" OnClick="btnCarregaAluno_Click" />
        </div>
    </div>
      <div class="row" style="margin-top: 15px">
        <div class="col-md-12 text-right">
            <asp:Label ID="lblResultado" CssClass="text text-danger" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
