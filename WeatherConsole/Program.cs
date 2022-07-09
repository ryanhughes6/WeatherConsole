using System.Xml;
namespace WeatherConsole { 

    class MainProgram
    {
        static void Main(string[] args)
        {
            //Declare XML file variable
            XmlDocument WeatherXML = new XmlDocument();

            //Load XML file from Environment Canada
            WeatherXML.Load("https://dd.weather.gc.ca/citypage_weather/xml/PE/s0000583_e.xml");

            //Read XML nodes from file
            XmlNodeList textsummary = WeatherXML.GetElementsByTagName("textSummary");
            XmlNodeList name = WeatherXML.GetElementsByTagName("name");
            XmlNodeList province = WeatherXML.GetElementsByTagName("province");
            XmlNodeList temp = WeatherXML.GetElementsByTagName("temperature");
            XmlNodeList condition = WeatherXML.GetElementsByTagName("condition");

            //Write out forecast
            Console.WriteLine("Forecast for " + name[0].InnerText + ", " + province[0].InnerText);
            Console.WriteLine("Last Updated: " + textsummary[1].InnerText);
            Console.WriteLine("Current temperature is: " + temp[0].InnerText + "°C");
            Console.WriteLine("Current conditions are: " + condition[0].InnerText);
        }
    }

}