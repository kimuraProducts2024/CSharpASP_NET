<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbookinbentory.aspx.cs" Inherits="WebApplication23.adminbookinbentory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function() {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>書籍管理</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img height="150px" width="100px" src="imgs/books.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>ブックID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ブックID"></asp:TextBox>
                                        <asp:Button ID="Button4" class="form-control btn btn-primary" runat="server" Text="Go" OnClick="Button4_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>ブック名</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="ブック名"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>言語</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                        <asp:ListItem Text="英語" Value="English" />
                                        <asp:ListItem Text="ヒンディ語" Value="Hindi" />
                                        <asp:ListItem Text="マレーシア語" Value="Marathi" />
                                        <asp:ListItem Text="フランス語" Value="French" />
                                        <asp:ListItem Text="ドイツ語" Value="German" />
                                        <asp:ListItem Text="日本語" Value="Japan" />
                                    </asp:DropDownList>
                                </div>
                                <label>出版社名</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                                        <asp:ListItem Text="" Value="0" />
                                        <asp:ListItem Text="出版社1" Value="Publisher1" />
                                        <asp:ListItem Text="出版社2" Value="Publisher2" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>著作者名</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                                        <asp:ListItem Text="A1" Value="a1" />
                                        <asp:ListItem Text="A2" Value="a2" />
                                    </asp:DropDownList>
                                </div>
                                <label>出版日</label>
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label>ジャンル</label>
                                <div class="form-group">
                                    <asp:ListBox CssClass="form-control" ID="ListBox1" runat="server" SelectionMode="Multiple" Rows="5">
                                        <asp:ListItem Text="アクション" Value="Action" />
                                        <asp:ListItem Text="アドベンチャー" Value="Adventure" />
                                        <asp:ListItem Text="コミック" Value="Comic Book" />
                                        <asp:ListItem Text="自己啓発" Value="Self Help" />
                                        <asp:ListItem Text="健康" Value="Healthy Living" />
                                        <asp:ListItem Text="幸福" Value="Wellness" />
                                        <asp:ListItem Text="ドラマ" Value="Drama" />
                                        <asp:ListItem Text="ファンタジー" Value="Fantasy" />
                                        <asp:ListItem Text="ホラー" Value="Horror" />
                                        <asp:ListItem Text="小説" Value="Poetry" />
                                        <asp:ListItem Text="自叙伝" Value="Personal" />
                                        <asp:ListItem Text="ロマンス" Value="Romance" />
                                        <asp:ListItem Text="サイエンスフィクション" Value="Science Fiction" />
                                        <asp:ListItem Text="サスペンス" Value="Suspence" />
                                        <asp:ListItem Text="芸術" Value="Art" />
                                        <asp:ListItem Text="バイオグラフィー" Value="Autobiography" />
                                        <asp:ListItem Text="百科辞書" Value="Encyclopedia" />
                                        <asp:ListItem Text="歴史" Value="History" />
                                        <asp:ListItem Text="数学" Value="Math" />
                                        <asp:ListItem Text="学習書" Value="Textbook" />
                                        <asp:ListItem Text="科学" Value="Science" />
                                        <asp:ListItem Text="旅行" Value="Travel" />
                                    </asp:ListBox>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <label>エディション</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="エディション"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <label>価格(冊単位)</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="価格(冊単位)" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <label>ページ数</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="ページ数" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <label>実在庫</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="実在庫" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <label>最大在庫</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="最大在庫" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <label>その他</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="その他" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <label>備考</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="備考" TextMode="MultiLine" Rows="2"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row" style="margin: 6px;">
                        <div class="col-4">
                            <asp:Button ID="Button1" class="btn btn-lg w-100 btn-success" runat="server" Text="追加" OnClick="Button1_Click" />
                        </div>
                        <div class="col-4">
                            <asp:Button ID="Button2" class="btn btn-lg w-100 btn-warning" runat="server" Text="更新" OnClick="Button2_Click" />
                        </div>
                        <div class="col-4">
                            <asp:Button ID="Button3" class="btn btn-lg w-100 btn-danger" runat="server" Text="削除" OnClick="Button3_Click" />
                        </div>
                    </div>
                </div>
                <a href="homepage.aspx"><< Back to Home</a><br />
                <br />
            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>書籍一覧</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
