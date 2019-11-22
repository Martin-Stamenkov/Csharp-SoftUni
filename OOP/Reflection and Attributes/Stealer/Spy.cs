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
            //Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == investigateClass);

            sb.AppendLine($"Class under investigation: {investigateClass}");

            var classInstance = Activator.CreateInstance(type);
            FieldInfo[] classFields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().TrimEnd();
        }
    }
