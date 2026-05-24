<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment1.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator Form</title>
    <style>
        body {
            font-family: Arial;
            width: 550px;
            margin: 30px auto;
            border: 1px solid gray;
            padding: 20px;
            border-radius: 10px;
        }
        .textboxstyle {
            margin-left: 20px;
        }
        .btnstyle {
            padding: 8px 15px;
            border-radius: 10px;
            cursor: pointer;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h3>Insert your details :</h3>

            Name :
            <asp:TextBox ID="txtUserName" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server"
                ControlToValidate="txtUserName"
                ErrorMessage="Name Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <br /><br />

            Family Name :
            <asp:TextBox ID="txtFamily" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFamily" runat="server"
                ControlToValidate="txtFamily"
                ErrorMessage="Family Name Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cmpNames" runat="server"
                ControlToValidate="txtUserName"
                ControlToCompare="txtFamily"
                Operator="NotEqual"
                ErrorMessage="Should be different from name"
                ForeColor="Red">
            </asp:CompareValidator>
            <br /><br />

            Address :
            <asp:TextBox ID="txtAddress" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server"
                ControlToValidate="txtAddress"
                ErrorMessage="Address Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revAddress" runat="server"
                ControlToValidate="txtAddress"
                ValidationExpression=".{2,}"
                ErrorMessage="At least 2 characters"
                ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br /><br />

            City :
            <asp:TextBox ID="txtCity" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCity" runat="server"
                ControlToValidate="txtCity"
                ErrorMessage="City Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revCity" runat="server"
                ControlToValidate="txtCity"
                ValidationExpression=".{2,}"
                ErrorMessage="Minimum 2 characters"
                ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br /><br />

            Zip Code :
            <asp:TextBox ID="txtZipCode" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvZip" runat="server"
                ControlToValidate="txtZipCode"
                ErrorMessage="Zip Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revZip" runat="server"
                ControlToValidate="txtZipCode"
                ValidationExpression="^\d{5}$"
                ErrorMessage="Zip must contain 5 digits"
                ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br /><br />

            Phone :
            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server"
                ControlToValidate="txtPhoneNumber"
                ErrorMessage="Phone Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revPhone" runat="server"
                ControlToValidate="txtPhoneNumber"
                ValidationExpression="^\d{2,3}-\d{7}$"
                ErrorMessage="Format XX-XXXXXXX or XXX-XXXXXXX"
                ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br /><br />

            E-Mail :
            <asp:TextBox ID="txtEmail" runat="server" CssClass="textboxstyle"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Email Required"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
                ControlToValidate="txtEmail"
                ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
                ErrorMessage="Invalid Email"
                ForeColor="Red">
            </asp:RegularExpressionValidator>
            <br /><br />

            <asp:Button ID="btnCheck" runat="server"
                Text="Check"
                CssClass="btnstyle"
                OnClick="btnCheck_Click" />
            <br /><br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                HeaderText="Validation Summary"
                ShowMessageBox="true"
                ShowSummary="true"
                ForeColor="Red" />
        </div>
    </form>
</body>
</html>