<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="WebApplication23.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                                  <img width="150px" src="imgs/adminuser.png" />
                              </center>
                          </div>
                      </div>
                      <div class="row">
                          <div class="col">
                              <center>
                                  <h3>管理者ログイン</h3>
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
                                  <label>管理者ID</label>
                                  <div class="form-group">
                                      <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="管理者ID"></asp:TextBox>
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
                                          <input id="Button2" class="btn btn-primary w-100" type="button" value="新規登録" />
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
