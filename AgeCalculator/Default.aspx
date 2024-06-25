<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AgeCalculator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col-md-4">
            <h2>Please Enter Your Date of Birth</h2>
            <p>
                <asp:TextBox ID="DOB" runat="server" TextMode="Date"/>
            </p>
            <p>
                <input type="submit" id="calculate" value="Calculate Age" runat="server" onserverclick="CalculateAge" />
            </p>
            <p>
                <span id="Age" runat="server" />
            </p>
        </div>
    </div>

</asp:Content>
