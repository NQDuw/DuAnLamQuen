<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MinhHoa.aspx.cs" Inherits="DuAnLamQuen.MinhHoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Chọn ngành: <asp:DropDownList ID="ddlNganh" runat="server" OnSelectedIndexChanged="ddlNganh_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <asp:Button ID="btnGui" runat="server" Text="Gửi" OnClick="btnGui_Click"
            OnClientClick="return hoilai() "/>
        <br />
        <asp:Label ID="lbKetqua" runat="server" Text="" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
