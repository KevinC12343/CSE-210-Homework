using System.IO; 
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        
    }
    public void DisplayAll()
    {

    }
    public void LoadFromFile(string file)
    {
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
    }
}