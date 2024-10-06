public class PromptGenerator
{
    private string[] prompts =
    {
        "What happened that you never want to forget?",
        "Did you behave in a way you didn't like and what can you change?",
        "What was one success you had today? How will you keep succeding?",
        "What was one challange you faced today and how did you overcome it?",
        "Draw or paint for 5 minutes and record how you feel here. Does the creative process help end your day?",
        "Write a short poem about your day.",
    };
     

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}
