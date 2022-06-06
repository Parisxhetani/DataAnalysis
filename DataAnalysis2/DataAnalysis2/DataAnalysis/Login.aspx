<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DataAnalysis.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
                    <div class="divMain">
                        <div class="leftDiv">
                            <div class="login100-pic js-tilt " data-tilt>

                                <img src="images/img-01.png" alt="IMG" />
                            </div>
                        </div>
                        <div class="rigthDiv">
                            <form class="login100-form validate-form">
                                <span class="login100-form-title">UNYT Login
                                </span>

                                <div class="wrap-input100 validate-input" data-validate="Valid email is required: ex@abc.xyz">
                                    <!--<input class="input100" type="text" name="user_email" placeholder="Email" />-->
                                    <asp:TextBox ID="email_TextBox" runat="server" CssClass="input100" placeholder="Email"></asp:TextBox>
                                    <span class="focus-input100"></span>
                                    <span class="symbol-input100">
                                        <i class="fa fa-envelope" aria-hidden="true"></i>
                                    </span>
                                </div>

                                <div class="wrap-input100 validate-input" data-validate="Password is required">
                                    <!--<input class="input100" type="password" name="password" placeholder="Password" />-->
                                    <asp:TextBox ID="password_TextBox" runat="server" CssClass="input100" TextMode="Password" placeholder="Password"></asp:TextBox>
                                    <span class="focus-input100"></span>
                                    <span class="symbol-input100">
                                        <i class="fa fa-lock" aria-hidden="true"></i>
                                    </span>
                                </div>

                                <div class="container-login100-form-btn">
                                    <!--<button class="login100-form-btn" type="submit">
                                        Login
                                    </button>-->
                                    <asp:Button ID="Button1" runat="server" Text="Login" class="login100-form-btn" OnClick="Button1_Click" />
                                </div>
                            </form>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/tilt/tilt.jquery.min.js"></script>
    <script>
        $('.js-tilt').tilt({
            scale: 1.1
        })
    </script>
    <script src="js/main.js"></script>
</body>
</html>
