using OpenQA.Selenium;
using Framework.Enums;

namespace Framework.Helpers
{
    public class LocatorHelper
    {
        private LocatorType _byType;
        private string _byValue;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private LocatorHelper _parent;

        public LocatorHelper(string byValue, LocatorHelper parent = null)
        {
            _byValue = byValue;
            _byType = LocatorType.XPath;
            _parent = parent;

        }

        public LocatorHelper(string byValue, LocatorType byType, LocatorHelper parent = null)
        {
            _byValue = byValue;
            _byType = byType;
            _parent = parent;
        }

        public LocatorHelper SetParent(LocatorHelper parent){

            _parent = parent;
            return this;

        }


        public By GetBy()
        {
            //string str = ApplyParameters();
            string str = _byValue;
            By by;

            switch(_byType)
            {
                case LocatorType.className:
                    by = By.ClassName(str); 
                    break;
                case LocatorType.XPath:
                    by = By.XPath(str); 
                    break;
                case LocatorType.LinkText: 
                    by = By.LinkText(str); 
                    break;
                case LocatorType.PartialLinkText:
                    by = By.PartialLinkText(str);
                    break;
                case LocatorType.Id: 
                    by = By.Id(str);
                    break;
                case LocatorType.Name:
                    by = By.Name(str);
                    break;
                case LocatorType.CssSelector: 
                    by = By.CssSelector(str);
                    break;
                case LocatorType.TagName: 
                    by = By.TagName(str); 
                    break;
                default:
                    throw new Exception("By type is not recognised");


            }

            //if(_parent != null)            
            //    return (By)new ByChained(new By[2]
            //    {
            //        _parent.GetBy(), by
            //    });

            return by;
            
        }

        private string ApplyParameters()
        {
            string str = _byValue;
            foreach(KeyValuePair<string, string> parameter in _parameters)
            {
                str.Replace("{" + parameter.Key + "}", parameter.Value);
            }
            return str;
        }
    
    }
}
