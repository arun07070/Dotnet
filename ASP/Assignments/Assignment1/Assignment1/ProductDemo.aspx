<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ProductDemo.aspx.cs"
    Inherits="Assignment1.ProductDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Display</title>
    <style>
        body {
            width: 500px;
            margin: 40px auto;
            padding: 20px;
            border: 1px solid gray;
            border-radius: 12px;
            font-family: Arial;
            text-align: center;
        }
        h2 {
            margin-bottom: 20px;
        }
        .dropdownstyle, .btnstyle {
            padding: 8px;
            margin: 10px;
            border-radius: 8px;
        }
        .imgstyle {
            margin-top: 15px;
            border-radius: 10px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h2>Product List</h2>
            <asp:DropDownList ID="ddlItems"
                runat="server"
                CssClass="dropdownstyle"
                AutoPostBack="true"
                OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Image ID="imgItems"
                runat="server"
                Height="220px"
                Width="260px"
                CssClass="imgstyle" />
            <br />
            <asp:Button ID="btnShowPrice"
                runat="server"
                Text="Show Price"
                CssClass="btnstyle"
                OnClick="btnShowPrice_Click" />
            <br />
            <asp:Label ID="lblAmount"
                runat="server"
                Font-Bold="true"
                ForeColor="DarkGreen">
            </asp:Label>
        </div>
    </form>
</body>
</html>