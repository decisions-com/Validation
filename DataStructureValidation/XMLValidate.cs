using DecisionsFramework.Design.Flow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

/// <summary>
/// The simplest types of steps are method based sync steps.  Simply write whatever
/// .NET code you want and use an attribute on the CLASS or on the METHOD itself to 
/// register that code with the workflow engine as a flow step.
/// </summary>
namespace DataStructureValidation
{
    [AutoRegisterMethodsOnClass(true, "Data/Validation")]
    public class XMLValidate
    {
        public string XMLValidation(string XMLToValidate)
        {

            try
            {


                XmlReaderSettings booksSettings = new XmlReaderSettings();
            
                booksSettings.ValidationType = ValidationType.DTD;
            

                XmlReader books = XmlReader.Create(new StringReader(XMLToValidate), booksSettings);
           
                while (books.Read()) { }
            }
            catch(Exception ex2)
            {
                return ex2.Message;
            }
            return "OK";
        }


        

    }
}
