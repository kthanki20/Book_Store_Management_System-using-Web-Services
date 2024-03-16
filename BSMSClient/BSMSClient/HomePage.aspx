<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BSMSClient.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
<style>
    .container {
        padding-top: 35px;
    }

    .margin-top{
        margin-top: 100px;
    }

    form{
        margin-top: 20px;
    }

    img{
        margin-left: 40px;
        margin-top: 25px;
        width : 1000px;
        height: 1000px;
    }

    .sign-in-image {
        display: none; /* Hide image on small screens */
    }

    @media (min-width: 768px) {
        .sign-in-image {
            display: block; /* Show image on medium screens and above */
        }
    }
</style>

</head>
<body>
    <div class="container">
        <h1>About Us</h1>
        <p>Book Store Management System</p>
        <p></p>
        <p><a href="Register.aspx">Register Now</a></p>
        <p><a href="LoginPage.aspx">Login Now</a></p>
           <div class="col-md-6 sign-in-image">
       <img src="../../../Assets/Images/book18.jpg" alt="Sign In Image" class="img-fluid" />
   </div>

    </div>
</body>
</html>
