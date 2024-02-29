<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhToan.aspx.cs" Inherits="DuAnLamQuen.TinhToan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 259px">
            <asp:Label ID="Label1" runat="server" Text="Tính Toán Đơn Giản"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Số Thứ 1"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtso1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Số Thứ 2"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtso2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btncong" runat="server" OnClick="btncong_Click" Text="Cộng" />
&nbsp;
            <asp:Button ID="btntru" runat="server" OnClick="btntru_Click" Text="Trừ" />
&nbsp;
            <asp:Button ID="btnnhan" runat="server" OnClick="btnnhan_Click" Text="Nhân" />
&nbsp;
            <asp:Button ID="bntchia" runat="server" OnClick="bntchia_Click" Text="Chia" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Kết quả"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtkq" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
