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
            MethodInfo[] nonPublicMethods = type.GetMethods(BindingFlags.Instance  | BindingFlags.Public);

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
    }

