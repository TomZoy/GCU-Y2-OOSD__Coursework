<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LookUpPeople.aspx.vb" Inherits="LookUpPeople" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Look up People</title>
</head>
<body>
    <h2>Look up People</h2>
    <a href="default.aspx">Home</a>

    <form id="form1" runat="server">
    

        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="SchoolDataContext" EntityTypeName="" TableName="People"
            Where="LastName = @LN">
		    <WhereParameters>
			    <asp:ControlParameter Name="LN" ControlID="DropDownList"  DefaultValue="Abercrombie" Type="String"/>
		    </WhereParameters>
        </asp:LinqDataSource>

        <asp:FormView ID="FormView1" runat="server" 
            DataKeyNames="PersonID" DataSourceID="LinqDataSource1">
    
           
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
               
                <hr/>
                </ItemTemplate>
               
            </asp:FormView>
    
            <asp:LinqDataSource ID="LinqDataSource2" runat="server" 
                ContextTypeName="SchoolDataContext" EntityTypeName="" TableName="People">
            </asp:LinqDataSource>
            
          
            Select Pesron: <asp:DropDownList ID="DropDownList" runat="server"  
	         DataSourceID= "LinqDataSource2"  DataTextField="LastName" DataValueField="LastName"
	        AutoPostBack="true"/>
    </form>

   

</body>
</html>
