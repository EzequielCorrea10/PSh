using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YourNamespace.Reports
{
    public static class ReportGenerator
    {
        public static void GenerateCsv<T>(IEnumerable<T> data, string filePath)
        {
            var properties = typeof(T).GetProperties();
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(",", properties.Select(p => p.Name)));

            foreach (var item in data)
            {
                var line = string.Join(",", properties.Select(p => EscapeCsvValue(p.GetValue(item, null)?.ToString() ?? string.Empty)));
                sb.AppendLine(line);
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        private static string EscapeCsvValue(string value)
        {
            if (value.Contains(",") || value.Contains("\""))
            {
                value = $"\"{value.Replace("\"", "\"\"")}\"";
            }
            return value;
        }
    }
}