<!--
Tucker Godsey
Assignment 6
Due 3/12/2019
Web Server Application Development IT3047 001

This page allows users to input a location and recieve weather data
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="godseyte_Assignment06._default" %>

<!DOCTYPE html>

<!-- Cyborg Bootstrap Theme CSS -->
<link rel="stylesheet" href="cyborg.css">
<!-- Style Sheet -->
<link rel="stylesheet" href="style.css" />
<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script> 


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="align-content-center align-items-center" id="wrap">
            
            <div class="jumbotron text-center">
                <h1>Tucker Godsey Weather API</h1>
                <p>Assignment 06</p>
            </div>

            <div style="width: 80%; margin: auto;">
                
                <div class="jumbotron">
                <h3>Please input your ZIP code (United States Only)</h3>
                    <div class="form-inline">
                        <asp:TextBox ID="txtZipInput" runat="server" CssClass="form-control" ></asp:TextBox>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-dark" OnClick="btnSubmit_Click" />
                        <asp:Label ID="lblZipError" runat="server" Text="Please Enter a Valid Zip Code!" CssClass="alert-danger" Visible="false" ></asp:Label>
                    </div>
                
                </div>

            <asp:Table ID="tblResults" runat="server" Visible="False" style="margin: auto; width: 100%;" >

                <asp:TableRow>

                    <asp:TableCell>

                        <div class="card-group">

                            <div class="card">

                                <div class="card-header">
                                    <h4>Temperature</h4>
                                </div>

                                <div class="card-body">
                                    <asp:Label ID="lblTemp" runat="server" Text="" CssClass="text-lg-center"></asp:Label>
                                </div>

                            </div>

                            <div class="card">

                                <div class="card-header">
                                    <h4>Weather</h4>
                                </div>

                                <div class="card-body">
                                    <asp:Label ID="lblWeather" runat="server" Text="" CssClass="text-lg-center"></asp:Label>
                                    <asp:Image ID="imgCondition" runat="server" CssClass="img-fluid" />
                                </div>

                            </div>

                            <div class="card">

                                <div class="card-header">
                                    <h4>Cloud Cover</h4>
                                </div>

                                <div class="card-body">
                                    <asp:Label ID="lblCloud" runat="server" Text="" CssClass="text-lg-center"></asp:Label>
                                </div>

                            </div>

                            <div class="card">

                                <div class="card-header">
                                    <h4>Humidity</h4>
                                </div>

                                <div class="card-body">
                                    <asp:Label ID="lblHumidity" runat="server" Text="" CssClass="text-lg-center"></asp:Label>
                                </div>

                            </div>

                        </div>

                    </asp:TableCell>

                </asp:TableRow>

            </asp:Table>

            

            </div>

            

            

        </div>
    </form>
</body>
</html>
