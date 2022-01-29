<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Sekme Başlığı</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Burası kullanıcıların gördüğü kısım
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        Burası kullanıcıların gördüğü kısım
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Onaylıyorum" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Kabul Ediyorum</asp:ListItem>
            <asp:ListItem>Kabul Etmiyorum</asp:ListItem>
        </asp:CheckBoxList>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Bilgisayar</asp:ListItem>
            <asp:ListItem>Monitör</asp:ListItem>
            <asp:ListItem>Klavye</asp:ListItem>
        </asp:DropDownList>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.aribilgi.com/">HyperLink</asp:HyperLink>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Resimler/logo.png" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>Yazılım</asp:ListItem>
            <asp:ListItem>Front-end</asp:ListItem>
            <asp:ListItem>Back-end</asp:ListItem>
        </asp:ListBox>
        <asp:Literal ID="Literal1" runat="server" Text="Bu yazıda html etiketi yok"></asp:Literal>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Kabul</asp:ListItem>
            <asp:ListItem>Red</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">LinkButton</asp:LinkButton>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Bolum_No" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Bolum_No" HeaderText="Bolum_No" InsertVisible="False" ReadOnly="True" SortExpression="Bolum_No" />
                <asp:BoundField DataField="Bolum_Adi" HeaderText="Bolum_Adi" SortExpression="Bolum_Adi" />
            </Columns>
        </asp:GridView>
        <asp:DataList ID="DataList1" runat="server">
        </asp:DataList>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BilisimConnectionString %>" SelectCommand="SELECT * FROM [Bolumler]"></asp:SqlDataSource>
        <br />
        <input id="Button2" type="button" value="button" />
        <input id="Reset1" type="reset" value="reset" />
        <input id="Submit1" type="submit" value="submit" />
        <input id="Text1" type="text" /><input id="File1" type="file" />
        <input id="Password1" type="password" />
        <input id="Checkbox2" type="checkbox" />
        <input id="Radio1" type="radio" />
        <input id="Hidden1" type="hidden" />
        <textarea id="TextArea1" cols="20" name="S1" rows="2"></textarea><table style="width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <img alt="" src="" />
        <select id="Select1" name="D1">
            <option>deneme</option>
            <option selected="selected" value="Bilgisayar">Bilgisayar</option>
        </select>
        <hr />
        <div>
        </div>
    </form>

</body>
</html>
