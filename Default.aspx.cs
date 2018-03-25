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
        string url = this.txtUrl.Text;
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse) request.GetResponse();
        StreamReader srReader = new StreamReader(response.GetResponseStream());
        this.txtSourceCode.Text = srReader.ReadToEnd();
        srReader.Close();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string source = this.txtSourceCode.Text;
        string keyword = this.txtKeyWord.Text;
        this.lblKeyword.Text = keyword;
        this.lblFoundFlag.Text = source.Contains(keyword) ? "Found" : "Not Found";
        int count = 0;
        int i = 0;
        while ((i = source.IndexOf(keyword, i)) != -1)
        {
            i += keyword.Length;
            count++;
        }
        this.lblFindCount.Text = count == 0 ? "0" : count.ToString();
    }
}