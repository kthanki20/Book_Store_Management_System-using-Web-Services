<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="BSMSClient.LoginPage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .form-group{
            margin-top: 10px;
        }

        #btnSignUp{
            margin-top: 10px;
        }

        img{
            margin-left: 40px;
            margin-top: -70px;
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
     <h2 class="mt-5 mb-4">Login Here!</h2>
     <div class="row">
         <div class="col-md-6">
             <form runat="server">
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtName">Username</asp:Label>
                     <input runat="server" type="text" id="txtName" class="form-control" placeholder="Enter Username" required="required" 
                         oninvalid="this.setCustomValidity('UserName is required')" oninput="this.setCustomValidity('')"/>
                 </div>

                  <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtPassword">Password</asp:Label>
                     <input runat="server" type="text" id="txtPassword" class="form-control" placeholder="Enter Password" required="required" 
                        oninvalid="this.setCustomValidity('Password is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <asp:Button runat="server" ID="btnSignUp" Text="Login!" CssClass="btn btn-primary" OnClick="btnSignUp_Click" /><asp:Label runat="server" Text="Label" ID="insertLabel"></asp:Label>
                  <!-- <p class="mt-2">Go To Home Page.. <a href="HomePage.aspx">Back</a></p>-->
             </form>
         </div>
         <div class="col-md-6 sign-in-image">
            < <img src="../../../Assets/Images/book_wallpaper.jpg" alt="Sign In Image" width="600" height="600" class="img-fluid" />
         </div>
     </div>
 </div>

 <script src="../../../Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
