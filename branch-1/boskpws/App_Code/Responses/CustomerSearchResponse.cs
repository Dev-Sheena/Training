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

/// <summary>
/// Summary description for CustomerSearchResponse
/// </summary>
public class CustomerSearchResponse
{
    public string MLCardNo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Street { get; set; }
    public string ProvinceCity { get; set; }
    public string BirthDate { get; set; }
    public string Gender { get; set; }
    public string ContactNo { get; set; }
    public string Country { get; set; }
    public string IDType { get; set; }
    public string IDNo { get; set; }
    public string ExpiryDate { get; set; }
    public string CustID { get; set; }
    public string PhoneNo { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string PlaceofBirth { get; set; }
    public string NatureOfWork { get; set; }
    public string PermanentAddress { get; set; }
    public string Nationality { get; set; }
    public string CompanyOrEmployer { get; set; }
    public string BusinessOrProfession { get; set; }
    public string GovtIDType { get; set; }
    public string GovtIDNo { get; set; }
    public string createdby { get; set; }
    public string datecreated { get; set; }
    public string modifiedby { get; set; }
    public string datemodified { get; set; }
    //public Byte[] kycfront { get; set; }
    //public Byte[] kycback { get; set; }
    //public Byte[] id1 { get; set; }
    //public Byte[] id2 { get; set; }
    //public Byte[] id3 { get; set; }
}
