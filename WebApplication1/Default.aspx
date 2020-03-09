<%@ Page MaintainScrollPositionOnPostback="true" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link  href="StyleSheet1.css" rel="stylesheet" type="text/css"  runat="server" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"  />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css"  />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        function openModal() {
            $('#myModal').modal('show');
        }
        function ShowMessage(message, messagetype) {
            var cssclass;
            switch (messagetype) {
                case 'Success':
                    cssclass = 'alert-success'
                    break;
                case 'Error':
                    cssclass = 'alert-danger'
                    break;
                case 'Warning':
                    cssclass = 'alert-warning'
                    break;
                default:
                    cssclass = 'alert-info'
            }
            $('#alert_container').append('<div id="alert_div" style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999;" class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
        }
    </script>
    <style type="text/css">
        #alan {
            margin-left: 9px;
        }
        #Button5 {
            height: 22px;
            width: 23px;
        }
        .messagealert {
            width: 70%;
            position: fixed;
             top:0px;
            z-index: 100000;
            padding: 0;
            font-size: 15px;
        }
        #Button6 {
            height: 24px;
            width: 23px;
        }
        .auto-style1 {
            
        }
        .auto-style2 {
            height: 40px;
            width: 426px;
            background-color: cadetblue;
            color: white;
            font-size: 14pt;
        }
        .auto-style3 {
            width: 791px;
        }
        .auto-style5 {
            width: 97px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        </style>

   
   
   
</head>
<body class="anaKatman">
    <form id="form1" runat="server" class="auto-style6">
        <div>
        
    </div>
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog"
            aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-sm">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close"
                            data-dismiss="modal" aria-hidden="true">
                            &times;
                        </button>
                        <h4 class="modal-title" id="myModalLabel">Faaliyet Seçenekleri</h4>
                    </div>
                    <div class="modal-body">
                        <table class ="table">
                        <tr>
                           <td> Adet :</td>
                           <td>
                                   <asp:DropDownList ID="DropDownList1" runat="server" Width ="120px" >
                                   <asp:ListItem>Adet seçiniz..</asp:ListItem>
                                   <asp:ListItem>1</asp:ListItem>
                                   <asp:ListItem>2</asp:ListItem>
                                   <asp:ListItem>3</asp:ListItem>
                                   <asp:ListItem>4</asp:ListItem>
                                   <asp:ListItem>5</asp:ListItem>
                                   <asp:ListItem>6</asp:ListItem>
                                   <asp:ListItem>7</asp:ListItem>
                                   <asp:ListItem>8</asp:ListItem>
                                   <asp:ListItem>9</asp:ListItem>
                                   <asp:ListItem>10</asp:ListItem>
                                   </asp:DropDownList>
                                </td>
                        </tr>
                           <tr>
                           <td>Yazar Sayısı :</td>
                            <td>
                                   <asp:DropDownList ID="DropDownList2" runat="server" Width ="120px">
                                   <asp:ListItem>Yazar seçiniz..</asp:ListItem>
                                   <asp:ListItem>1</asp:ListItem>
                                   <asp:ListItem>2</asp:ListItem>
                                   <asp:ListItem>3</asp:ListItem>
                                   <asp:ListItem>4</asp:ListItem>
                                   <asp:ListItem>5</asp:ListItem>
                                   <asp:ListItem>6</asp:ListItem>
                                   <asp:ListItem>7</asp:ListItem>
                                   <asp:ListItem>8</asp:ListItem>
                                   <asp:ListItem>9</asp:ListItem>
                                   <asp:ListItem>10</asp:ListItem>
                                   </asp:DropDownList>
                                </td>
                        </tr>
                             <tr>
                                <td>D.Ö/D.S :</td>
                                <td>
                                   <asp:DropDownList ID="DropDownList3" runat="server" Width ="120px" >
                                   <asp:ListItem>Seçiniz..</asp:ListItem>
                                   <asp:ListItem>Doktora Öncesi</asp:ListItem>
                                   <asp:ListItem>Doktora Sonrası</asp:ListItem>
                                   </asp:DropDownList>
                                </td>
                        </tr>
                        </table>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="ButonKaydet" runat="server" Text="Kaydet" OnClick="btn_kaydet" CssClass="auto-style1" />
                    </div>
                </div>
                </div>
            </div>
        
        <div>
         <div class="messagealert" id="alert_container"> </div>
            
        </div>
       
         
        <div class="ÜstLabel">

            <asp:Label ID="Label1" runat="server" CssClass="AnaLabel" Text="Doçentlik Başvuru Puanı Hesaplama Formu"></asp:Label>

        </div>

        <div>
            <table id="puanlama" border="1" class="anaKatman">
                <tbody>
                <tr>
                    <td>
                        <select id="alan" name="D1" class="Label">
                        <option selected="selected">Alanınızı Seçiniz</option>
                        <option>Eğitim Bilimleri Temel Alanı</option>
                        <option>Fen Bilimleri ve Matematik Temel Alanı</option>
                        <option>Filoloji Temel Alanı</option>
                        <option>Güzel Sanatlar Temel Alanı</option>
                        <option>Hukuk Temel Alanı</option>
                        <option>İlahiyat Temel Alanı</option>
                        <option>Mimarlık, Planlama ve Tasarım Temel Alanı</option>
                        <option>Mühendislik Temel Alanı</option>
                        <option>Sağlık Bilimleri Temel Alanı</option>
                        <option>Sosyal, Beşeri ve İdari Bilimler Temel Alanı</option>
                        <option>Ziraat, Orman ve Su Ürünleri Temel Alanı</option>
                        <option>Spor Bilimleri Temel Alanı</option>
                </select>
                        </td>

                </tr>
                <tr class="baslik">
                <th class="ÜstLabel">Faaliyet Tipi</th>
                <th class="ÜstLabel">Detay</th>
                <th class="ÜstLabel">Puan</th>
                <th class="ÜstLabel">Ekle/Sil</th>
                </tr>
                    <tr>
                <td rowspan="3" id="ft_makale" class="Table">1)Uluslararası Makale</td>
                <td>
                    a) SSCI, SCI, SCI- Expanded ve AHCI kapsamındaki dergilerde editör mektup, özet veya kitap kritiği hariç olmak üzere yayımlanmış makale
                </td>
                <td class="sayi">20</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle1a" runat="server" Text="+" data-toggle="modal" data-target="#myModal" CssClass="auto-style1" OnClick="Ekle1a_Click" />
                        <asp:Button ID="Sil1a" runat="server" Text="-" OnClick="Sil1a_Click" CssClass="auto-style1" Width="22px" />
                    </div>
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    b) Uluslararası alan endekslerinde taranan dergilerde editöre mektup, özet veya kitap kritiği hariç olmak üzere yayımlanmış makale
                </td>
                <td class="sayi">15</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle1b" runat="server" Text="+" OnClick="Ekle1b_Click" EnableViewState="False" />
                        <asp:Button ID="Sil1b" runat="server" Text="-" Width="22px" OnClick="Sil1b_Click" />
                    </div>
                    <asp:Panel ID="Panel2" runat="server">
                    </asp:Panel>

                </td>
            </tr>
            <tr>
                <td>
                    c) Bu maddenin a veya b bentleri kapsamındaki yayınlarda alanında bilime katkı sağlayan kitap kritiği yapılmış makale
                </td>
                <td class="sayi">5</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle1c" runat="server" Text="+" OnClick="Ekle1c_Click" />  
                        <asp:Button ID="Sil1c" runat="server" Text="-" Width="22px" OnClick="Sil1c_Click" />
                    </div>
                    <asp:Panel ID="Panel3" runat="server">
                    </asp:Panel>
                </td>
                </tr>
            <tr>
                <td rowspan="2" class="Table">2)Ulusal Makale </td>
                <td>
                    a) ULAKBİM tarafından taranan ulusal hakemli dergilerde yayımlanmış makale
                </td>
                <td class="sayi">8</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle2a" runat="server" Text="+" OnClick="Ekle2a_Click" />    
                        <asp:Button ID="Sil2a" runat="server" Text="-" Width="22px" OnClick="Sil2a_Click" />
                    </div>
                    <asp:Panel ID="Panel4" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    b) a bendi dışındaki ulusal hakemli dergilerde yayımlanmış makale 
                </td>
                <td class="sayi">4</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle2b" runat="server" Text="+" OnClick="Ekle2b_Click" /> 
                        <asp:Button ID="Sil2b" runat="server" Text="-" Width="22px" OnClick="Sil2b_Click" />
                    </div>
                    <asp:Panel ID="Panel5" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="7" class="Table">3)Lisansüstü Tezlerden Üretilmiş Yayın</td>
                <td>
                    a) Uluslararası yayınevleri tarafından yayımlanmış kitap 
                </td>
                <td class="sayi">10</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3a" runat="server" Text="+" OnClick="Ekle3a_Click" />  
                        <asp:Button ID="Sil3a" runat="server" Text="-" Width="22px" OnClick="Sil3a_Click" />
                    </div>
                    <asp:Panel ID="Panel6" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    b) Uluslararası yayınevleri tarafından yayımlanmış kitapta bölüm
                </td>
                <td class="sayi">8</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3b" runat="server" Text="+" OnClick="Ekle3b_Click" /> 
                        <asp:Button ID="Sil3b" runat="server" Text="-" Width="22px" OnClick="Sil3b_Click" />
                    </div>
                    <asp:Panel ID="Panel7" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                   c) Ulusal yayınevleri tarafından yayımlanmış kitap
                </td>
                <td class="sayi">5</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3c" runat="server" Text="+" OnClick="Ekle3c_Click" /> 
                        <asp:Button ID="Sil3c" runat="server" Text="-" Width="22px" OnClick="Sil3c_Click" />
                    </div>
                    <asp:Panel ID="Panel8" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    d) Ulusal yayınevleri tarafından yayımlanmış kitapta bölüm
                </td>
                <td class="sayi">4</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3d" runat="server" Text="+" OnClick="Ekle3d_Click" />   
                        <asp:Button ID="Sil3d" runat="server" Text="-" Width="22px" OnClick="Sil3d_Click" />
                    </div>
                    <asp:Panel ID="Panel9" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    e) SSCI, SCI, SCI-Expanded ve AHCI kapsamındaki dergilerde yayımlanmış makale
                </td>
                <td class="sayi">8</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3e" runat="server" Text="+" OnClick="Ekle3e_Click" />   
                        <asp:Button ID="Sil3e" runat="server" Text="-" Width="22px" OnClick="Sil3e_Click" />
                    </div>
                    <asp:Panel ID="Panel10" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                f) Uluslararası alan endekslerinde taranan dergilerde yayımlanmış makale
                </td>
                <td class="sayi">6</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3f" runat="server" Text="+" OnClick="Ekle3f_Click" />
                        <asp:Button ID="Sil3f" runat="server" Text="-" Width="22px" OnClick="Sil3f_Click" />
                    </div>
                    <asp:Panel ID="Panel11" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    g) ULAKBİM tarafından taranan dergilerde yayımlanmış makale 
                </td>
                <td class="sayi">4</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle3g" runat="server" Text="+" OnClick="Ekle3g_Click" />    
                        <asp:Button ID="Sil3g" runat="server" Text="-" Width="22px" OnClick="Sil3g_Click" />
                    </div>
                    <asp:Panel ID="Panel12" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="4" id="ft_kitap" class="Table">4)Kitap </td>
                <td>
                    a) Uluslararası yayınevleri tarafından yayımlanmış kitap
                </td>
                <td class="sayi">20</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle4a" runat="server" Text="+" OnClick="Ekle4a_Click" />
                        <asp:Button ID="Sil4a" runat="server" Text="-" Width="22px" OnClick="Sil4a_Click" />
                    </div>
                    <asp:Panel ID="Panel13" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                 b) Uluslararası yayınevleri tarafından yayımlanmış kitap editörlüğü veya bölüm yazarlığı 
                </td>
                <td class="sayi">10</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle4b" runat="server" Text="+" OnClick="Ekle4b_Click" /> 
                        <asp:Button ID="Sil4b" runat="server" Text="-" Width="22px" OnClick="Sil4b_Click" />
                    </div>
                    <asp:Panel ID="Panel14" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    c) Ulusal yayınevleri tarafından yayımlanmış kitap
                </td>
                <td class="sayi">15</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle4c" runat="server" Text="+" OnClick="Ekle4c_Click" /> 
                        <asp:Button ID="Sil4c" runat="server" Text="-" Width="22px" OnClick="Sil4c_Click" />
                    </div>
                    <asp:Panel ID="Panel15" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                   d) Ulusal yayınevleri tarafından yayımlanmış kitap editörlüğü veya bölüm yazarlığı
                </td>
                <td class="sayi">8</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle4d" runat="server" Text="+" OnClick="Ekle4d_Click" /> 
                        <asp:Button ID="Sil4d" runat="server" Text="-" Width="22px" OnClick="Sil4d_Click" />
                    </div>
                    <asp:Panel ID="Panel16" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="3" id="ft_atif" class="Table">5)Atıflar</td>
                <td>
                a) SCI, SCI-Expanded, SSCI ve AHCI tarafından taranan dergilerde; Uluslararası yayınevleri tarafından yayımlanmış kitaplarda yayımlanan ve 
                    adayın yazar olarak yer almadığı yayınlardan her birinde, metin içindeki atıf sayısına bakılmaksızın adayın atıf yapılan her eseri için
                </td>
                <td class="sayi">3</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle5a" runat="server" Text="+" OnClick="Ekle5a_Click" />
                        <asp:Button ID="Sil5a" runat="server" Text="-" Width="22px" OnClick="Sil5a_Click" />
                    </div>
                    <asp:Panel ID="Panel17" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                   b) SCI, SCI-Expanded, SSCI ve AHCI dışındaki endeksler tarafından taranan dergilerde; Uluslararası yayınevleri tarafından yayımlanmış kitaplarda
                      bölüm yazarı olarak yayımlanan ve adayın yazar olarak yer almadığı yayınlardan her birinde, metin içindeki atıf sayısına bakılmaksızın adayın atıf yapılan her eseri için
                </td>
                <td class="sayi">2</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle5b" runat="server" Text="+" OnClick="Ekle5b_Click" /> 
                        <asp:Button ID="Sil5b" runat="server" Text="-" Width="22px" OnClick="Sil5b_Click" />
                    </div>
                    <asp:Panel ID="Panel18" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                c) Ulusal hakemli dergilerde; Ulusal yayınevleri tarafından yayımlanmış kitaplarda yayımlanan ve adayın yazar olarak yer almadığı yayınlardan her
                   birinde, metin içindeki atıf sayısına bakılmaksızın adayın atıf yapılan her eseri için
                </td>
                <td class="sayi">1</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle5c" runat="server" Text="+" OnClick="Ekle5c_Click" />
                        <asp:Button ID="Sil5c" runat="server" Text="-" Width="22px" OnClick="Sil5c_Click" />
                    </div>
                    <asp:Panel ID="Panel19" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="2" id="ft_tezd" class="Table">6)Lisansüstü Tez Danışmanlığı</td>
                <td>
                    a) Doktora tez danışmanlığı
                </td>
                <td class="sayi">4</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle6a" runat="server" Text="+" OnClick="Ekle6a_Click" />
                        <asp:Button ID="Sil6a" runat="server" Text="-" Width="22px" OnClick="Sil6a_Click" />
                    </div>
                    <asp:Panel ID="Panel20" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    b) Yüksek Lisans tez danışmanlığı
                </td>
                <td class="sayi">2</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle6b" runat="server" Text="+" OnClick="Ekle6b_Click" />
                        <asp:Button ID="Sil6b" runat="server" Text="-" Width="22px" OnClick="Sil6b_Click" />
                    </div>
                    <asp:Panel ID="Panel21" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="4" id="ft_ars_proj" class="Table">7)Bilimsel Araştırma Projesi</td>
                <td>
                    a) Devam eden veya başarı ile tamamlanmış AB Çerçeve Programı Bilimsel Araştırma Projesinde koordinatör / baş araştırmacı olmak
                </td>
                <td class="sayi">15</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle7a" runat="server" Text="+" OnClick="Ekle7a_Click" />
                        <asp:Button ID="Sİl7a" runat="server" Text="-" Width="22px" OnClick="Sİl7a_Click" />
                    </div>
                    <asp:Panel ID="Panel22" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                     b) Devam eden veya başarı ile tamamlanmış AB Çerçeve programı bilimsel araştırma projesinde ortak araştırmacı olmak
                </td>
                <td class="sayi">10</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle7b" runat="server" Text="+" OnClick="Ekle7b_Click" /> 
                        <asp:Button ID="Sil7b" runat="server" Text="-" Width="22px" OnClick="Sil7b_Click" />
                    </div>
                    <asp:Panel ID="Panel23" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
              c) Devam eden veya başarı ile tamamlanmış a ve b bentleri dışındaki uluslararası destekli bilimsel araştırma projelerinde (derleme ve rapor
                 hazırlama çalışmaları hariç) görev almak
                </td>
                <td class="sayi">6</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle7c" runat="server" Text="+" OnClick="Ekle7c_Click" />
                        <asp:Button ID="Sil7c" runat="server" Text="-" Width="22px" OnClick="Sil7c_Click" />
                    </div>
                    <asp:Panel ID="Panel24" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                  d) Üniversiteler dışındaki kamu kurumlarıyla yapılan başarıyla tamamlanan veya yürütülen bilimsel araştırma projelerinde görev almak 
                </td>
                <td class="sayi">4</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle7d" runat="server" Text="+" OnClick="Ekle7d_Click" />
                        <asp:Button ID="Sil7d" runat="server" Text="-" Width="22px" OnClick="Sil7d_Click" />
                    </div>
                    <asp:Panel ID="Panel25" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="2" id="ft_btf" class="Table">8)Bilimsel Toplantı Faaliyeti</td>
                <td>
                   a) Uluslararası bilimsel toplantılarda sunulan (poster hariç), tam metni veya özeti matbu veya elektronik olarak bildiri kitapçığında yayımlanmış çalışmalar.
                </td>
                <td class="sayi">3</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle8a" runat="server" Text="+" OnClick="Ekle8a_Click" />  
                        <asp:Button ID="Sil8a" runat="server" Text="-" Width="22px" OnClick="Sil8a_Click" />
                    </div>
                    <asp:Panel ID="Panel26" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                 a) Ulusal bilimsel toplantılarda sunulan (poster hariç), tam metni veya özeti matbu veya elektronik olarak bildiri kitapçığında yayımlanmış çalışmalar.
                </td>
                <td class="sayi">2</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle8b" runat="server" Text="+" OnClick="Ekle8b_Click" />  
                        <asp:Button ID="Sil8b" runat="server" Text="-" Width="22px" OnClick="Sil8b_Click" />
                    </div>
                    <asp:Panel ID="Panel27" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td rowspan="2" id="ft_eöf" class="Table">9)Eğitim Öğretim Faaliyeti</td>
                <td>
                    a) Bir dönem yüksek lisans veya doktora dersi
                </td>
                <td class="sayi">3</td>
                <td class="auto-style5">
                    <div class="ec">
                        <asp:Button ID="Ekle9a" runat="server" Text="+" OnClick="Ekle9a_Click" /> 
                        <asp:Button ID="Sil9a" runat="server" Text="-" Width="22px" OnClick="Sil9a_Click" />
                    </div>
                    <asp:Panel ID="Panel28" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    b) Bir dönem önlisans veya lisans dersi
                </td>
                <td class="sayi">2</td>
                <td>
                    <div class="ec">
                        <asp:Button ID="Ekle9b" runat="server" Text="+" OnClick="Ekle9b_Click" />  
                        <asp:Button ID="Sil9b" runat="server" Text="-" Width="22px" OnClick="Sil9b_Click" />
                    </div>
                    <asp:Panel ID="Panel29" runat="server">
                    </asp:Panel>
                    </td>
            </tr>
            <tr>
                  <td colspan="5" style="text-align:center;">

                        
                      <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click1" UseSubmitBehavior="False" CssClass="Buton" />

                    </td>

            </tr>
                   
                      
                      
                        



                </tbody>
            </table>
            </div>
        <div>
            <asp:Label ID="Label10" runat="server" Text="Hesap Tablosu" CssClass="ÜstLabel"></asp:Label>
        </div>
        <div>
            <table class ="table-bordered" border ="1">
                <tbody>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label6" runat="server" Text="Doktora Öncesi Ham Puan" CssClass="Table"></asp:Label>
                            <br />
                            <asp:Label ID="Label7" runat="server" Text="Doktora Sonrası Ham Puan" CssClass="Table"></asp:Label>
                            <br />
                            <asp:Label ID="Label8" runat="server" Text="Toplam Ham Puan" CssClass="Table"></asp:Label>
                            <br />
                            <asp:Label ID="Label9" runat="server" Text="Açıklama" CssClass="Table"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="Label" Visible="False"></asp:Label>       
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Label" CssClass="Label" Visible="False"></asp:Label>
                            <br />
                            <asp:Label ID="Label4" runat="server" Text="Label" CssClass="Label" Visible="False"></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Label" CssClass="Label" Font-Bold="False" Visible="False"></asp:Label>

                        </td>
                                                                
                    </tr>
                </tbody>
            </table>
        </div>
        
    </form>
</body>
</html>
