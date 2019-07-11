# Practice: List of Dictionaries about Words

Now, you are going to refactor the structure of our data. Instead of one C# Dictionary with key value pairs for words and definitions. You want to track more than just the word and its definition, so we are going to build a list of dictionaries.

```cs
// Make a new list
List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

/*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few words
Dictionary<string, string> excitedWord = new Dictionary<string, string>();

// Add each of the 4 bits of data about the word to the Dictionary
excitedWord.Add();

// Add Dictionary to your `dictionaryOfWords` list


// create another Dictionary and add that to the list


/*
    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/

// Iterate the List of Dictionaries
foreach ()
{
    // Iterate the KeyValuePairs of the Dictionary
    foreach ()
    {
        Console.WriteLine($"{wordData.Key}: {wordData.Value}");
    }
}
```
