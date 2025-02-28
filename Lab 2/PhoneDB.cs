namespace Lab_2;

public class PhoneDB
{
    private HashSet<string> members;
    private Dictionary<string, HashSet<string>> telephones;

    // Constructor
    public PhoneDB(IEnumerable<string> names)
    {
        members = new HashSet<string>(names);
        telephones = new Dictionary<string, HashSet<string>>();
    }

    // Add Entry
    public void AddEntry(string name, string newNumber)
    {
        if (!members.Contains(name))
            throw new ArgumentException("Name not found in members."); // Name not found in members
        
        if (!telephones.ContainsKey(name))
            telephones[name] = new HashSet<string>();
        
        if (!telephones[name].Add(newNumber))
            throw new InvalidOperationException("Number already exists for this person."); // Avoid duplicate numbers
    }

    // Find Phones
    public HashSet<string> FindPhones(string name)
    {
        if (!telephones.TryGetValue(name, out var numbers))
            throw new KeyNotFoundException("Person not found in phone database."); // unknown_name
        
        return new HashSet<string>(numbers);
    }

    // Remove Entry
    public void RemoveEntry(string name, string oldNumber)
    {
        if (!telephones.TryGetValue(name, out var numbers) || !numbers.Contains(oldNumber))
            throw new KeyNotFoundException("Number not found for the given person."); // do not exist
        
        numbers.Remove(oldNumber);
        if (numbers.Count == 0)
            telephones.Remove(name); // if no numbers left, remove the person
    }
}