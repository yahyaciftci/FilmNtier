<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebDiziler.aspx.cs" Inherits="WEBUI.WebDiziler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <header>
        <style type="text/css">
            .auto-style1 {
                height: 114px;
                width: 337px;
                border: 2px solid;
                /*background-image: url("image/yeto.jpg")*/
                background-color: none;
                color: antiquewhite;
            }
            .Dizi {
            width: 180px;
            height: 275px;
            border: 1px solid;
            border-radius: 5px;
            padding: 10px;
            text-align: center;
            background-color: lightgray
        }

        .imagec:hover {
            transform: scale(1.10);
        }


        .DiziDetail {
            width: 180px;
            height: 25px;
            text-align: center;
            font-weight: bold;
            background-color: lightgray
        }

        .DiziPicture {
            padding: 5px;
        }

        .DiziEditing {
            text-align: center;
            font-weight: bold;
        }

        .Dizi:hover {
            background-color: lightgray;
        }

        .DiziPicture:hover {
            transform: scale(0.75);
            transition: transform 0.5s ease;
        }

            .ddd {
                background-color: transparent;
            }

            #lblFilm {
                margin-left: 200px;
            }

            #btnGiris {
                margin-top: 20px;
                margin-left: 120px;
            }

            #btnKayit {
                margin-top: auto;
            }

            .auto-style2 {
                margin-top: 20px;
                margin-left: 10px;
            }

            .auto-style3 {
                margin-top: 10px;
                margin-left: 66px;
            }

            .auto-style4 {
                margin-top: 20px;
            }

            .auto-style5 {
                margin-left: 100px;
            }
   


            @media (orientation : portrait) {
                .ddd {
                    display: flex;
                    flex-direction: column;
                    margin-left: auto;
                }
            }

            @media (orientation : landscape) {
                .ddd {
                    flex-direction: row;
                    /* margin-left:auto;*/
                }
            }
        </style>
    </header>
    <article class="ddd">
        <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
                <div class="Dizi">
                    <div class="imagec">
                        <asp:ImageButton ID="Image122" ImageUrl='<%#Eval("images") %>' CommandName="google" CommandArgument='<%#Eval("SeriesName") %>'    runat="server" Height="180" Width="175"    />
                       <%-- <asp:Image ID="Image1" ImageUrl='<%#Eval("images") %>' runat="server" Height="180" Width="175" />--%>

                    </div>
                    <div class="DiziDetail">
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("SeriesName") %>'></asp:Label>
                    </div>
                    <div class="DiziDetail">
                        <asp:Label ID="Label2" runat="server" Text='<%#"IMBD :"+(Eval("Vote"))%>'></asp:Label>

                    </div>
                    <div class="DiziDetail">
                        <asp:Label ID="Label3" runat="server" Text='<%#"Views :"+(Eval("Views")) %>'></asp:Label>
                    </div>

                    <div class="DiziEditing">
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("SeriesId") %>' CommandName="Duzenle">Duzenle</asp:LinkButton>
                    </div>

                </div>
            </ItemTemplate>
            <EditItemTemplate>
                <div class="Dizi">
                </div>

                <div class="Dizietail">
                    <asp:TextBox ID="txtUrunAdi" runat="server" Text='<%#Eval("SeriesName") %>'></asp:TextBox>
                </div>
                <div class="DiziDetail">
                    <asp:TextBox ID="txtUrunFiyati" runat="server" Text='<%#Eval("Vote")%>'></asp:TextBox>
                </div>
                <div class="DiziDetail">
                    <asp:TextBox ID="txtStok" runat="server" Text='<%#Eval("Views") %>'></asp:TextBox>
                </div>
                <div class="DiziEditing">
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("SeriesId") %>' CommandName="Guncelle">Guncelle</asp:LinkButton>||
                             <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%#Eval("SeriesId") %>' CommandName="Iptal">Iptal</asp:LinkButton>
                </div>
            </EditItemTemplate>
        </asp:DataList>
             <aside>
            <div class="reklambs">EN ÇOK BEĞENİLENLER</div>
            <div id="asideDiv">


                <div>
                    <asp:ImageButton ID="Image1" ImageUrl="~/image/dogu.jpg" CommandName="google" CommandArgument='<%#Eval("FilmName") %>' runat="server" Height="400" Width="250" />
                </div>
                <div>
                    <asp:ImageButton ID="ImageButton1" ImageUrl="~/image/behzatc.jpg" CommandName="google" CommandArgument='<%#Eval("FilmName") %>'  runat="server" Height="400" Width="250" />
                </div>
            </div>
        </aside>
    </article>
</asp:Content>
