<%@ Page Language="VB" AutoEventWireup="false" CodeFile="EditPeople.aspx.vb" Inherits="EditPeople" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit People</title>
</head>
<body>
   
    <h2>Edit People</h2>
    <a href="default.aspx">Home</a>

    <form id="form1" runat="server">
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="SchoolDataContext" EnableUpdate="True" EntityTypeName="" 
            TableName="People">
        </asp:LinqDataSource>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataKeyNames="PersonID" DataSourceID="LinqDataSource1">
            <EditItemTemplate>
                PersonID:
                <asp:Label ID="PersonIDLabel1" runat="server" Text='<%# Eval("PersonID") %>' />
                <br />
                LastName:
                <asp:TextBox ID="LastNameTextBox" runat="server" 
                    Text='<%# Bind("LastName") %>' />
                <br />
                FirstName:
                <asp:TextBox ID="FirstNameTextBox" runat="server" 
                    Text='<%# Bind("FirstName") %>' />
                <br />
                HireDate:
                <asp:TextBox ID="HireDateTextBox" runat="server" 
                    Text='<%# Bind("HireDate") %>' />
                <br />
                EnrollmentDate:
                <asp:TextBox ID="EnrollmentDateTextBox" runat="server" 
                    Text='<%# Bind("EnrollmentDate") %>' />
                <br />
               
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
          
            <ItemTemplate>
                PersonID:
                <asp:Label ID="PersonIDLabel" runat="server" Text='<%# Eval("PersonID") %>' />
                <br />
                LastName:
                <asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName") %>' />
                <br />
                FirstName:
                <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Bind("FirstName") %>' />
                <br />
                HireDate:
                <asp:Label ID="HireDateLabel" runat="server" Text='<%# Bind("HireDate") %>' />
                <br />
                EnrollmentDate:
                <asp:Label ID="EnrollmentDateLabel" runat="server" 
                    Text='<%# Bind("EnrollmentDate") %>' />
               
                <hr />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                    CommandName="Edit" Text="Edit" />
            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
