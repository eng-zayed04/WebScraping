<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%">
                <tr style="background-color: aqua; text-align: center;">
                    <td>Web Scraping </td>
                </tr>
                <tr>
                    <td>
                        <table style="width: 100%">
                            <tr valign="top">
                                <td style="width: 40%">
                                    <table style="width: 100%">
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="lblError" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%">Url</td>
                                            <td>
                                                <asp:TextBox ID="txtUrl" runat="server" Width="98%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%">Keyword</td>
                                            <td>
                                                <asp:TextBox ID="txtKeyWord" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click" />
                                                &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Panel ID="pnlReport" runat="server" Visible="False">
                                                    <table style="width: 80%; background-color: aquamarine;">
                                                        <tr>
                                                            <td style="width: 30%">
                                                                <asp:Label ID="lblKeyword" runat="server"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:Label ID="lblFoundFlag" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 30%">&nbsp;</td>
                                                            <td>
                                                                <asp:Label ID="lblFindCount" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                                
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtSourceCode" runat="server" TextMode="MultiLine" Width="100%" Height="400px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
