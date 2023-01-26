namespace RandomWordApi.Service;

public class RandomWordService 
{
    private RandomWordRepository randomWordRepository;

    public RandomWordService(RandomWordRepository randomWordRepository) 
    {
        this.randomWordRepository = randomWordRepository;
    }

    public string[] GetWord(int amountOfWords) 
    {
        return randomWordRepository.GetWord(amountOfWords);
    }

    public string[] GetAllWords() 
    {
        return randomWordRepository.GetAllWords();
    }

    public string CreateWord(string word) 
    {
        return randomWordRepository.CreateWord(word);
    }
}
