using Microsoft.AspNetCore.Mvc;
using RandomWordApi.Service;

namespace RandomWordApi.Controllers;

[ApiController]
public class RandomWordController : ControllerBase {
    private RandomWordService randomWordService;
    public RandomWordController(RandomWordService randomWordService) {
        this.randomWordService = randomWordService;
    }

    [HttpGet("randomword")]
    public string[]? GetWord(int amountOfWords) {
        return randomWordService.GetWord(amountOfWords);
    }
    
    [HttpGet("randomwords")]
    public string[]? GetAllWords() {
        return randomWordService.GetAllWords();
    }

    [HttpPost("randomword")]
    public string? CreateWord(string word) {
        return randomWordService.CreateWord(word);
    }
}
