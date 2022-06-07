<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="DataAnalysis.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
    <link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="vendor/animate/animate.css" />
    <link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css" />
    <link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css" />
    <link rel="stylesheet" type="text/css" href="css/util.css" />
    <link rel="stylesheet" type="text/css" href="css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="limiter">
            <div class="container-login100">
                <div class="wrap-login100">

                    <div class="login100-form-title">
                        <span>Admin Dashboard</span>
                    </div>

                    <div class="divMain" style="padding-bottom: 3%;">
                        <asp:TextBox ID="EmailTextbox" runat="server" CssClass="input100" placeholder="Email"></asp:TextBox>
                        <asp:TextBox ID="PasswordTextbox" runat="server" CssClass="input100" placeholder="Password"></asp:TextBox>
                    </div>

                    <div class="divMain" style="padding-bottom: 20%">
                        <asp:Button ID="InsertButton" runat="server" Text="Insert" class="login100-form-btn" OnClick="InsertButton_Click" />
                        <asp:Button ID="UpdateButton" runat="server" Text="Update" class="login100-form-btn" OnClick="UpdateButton_Click" />
                        <asp:Button ID="DeleteButton" runat="server" Text="Delete" class="login100-form-btn" OnClick="DeleteButton_Click" />
                    </div>
                    <div class="divMain" style="padding-bottom: 3%">

                        <asp:HiddenField ID="EmailHiddenField" runat="server" />
                        <asp:DropDownList ID="DropDownList1" runat="server" class="login100-form-btn">
                            <asp:ListItem>Student Email</asp:ListItem>
                        </asp:DropDownList>

                        <asp:HiddenField ID="GradeHiddenField" runat="server" />
                        <asp:DropDownList ID="DropDownList2" runat="server" class="login100-form-btn">
                            <asp:ListItem Value="0">Grade</asp:ListItem>
                            <asp:ListItem Value="1">A</asp:ListItem>
                            <asp:ListItem Value="2">A-</asp:ListItem>
                            <asp:ListItem Value="3">B+</asp:ListItem>
                            <asp:ListItem Value="4">B</asp:ListItem>
                            <asp:ListItem Value="5">B-</asp:ListItem>
                            <asp:ListItem Value="6">C+</asp:ListItem>
                            <asp:ListItem Value="7">C</asp:ListItem>
                            <asp:ListItem Value="8">C-</asp:ListItem>
                            <asp:ListItem Value="9">D+</asp:ListItem>
                            <asp:ListItem Value="10">D</asp:ListItem>
                            <asp:ListItem Value="11">D-</asp:ListItem>
                            <asp:ListItem Value="0">F</asp:ListItem>
                        </asp:DropDownList>

                        <asp:TextBox ID="ClassNameTextBox" runat="server" CssClass="input100" placeholder="Class Name"></asp:TextBox>
                    </div>
                    <div class="divMain" style="padding-bottom: 10%">
                        <asp:Button ID="AddGradeButton" runat="server" Text="Insert" class="login100-form-btn" OnClick="AddGradeButton_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>