using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] rigged = new int[0];
                int[] subterfuge = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Rigged", rigged);
                ViewState.Add("Subterfuge", subterfuge);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] rigged = (int[])ViewState["Rigged"];
            int[] subterfuge = (int[])ViewState["Subterfuge"];

            int newLength = assets.Length + 1;

            Array.Resize(ref assets, newLength);
            Array.Resize(ref rigged, newLength);
            Array.Resize(ref subterfuge, newLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = assetTextBox.Text;
            rigged[newIndex] = int.Parse(riggedTextBox.Text);
            subterfuge[newIndex] = int.Parse(subterfugeTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Rigged"] = rigged;
            ViewState["Subterfuge"] = subterfuge;

            resultLabel.Text = string.Format("Total elections rigged: {0}<br />Average acts of subterfuge per asset: {1:N2}<br />(Last asset you added: {2}.)",
            rigged.Sum(),
            subterfuge.Average(),
            assets[newIndex]);

            assetTextBox.Text = "";
            riggedTextBox.Text = "";
            subterfugeTextBox.Text = "";
        }
    }
}