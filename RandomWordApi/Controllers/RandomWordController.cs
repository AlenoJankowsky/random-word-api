using Microsoft.AspNetCore.Mvc;
using RandomWordApi.Service;

namespace RandomWordApi.Controllers;

[Route(template:"")]
[ApiController]
public class RandomWordController : ControllerBase {
    private RandomWordService randomWordService;
    public RandomWordController(RandomWordService randomWordService) {
        this.randomWordService = randomWordService;
    }

    [HttpGet(template:"GetWord")]
    public string[]? GetWord(int amountOfWords) {
        return randomWordService.GetWord(amountOfWords);
    }
    
    [HttpGet(template:"GetAllWords")]
    public string[]? GetAllWords() {
        return randomWordService.GetAllWords();
    }

    [HttpPost(template:"CreateWord")]
    public string? CreateWord(string word) {
        return randomWordService.CreateWord(word);
    }
}
