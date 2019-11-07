<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Vista.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscador</title>
    <link href="Recursos/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-title">
                        <h5>Buscador</h5>
                    </div>
                    <div class="card-body">
                        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>


                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="Recursos/js/jquery-3.4.1.min.js"></script>
    <script src="Recursos/js/bootstrap.js"></script>
</body>
</html>
