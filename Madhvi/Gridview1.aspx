<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview1.aspx.cs" Inherits="Madhvi.Gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowEditing="OnRowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
                <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Text="Edit" runat="server" CommandName="Edit" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton Text="Update" runat="server" OnClick="OnUpdate" />
                        <asp:LinkButton Text="Cancel" runat="server" OnClick="OnCancel" />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
