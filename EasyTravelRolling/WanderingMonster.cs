using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace EasyTravelRolling
{
    internal class WanderingMonster
    {
        private string name;
        public string Name
        {
            get { return GetStringCopy(name); }//end getter
            set { name = GetStringCopy(value); }//end setter
        }//end Name

        private string description;
        public string Description
        {
            get { return GetStringCopy(description); }//end getter
            set { description = GetStringCopy(value); }//end setter
        }//end Description

        private string pageRef;
        public string PageRef
        {
            get { return GetStringCopy(pageRef); }//end getter
            set { pageRef = GetStringCopy(value); }//end setter
        }//end PageRef

        public List<string> StringPropertyList
        {
            get
            {
                List<string> output = new List<string>();
                PropertyInfo[] properties = typeof(WanderingMonster).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if(properties[i].PropertyType == typeof(string))
                    {
                        output.Add((string)properties[i].GetValue(properties[i]));
                    }//end if property is a string
                }//end looping for each property
                return output;
            }//end getter
        }//end PropertyList

        /// <summary>
        /// sets all variables to null
        /// </summary>
        public WanderingMonster()
        {
            name = null;
            description = null;
            pageRef = null;
        }//end no-arg constructor

        /// <summary>
        /// initializes variables to specified values
        /// </summary>
        public WanderingMonster(string Name, string Description, string PageRef)
        {
            this.Name = Name;
            this.Description = Description;
            this.PageRef = PageRef;
        }//end 3-arg constructor

        /// <summary>
        /// returns string representation of this object. Properties set
        /// to null will be ignored
        /// </summary>
        public override string ToString()
        {
            string temp1 = "";
            if (Name != null) temp1 = $"{Name}. ";
            string temp2 = "";
            if (PageRef != null) temp2 = $"Found on {PageRef}.";
            string temp3 = "";
            if (Description != null) temp3 = $" \nDescription: {Description}";
            return $"{temp1}{temp2}{temp3}";
        }//end ToString()

        /// <summary>
        /// returns a new string with the same value as the parameter
        /// but a totally different object reference
        /// </summary>
        private static string GetStringCopy(string str)
        {
            //char[] newString = new char[str.Length];
            //str.CopyTo(0, newString, str.Length - 1, str.Length);
            //StringBuilder sb = new StringBuilder();
            //sb.Append(newString);
            //return sb.ToString();
            return str;
        }//end GetStringCopy
    }//end class
}//end namespace