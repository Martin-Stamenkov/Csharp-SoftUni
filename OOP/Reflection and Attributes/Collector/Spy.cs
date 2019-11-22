using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigateClass, params string[] fieldsToInvestigate)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(investigateClass);

        sb.AppendLine($"Class under investigation: {investigateClass}");

        var classInstance = Activator.CreateInstance(type);
        FieldInfo[] classFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().TrimEnd();
    }
    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);

        FieldInfo[] classField = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] publicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        MethodInfo[] nonPublicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        foreach (var field in classField)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (var method in publicMethods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }
        foreach (var method in nonPublicMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().TrimEnd();
    }
    public string RevealPrivateMethods(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type type = Type.GetType(className);
        MethodInfo[] privateMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");

        foreach (var method in privateMethods)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().TrimEnd();
    }
    public string CollectGettersAndSetters(string className)
    {
        StringBuilder sb = new StringBuilder();
        Type type = Type.GetType(className);
        MethodInfo[] allMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        
        foreach (var method in allMethods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (var method in allMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString().TrimEnd();
    }

}


