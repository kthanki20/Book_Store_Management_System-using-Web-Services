<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoPayment.aspx.cs" Inherits="BSMSClient.DoPayment" %>

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
                        <a class="nav-link" href="DoPayment.aspx">Payment</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

     <div class="container">
     <h2 class="mt-5 mb-4">Payment Sections</h2>
     <div class="row">
         <div class="col-md-6">
             <form runat="server">
                 
                   <div class="form-group">
                     <label>Payment_Status</label>
                          <div class="form-check">
                               <input runat="server" type="radio" id="Completed" name="payment_Status" value="Completed" class="form-check-input" required="required"
                                 oninvalid="this.setCustomValidity('Please select status')" oninput="this.setCustomValidity('')" />
                                  <label for="Completed">Completed</label>
                          </div>
                            <div class="form-check">
                                <input runat="server" type="radio" id="Pending" name="payment_Status" value="Pending" class="form-check-input" required="required"
                                 oninvalid="this.setCustomValidity('Please select status')" oninput="this.setCustomValidity('')" />
                          <label for="Pending">Pending</label>
                         </div>
                   </div>

                   <div class="form-group">
                      <label>Payment_Method</label>
                         <div class="form-check">
                              <input runat="server" type="radio" id="COD" name="payment_Method" value="COD" class="form-check-input" required="required"
                              oninvalid="this.setCustomValidity('Please select Method')" oninput="this.setCustomValidity('')" />
                               <label for="COD">COD</label>
                         </div>
                         <div class="form-check">
                              <input runat="server" type="radio" id="NetBanking" name="payment_Method" value="NetBanking" class="form-check-input" required="required"
                               oninvalid="this.setCustomValidity('Please select Method')" oninput="this.setCustomValidity('')" />
                              <label for="NetBanking">NetBanking</label>
                         </div>
                   </div>

                 <asp:Button runat="server" ID="btnSignUp" Text="Buy Now!" CssClass="btn btn-primary" OnClick="btnSignUp_Click" /><asp:Label runat="server" Text="Label" ID="insertLabel"></asp:Label>
                  <p class="mt-2">Go To Home Page <a href="HomePage.aspx">Back</a></p>
             </form>
         </div>
         <div class="col-md-6 sign-in-image">
             <img src="../../../Assets/Images/book17.jpg" alt="Sign In Image" width="600" height="600" class="img-fluid" />
         </div>
     </div>
 </div>

 <script src="../../../Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>

