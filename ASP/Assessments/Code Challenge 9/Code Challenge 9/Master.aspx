<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Master.aspx.cs" Inherits="Code_Challenge_9.Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Food Order Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Online Food Ordering Management System</h1>

    <hr />

    <asp:HyperLink ID="HyperLink1" runat="server"
        NavigateUrl="~/MenuList.aspx">
        Menu Items
    </asp:HyperLink>

    |

    <asp:HyperLink ID="HyperLink2" runat="server"
        NavigateUrl="~/AddEditMenu.aspx">
        Add Menu
    </asp:HyperLink>

    |

    <asp:HyperLink ID="HyperLink3" runat="server"
        NavigateUrl="~/OrderStats.aspx">
        Order Stats
    </asp:HyperLink>

    |

    <asp:HyperLink ID="HyperLink4" runat="server"
        NavigateUrl="~/Logout.aspx">
        Logout
    </asp:HyperLink>

    <hr />

    <asp:ContentPlaceHolder ID="MainContent"
        runat="server">
    </asp:ContentPlaceHolder>

    <hr />

    <h4>© 2026 Food Order Management</h4>
        </div>
    </form>
</body>
</html>
