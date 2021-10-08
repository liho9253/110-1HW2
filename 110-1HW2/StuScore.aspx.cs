using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW2
{
    public partial class StuScore : System.Web.UI.Page
    {
        public class Scores
        {
            public string s_Id;
            public float f_ChiS;
            public float f_MathS;
            public float f_EngS;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Scores o_Stu = new Scores();
            o_Stu.s_Id = "A123456789";
            o_Stu.f_ChiS = 62f;
            o_Stu.f_MathS = 73f;
            o_Stu.f_EngS = 84f;

            Response.Write("s_Id = "+ o_Stu.s_Id + 
                           ", f_ChiS = "+ o_Stu.f_ChiS.ToString() + 
                           ", f_MathS = " + o_Stu.f_MathS.ToString() + 
                           ", f_EngS = " + o_Stu.f_EngS.ToString());
        }
    }
}