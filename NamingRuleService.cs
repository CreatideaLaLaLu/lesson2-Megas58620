using System.Text;

namespace Pingtung.Twport.Travel.Service
{
    public class NamingRuleService
    {
        /// <summary>
        /// 測試方法
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            switch (index)
            {
                // bad: 單獨一行
                //case 1: break;

                // good: 換行
                case 1:
                    break;
                // bad: 單獨一行
                //default: break;

                // good:換行
                default:
                    break;
            }

            // bad:if判斷式未寫完整
            if (index == 0) DoTrue();
            else
                DoFalse();

            // good:正規化
            if (index == 0)
            {
                DoTrue();
            }
            else
            {
                 DoFalse();
            }

            // bad:多於換行，if判斷式內不做true/false判斷，換行
            //if (DoTrue() == true) { DoTrue(); }

            // good:正規化
            if (DoTrue())
            {
                DoTrue();
            }

            // bad:回傳值不需使用括號
            //return (index * (index + 1) / 2);

            // good:移除括號
            return index * (index + 1) / 2;
        }

        /// <summary>
        /// DoTrue
        /// </summary>
        /// <returns></returns>
        private bool DoTrue()
        {
            return true;
        }
        // good:大括號後需換行

        /// <summary>
        /// DoFalse
        /// </summary>
        /// <returns></returns>
        private bool DoFalse()
        {
            return false;
        }

        /// <summary>
        /// 測試字串方法
        /// </summary>
        /// <param name="value">值</param>
        public void TestStringFunction(string value)
        {
            // bad:私有變數未採用camelCasting 命名法
            //string NewString = "ABCDEFG"; //新字串

            // good:採用camelCasting 命名法
            string newString = "ABCDEFG"; //新字串

            // bad:字串判斷null空值採用string.IsNullOrEmpty()
            //if (value != null | value != "") value = newString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            // good:採用string.IsNullOrEmpty()，取代字串使用StringBuilder提升效能
            if (string.IsNullOrEmpty(value))
            {
                value = new StringBuilder(newString).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }
        }

    }
}