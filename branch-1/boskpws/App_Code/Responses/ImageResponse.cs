using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;

/// <summary>
/// Summary description for ImageResponse
/// </summary>
public class ImageResponse
{
    public Object respcode;
    public String respmsg;
    public DataSet ds;
    public List<byte[]> lst;

    public ImageResponse(Int16 respc, String respm, List<byte[]> list)
    {
        respcode = respc;
        respmsg = respm;
        lst = list;
    }

    public ImageResponse(Int16 respc, String respm)
    {
        respcode = respc;
        respmsg = respm;
    }
	public ImageResponse()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
