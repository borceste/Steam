using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using Steam.DataAccessLayer;
using Steam.Models;

namespace Steam.Controllers
{
    public static class XmlHelper
    {
        public static bool NewLineOnAttributes { get; set; }
        /// <summary>
        /// Serializes an object to an XML string, using the specified namespaces.
        /// </summary>
        public static string ToXml(object obj, XmlSerializerNamespaces ns)
        {
            Type T = obj.GetType();

            var xs = new XmlSerializer(T);
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = NewLineOnAttributes, OmitXmlDeclaration = true };

            var sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb, ws))
            {
                xs.Serialize(writer, obj, ns);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Serializes an object to an XML string.
        /// </summary>
        public static string ToXml(object obj)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            return ToXml(obj, ns);
        }

        /// <summary>
        /// Deserializes an object from an XML string.
        /// </summary>
        public static T FromXml<T>(string xml)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(xml))
            {
                return (T)xs.Deserialize(sr);
            }
        }

        /// <summary>
        /// Deserializes an object from an XML string, using the specified type name.
        /// </summary>
        public static object FromXml(string xml, string typeName)
        {
            Type T = Type.GetType(typeName);
            XmlSerializer xs = new XmlSerializer(T);
            using (StringReader sr = new StringReader(xml))
            {
                return xs.Deserialize(sr);
            }
        }

        /// <summary>
        /// Serializes an object to an XML file.
        /// </summary>
        public static void ToXmlFile(Object obj, string filePath)
        {
            var xs = new XmlSerializer(obj.GetType());
            var ns = new XmlSerializerNamespaces();
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = NewLineOnAttributes, OmitXmlDeclaration = true };
            ns.Add("", "");

            using (XmlWriter writer = XmlWriter.Create(filePath, ws))
            {
                xs.Serialize(writer, obj);
            }
        }

        /// <summary>
        /// Deserializes an object from an XML file.
        /// </summary>
        public static T FromXmlFile<T>(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            try
            {
                var result = FromXml<T>(sr.ReadToEnd());
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("There was an error attempting to read the file " + filePath + "\n\n" + e.InnerException.Message);
            }
            finally
            {
                sr.Close();
            }
        }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            
            
            DataClass dataClass = new DataClass();
            List<Game> games = dataClass.Games.ToList();
            List<Game> newGames = new List<Game>();
            foreach(Game g in games)
            {
                Game newGame = new Game();
                newGame.Id = g.Id;
                newGame.name = g.name;
                newGame.price = g.price;
                newGame.images = XmlHelper.FromXml<List<string>>(g.listOfImages);
                newGame.coverImage = g.coverImage;
                newGame.description = g.description;
                newGame.developer = g.developer;
                newGame.rating = g.rating;
                newGame.reviews = g.reviews;
                newGame.discount = g.discount;
                newGame.genre = g.genre;
                newGame.sold = g.sold;
                newGame.dateAdded = g.dateAdded;
                newGames.Add(newGame);
                
            }

            return View(newGames);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}