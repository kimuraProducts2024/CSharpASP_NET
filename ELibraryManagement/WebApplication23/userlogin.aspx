<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="WebApplication23.userlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle1 {
            display: block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/generaluser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>ユーザログイン</h3>
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
                                <div class="col">
                                    <label>ユーザID</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ユーザID"></asp:TextBox>
                                    </div>
                                    <label>パスワード</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="パスワード" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="form-group">
                                        <asp:Button class="btn btn-success w-100" ID="Button1"  runat="server" Text="ログイン" OnClick="Button1_Click" />
                                    </div>
                                    <br />
                                    <div class="form-group">
                                        <a href="usersignup.aspx">
                                            <input id="Button2" class="btn btn-primary w-100" type="button" value="ユーザ新規登録" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            
            <a href="homepage.aspx" style="text-decoration: none;"><< Back to Home</a><br />
            </div>
        </div>
    </div>
</asp:Content>
