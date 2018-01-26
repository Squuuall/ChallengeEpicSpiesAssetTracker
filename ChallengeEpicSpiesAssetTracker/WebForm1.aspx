<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl="http://learnvisualstudio.kenjlucas.com/WebApps/EpicSpiesChallenge02/epic-spies-logo.jpg" style="margin-right: 0px" Width="100px" />
        <br />
        <br />
        <h1>Asset Performance Tracker</h1>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp;
            <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
