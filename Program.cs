﻿using System.Text.Json;
 
 // deserialize mario json from file into List<Mario>
 List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
 // deserialize mario json from file into List<Mario>
 List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
 // combine all characters into 1 list
 List<Character> characters = [];
 characters.AddRange(dks);
 characters.AddRange(marios);
 
 // display all characters
// foreach(Character character in characters)
 // {
 //   Console.WriteLine(character.Display());
 // }
 Console.Clear();
 
 // display first character
// Console.WriteLine(characters.First().Display());
 
 // display the first 5 characters
// foreach(Character character in characters.Take(5))
 // {
 //   Console.WriteLine(character.Display());
 // }
 
 // display every character except the first 5
// foreach(Character character in characters.Skip(5))
 // {
 //   Console.WriteLine(character.Display());
 // }
 
 // display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
 // {
 //   Console.WriteLine(character.Display());
 // }
 
 // display last character
// Console.WriteLine(characters.Last().Display());
 
 // first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));
 
 // oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());
 
 // are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
 // Console.WriteLine($"Are there characters created in 1995: {Character1995}");
 // how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
 // which characters were created in 1995
 // which characters were created in 1995 (name & description only)
 // which characters were created in 1995
 // foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
 // {
 //   Console.WriteLine(characterDTO.Display());
 // }
 
 // how many characters in total (all series)?
 // int CharacterCount = characters.Count();
 // Console.WriteLine($"There are {CharacterCount} characters in all series");
 // how many characters appear in the Mario series?
 // int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
 // Console.WriteLine($"There are {MarioCount} characters in the Mario series");
 // how many characters appear in the Donkey Kong series?
 //int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
 //Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
 // how many characters appear in the Mario & Donkey Kong series?
 //int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
 //Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
 // which characters (name only) appear in Mario and Donkey Kong?
 //foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
 //{
  // Console.WriteLine($"\t{name}");
 //}
 // how many characters appear in Donkey Kong and not in Mario?
 //int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
 //Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");
 // foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
 //   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
 // }
 
 // how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
 // which characters have the longest name?
 //foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
 //  Console.WriteLine($"\t{name}");
// }

 // all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
 //foreach(var characterByYearCreated in CharactersByYearCreated)
 //{
 //Console.WriteLine(characterByYearCreated.Key);
  // foreach(var character in characterByYearCreated) {
     //Console.WriteLine($"\t{character.Name}");
  // }
 //}
Console.WriteLine("___________________________________________________");
 //1.19a
 Console.WriteLine($"Characters created in 1981: {characters.Count(c => c.YearCreated == 1981)}");

 //1.19b
  foreach (var c in characters.Where(c => c.YearCreated == 1981).Select(c => new { c.Name }))
        {
            Console.WriteLine($"{c.Name} ");
        }

//1.19c
 Console.WriteLine($"Characters created in 1981 (Mario series): {characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Mario"))}");

//1.19d
 foreach (var c in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name))
        {
            Console.WriteLine(c);
        }


//1.19e
  Console.WriteLine($"Characters created in 1981 (Donkey Kong series): {characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong"))}");

  //1.19f
  foreach (var c in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name))
        {
            Console.WriteLine(c);
        }

  //1.20

   Console.WriteLine($"Characters first appeared in Donkey Kong 64: {characters.Count(c => c.FirstAppearance == "Donkey Kong 64")}");

   //1.20b
   foreach (var c in characters.Where(c => c.FirstAppearance == "Donkey Kong 64").Select(c => c.Name))
{
    Console.WriteLine(c);
}

//1.21
bool anyNoAlias = characters.Any(c => !c.Alias.Any());
Console.WriteLine($"Any characters without alias: {anyNoAlias}");

// 1.21b Count characters with no alias (all series)
Console.WriteLine($"Characters without alias: {characters.Count(c => !c.Alias.Any())}");

// 1.21c List characters with no alias (all series) - return Name, Alias (empty), and Series
foreach (var c in characters.Where(c => !c.Alias.Any()).Select(c => new { c.Name, Alias = "None", c.Series }))
{
    Console.WriteLine($"{c.Name} - {c.Alias} - {string.Join(", ", c.Series)}");
}

// 1.21d 
bool anyMarioNoAlias = characters.Any(c => c.Series.Contains("Mario") && !c.Alias.Any());
Console.WriteLine($"Any characters without alias (Mario series): {anyMarioNoAlias}");

// 1.21e 
Console.WriteLine($"Characters without alias (Mario series): {characters.Count(c => c.Series.Contains("Mario") && !c.Alias.Any())}");

// 1.21f 
foreach (var c in characters.Where(c => c.Series.Contains("Mario") && !c.Alias.Any()).Select(c => new { c.Name, Alias = "None" }))
{
    Console.WriteLine($"{c.Name} - {c.Alias}");
}

// 1.21g 
bool anyDKNoAlias = characters.Any(c => c.Series.Contains("Donkey Kong") && !c.Alias.Any());
Console.WriteLine($"Any characters without alias (Donkey Kong series): {anyDKNoAlias}");

// 1.21h 
Console.WriteLine($"Characters without alias (Donkey Kong series): {characters.Count(c => c.Series.Contains("Donkey Kong") && !c.Alias.Any())}");

// 1.21i 
foreach (var c in characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Alias.Any()).Select(c => new { c.Name, Alias = "None" }))
{
    Console.WriteLine($"{c.Name} - {c.Alias}");
}

//1.22
bool hasSnowmadKingAlias = characters.Any(c => c.Alias.Contains("Snowmad King"));
Console.WriteLine($"Any character with alias 'Snowmad King': {hasSnowmadKingAlias}");
//1.22b
foreach (var c in characters.Where(c => c.Alias.Contains("Snowmad King")).Select(c => new { c.Name, Alias = "Snowmad King" }))
{
    Console.WriteLine($"{c.Name} - {c.Alias}");
}
//1.24?

 Console.WriteLine($"Characters with species 'Kremling': {characters.Count(c => c.Species == "Kremling")}");

 //1.24b
  foreach (var c in characters.Where(c => c.Species == "Kremling").Select(c => c.Name))
        {
            Console.WriteLine(c);
        }

//1.25
 Console.WriteLine($"Human characters in Mario series: {characters.Count(c => c.Series.Contains("Mario") && c.Species == "Human")}");

 //1.25b
 foreach (var c in characters.Where(c => c.Series.Contains("Mario") && c.Species == "Human").Select(c => c.Name))
        {
            Console.WriteLine(c);
        }

//1.26
        foreach (var c in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Species != "Human" && c.Species != "Kong").Select(c => new { c.Name, c.Species }))
        {
            Console.WriteLine($"{c.Name} - {c.Species}");
        }
    