<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loading.aspx.cs" Inherits="BSMSClient.loading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment</title>
    <script>
        window.onload = function () {
            setTimeout(() => {
                window.location.href = "Finish.aspx";
            }, 5000)
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:100px;">
              <img src="../../../Assets/Images/pendulum.gif" width="600" height="400" alt="Sign In Image"  class="img-fluid" />

        </div>
    </form>
</body>
</html>
