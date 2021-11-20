using System.IO;
using System.Text.Json;

namespace StudentReputation
{
    public static class SaveLoader
    {
        public static void Save(ClassList list)
        {
            var json = JsonSerializer.Serialize(list);
            File.WriteAllText("classlist.json", json);
        }

        public static ClassList Load(out bool isNew)
        {
            if (File.Exists("classlist.json"))
            {
                isNew = false;
                var json = File.ReadAllText("classlist.json");
                return JsonSerializer.Deserialize<ClassList>(json);
            }

            isNew = true;
            return new ClassList();
        }
    }
}