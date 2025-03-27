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
 int CharacterCount = characters.Count();
 Console.WriteLine($"There are {CharacterCount} characters in all series");
 // how many characters appear in the Mario series?
 int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
 Console.WriteLine($"There are {MarioCount} characters in the Mario series");
 // how many characters appear in the Donkey Kong series?
 int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
 Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
 // how many characters appear in the Mario & Donkey Kong series?
 int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
 Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
 // which characters (name only) appear in Mario and Donkey Kong?
 foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
 {
   Console.WriteLine($"\t{name}");
 }