<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication23.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="auto-style1">
        <img src="imgs/head-img.jpg" style="width: 100%; height: 200px;" />
    </section>
    <section>

        <div class="container">
            <div class="row">
                <div class="col-l2">
                    <center>
                        <h2>書籍登録・検索</h2>
                        <p><b>３つの機能があります -</b></p>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="180px" src="imgs/inbentory.png" />
                        <h4>書籍の管理</h4>
                        <p class="text-justify">各種書籍の登録・更新・削除ができます。書籍管理画面から、対象の書籍情報で登録が可能です。また、登録済みの書籍情報を修正したり、削除もできます。</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="157px" src="imgs/search.png" />
                        <h4>書籍の検索</h4>
                        <p class="text-justify">様々なジャンルの書籍を、検索したいキーワードを元に検索が可能です。ただし、ユーザ登録が必要で、ログインが成功したら、検索画面に移れます。</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="190px" src="imgs/book-list.png" />
                        <h4>書籍情報閲覧</h4>
                        <p class="text-justify">キーワードで検索した書籍についての一覧が閲覧できます。特に検索していなければ、全検索で一覧が表示されます。こちらも、ログインが必要です。</p>
                    </center>
                </div>
            </div>
        </div>

    </section>
    <section class="auto-style1">
        <img src="imgs/home-body.jpg" style="width: 100%; height: 200px;" />
    </section>
    <section>

        <div class="container">
            <div class="row">
                <div class="col-l2">
                    <center>
                        <h2>ユーザ登録・書籍リスト閲覧</h2>
                        <p><b>ユーザは３つのプロセスで使用できます -</b></p>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/signup.png" />
                        <h4>新規登録</h4>
                        <p class="text-justify">必要な情報を入力して、ユーザ登録をします。画面右上のユーザ登録をクリックすると、登録画面に遷移します。まずはこちらから進めてください。</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="157px" src="imgs/search.png" />
                        <h4>書籍の検索</h4>
                        <p class="text-justify">様々なジャンルの書籍を、検索したいキーワードを元に検索が可能です。ただし、ユーザ登録が必要で、ログインが成功したら、検索画面に移れます。</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="190px" src="imgs/library2.png" />
                        <h4>書籍情報閲覧</h4>
                        <p class="text-justify">キーワードで検索した書籍についての一覧が閲覧できます。特に検索していなければ、全検索で一覧が表示されます。こちらも、ログインが必要です。</p>
                    </center>
                </div>
            </div>

        </div>

    </section>

</asp:Content>
