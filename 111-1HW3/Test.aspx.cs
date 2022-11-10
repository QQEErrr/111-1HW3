using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] Category = { "蔬菜", "水果" };
        string[,] Food = { { "A菜", "空心菜" }, { "番茄", "火龍果" } };

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                for(var v_x = 0; v_x < Category.Length; v_x++)
                {
                    ListItem l_i = new ListItem();
                    l_i.Value = l_i.Text = Category[v_x];

                    ddl_Category.Items.Add(l_i);
                }
                QQEE();
            }
        }
        protected void ddl_Category_Changed(object sender, EventArgs e)
        {
            QQEE();
        }
        void QQEE()
        {
            ddl_Food.Items.Clear();
            int i_x = ddl_Category.SelectedIndex;
            for (var Q_Q = 0; Q_Q < Food.GetLength(1);Q_Q++)
            {
                ListItem E_E = new ListItem();
                E_E.Value = E_E.Text = Food[i_x, Q_Q];

                ddl_Food.Items.Add(E_E);
            }
        }
    }
}