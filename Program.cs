using System.Xml.Serialization;

class Programm
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Apple", 4);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Dog));
        using (StreamWriter fileStream = new StreamWriter("User_Atr.xml"))
        {
            xmlSerializer.Serialize(fileStream, dog);
        }
    }
}
[Serializable]
public class Dog
{
    [XmlAttribute]
    public string name;
    [XmlAttribute]
    public int age;

    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Dog()
    {

    }
}