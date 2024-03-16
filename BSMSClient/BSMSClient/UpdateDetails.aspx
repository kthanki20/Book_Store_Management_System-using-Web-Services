<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDetails.aspx.cs" Inherits="BSMSClient.UpdateDetails" %>

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
       
                </ul>
            </div>
        </div>
    </nav>

     <div class="container">
     <h2 class="mt-5 mb-4">Update Your Information Here</h2>
     <div class="row">
         <div class="col-md-6">
             <form runat="server">
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtName">first_name</asp:Label>
                     <input runat="server" type="text" id="txtName" class="form-control" placeholder="Enter First name" required="required" 
                         oninvalid="this.setCustomValidity('Name is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtLastName">last_name</asp:Label>
                     <input runat="server" type="text" id="txtLastName" class="form-control" placeholder="Enter Last Name" required="required"
                         oninvalid="this.setCustomValidity('Last Name')" oninput="this.setCustomValidity('')" />
                 </div>

                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtEmail">Email</asp:Label>
                     <input runat="server" type="email" id="txtEmail" class="form-control" placeholder="Enter Email" required="required"
                         oninvalid="this.setCustomValidity('Email is required')" oninput="this.setCustomValidity('')" />
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtPassword">Password</asp:Label>
                     <input runat="server" type="tel" id="txtPassword" class="form-control" placeholder="Enter Password" required="required"
                         oninvalid="this.setCustomValidity('Enter Password')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtAddress">Address</asp:Label>
                     <input runat="server" type="text" id="txtAddress" class="form-control" placeholder="Enter Address" required="required"
                         oninvalid="this.setCustomValidity('Address is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtAddress">Zip_Code</asp:Label>
                     <input runat="server" type="text" id="txtZip_Code" class="form-control" placeholder="Enter Zip_code" required="required"
                         oninvalid="this.setCustomValidity('Address is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtPhoneNumber">PhoneNumber</asp:Label>
                     <div class="input-group">
                         <input runat="server" type="tel" pattern="[1-9]{1}[0-9]{9}" title="1234567890" id="txtPhoneNumber" class="form-control" placeholder="Enter your Contact Number" required="required"
                             oninvalid="this.setCustomValidity('PhoneNumber is required')" oninput="this.setCustomValidity('')"/>
                  
                     </div>
                 </div>
                   <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="DOB">Date-Of-birth</asp:Label>
                     <div class="input-group">
                         <input runat="server" type="date" id="DOB" class="form-control" placeholder="Enter your DOB" required="required"
                             oninvalid="this.setCustomValidity('DOB is required')" oninput="this.setCustomValidity('')"/>
                     </div>
                  </div>
                   <div class="form-group">
                      <label>Role</label>
                      <div class="form-check">
                          <input runat="server" type="radio" id="admin" name="Role" value="admin" class="form-check-input" required="required"
                              oninvalid="this.setCustomValidity('Please select role')" oninput="this.setCustomValidity('')" />
                          <label for="admin">Admin</label>
                      </div>
                      <div class="form-check">
                          <input runat="server" type="radio" id="user1" name="Role" value="user" class="form-check-input" required="required"
                              oninvalid="this.setCustomValidity('Please select role')" oninput="this.setCustomValidity('')" />
                          <label for="User">User</label>
                      </div>
                 </div>
                 <asp:Button runat="server" ID="btnSignUp" Text="Update!" CssClass="btn btn-primary" OnClick="btnSignUp_Click" /><asp:Label runat="server" Text="Label" ID="insertLabel"></asp:Label>
                 <p class="mt-2">Go To Home Page <a href="HomePage.aspx">Back</a></p>
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

