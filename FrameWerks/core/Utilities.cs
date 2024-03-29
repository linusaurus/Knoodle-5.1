﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace FrameWorks
{
    public class Utilities
    {
        /// <summary>
        /// Method to populate a list with all the class
        /// in the namespace provided by the user
        /// </summary>
        /// <param name="nameSpace">The namespace the user wants searched</param>
        /// <returns></returns>
        public static List<string> GetAllClasses(string nameSpace)
        {
            //create an Assembly and use its GetExecutingAssembly Method
            //http://msdn2.microsoft.com/en-us/library/system.reflection.assembly.getexecutingassembly.aspx
            Assembly asm = Assembly.GetExecutingAssembly();
            //Assembly asm = Assembly.ReflectionOnlyLoadFrom("Weaselware.Knoodle");
        
            //create a list for the namespaces
            List<string> namespaceList = new List<string>();
            //create a list that will hold all the classes
       
            List<string> returnList = new List<string>();
            //loop through all the "Types" in the Assembly using
   
            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == nameSpace)
                    namespaceList.Add(type.FullName.Substring(17));
            }
            //now loop through all the classes returned above and add
            //them to our classesName list
            foreach (String className in namespaceList)
                returnList.Add(className);
            //return the list
            return returnList;
        }

        public static List<string> GetAllNameSpaces()
        {
            //create an Assembly and use its GetExecutingAssembly Method
            Assembly asm = Assembly.GetExecutingAssembly();
            //create a list for the namespaces
            List<string> namespaceList = new List<string>();
         
            var s = asm.GetTypes().Select(t => t.Namespace).Where(e => e.StartsWith("FrameWorks.Makes")).Distinct().ToList();

            foreach (var item in s)
            {
                if (item.Length > 16)
                {
                    string e = item.Substring(17);
                    namespaceList.Add(e);
                }   
            }

            List<string> returnList = new List<string>();
            //loop through all the "Types" in the Assembly using

            foreach (String className in namespaceList)
                returnList.Add(className);
            //return the list
            return namespaceList;
        }
    }
}
