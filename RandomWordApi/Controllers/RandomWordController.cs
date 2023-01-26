using Microsoft.AspNetCore.Mvc;
using RandomWordApi.Service;

namespace RandomWordApi.Controllers;

[ApiController]
public class RandomWordController : ControllerBase {
    private RandomWordService RandomWordService;
    public RandomWordController(RandomWordService RandomWordService) {
        this.RandomWordService = RandomWordService;
    }

    [HttpGet("randomword")]
    public string[]? GetWord(int amountOfWords) {
        return RandomWordService.GetWord(amountOfWords);
    }
    
    [HttpGet("randomwords")]
    public string[]? GetAllWords() {
        return RandomWordService.GetAllWords();
    }

    [HttpPost("randomword")]
    public string? CreateWord(string word) {
        return RandomWordService.CreateWord(word);
    }
}
