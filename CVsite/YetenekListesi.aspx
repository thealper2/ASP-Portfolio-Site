﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YetenekListesi.aspx.cs" Inherits="YetenekListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <form id="Form1" runat="server">

        <table class="table table-bordered">

            <tr>
                <th>ID</th>
                <th>YETENEK</th>
                <th>ISLEMLER</th>
            </tr>

            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID") %></td>
                            <td><%# Eval("YETENEK") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminYetenekSil.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-warnings">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminYetenekGuncelle.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="AdminYetenekEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Yetenek Ekle</asp:HyperLink>
    </form>

</asp:Content>

