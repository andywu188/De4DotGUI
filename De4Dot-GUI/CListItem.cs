using System;

namespace De4DotGUI
{

    [Serializable]
    public class CListItem : ICloneable
    {
        private string text;
        private object value;


        public CListItem()
        {

        }

        public CListItem(string text)
        {
            this.text = text;
            this.value = text;
        }

        public CListItem(string text, object value)
        {
            this.text = text;
            this.value = value;
        }

        /// <summary>
        /// 获取字典文本
        /// </summary>
        /// <returns></returns>
        public string GetText()
        {
            return this.text;
        }

        /// <summary>
        /// 设置字典文本
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string text)
        {
            this.text = text;
        }
        /// <summary>
        /// 获取字典值
        /// </summary>
        /// <returns></returns>
        public object GetValue()
        {
            return this.value;
        }
        /// <summary>
        /// 设置字典值
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.Text.ToString();
        }

        /// <summary>
        /// 字典文本
        /// </summary>
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

        /// <summary>
        /// 字典值
        /// </summary>
        public object Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public object Clone()
        {
            return this;
        }
    }
}

