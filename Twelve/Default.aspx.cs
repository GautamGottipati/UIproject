using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Twelve
{
    public partial class _Default : Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = lblName.Text + "<br/>" + "PreInit";
        }
        
        // Loaded First 
        // Check the IsPostBack property to determine whether this is the first time the page is being processed
        protected void Page_PreInit(object sender, EventArgs e)
        {
              
            //lblName.Text = lblName.Text + "<br/>" + "PreInit";
        }
        // Loaded Second
        protected void Page_Init(object sender, EventArgs e)
        {
             
            lblName.Text = lblName.Text + "<br/>" + "Init";
        }
        // Third
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            
            lblName.Text = lblName.Text + "<br/>" + "InitComplete";
        }
        // Fourth
        protected override void OnPreLoad(EventArgs e)
        {
            
            lblName.Text = lblName.Text + "<br/>" + "PreLoad";
        }
        // Fifth
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click";
        }
        // Sixth
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            
            lblName.Text = lblName.Text + "<br/>" + "LoadComplete";
        }
        //Seventh
        protected override void OnPreRender(EventArgs e)
        {
             
            lblName.Text = lblName.Text + "<br/>" + "PreRender";
        }
        // Eighth
        protected override void OnSaveStateComplete(EventArgs e)
        {
            
            lblName.Text = lblName.Text + "<br/>" + "SaveStateComplete";
        }
        // Last
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            
            lblName.Text = lblName.Text + "<br/>" + "UnLoad";
        }
    }
}
