<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="MenuList.aspx.cs"
    Inherits="Code_Challenge_9.MenuList" %>

<asp:Content ID="Content1"
    ContentPlaceHolderID="MainContent"
    runat="server">

    <style>

        body {
            background-color: #f4f4f4;
        }

        .dashboard-container {
            width: 95%;
            margin: 30px auto;
            background-color: #f1f1f1;
            padding: 40px;
            border-radius: 15px;
            box-shadow: 0px 0px 10px #ccc;
        }

        .dashboard-title {
            text-align: center;
            color: #234a91;
            font-size: 40px;
            font-weight: bold;
            margin-bottom: 30px;
        }

        .add-btn {
            display: block;
            width: 220px;
            margin: auto;
            text-align: center;
            background-color: #2f56a6;
            color: white;
            padding: 15px;
            text-decoration: none;
            border-radius: 8px;
            font-size: 22px;
            font-weight: bold;
        }

        .add-btn:hover {
            background-color: #1d3f80;
            color: white;
        }

        .grid-container {
            margin-top: 40px;
            background-color: white;
            padding: 25px;
            border-radius: 15px;
            box-shadow: 0px 0px 10px #ddd;
        }

        .menu-grid {
            width: 100%;
            border-collapse: collapse;
            font-size: 18px;
        }

        .menu-grid th {
            background-color: #2f56a6;
            color: white;
            padding: 15px;
            text-align: center;
        }

        .menu-grid td {
            padding: 14px;
            text-align: center;
            border: 1px solid #ccc;
        }

        .menu-grid tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .menu-grid a {
            font-weight: bold;
        }

    </style>

    <div class="dashboard-container">

        <div class="dashboard-title">
            Menu Management Dashboard
        </div>

        <asp:HyperLink ID="lnkAdd"
            runat="server"
            NavigateUrl="~/AddEditMenu.aspx"
            CssClass="add-btn">

            + Add New Item

        </asp:HyperLink>

        <div class="grid-container">

            <asp:GridView ID="gvMenu"
                runat="server"
                AutoGenerateColumns="False"
                DataKeyNames="MenuId"
                CssClass="menu-grid"
                GridLines="None"
                OnRowDeleting="gvMenu_RowDeleting">

                <Columns>

                    <asp:BoundField DataField="MenuId"
                        HeaderText="ID" />

                    <asp:BoundField DataField="ItemName"
                        HeaderText="Item Name" />

                    <asp:BoundField DataField="Category"
                        HeaderText="Category" />

                    <asp:BoundField DataField="Price"
                        HeaderText="Price" />

                    <asp:HyperLinkField HeaderText="View"
                        Text="View"
                        DataNavigateUrlFields="MenuId"
                        DataNavigateUrlFormatString="MenuDetails.aspx?MenuId={0}" />

                    <asp:HyperLinkField HeaderText="Edit"
                        Text="Edit"
                        DataNavigateUrlFields="MenuId"
                        DataNavigateUrlFormatString="AddEditMenu.aspx?MenuId={0}" />

                    <asp:CommandField ShowDeleteButton="True"
                        HeaderText="Delete" />

                </Columns>

            </asp:GridView>

        </div>

    </div>

</asp:Content>