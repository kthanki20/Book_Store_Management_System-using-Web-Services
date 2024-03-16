<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateOrder.aspx.cs" Inherits="BSMSClient.UpdateOrder" %>

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
     <script>
         function togglePasswordVisibility() {
             var passwordField = document.getElementById("txtPassword");
             if (passwordField.type === "password") {
                 passwordField.type = "text";
             } else {
                 passwordField.type = "password";
             }
         }
     </script>
</head>
<body>
     <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Book Store Management System</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">                 
                    <li class="nav-item">
                        <a class="nav-link" href="OrderBook.aspx">Order</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="DoPayment.aspx">Payment</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

     <div class="container">
     <h2 class="mt-5 mb-4">Let's Order Something</h2>
     <div class="row">
         <div class="col-md-6">
             <form runat="server">
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtid">id</asp:Label>
                     <input runat="server" type="number" id="txtid" class="form-control" placeholder="Enter Customer Identity" required="required" 
                         oninvalid="this.setCustomValidity('Identity is required')" oninput="this.setCustomValidity('')"/>
                 </div>

                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtbid">Book_Identity</asp:Label>
                     <input runat="server" type="number" id="txtbid" class="form-control" placeholder="Enter Book identity" required="required"
                         oninvalid="this.setCustomValidity('Identity is required')" oninput="this.setCustomValidity('')" />
                 </div>
                
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtprice">Price</asp:Label>
                     <input runat="server" type="number" id="txtprice" class="form-control" placeholder="Enter Price" required="required"
                         oninvalid="this.setCustomValidity('price is required')" oninput="this.setCustomValidity('')"/>
                 </div>
      
                      <asp:Label runat="server">Select An Image</asp:Label>
                      <asp:FileUpload ID="fileUpload" runat="server"/>

                 <div></div>


                 <asp:Button runat="server" ID="btnSignUp" Text="Click To Update Ordered_Item!" CssClass="btn btn-primary" OnClick="btnSignUp_Click" /><asp:Label runat="server" Text="Label" ID="insertLabel"></asp:Label>
              
                 <p class="mt-2">GO Back <a href="HomePage.aspx">Back!</a></p>

             </form>
         </div>
         <div class="col-md-6 sign-in-image">
             <img src="../../../Assets/Images/book3.jpeg" alt="Sign In Image" width="600" height="600" class="img-fluid" />
         </div>
     </div>
 </div>

 <script src="../../../Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>


