using RandomWordApi.Service;

namespace RandomWordApi;

public class RandomWordRepository 
{
    private DataService DataService;
    
    Random randomNumber = new Random();

    public RandomWordRepository(DataService dataService) 
    {
        this.DataService = dataService;
    }

    public string[]? GetWord(int amountOfWords) 
    {
        string[]? listOfWantedWords = new string[amountOfWords]; 
        for (int iterationCounter = 0; iterationCounter < amountOfWords; iterationCounter++) 
        {
            listOfWantedWords[iterationCounter] = this.DataService.randomWords[randomNumber.Next(this.DataService.randomWords.Count())];
        }

        return listOfWantedWords;
    }

    public string[]? GetAllWords() 
    {
        return this.DataService.randomWords.ToArray();
    }

    public string? CreateWord(string word) 
    {
        this.DataService.randomWords.Add(word);

        return word;
    }
}
