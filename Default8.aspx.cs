using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default8 :  System.Web.UI.Page
{
    private const string CmdText = "insert into userinfo5(tickets,userid,MovieName,TheatreName,Time,name) values (@Count,@UserId,@MovieName,@TheatreName,@Time,@name)";
    private const string CmdText2 = "select FirstName from userinfo where Id=@User";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = 0;
        string a = Checkbox1.Checked ? "Y" : "N";
        if (a == "Y")
        {
            count += 1;
        }
        string b = Checkbox2.Checked ? "Y" : "N";
        if (b == "Y")
        {
            count += 1;
        }
        string c = Checkbox3.Checked ? "Y" : "N";
        if (c == "Y")
        {
            count += 1;
        }
        string d = Checkbox4.Checked ? "Y" : "N";
        if (b == "Y")
        {
            count += 1;
        }
        string eab = Checkbox5.Checked ? "Y" : "N";
        if (eab == "Y")
        {
            count += 1;
        }
        string f = Checkbox6.Checked ? "Y" : "N";
        if (f == "Y")
        {
            count += 1;
        }
        string g = Checkbox7.Checked ? "Y" : "N";
        if (g == "Y")
        {
            count += 1;
        }
        string h = Checkbox8.Checked ? "Y" : "N";
        if (h == "Y")
        {
            count += 1;
        }
        string i = Checkbox9.Checked ? "Y" : "N";
        if (i == "Y")
        {
            count += 1;
        }
        string j = Checkbox10.Checked ? "Y" : "N";
        if (j == "Y")
        {
            count += 1;
        }
        string k = Checkbox11.Checked ? "Y" : "N";
        if (k == "Y")
        {
            count += 1;
        }
        string l = Checkbox12.Checked ? "Y" : "N";
        if (l == "Y")
        {
            count += 1;
        }
        string m = Checkbox13.Checked ? "Y" : "N";
        if (m == "Y")
        {
            count += 1;
        }
        string n = Checkbox14.Checked ? "Y" : "N";
        if (n == "Y")
        {
            count += 1;
        }
        string o = Checkbox15.Checked ? "Y" : "N";
        if (o == "Y")
        {
            count += 1;
        }
        string p = Checkbox16.Checked ? "Y" : "N";
        if (p == "Y")
        {
            count += 1;
        } 
        string q = Checkbox17.Checked ? "Y" : "N";
        if (q == "Y")
        {
            count += 1;
        }
        string r = Checkbox18.Checked ? "Y" : "N";
        if (r == "Y")
        {
            count += 1;
        }
        string s = Checkbox19.Checked ? "Y" : "N";
        if (s == "Y")
        {
            count += 1;
        }
        string t = Checkbox20.Checked ? "Y" : "N";
        if (t == "Y")
        {
            count += 1;
        }
        string u = Checkbox21.Checked ? "Y" : "N";
        if (u == "Y")
        {
            count += 1;
        }
        string v = Checkbox21.Checked ? "Y" : "N";
        if (v == "Y")
        {
            count += 1;
        }
        string w = Checkbox22.Checked ? "Y" : "N";
        if (w == "Y")
        {
            count += 1;
        }
        string x = Checkbox23.Checked ? "Y" : "N";
        if (x == "Y")
        {
            count += 1;
        }
        string y = Checkbox24.Checked ? "Y" : "N";
        if (y == "Y")
        {
            count += 1;
        }
        string z = Checkbox25.Checked ? "Y" : "N";
        if (z == "Y")
        {
            count += 1;
        }
        string ab = Checkbox26.Checked ? "Y" : "N";
        if (ab == "Y")
        {
            count += 1;
        }
        string ac = Checkbox27.Checked ? "Y" : "N";
        if (ac == "Y")
        {
            count += 1;
        }
        string ad = Checkbox28.Checked ? "Y" : "N";
        if (ad == "Y")
        {
            count += 1;
        }
        string ae = Checkbox29.Checked ? "Y" : "N";
        if (ae == "Y")
        {
            count += 1;
        }
        string af = Checkbox30.Checked ? "Y" : "N";
        if (af == "Y")
        {
            count += 1;
        }
        string ag = Checkbox31.Checked ? "Y" : "N";
        if (ag == "Y")
        {
            count += 1;
        }
        string ah = Checkbox32.Checked ? "Y" : "N";
        if (ah == "Y")
        {
            count += 1;
        }
        string ai = Checkbox33.Checked ? "Y" : "N";
        if (ai == "Y")
        {
            count += 1;
        }
        string aj = Checkbox34.Checked ? "Y" : "N";
        if (aj == "Y")
        {
            count += 1;
        }
        string ak = Checkbox35.Checked ? "Y" : "N";
        if (ak == "Y")
        {
            count += 1;
        }
        string al = Checkbox36.Checked ? "Y" : "N";
        if (al == "Y")
        {
            count += 1;
        }
        string am = Checkbox37.Checked ? "Y" : "N";
        if (am == "Y")
        {
            count += 1;
        }
        string an = Checkbox38.Checked ? "Y" : "N";
        if (an == "Y")
        {
            count += 1;
        }
        string ao = Checkbox39.Checked ? "Y" : "N";
        if (ao == "Y")
        {
            count += 1;
        }
        string ap = Checkbox40.Checked ? "Y" : "N";
        if (ap == "Y")
        {
            count += 1;
        }
        string aq = Checkbox41.Checked ? "Y" : "N";
        if (aq == "Y")
        {
            count += 1;
        }
        string ar = Checkbox42.Checked ? "Y" : "N";
        if (ar == "Y")
        {
            count += 1;
        }
        string at = Checkbox43.Checked ? "Y" : "N";
        if (at == "Y")
        {
            count += 1;
        }
        string au = Checkbox44.Checked ? "Y" : "N";
        if (au == "Y")
        {
            count += 1;
        }
        string av = Checkbox45.Checked ? "Y" : "N";
        if (av == "Y")
        {
            count += 1;
        }
        string aw = Checkbox46.Checked ? "Y" : "N";
        if (aw == "Y")
        {
            count += 1;
        }
        string ax = Checkbox47.Checked ? "Y" : "N";
        if (ax == "Y")
        {
            count += 1;
        }
        string ay = Checkbox48.Checked ? "Y" : "N";
        if (ay == "Y")
        {
            count += 1;
        }
        string az = Checkbox49.Checked ? "Y" : "N";
        if (az == "Y")
        {
            count += 1;
        }
        string ba = Checkbox50.Checked ? "Y" : "N";
        if (ba == "Y")
        {
            count += 1;
        }
        string bb = Checkbox51.Checked ? "Y" : "N";
        if (bb == "Y")
        {
            count += 1;
        }
        string bc = Checkbox52.Checked ? "Y" : "N";
        if (bc == "Y")
        {
            count += 1;
        }
        string bd = Checkbox53.Checked ? "Y" : "N";
        if (bd == "Y")
        {
            count += 1;
        }
        string be = Checkbox54.Checked ? "Y" : "N";
        if (be == "Y")
        {
            count += 1;
        }
        string bf = Checkbox55.Checked ? "Y" : "N";
        if (bf == "Y")
        {
            count += 1;
        }
        string bg = Checkbox56.Checked ? "Y" : "N";
        if (bg == "Y")
        {
            count += 1;
        }
        string bh = Checkbox57.Checked ? "Y" : "N";
        if (bh == "Y")
        {
            count += 1;
        }
        string bi = Checkbox58.Checked ? "Y" : "N";
        if (b == "Y")
        {
            count += 1;
        }
        string bj = Checkbox59.Checked ? "Y" : "N";
        if (bj == "Y")
        {
            count += 1;
        }
        string bk = Checkbox60.Checked ? "Y" : "N";
        if (bk == "Y")
        {
            count += 1;
        }
        string bl = Checkbox61.Checked ? "Y" : "N";
        if (bl == "Y")
        {
            count += 1;
        }
        string bm = Checkbox62.Checked ? "Y" : "N";
        if (bm == "Y")
        {
            count += 1;
        }
        string bn = Checkbox63.Checked ? "Y" : "N";
        if (bn == "Y")
        {
            count += 1;
        }
        string bo = Checkbox64.Checked ? "Y" : "N";
        if (bo == "Y")
        {
            count += 1;
        }
        string bp = Checkbox65.Checked ? "Y" : "N";
        if (bp == "Y")
        {
            count += 1;
        }
        string bq = Checkbox66.Checked ? "Y" : "N";
        if (bq == "Y")
        {
            count += 1;
        }
        string br = Checkbox67.Checked ? "Y" : "N";
        if (br == "Y")
        {
            count += 1;
        }
        string bs = Checkbox68.Checked ? "Y" : "N";
        if (bs == "Y")
        {
            count += 1;
        }
        string bt = Checkbox69.Checked ? "Y" : "N";
        if (bt == "Y")
        {
            count += 1;
        }
        string bu = Checkbox70.Checked ? "Y" : "N";
        if (bu == "Y")
        {
            count += 1;
        }
        string bv = Checkbox71.Checked ? "Y" : "N";
        if (bv == "Y")
        {
            count += 1;
        }
        string bw = Checkbox72.Checked ? "Y" : "N";
        if (bw == "Y")
        {
            count += 1;
        }
        string bx = Checkbox73.Checked ? "Y" : "N";
        if (bx == "Y")
        {
            count += 1;
        }
        string by = Checkbox74.Checked ? "Y" : "N";
        if (by == "Y")
        {
            count += 1;
        }
        string bz = Checkbox75.Checked ? "Y" : "N";
        if (bz == "Y")
        {
            count += 1;
        }
        

        string abc = Checkbox76.Checked ? "Y" : "N";
        if (abc == "Y")
        {
            count += 1;
        }
        string abd = Checkbox77.Checked ? "Y" : "N";
        if (abd == "Y")
        {
            count += 1;
        }
        string abe = Checkbox78.Checked ? "Y" : "N";
        if (abe == "Y")
        {
            count += 1;
        }
        string abf = Checkbox79.Checked ? "Y" : "N";
        if (abf == "Y")
        {
            count += 1;
        }
        string abg = Checkbox80.Checked ? "Y" : "N";
        if (abg == "Y")
        {
            count += 1;
        }
        
        
        string baf = Checkbox101.Checked ? "Y" : "N";
        if (baf == "Y")
        {
            count += 1;
        }
        string bag = Checkbox102.Checked ? "Y" : "N";
        if (bag == "Y")
        {
            count += 1;
        }
        string bah = Checkbox103.Checked ? "Y" : "N";
        if (bah == "Y")
        {
            count += 1;
        }
        string bai = Checkbox104.Checked ? "Y" : "N";
        if (bai == "Y")
        {
            count += 1;
        }
        string baj = Checkbox105.Checked ? "Y" : "N";
        if (baj == "Y")
        {
            count += 1;
        }
        string bak = Checkbox106.Checked ? "Y" : "N";
        if (bak == "Y")
        {
            count += 1;
        }
        string bal = Checkbox107.Checked ? "Y" : "N";
        if (bal == "Y")
        {
            count += 1;
        }
        string bam = Checkbox108.Checked ? "Y" : "N";
        if (bam == "Y")
        {
            count += 1;
        }
        string ban = Checkbox109.Checked ? "Y" : "N";
        if (ban == "Y")
        {
            count += 1;
        }
        string bao = Checkbox110.Checked ? "Y" : "N";
        if (bao == "Y")
        {
            count += 1;
        }
        string bap = Checkbox111.Checked ? "Y" : "N";
        if (bap == "Y")
        {
            count += 1;
        }
        string baq = Checkbox122.Checked ? "Y" : "N";
        if (baq == "Y")
        {
            count += 1;
        }
        string bar = Checkbox123.Checked ? "Y" : "N";
        if (bar == "Y")
        {
            count += 1;
        }
        string bas = Checkbox124.Checked ? "Y" : "N";
        if (bas == "Y")
        {
            count += 1;
        }
        string bat = Checkbox125.Checked ? "Y" : "N";
        if (bat == "Y")
        {
            count += 1;
        }
        string bau = Checkbox126.Checked ? "Y" : "N";
        if (bau == "Y")
        {
            count += 1;
        }
        string bav = Checkbox127.Checked ? "Y" : "N";
        if (bav == "Y")
        {
            count += 1;
        }
        string baw = Checkbox128.Checked ? "Y" : "N";
        if (baw == "Y")
        {
            count += 1;
        }
        string bax = Checkbox129.Checked ? "Y" : "N";
        if (bax == "Y")
        {
            count += 1;
        }
        string bay = Checkbox130.Checked ? "Y" : "N";
        if (bay == "Y")
        {
            count += 1;
        }
        string baz = Checkbox131.Checked ? "Y" : "N";
        if (baz == "Y")
        {
            count += 1;
        }
        string abca = Checkbox132.Checked ? "Y" : "N";
        if (abca == "Y")
        {
            count += 1;
        }
        string abad = Checkbox133.Checked ? "Y" : "N";
        if (abad == "Y")
        {
            count += 1;
        }
        string abae = Checkbox134.Checked ? "Y" : "N";
        if (abae == "Y")
        {
            count += 1;
        }
        string abaf = Checkbox135.Checked ? "Y" : "N";
        if (abaf == "Y")
        {
            count += 1;
        }
        string abag = Checkbox136.Checked ? "Y" : "N";
        if (abag == "Y")
        {
            count += 1;
        }
        string abah = Checkbox137.Checked ? "Y" : "N";
        if (abah == "Y")
        {
            count += 1;
        }
        string abai = Checkbox138.Checked ? "Y" : "N";
        if (abai == "Y")
        {
            count += 1;
        }
        string abaj = Checkbox139.Checked ? "Y" : "N";
        if (abaj == "Y")
        {
            count += 1;
        }
        string abak = Checkbox140.Checked ? "Y" : "N";
        if (abak == "Y")
        {
            count += 1;
        }
        string abal = Checkbox141.Checked ? "Y" : "N";
        if (abal == "Y")
        {
            count += 1;
        }
        string abam = Checkbox142.Checked ? "Y" : "N";
        if (abam == "Y")
        {
            count += 1;
        }
        string aban = Checkbox143.Checked ? "Y" : "N";
        if (aban == "Y")
        {
            count += 1;
        }
        string abao = Checkbox144.Checked ? "Y" : "N";
        if (abao == "Y")
        {
            count += 1;
        }
        string abap = Checkbox145.Checked ? "Y" : "N";
        if (abap == "Y")
        {
            count += 1;
        }
        string abaq = Checkbox146.Checked ? "Y" : "N";
        if (abaq == "Y")
        {
            count += 1;
        }
        string abar = Checkbox147.Checked ? "Y" : "N";
        if (abar == "Y")
        {
            count += 1;
        }
        string abas = Checkbox148.Checked ? "Y" : "N";
        if (abas == "Y")
        {
            count += 1;
        }
        string abat = Checkbox149.Checked ? "Y" : "N";
        if (abat == "Y")
        {
            count += 1;
        }
        string abau = Checkbox150.Checked ? "Y" : "N";
        if (abau == "Y")
        {
            count += 1;
        }
        string abav = Checkbox151.Checked ? "Y" : "N";
        if (abav == "Y")
        {
            count += 1;
        }
        string abaw = Checkbox152.Checked ? "Y" : "N";
        if (abaw == "Y")
        {
            count += 1;
        }
        string abax = Checkbox153.Checked ? "Y" : "N";
        if (abax == "Y")
        {
            count += 1;
        }
        string abay = Checkbox154.Checked ? "Y" : "N";
        if (abay == "Y")
        {
            count += 1;
        }
        string abaz = Checkbox155.Checked ? "Y" : "N";
        if (abaz == "Y")
        {
            count += 1;
        }
        string baab = Checkbox156.Checked ? "Y" : "N";
        if (baab == "Y")
        {
            count += 1;
        }

        string baac = Checkbox157.Checked ? "Y" : "N";
        if (baac == "Y")
        {
            count += 1;
        }
        string baad = Checkbox158.Checked ? "Y" : "N";
        if (baad == "Y")
        {
            count += 1;
        }
        string baae = Checkbox159.Checked ? "Y" : "N";
        if (baae == "Y")
        {
            count += 1;
        }
        string baaf = Checkbox160.Checked ? "Y" : "N";
        if (baaf == "Y")
        {
            count += 1;
        }
        string baag = Checkbox161.Checked ? "Y" : "N";
        if (baag == "Y")
        {
            count += 1;
        }
        string baah = Checkbox162.Checked ? "Y" : "N";
        if (baah == "Y")
        {
            count += 1;
        }
        string baai = Checkbox163.Checked ? "Y" : "N";
        if (baai == "Y")
        {
            count += 1;
        }
        string baaj = Checkbox164.Checked ? "Y" : "N";
        if (baaj == "Y")
        {
            count += 1;
        }
        string baak = Checkbox165.Checked ? "Y" : "N";
        if (baak == "Y")
        {
            count += 1;
        }
        string baal = Checkbox166.Checked ? "Y" : "N";
        if (baal == "Y")
        {
            count += 1;
        }
        string baam = Checkbox167.Checked ? "Y" : "N";
        if (baam == "Y")
        {
            count += 1;
        }
        string baan = Checkbox168.Checked ? "Y" : "N";
        if (baan == "Y")
        {
            count += 1;
        }
        string baao = Checkbox169.Checked ? "Y" : "N";
        if (baao == "Y")
        {
            count += 1;
        }
        string baap = Checkbox170.Checked ? "Y" : "N";
        if (baap == "Y")
        {
            count += 1;
        }
        string baaq = Checkbox171.Checked ? "Y" : "N";
        if (baaq == "Y")
        {
            count += 1;
        }
        string baar = Checkbox172.Checked ? "Y" : "N";
        if (baar == "Y")
        {
            count += 1;
        }
        string baas = Checkbox173.Checked ? "Y" : "N";
        if (baas == "Y")
        {
            count += 1;
        }
        string baat = Checkbox174.Checked ? "Y" : "N";
        if (baat == "Y")
        {
            count += 1;
        }
        string baau = Checkbox175.Checked ? "Y" : "N";
        if (baau == "Y")
        {
            count += 1;
        }
        string baav = Checkbox176.Checked ? "Y" : "N";
        if (baav == "Y")
        {
            count += 1;
        }
        string baaw = Checkbox177.Checked ? "Y" : "N";
        if (baaw == "Y")
        {
            count += 1;
        }
        string baax = Checkbox178.Checked ? "Y" : "N";
        if (baax == "Y")
        {
            count += 1;
        }
        string baay = Checkbox179.Checked ? "Y" : "N";
        if (baay == "Y")
        {
            count += 1;
        }
        string baaz = Checkbox180.Checked ? "Y" : "N";
        if (baaz == "Y")
        {
            count += 1;
        }
        string abcaa = Checkbox181.Checked ? "Y" : "N";
        if (abcaa == "Y")
        {
            count += 1;
        }
        string abada = Checkbox182.Checked ? "Y" : "N";
        if (abada == "Y")
        {
            count += 1;
        }
        string abaea = Checkbox183.Checked ? "Y" : "N";
        if (abaea == "Y")
        {
            count += 1;
        }
        string abafa = Checkbox184.Checked ? "Y" : "N";
        if (abafa == "Y")
        {
            count += 1;
        }
        string abaga = Checkbox185.Checked ? "Y" : "N";
        if (abaga == "Y")
        {
            count += 1;
        }
        string abaha = Checkbox186.Checked ? "Y" : "N";
        if (abaha == "Y")
        {
            count += 1;
        }
        string abaia = Checkbox187.Checked ? "Y" : "N";
        if (abaia == "Y")
        {
            count += 1;
        }
        string abaja = Checkbox188.Checked ? "Y" : "N";
        if (abaja == "Y")
        {
            count += 1;
        }
        string abaka= Checkbox189.Checked ? "Y" : "N";
        if (abaka == "Y")
        {
            count += 1;
        }
        string abala = Checkbox190.Checked ? "Y" : "N";
        if (abala == "Y")
        {
            count += 1;
        }
        string abama = Checkbox191.Checked ? "Y" : "N";
        if (abama == "Y")
        {
            count += 1;
        }
        string abana = Checkbox192.Checked ? "Y" : "N";
        if (abana == "Y")
        {
            count += 1;
        }
        string abaoa = Checkbox193.Checked ? "Y" : "N";
        if (abaoa == "Y")
        {
            count += 1;
        }
        string abapa = Checkbox194.Checked ? "Y" : "N";
        if (abapa == "Y")
        {
            count += 1;
        }
        string abaqa = Checkbox195.Checked ? "Y" : "N";
        if (abaqa == "Y")
        {
            count += 1;
        }
        string abara = Checkbox196.Checked ? "Y" : "N";
        if (abara == "Y")
        {
            count += 1;
        }
        string abasa = Checkbox197.Checked ? "Y" : "N";
        if (abasa == "Y")
        {
            count += 1;
        }
        string abata = Checkbox198.Checked ? "Y" : "N";
        if (abata == "Y")
        {
            count += 1;
        }
        string abaua = Checkbox199.Checked ? "Y" : "N";
        if (abaua == "Y")
        {
            count += 1;
        }
        string abava = Checkbox200.Checked ? "Y" : "N";
        if (abava == "Y")
        {
            count += 1;
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
        con.Open(); 
        
         SqlCommand cmd = new SqlCommand(CmdText, con);
        cmd.Parameters.AddWithValue("@Count", count);
        cmd.Parameters.AddWithValue("@TheatreName", Session["textBoxValue3"]);
        cmd.Parameters.AddWithValue("@Time", Session["textBoxValue4"]);
        cmd.Parameters.AddWithValue("@UserId", Session["textBoxValue"]);
        cmd.Parameters.AddWithValue("@MovieName", Session["textBoxValue2"]);



        SqlCommand cmd2 = new SqlCommand(CmdText2, con);

        cmd2.Parameters.AddWithValue("@User", Session["textBoxValue"].ToString());
        SqlDataReader myReader = cmd2.ExecuteReader();
        while (myReader.Read())
        {

            cmd.Parameters.AddWithValue("@name", myReader["FirstName"].ToString());
            

            

        }

        myReader.Close();
       

      

        cmd.ExecuteNonQuery();
        Response.Redirect("Default9.aspx");
    }

    
}