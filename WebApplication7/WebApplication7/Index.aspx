<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication7.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <title></title>
</head>
<body>



    <form id="form1" runat="server">


        
    <div>

       
  <div class="input-group">
    <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
    
       <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox><br />
  </div>
  <div class="input-group">
    <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
       <asp:TextBox ID="TextBox2" class="form-control"  runat="server"></asp:TextBox><br />
  </div>
  <div class="input-group">
    <span class="input-group-addon">Text</span>
     <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox><br />
  </div>
              <div class="input-group">
    <span class="input-group-addon">Text</span>
     <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox><br />
  </div>
              <div class="input-group">
    <span class="input-group-addon">Text</span>
     <asp:TextBox ID="TextBox5" class="form-control" runat="server"></asp:TextBox><br />
  </div>
       
        <asp:Button ID="Button3" cssClass="btn btn-default" runat="server" Text="Button" OnClick="Button3_Click" /><br />

    </div>

        
       <asp:Button ID="Button2" cssClass="btn btn-default" runat="server" Text="Button" OnClick="Button2_Click" />
        <div  class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" cssClass="table table-striped">
        </asp:GridView>
       
            </div>
        <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
    </form>
</body>
</html>
