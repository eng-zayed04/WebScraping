using System;
using System.IO;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGenerate_Click(object sender, EventArgs e)
    {
        this.lblError.Text = "";
        this.lblError.Text = string.IsNullOrWhiteSpace(this.txtUrl.Text) ? "Please enter Url " : "";
        this.pnlReport.Visible = false;
        string url = this.txtUrl.Text;
        this.txtSourceCode.Text = GenerateSourceCode(url);
    }

    public string GenerateSourceCode(string url)
    {
        string sourceCode;
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        StreamReader sr = new StreamReader(response.GetResponseStream());
        sourceCode= sr.ReadToEnd();
        sr.Close();
        return sourceCode;
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        this.lblError.Text = string.IsNullOrWhiteSpace(this.txtUrl.Text) ? "Please enter Url " : "";
        this.lblError.Text += string.IsNullOrWhiteSpace(this.txtUrl.Text) ? "Please enter Keyword" : "";
        if (!string.IsNullOrWhiteSpace(this.lblError.Text)) return;

        this.pnlReport.Visible = true;

        this.txtSourceCode.Text = GenerateSourceCode(this.txtUrl.Text);

        this.lblKeyword.Text = this.txtKeyWord.Text;
        this.lblFoundFlag.Text = this.txtSourceCode.Text.Contains(this.txtKeyWord.Text) ? "Found" : "Not Found";

        int count = CountKeyword(this.txtSourceCode.Text, this.txtKeyWord.Text);
        this.lblFindCount.Text = count == 0 ? "0" : count.ToString();
    }

    public int CountKeyword(string source, string keyword)
    {
        int count = 0;
        int i = 0;
        while ((i = source.IndexOf(keyword, i)) != -1)
        {
            i += keyword.Length;
            count++;
        }
        return count;
    }
}