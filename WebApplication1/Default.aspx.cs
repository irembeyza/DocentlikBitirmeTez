using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
    
namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        public static List<Madde> sonuclar = new List<Madde>();
        public static int sayi;
        public static int sonuc;
        public static int maddeid;
        public enum MessageType {Dikkat};
        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }
        void Hesapla()
        {
            if (DropDownList1.SelectedItem.Text == "Adet seçiniz.." || DropDownList2.SelectedItem.Text == "Yazar seçiniz.." || DropDownList3.SelectedItem.Text == "Seçiniz..")
            {
                ShowMessage("Faaliyet seçenekleri eklenemedi.İlgili alanları eksiksiz doldurunuz", MessageType.Dikkat); 
                DropDownList1.Text = "Adet seçiniz..";
                DropDownList2.Text = "Yazar seçiniz..";
                DropDownList3.Text = "Seçiniz..";
                return;
            }
            else
            {
                sonuc = (sayi * Convert.ToInt32(DropDownList1.SelectedItem.Text)) / Convert.ToInt32(DropDownList2.SelectedItem.Text);
                sonuclar.Add(new Madde()
                {
                    Maddesonucu = sonuc,
                    Durum = DropDownList3.SelectedItem.Text,
                    MaddeID = maddeid,

                });
                Label l = new Label();
                l.Text = sonuc + "/" + DropDownList3.SelectedItem.Text;
                DropDownList1.Text = "Adet seçiniz..";
                DropDownList2.Text = "Yazar seçiniz..";
                DropDownList3.Text = "Seçiniz..";

                if (maddeid == 1)
                {
                    Panel1.Controls.Add(l);

                }
                else if(maddeid == 2)
                {
                    Panel2.Controls.Add(l);

                }
                else if (maddeid == 3)
                {
                    Panel3.Controls.Add(l);


                }
                else if (maddeid == 4)
                {
                    Panel4.Controls.Add(l);


                }
                else if (maddeid == 5)
                {
                    Panel5.Controls.Add(l);


                }
                else if (maddeid == 6)
                {
                    Panel6.Controls.Add(l);


                }
                else if (maddeid == 7)
                {
                    Panel7.Controls.Add(l);


                }
                else if (maddeid == 8)
                {
                    Panel8.Controls.Add(l);


                }
                else if (maddeid == 9)
                {
                    Panel9.Controls.Add(l);


                }
                else if (maddeid == 10)
                {
                    Panel10.Controls.Add(l);


                }
                else if (maddeid == 11)
                {
                    Panel11.Controls.Add(l);


                }
                else if (maddeid == 12)
                {
                    Panel12.Controls.Add(l);


                }
                else if (maddeid == 13)
                {
                    Panel13.Controls.Add(l);


                }
                else if (maddeid == 14)
                {
                    Panel14.Controls.Add(l);


                }
                else if (maddeid == 15)
                {
                    Panel15.Controls.Add(l);


                }
                else if (maddeid == 16)
                {
                    Panel16.Controls.Add(l);


                }
                else if (maddeid == 17)
                {
                    Panel17.Controls.Add(l);


                }
                else if (maddeid == 18)
                {
                    Panel18.Controls.Add(l);


                }
                else if (maddeid == 19)
                {
                    Panel19.Controls.Add(l);


                }
                else if (maddeid == 20)
                {
                    Panel20.Controls.Add(l);


                }
                else if (maddeid == 21)
                {
                    Panel21.Controls.Add(l);


                }
                else if (maddeid == 22)
                {
                    Panel22.Controls.Add(l);


                }
                else if (maddeid == 23)
                {
                    Panel23.Controls.Add(l);


                }
                else if (maddeid == 24)
                {
                    Panel24.Controls.Add(l);


                }
                else if (maddeid == 25)
                {
                    Panel25.Controls.Add(l);


                }
                else if (maddeid == 26)
                {
                    Panel26.Controls.Add(l);


                }
                else if (maddeid == 27)
                {
                    Panel27.Controls.Add(l);


                }
                else if (maddeid == 28)
                {
                    Panel28.Controls.Add(l);


                }
                else if (maddeid == 29)
                {
                    Panel29.Controls.Add(l);


                }




            }

        }
        void sonucCek()
        {
            var maddebir = sonuclar.Where(x => x.MaddeID == 1).ToList();
            var maddeiki = sonuclar.Where(x => x.MaddeID == 2).ToList();
            var maddeüc = sonuclar.Where(x => x.MaddeID == 3).ToList();
            var maddedört = sonuclar.Where(x => x.MaddeID == 4).ToList();
            var maddebes = sonuclar.Where(x => x.MaddeID == 5).ToList();
            var maddealti = sonuclar.Where(x => x.MaddeID == 6).ToList();
            var maddeyedi = sonuclar.Where(x => x.MaddeID == 7).ToList();
            var maddesekiz = sonuclar.Where(x => x.MaddeID == 8).ToList();
            var maddedokuz = sonuclar.Where(x => x.MaddeID == 9).ToList();
            var maddeon = sonuclar.Where(x => x.MaddeID == 10).ToList();
            var maddeonbir = sonuclar.Where(x => x.MaddeID == 11).ToList();
            var maddeoniki = sonuclar.Where(x => x.MaddeID == 12).ToList();
            var maddeonüc = sonuclar.Where(x => x.MaddeID == 13).ToList();
            var maddeondört = sonuclar.Where(x => x.MaddeID == 14).ToList();
            var maddeonbes = sonuclar.Where(x => x.MaddeID == 15).ToList();
            var maddeonalti = sonuclar.Where(x => x.MaddeID == 16).ToList();
            var maddeonyedi = sonuclar.Where(x => x.MaddeID == 17).ToList();
            var maddeonsekiz = sonuclar.Where(x => x.MaddeID == 18).ToList();
            var maddeondokuz = sonuclar.Where(x => x.MaddeID == 19).ToList();
            var maddeyirmi = sonuclar.Where(x => x.MaddeID == 20).ToList();
            var maddeyirmibir = sonuclar.Where(x => x.MaddeID == 21).ToList();
            var maddeyirmiiki = sonuclar.Where(x => x.MaddeID == 22).ToList();
            var maddeyirmiüc = sonuclar.Where(x => x.MaddeID == 23).ToList();
            var maddeyirmidört = sonuclar.Where(x => x.MaddeID == 24).ToList();
            var maddeyirmibes = sonuclar.Where(x => x.MaddeID == 25).ToList();
            var maddeyirmialti = sonuclar.Where(x => x.MaddeID == 26).ToList();
            var maddeyirmiyedi = sonuclar.Where(x => x.MaddeID == 27).ToList();
            var maddeyirmisekiz = sonuclar.Where(x => x.MaddeID == 28).ToList();
            var maddeyirmidokuz = sonuclar.Where(x => x.MaddeID == 29).ToList();





            foreach (var item in maddebir)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel1.Controls.Add(l);
               

            }
            foreach (var item in maddeiki)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel2.Controls.Add(l);
                

            }
            foreach (var item in maddeüc)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel3.Controls.Add(l);


            }
            foreach (var item in maddedört)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel4.Controls.Add(l);


            }
            foreach (var item in maddebes)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel5.Controls.Add(l);


            }
            foreach (var item in maddealti)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel6.Controls.Add(l);


            }
            foreach (var item in maddeyedi)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel7.Controls.Add(l);


            }
            foreach (var item in maddesekiz)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel8.Controls.Add(l);


            }
            foreach (var item in maddedokuz)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel9.Controls.Add(l);


            }
            foreach (var item in maddeon)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel10.Controls.Add(l);


            }
            foreach (var item in maddeonbir)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel11.Controls.Add(l);


            }
            foreach (var item in maddeoniki)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel12.Controls.Add(l);


            }
            foreach (var item in maddeonüc)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel13.Controls.Add(l);


            }
            foreach (var item in maddeondört)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel14.Controls.Add(l);


            }
            foreach (var item in maddeonbes)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel15.Controls.Add(l);


            }
            foreach (var item in maddeonalti)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel16.Controls.Add(l);


            }
            foreach (var item in maddeonyedi)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel17.Controls.Add(l);


            }
            foreach (var item in maddeonsekiz)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel18.Controls.Add(l);


            }
            foreach (var item in maddeondokuz)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel19.Controls.Add(l);


            }
            foreach (var item in maddeyirmi)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel20.Controls.Add(l);


            }
            foreach (var item in maddeyirmibir)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel21.Controls.Add(l);


            }
            foreach (var item in maddeyirmiiki)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel22.Controls.Add(l);


            }
            foreach (var item in maddeyirmiüc)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel23.Controls.Add(l);


            }
            foreach (var item in maddeyirmidört)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel24.Controls.Add(l);


            }
            foreach (var item in maddeyirmibes)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel25.Controls.Add(l);


            }
            foreach (var item in maddeyirmialti)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel26.Controls.Add(l);


            }
            foreach (var item in maddeyirmiyedi)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel27.Controls.Add(l);


            }
            foreach (var item in maddeyirmisekiz)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel28.Controls.Add(l);


            }
            foreach (var item in maddeyirmidokuz)
            {
                Label l = new Label();
                l.Text = item.Maddesonucu + "/" + item.Durum + "</br>";
                Panel29.Controls.Add(l);


            }





        }

        protected void Page_Load(object sender, EventArgs e)
        {
            sonucCek();
        }

        protected void Ekle1a_Click(object sender, EventArgs e)
        {
            sayi = 20;
            maddeid = 1;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

        }
        protected void Sil1a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 1);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel1.Controls.RemoveAt(Panel1.Controls.Count - 1);
            }
        }

        protected void Ekle1b_Click(object sender, EventArgs e)
        {
            maddeid = 2;
            sayi = 15;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

        }
        protected void Sil1b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 2);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel2.Controls.RemoveAt(Panel2.Controls.Count - 1);

            }
        }

        protected void Ekle1c_Click(object sender, EventArgs e)
        {
            maddeid = 3;
            sayi = 5;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

        }
        protected void Sil1c_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 3);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel3.Controls.RemoveAt(Panel3.Controls.Count - 1);

            }
        }

        protected void Ekle2a_Click(object sender, EventArgs e)
        {
            maddeid = 4;
            sayi = 8;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);

        }
        protected void Sil2a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 4);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel4.Controls.RemoveAt(Panel4.Controls.Count - 1);

            }
        }

        protected void btn_kaydet(object sender, EventArgs e)
        {
            Hesapla();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            int doktoraöncesitoplam = 0;
            int doktorasonrasıtoplam = 0;
            int toplam = 0;
            // doktor öncesi
            var doktoraönce = sonuclar.Where(i => i.Durum == "Doktora Öncesi").ToList();
            doktoraöncesitoplam = doktoraönce.Select(i => i.Maddesonucu).Sum();
            Label2.Text = doktoraöncesitoplam.ToString();
            Label2.Visible = true;

            // doktor sonrası
            var doktorasonrası = sonuclar.Where(i => i.Durum == "Doktora Sonrası").ToList();
            doktorasonrasıtoplam = doktorasonrası.Select(i => i.Maddesonucu).Sum();
            Label3.Text = doktorasonrasıtoplam.ToString();
            Label3.Visible = true;

            //genel toplam
            toplam = sonuclar.Select(i => i.Maddesonucu).Sum();
            Label4.Text = toplam.ToString();
            Label4.Visible = true;
            if (toplam >= 100 && doktorasonrasıtoplam > 90)
            {
                Label5.Text = "Doçentlik Başvuru Şartı Sağlanmıştır.";
                Label5.ForeColor = Color.Green;
                Label5.Visible = true;
            }
            else if (doktorasonrasıtoplam < 90)
            {
                Label5.Text = "En az Doksan(90) puanın doktora unvanının alınmasından sonra gerçekleştirilen çalışmalarda elde edilmiş olması gerekmektedir. ";
                Label5.ForeColor = Color.Red;
                Label5.Visible = true;

            }
            else
            {
                Label5.Text = "Doçentlik Başvuru Şartı Sağlanmamıştır.";
                Label5.ForeColor = Color.Red;
                Label5.Visible = true;

            }

        }

        protected void Ekle2b_Click(object sender, EventArgs e)
        {
            maddeid = 5;
            sayi = 4;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil2b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 5);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel5.Controls.RemoveAt(Panel5.Controls.Count - 1);

            }
        }

        protected void Ekle3a_Click(object sender, EventArgs e)
        {
            maddeid = 6;
            sayi = 10;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 6);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel6.Controls.RemoveAt(Panel6.Controls.Count - 1);

            }
        }

        protected void Ekle3b_Click(object sender, EventArgs e)
        {
            maddeid = 7;
            sayi = 8;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 7);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel7.Controls.RemoveAt(Panel7.Controls.Count - 1);

            }
        }

        protected void Ekle3c_Click(object sender, EventArgs e)
        {
            maddeid = 8;
            sayi = 5;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3c_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 8);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel8.Controls.RemoveAt(Panel8.Controls.Count - 1);

            }
        }

        protected void Ekle3d_Click(object sender, EventArgs e)
        {
            maddeid = 9;
            sayi = 4;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3d_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 9);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel9.Controls.RemoveAt(Panel9.Controls.Count - 1);

            }
        }

        protected void Ekle3e_Click(object sender, EventArgs e)
        {
            maddeid = 10;
            sayi = 8;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3e_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 10);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel10.Controls.RemoveAt(Panel10.Controls.Count - 1);

            }
        }

        protected void Ekle3f_Click(object sender, EventArgs e)
        {
            maddeid = 11;
            sayi = 6;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3f_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 11);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel11.Controls.RemoveAt(Panel11.Controls.Count - 1);

            }
        }

        protected void Ekle3g_Click(object sender, EventArgs e)
        {
            maddeid = 12;
            sayi = 4;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil3g_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 12);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel12.Controls.RemoveAt(Panel12.Controls.Count - 1);

            }
        }

        protected void Ekle4a_Click(object sender, EventArgs e)
        {
            maddeid = 13;
            sayi = 20;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil4a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 13);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel13.Controls.RemoveAt(Panel13.Controls.Count - 1);

            }
        }

        protected void Ekle4b_Click(object sender, EventArgs e)
        {
            maddeid = 14;
            sayi = 10;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil4b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 14);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel14.Controls.RemoveAt(Panel14.Controls.Count - 1);

            }
        }

        protected void Ekle4c_Click(object sender, EventArgs e)
        {
            maddeid = 15;
            sayi = 15;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil4c_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 15);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel15.Controls.RemoveAt(Panel15.Controls.Count - 1);

            }
        }

        protected void Ekle4d_Click(object sender, EventArgs e)
        {
            maddeid = 16;
            sayi = 8;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil4d_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 16);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel16.Controls.RemoveAt(Panel16.Controls.Count - 1);

            }
        }

        protected void Ekle5a_Click(object sender, EventArgs e)
        {
            maddeid = 17;
            sayi = 3;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil5a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 17);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel17.Controls.RemoveAt(Panel17.Controls.Count - 1);

            }
        }

        protected void Ekle5b_Click(object sender, EventArgs e)
        {
            maddeid = 18;
            sayi = 2;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil5b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 18);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel18.Controls.RemoveAt(Panel18.Controls.Count - 1);

            }
        }

        protected void Ekle5c_Click(object sender, EventArgs e)
        {
            maddeid = 19;
            sayi = 1;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil5c_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 19);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel19.Controls.RemoveAt(Panel19.Controls.Count - 1);

            }
        }

        protected void Ekle6a_Click(object sender, EventArgs e)
        {
            maddeid = 20;
            sayi = 4;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil6a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 20);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel20.Controls.RemoveAt(Panel20.Controls.Count - 1);

            }
        }

        protected void Ekle6b_Click(object sender, EventArgs e)
        {
            maddeid = 21;
            sayi = 2;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil6b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 21);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel21.Controls.RemoveAt(Panel21.Controls.Count - 1);

            }
        }

        protected void Ekle7a_Click(object sender, EventArgs e)
        {
            maddeid = 22;
            sayi = 15;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sİl7a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 22);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel22.Controls.RemoveAt(Panel22.Controls.Count - 1);

            }
        }

        protected void Ekle7b_Click(object sender, EventArgs e)
        {
            maddeid = 23;
            sayi = 10;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil7b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 23);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel23.Controls.RemoveAt(Panel23.Controls.Count - 1);

            }
        }

        protected void Ekle7c_Click(object sender, EventArgs e)
        {
            maddeid = 24;
            sayi = 6;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil7c_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 24);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel24.Controls.RemoveAt(Panel24.Controls.Count - 1);

            }
        }

        protected void Ekle7d_Click(object sender, EventArgs e)
        {
            maddeid = 25;
            sayi = 4;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil7d_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 25);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel25.Controls.RemoveAt(Panel25.Controls.Count - 1);

            }
        }

        protected void Ekle8a_Click(object sender, EventArgs e)
        {
            maddeid = 26;
            sayi = 3;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil8a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 26);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel26.Controls.RemoveAt(Panel26.Controls.Count - 1);

            }
        }

        protected void Ekle8b_Click(object sender, EventArgs e)
        {
            maddeid = 27;
            sayi = 2;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil8b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 27);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel27.Controls.RemoveAt(Panel27.Controls.Count - 1);

            }
        }

        protected void Ekle9a_Click(object sender, EventArgs e)
        {
            maddeid = 28;
            sayi = 3;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil9a_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 28);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel28.Controls.RemoveAt(Panel28.Controls.Count - 1);

            }
        }

        protected void Ekle9b_Click(object sender, EventArgs e)
        {
            maddeid = 29;
            sayi = 2;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void Sil9b_Click(object sender, EventArgs e)
        {
            var son = sonuclar.LastOrDefault(x => x.MaddeID == 29);
            if (son != null)
            {
                sonuclar.Remove(son);
                Panel29.Controls.RemoveAt(Panel29.Controls.Count - 1);

            }
        }
    }
}