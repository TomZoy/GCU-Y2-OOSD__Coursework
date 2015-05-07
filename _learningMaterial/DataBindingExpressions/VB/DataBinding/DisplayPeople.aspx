<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DisplayPeople.aspx.vb" Inherits="DisplayPeople" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Display People</title>
</head>
<body>
    <h2>Display People</h2>
    <a href="default.aspx">Home</a>

    <form id="form1" runat="server">
    

        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="SchoolDataContext" EntityTypeName="" TableName="People" />
		   
        <asp:FormView ID="FormView1" runat="server" 
            DataKeyNames="PersonID" DataSourceID="LinqDataSource1" AllowPaging="True">
    
           
            <ItemTemplate>
                PersonID:
                <asp:Label ID="PersonIDLabel" runat="server" Text='<%# Eval("PersonID") %>' />
                <br />
                LastName:
                <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                <br />
                FirstName:
                <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
                <br />
                HireDate:
                <asp:Label ID="HireDateLabel" runat="server" Text='<%# Eval("HireDate") %>' />
                <br />
                EnrollmentDate:
                <asp:Label ID="EnrollmentDateLabel" runat="server" Text='<%# Eval("EnrollmentDate") %>' />
                <br />
                OfficeAssignment:
                <asp:Label ID="OfficeAssignmentLabel" runat="server" Text='<%# Eval("OfficeAssignment") %>' />
                <hr/>
                </ItemTemplate>
               
            </asp:FormView>
    </form>

</body>
</html>
