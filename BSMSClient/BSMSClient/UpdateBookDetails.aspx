<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateBookDetails.aspx.cs" Inherits="BSMSClient.UpdateBookDetails" %>

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
                        <a class="nav-link" href="AddBook.aspx">Add Books</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

     <div class="container">
     <h2 class="mt-5 mb-4">Update Book Information</h2>
     <div class="row">
         <div class="col-md-6">
             <form runat="server">
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txttitle">Title</asp:Label>
                     <input runat="server" type="text" id="txttitle" class="form-control" placeholder="Enter Title" required="required" 
                         oninvalid="this.setCustomValidity('title is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtlanguage">Language</asp:Label>
                     <input runat="server" type="text" id="txtlanguage" class="form-control" placeholder="Enter Lanugage" required="required"
                         oninvalid="this.setCustomValidity('Language is required')" oninput="this.setCustomValidity('')" />
                 </div>

                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtDescription">Description</asp:Label>
                     <input runat="server" type="text" id="txtdescription" class="form-control" placeholder="Enter Description" required="required"
                         oninvalid="this.setCustomValidity('Description is required')" oninput="this.setCustomValidity('')" />
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtpublication_year">Publication_year</asp:Label>
                     <input runat="server" type="tel" id="txtpublication_year" class="form-control" placeholder="Enter publication year" required="required"
                         oninvalid="this.setCustomValidity('Enter year')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtPrice">Price</asp:Label>
                     <input runat="server" type="number" id="txtPrice" class="form-control" placeholder="Enter Price" required="required"
                         oninvalid="this.setCustomValidity('price is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <!--<div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtImage">Image</asp:Label>
                     <input runat="server" type="text" id="txtImage" class="form-control" placeholder="Select an Image" required="required"
                         oninvalid="this.setCustomValidity('Image is required')" oninput="this.setCustomValidity('')"/>
                 </div>-->

                 <asp:Label runat="server">Select An Image</asp:Label>
                 <asp:FileUpload ID="fileUpload" runat="server"/>
                 <asp:Image ID="uploadedImage" runat="server" Visible="false" />

                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtstatus">Status</asp:Label>
                     <input runat="server" type="text" id="txtstatus" class="form-control" placeholder="Enter Status" required="required"
                         oninvalid="this.setCustomValidity('Status is required')" oninput="this.setCustomValidity('')"/>
                 </div>
                 <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtedition">Edition</asp:Label>
                     <div class="input-group">
                         <input runat="server" type="text"  id="txtedition" class="form-control" placeholder="Enter edition" required="required"
                             oninvalid="this.setCustomValidity('edition is required')" oninput="this.setCustomValidity('')"/>
                  
                     </div>
                 </div>
                   <div class="form-group">
                     <asp:Label runat="server" AssociatedControlID="txtGenre">Genre</asp:Label>
                     <div class="input-group">
                         <input runat="server" type="text" id="txtGenre" class="form-control" placeholder="Enter your category" required="required"
                             oninvalid="this.setCustomValidity('Category is required')" oninput="this.setCustomValidity('')"/>
                     </div>
                  </div>

                 <asp:Button runat="server" ID="btnSignUp" Text="Update Book Info." CssClass="btn btn-primary" OnClick="btnSignUp_Click" /><asp:Label runat="server" Text="Label" ID="insertLabel"></asp:Label>
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

