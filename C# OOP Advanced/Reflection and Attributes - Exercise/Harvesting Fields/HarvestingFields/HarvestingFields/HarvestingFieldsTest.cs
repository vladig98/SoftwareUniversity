using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HarvestingFieldsTest
{
    public string PrintFields(string className, string flags)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

        switch (flags)
        {
            case "private":
                fields = fields.Where(f => f.IsPrivate).ToArray();
                break;
            case "protected":
                fields = fields.Where(x => x.IsFamily).ToArray();
                break;
            case "public":
                fields = fields.Where(x => x.IsPublic).ToArray();
                break;
            case "all":
                break;
            default:
                return "";
        }

        StringBuilder sb = new StringBuilder();

        foreach (FieldInfo field in fields)
        {
            sb.AppendLine($"{GetFieldType(field)} {field.FieldType.Name} {field.Name}");
        }

        return sb.ToString();
    }

    private string GetFieldType(FieldInfo field)
    {
        if (field.IsFamily)
        {
            return "protected";
        }
        if (field.IsPrivate)
        {
            return "private";
        }
        if (field.IsPublic)
        {
            return "public";
        }
        if (field.IsAssembly)
        {
            return "internal";
        }

        return "";
    }
}
