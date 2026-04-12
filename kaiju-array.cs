// A short list of tasks for anyone unlucky enough to be on kaiju duty
string[] sideQuests =
{
    "Avoid the kaiju while scouting the city for food",
    "Study their movement patterns to uncover weaknesses",
    "Figure out how to actually defeat one without getting flattened, roasted, or eaten",
    "Locate the kaiju's resting place before it goes on another rampage"
};

// Display each quest
foreach (string quest in sideQuests)
{
    Console.WriteLine($"- {quest}");
}
