using Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
public class SampleService : ISampleService
{
    public string Test(string s)
    {
        Console.WriteLine("Test Method Executed!");
        return s + "";
    }
    public void XmlMethod(XElement xml)
    {
        Console.WriteLine(xml.ToString());
    }
    public MyCustomModel TestCustomModel(MyCustomModel customModel)
    {
        return customModel;
    }

    public List<BachelorProjectBackend.Models.test> TestList()
    {
        return BachelorProjectBackend.Repository.test.test1();
    }
}