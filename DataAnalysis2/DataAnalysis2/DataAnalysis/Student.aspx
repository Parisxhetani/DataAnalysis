<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="DataAnalysis.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student</title>
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
                        <span>Student </span><span style="color: #333333;">Dashboard</span>
                        <div class="divMain" style="padding-bottom: 3%; padding-top: 5%; margin-left: 26%;">
                            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        </div>
                        <div class="divMain" style="padding-bottom: 3%; padding-top: 5%; margin-left: 26%;">
                            <asp:Label ID="cgpa_label" runat="server" Text="vk:)"></asp:Label>
                        </div>
                    </div>
                    <asp:Button ID="LogoutButton" runat="server" Text="Logout" class="login100-form-btn" OnClick="LogoutButton_Click" Style="margin: auto; background-color: #333333; width: 20%" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
