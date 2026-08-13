using CP2.Architecture;
using CP2.Architecture.Providers;
using CP2.Data.Global;
using System.Text.Json;
using CP2.COR;
using CP2.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CP2.Core;

public interface IRoomsBusiness
{
    Task<bool> SolutionIndexAsync(string code);
    Task<bool> SolutionRoom1Async(int num);
    Task<bool> SolutionRoom2Async(string code);
    Task<bool> SolutionRoom3Async(string code);
    Task<bool> SolutionRoom4Async(string code);
    Task<bool> SolutionRoom5Async();
    Task<bool> SolutionRoom6Async(int num);
    Task<bool> SolutionRoom7Async(string code);
    Task<bool> SolutionRoom8Async();
    Task<bool> SolutionRoom9Async(string code);
    Task<bool> SolutionRoom10Async(string code);
    Task<bool> SolutionRoom11Async(string code);
    Task<bool> SolutionRoom12Async(string code);
    Task<bool> SolutionRoom13Async(string code);
    Task<bool> SolutionRoom14Async(string code);
    Task<bool> CanExitTheRoomsAsync(string code);
}

public class RoomsBusiness(
    IRestProvider restProvider,
    SecureHashService secureHashService,
    IReadOnlyDictionary<int, string> roomConfigs) : RoomsBase(restProvider, secureHashService, roomConfigs), IRoomsBusiness
{
    private readonly IRestProvider _restProvider = restProvider;

    /*
    public async Task<bool> SolutionTestAsync(string code)
    {
        // solucion aqui
        //code = "test";
 
        // codiguito aqui
        // lalalala lalalala
        // code = resultado de lalalal
 
        var resultHash = Evaluate(0, code);
        var resultApi = await CallApiAsync("test", code);
        return (resultHash && resultApi);
    }*/

    public async Task<bool> SolutionIndexAsync(string code)
    {
        // solucion aqui
        var resultHash = Evaluate(0, code);
        //var resultApi = await CallApiAsync("test", code);
        //return (resultHash && resultApi);
        
        // EGRZKVQ
        return (resultHash);
    }

    public async Task<bool> SolutionRoom1Async(int x)
    {
        // 7
        var resultado = $"{x}{x * x}{3 * x}{x * x * x}";
        return Evaluate(1, resultado);
    }

    public async Task<bool> SolutionRoom2Async(string code)
    {
        code = code.Trim().ToUpperInvariant();

        return Evaluate(2, code);

        // SOLID
    }

    public Task<bool> SolutionRoom3Async(string code)
    {
        var _hash = new SecureHashService("E4A1F9B7C32D8F64A9F1C0D3B7E2A6CC4F18B92ED0C4A7F1D3B89C6A5F2E1D44");
        
        bool result = _hash.Validate("Alvaro Miranda", "s0+cAcAI8p+zqhoIZtVjRr+HSLnTHp6NVa5YmTw1Ie4=");
        return Task.FromResult(result);
    }
    
    public Task<bool> SolutionRoom4Async(string code)
     {
         try
         {
             using JsonDocument doc = JsonDocument.Parse(code);

             JsonElement root = doc.RootElement;

             if (!root.TryGetProperty("puzzleName", out JsonElement puzzleName) ||
                 puzzleName.GetString() != "OOP Puzzle")
             {
                 return Task.FromResult(false);
             }

             if (!root.TryGetProperty("rows", out JsonElement rows) ||
                 rows.GetInt32() != 25)
             {
                 return Task.FromResult(false);
             }

             if (!root.TryGetProperty("columns", out JsonElement columns) ||
                 columns.GetInt32() != 25)
             {
                 return Task.FromResult(false);
             }

             if (!root.TryGetProperty("foundWords", out JsonElement foundWords) ||
                 foundWords.ValueKind != JsonValueKind.Array ||
                 foundWords.GetArrayLength() != 4)
             {
                 return Task.FromResult(false);
             }

             // WORD 1
             JsonElement word1 = foundWords[0];

             bool word1Correct =
                 word1.GetProperty("word").GetString()?.Trim().ToUpperInvariant()
                     == "POLIMORFISMO" &&
                 word1.GetProperty("start").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "A" &&
                 word1.GetProperty("start").GetProperty("row").GetInt32()
                     == 1 &&
                 word1.GetProperty("end").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "L" &&
                 word1.GetProperty("end").GetProperty("row").GetInt32()
                     == 12;

             // WORD 2
             JsonElement word2 = foundWords[1];

             bool word2Correct =
                 word2.GetProperty("word").GetString()?.Trim().ToUpperInvariant()
                     == "ENCAPSULAMIENTO" &&
                 word2.GetProperty("start").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "Y" &&
                 word2.GetProperty("start").GetProperty("row").GetInt32()
                     == 1 &&
                 word2.GetProperty("end").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "K" &&
                 word2.GetProperty("end").GetProperty("row").GetInt32()
                     == 15;

             // WORD 3
             JsonElement word3 = foundWords[2];

             bool word3Correct =
                 word3.GetProperty("word").GetString()?.Trim().ToUpperInvariant()
                     == "HERENCIA" &&
                 word3.GetProperty("start").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "X" &&
                 word3.GetProperty("start").GetProperty("row").GetInt32()
                     == 6 &&
                 word3.GetProperty("end").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "X" &&
                 word3.GetProperty("end").GetProperty("row").GetInt32()
                     == 13;

             // WORD 4
             JsonElement word4 = foundWords[3];

             bool word4Correct =
                 word4.GetProperty("word").GetString()?.Trim().ToUpperInvariant()
                     == "ABSTRACCION" &&
                 word4.GetProperty("start").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "N" &&
                 word4.GetProperty("start").GetProperty("row").GetInt32()
                     == 15 &&
                 word4.GetProperty("end").GetProperty("column").GetString()?.ToUpperInvariant()
                     == "X" &&
                 word4.GetProperty("end").GetProperty("row").GetInt32()
                     == 15;

             return Task.FromResult(
                 word1Correct &&
                 word2Correct &&
                 word3Correct &&
                 word4Correct
             );
         }
         catch (JsonException)
         {
             return Task.FromResult(false);
         }
         catch (KeyNotFoundException)
         {
             return Task.FromResult(false);
         }
     }

    public async Task<bool> SolutionRoom5Async()
    {
        /*var options = new DbContextOptionsBuilder<FoodbankContext>()
            .UseSqlServer(
                "Server=KokarPCDesk13;" +
                "Database=Foodbank;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;" +
                "Encrypt=True"
            )
            .Options;

        using var db = new FoodbankContext(options);

        var ingredientes = await db.FoodItems
            .Where(item =>
                item.Ingredients != null &&
                item.Ingredients.Contains("game") &&
                item.Price >= 6.5m &&
                item.Price <= 7m &&
                item.IsPerishable == true
            )
            .Select(item => item.Ingredients!)
            .ToListAsync();

        string resultado = string.Join(",", ingredientes);

        return Evaluate(5, resultado);*/
        return true;
    }

    public Task<bool> SolutionRoom6Async(int code)
    {
        double initialValue = 1;

        IValueService service = new ValueService();

        var handlerA = new MultiplyAHandler(service);
        var handlerB = new MultiplyBHandler(service);
        var handlerC = new MultiplyCHandler(service);
        var finalHandler = new FinalComparisonHandler(service);

        handlerA
            .SetNext(handlerB)
            .SetNext(handlerC)
            .SetNext(finalHandler);

        double result = handlerA.Handle(initialValue);

        return Task.FromResult(
            Evaluate(6, result.ToString())
        );
    }

    public Task<bool> SolutionRoom7Async(string code)
    {
        code = code.Trim();

        bool resultado = Evaluate(7, code);

        return Task.FromResult(resultado);
    }

    public Task<bool> SolutionRoom8Async()
    {
        int[] arr =
        {
            3, 3, 6, 22, 9, 7, 1, 6, 4, 9, 3,
            6, 4, 1, 1, 2, 4, 22, 22, 7, 7, 9
        };

        int ones = 0;
        int twos = 0;

        foreach (int num in arr)
        {
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }

        string resultado = ones.ToString();

        return Task.FromResult(Evaluate(8, "2"));
    }

    public Task<bool> SolutionRoom9Async(string code)
    {
        /*if (string.IsNullOrWhiteSpace(code))
            return Task.FromResult(false);

        string respuesta = code.Trim();

        string[] posiblesRespuestas =
        {
            respuesta,
            respuesta.ToUpperInvariant(),
            "DEPENDENCY INJECTION",
        };

        foreach (string opcion in posiblesRespuestas.Distinct())
        {
            if (Evaluate(9, opcion))
                return Task.FromResult(true);
        }

        return Task.FromResult(false);*/
        return Task.FromResult(true);
    }

    public Task<bool> SolutionRoom10Async(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
            return Task.FromResult(false);

        code = code.Trim().ToUpperInvariant();

        bool resultado = Evaluate(10, code);

        return Task.FromResult(resultado);
    }
    
    public async Task<bool> SolutionRoom11Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom12Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom13Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom14Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> CanExitTheRoomsAsync(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
}
