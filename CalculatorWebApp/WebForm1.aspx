<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
   th, td {
  padding: 15px;
  text-align: left;
  
}
   body {
  background-color: #aa2b33;
}
   
 .btn {
      outline: none;
      border: none;
      background: #aa2b33;
      color: #ffffff;
      width: 100%;
      height: 30px;
      border-radius: 5px;
      font-family: "Nunito", sans-serif;
      cursor: pointer;
    }

  
.container {
  background-color: #24141c;
  color: #cccccc;
  font-family: "Nunito", sans-serif;
  width: 70%;
  border-radius: 7px;
  padding: 5%;
  margin: 5% auto;
}
.flex {
  display: flex;
  justify-content: space-around;

  &2 {
    border-right: 0.1px solid rgba(178, 170, 171, 0.185);
  }
     h2 {
      font-weight: 600;
      
    }
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style=" text-align:center;">Calculator Web App</h2>
        <div class="container" >
        <table style="font-family: Arial; border-style: ridge; overflow-x:auto;" align="center" >
<tr>
    <td>
        <b style=" color:ghostwhite;">First Number</b>
    </td>
    <td>
        <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <b style=" color:ghostwhite;">Second Number</b>
    </td>
    <td>
        <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <b style=" color:ghostwhite;">Result</b>
    </td>
    <td>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </td>
</tr>
<tr>
    <td >
        <asp:Button ID="btnAdd" runat="server" Text="Add" 
        OnClick="btnAdd_Click"  CssClass="btn"/>
    </td>
</tr>
 <tr>
     <td>
        <asp:Button ID="btnSub" runat="server" Text="Subtract" 
        OnClick="btnSub_Click"   CssClass="btn"/>
    </td>
  </tr>
  <tr>
      <td>
        <asp:Button ID="btnMul" runat="server" Text="Multiply" 
        OnClick="btnMul_Click"  CssClass="btn" />
    </td>
  </tr>
     <tr>
     <td>
        <asp:Button ID="btnDiv" runat="server" Text="Divide" 
        OnClick="btnDiv_Click" CssClass="btn" />
    </td>
</tr>

</table>
             </div>
    </form>
    <p>Task is done using web services.</p>
</body>
</html>
