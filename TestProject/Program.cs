// int i = 0;
// do {
//     Console.WriteLine(i);
//     i++;
// } while (i < 5);

// float a = 0;

// switch (a)
// {
//   case true:
//     Console.WriteLine("One");
//     break;
//   default:
//     Console.WriteLine("Invalid input");
//     break;
// }


// using System;

// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6)
// {
//   RandomizeAnimals();
//   string[,] group = AssignGroup(groups);
//   Console.WriteLine(schoolName);
//   PrintGroup(group);
// }

// void RandomizeAnimals()
// {
//   Random random = new Random();

//   for (int i=0; i< pettingZoo.Length; i++)
//   {
//     int r = random.Next(i, pettingZoo.Length);
  
//     string temp = pettingZoo[i];
//     pettingZoo[i] = pettingZoo[r];
//     pettingZoo[r] = temp;
//   }
// }

// string[,] AssignGroup(int groups = 6)
// {
//   string[,] result = new string[groups, pettingZoo.Length / groups];
//   int start = 0;

//   for (int i=0; i<groups; i++)
//   {
//     for (int j=0; j<pettingZoo.Length/groups; j++)
//     {
//       result[i, j] = pettingZoo[start++];
//     }
//   }
  
//   return result;
// }

// void PrintGroup(string[,] group)
// {
//   for (int i=0; i<group.GetLength(0); i++)
//   {
//     Console.Write($"Group {i+1}: ");
//     for (int j=0; j<group.GetLength(1); j++)
//     {
//       Console.Write($"{group[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }


// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//   PlayGame();
// }

// void PlayGame() 
// {
//   var play = true;

//   while (play) 
//   {
//     var target = GetTarget();
//     var roll = RollDice();

//     Console.WriteLine($"Roll a number greater than {target} to win!");
//     Console.WriteLine($"You rolled a {roll}");
//     Console.WriteLine(WinOrLose(roll, target));
//     Console.WriteLine("\nPlay again? (Y/N)");

//     play = ShouldPlay();
//   }
// }

// bool ShouldPlay()
// {
//   string input = Console.ReadLine();
//   return input.Trim().ToUpper().Equals("Y");
// }

// int GetTarget()
// {
//   return random.Next(1, 6);
// }

// int RollDice()
// {
//   return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target)
// {
//   return roll > target ? "You win!" : "You lose!";
// }

// int target = 80;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// // int[] result = TwoCoins(coins, target);
// int[,] result = TwoCoins(coins, target);

// int[,] TwoCoins(int[] coins, int target) 
// {
//   int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//   int count = 0;

//   for (int curr = 0; curr < coins.Length; curr++)
//   {
//     for (int next = curr + 1; next < coins.Length; next++)
//     {
//       if (coins[curr] + coins[next] == target)
//       {
//         result[count, 0] = curr;
//         result[count, 1] = next;
//         count++;
//       }
//       if (count == result.GetLength(0))
//         return result;
//     }
//   }
  
//   return (count == 0) ? new int[0,0] : result;
// }

// int[] TwoCoins(int[] coins, int target) 
// {
//   for (int curr = 0; curr < coins.Length; curr++)
//   {
//     for (int next = curr + 1; next < coins.Length; next++)
//     {
//       if (coins[curr] + coins[next] == target)
//         return new int[] {curr, next};
//     }
//   }
//   return  new int[0];
// }

// if (result.Length == 0)
//   Console.WriteLine("No solution found");
// else
// {
//   Console.WriteLine("Change found at positions:");
//   for (int i=0; i<result.GetLength(0); i++)
//   {
//     if (result[i, 0] == -1)
//       break;

//     Console.WriteLine($"{result[i, 0]}, {result[i, 1]}");
//   }
// }


// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word)
// {
//   int start = 0;
//   int end = word.Length-1;

//   while (start < end)
//   {
//     if (word[start] != word[end])
//       return false;
    
//     start++;
//     end--;
//   }
  
//   return true;
// }


// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseWord(string word)
// {
//   string result = "";

//   for (int i=word.Length-1; i>=0; i--)
//   {
//     result += word[i];
//   }

//   return result;
// }

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach (string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }


// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// double VndToUsd(int vnd)
// {
//   double rate = 23500;
//   return vnd / rate;
// }

// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int)(rate * usd);
// }


// using System.Security.Principal;

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i=0; i<items.Length; i++)
// {
//   total += GetDiscountedPrice(i);
// }

// // if (TotalMeetsMinimum())
// //   total -= 5.00;

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     // double result = items[itemIndex] * (1 - discounts[itemIndex]);
//     // return result;
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }


// void Update();

// int[] GetEnemyCoordinates(string enemyId);
// int[] GetDistanceFromHero(string enemyId);
// int[] GetHeroCoordinates();

// bool EnemyCanHitHero(string enemyId);
// int GetEnemyDamageOutput(string enemyId);
// void UpdateHeroHP(int damage);


// string[,] corporate = 
// 	{
// 		{"Robert", "Bavin"}, {"Simon", "Bright"},
// 		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
// 		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

// 	string[,] external = 
// 	{
// 		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
// 		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
// 	};

// 	string externalDomain = "hayworth.com";

// 	for (int i = 0; i < corporate.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// 	}

// 	for (int i = 0; i < external.GetLength(0); i++) 
// 	{
// 		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// 	}

// 	void DisplayEmail(string first, string last, string domain = "contoso.com") 
// 	{
// 		string email = first.Substring(0, 2) + last;
// 		email = email.ToLower();
// 		Console.WriteLine($"{email}@{domain}");
// 	}


// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// // RSVP("Rebecca", 1, "none", true);
// // RSVP("Nadia", 2, "Nuts", true);
// // // RSVP("Linh", 2, "none", false);
// // RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
// // // RSVP("Tony", 1, "Jackfruit", true);
// // RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
// // RSVP("Noor", 4, "none", false);
// // RSVP("Jonte", 2, "Stone fruit", false);

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
// {
//     if (inviteOnly)
//     {
//       bool found = false;
//       foreach (string guest in guestList)
//       {
//         if (guest.Equals(name))
//         {
//           found = true;
//           break;
//         }
//       }
//       if (!found)
//       {
//         Console.WriteLine($"Sorry, {name} is not on the guest list");
//         return;
//       }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }


// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }


// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }


// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }


// double pi = 3.14159;

// // PrintCircleArea(12);
// // PrintCircleCircumference(12);

// PrintCircleInfo(12);

// void PrintCircleInfo(int radius)
// {
//   Console.WriteLine($"Circle with radius {radius}");
//   PrintCircleArea(radius);
//   PrintCircleCircumference(radius);
// }

// void PrintCircleArea(int radius)
// {
//   double area = pi * (radius * radius);
//   Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//   double circumference = 2 * pi * radius;
//   Console.WriteLine($"Circumference = {circumference}");
// }


// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }


// using System.ComponentModel;

// int[] schedule = {800, 1200, 1600, 2000};
// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//   int difference = 0;

//   if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     Console.WriteLine("Invalid GMT");
  
//   else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     difference = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//   else
//     difference = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//   for (int i = 0; i < times.Length; i++)
//   {
//     int newTime = ((times[i] + difference)) % 2400;
//     Console.WriteLine($"{times[i]} -> {newTime}");
//   }
// }


// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLenght = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input)
// {
//   address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
//   ValidateLenght();
//   ValidateZeroes();
//   ValidateRange();

//   if (validLenght && validZeroes && validRange) 
//   {
//       Console.WriteLine($"{ip} is a valid IPv4 address");
//   } 
//   else 
//   {
//       Console.WriteLine($"{ip} is an invalid IPv4 address");
//   }
// }

// void ValidateLenght()
// {
//   validLenght = address.Length == 4;
// }

// void ValidateZeroes()
// {
//   foreach (string number in address)
//   {
//     if (number.Length > 1 && number.StartsWith("0"))
//     {
//       validZeroes = false;
//       return;
//     }
    
//   }

//   validZeroes = true;
// }

// void ValidateRange()
// {
//   foreach (string number in address)
//   {
//     int value = int.Parse(number);
//     if (value < 0 || value > 255)
//     {
//       validRange = false;
//       return;
//     }
//   }

//   validRange = true;
// }


// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine();

// // Methods

// void DisplayTimes()
// {
//   /* Format and display medicine times */
//   foreach (int val in times)
//   {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//       time = time.Insert(len - 2, ":");

//     else if (len == 2)
//       time = time.Insert(0, "0:");
    
//     else
//       time = time.Insert(0, "0:0");

//     Console.Write($"{time} ");
//   }

//   Console.WriteLine();
// }

// void AdjustTimes()
// {
//   for (int i=0; i < times.Length; i++)
//   {
//     times[i] = ((times[i] + diff)) % 2400;
//   }
// }

//


// void DisplayRandomNumber()
// {
//   Random random = new Random();
//   // int number = random.Next(1, 101);
//   // Console.WriteLine($"Number generated by method: {number}");
//   for (int i=0; i < 5; i++)
//   {
//     Console.Write($"{random.Next(1, 100)} ");
//   }
//   Console.WriteLine();
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumber();


// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here
// const string openSpan = "<span>";
// const string closeSpan = "</span>";
// const string openDiv = "<div>";
// const string closeDiv = "</div>";

// int openingPosition = input.IndexOf(openSpan);
// int closingPosition = input.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// quantity = input.Substring(openingPosition, length);

// Console.WriteLine($"Quantity: {quantity}");

// openingPosition = input.IndexOf(openDiv);
// closingPosition = input.IndexOf(closeDiv);

// openingPosition += openDiv.Length;
// length = closingPosition - openingPosition;
// output = input.Substring(openingPosition, length);
// output = output.Replace("&trade;", "&reg;");

// Console.WriteLine($"Output: {output}");


// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);


// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);


// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }


// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");


// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }


// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition++;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// using System.Diagnostics.CodeAnalysis;

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here
// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently you own {currentShares:N0} shares at a return of {currentReturn:P2}.\n");
// Console.WriteLine($"Our new product, {newProduct}, offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n");
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10) + String.Format("{0:C}", currentProfit).PadRight(20) + "\n";
// comparisonMessage += newProduct.PadRight(20) + String.Format("{0:P}", newReturn).PadRight(10) + String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);


// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);


// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));


// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"  Shares: {productShares:N3} Product");
// Console.WriteLine($"    Sub Total: {subtotal:C}");
// Console.WriteLine($"        Tax: {taxPercentage:P2}");
// Console.WriteLine($"    Total Billed: {total:C}");


// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount);

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orderIDs = orderStream.Split(',');
// Array.Sort(orderIDs);

// foreach (string orderID in orderIDs)
// {
//     Console.Write(orderID);
//     if (orderID.Length != 4)
//       Console.WriteLine("\t- Error");
//     else
//       Console.WriteLine();
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(' ');

// for (int i=0; i < words.Length; i++)
// {
//   char[] wordArray = words[i].ToCharArray();
//   Array.Reverse(wordArray);
//   words[i] = new string(wordArray);
// }

// string result = String.Join(" ", words);
// Console.WriteLine(result);

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// int result1;
// decimal result2;
// float result3;


// result1 = value1 / Convert.ToInt32(value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string message = "";
// decimal total = 0m;

// foreach (string value in values)
// {
//   if (decimal.TryParse(value, out decimal number))
//     total += number;
//   else
//     message += value;
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine("Unable to report the measurement.");
// }
// if (result < 0)
//   Console.WriteLine($"Measurements (w/ offset): {50 + result}");

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int[] data = new int[5];

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }
 
//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }

// string[] roleNames = ["administrator", "manager", "user"];
// string? userInput;
// bool validRole = false;


// while (validRole == false)
// {
//   Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//   userInput = Console.ReadLine();
//   if (userInput != null)
//   {
//     string userInputRole = userInput.Trim().ToLower();
//     if (roleNames.Contains(userInputRole))
//     {
//       Console.WriteLine($"Your input value ({userInput}) has been accepted.");
//       validRole = true;
//     }
//     else
//     {
//       Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid.");
//     }
//   }
// }

// string? userInput;
// bool numberValid = false;

// Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {
//   userInput = Console.ReadLine();
//   if (int.TryParse(userInput, out int number))
//   {
//     if (number >= 5 && number <= 10)
//     {
//       Console.WriteLine($"Your input value ({number}) has been accepted.");
//       numberValid = true;
//       break;
//     }
//     else
//     {
//       Console.WriteLine($"You entered {number}. Please enter a valid number between 5 and 10");
//     }
//   }
//   else
//   {
//     Console.WriteLine("Sorry, you entered an invalid number, please try again");
//   }
// }
// while(numberValid == false);

// int hero = 10;
// int monster = 10;
// Random random = new Random();

// while (hero > 0 && monster > 0)
// {
//   int heroDamage = random.Next(1, 11);
//   int monsterDamage = random.Next(1, 11);

//   // Hero attack
//   monster -= heroDamage;
//   Console.WriteLine($"Monster was damaged and lost {heroDamage} health. Monster health: {monster}");

//   if (monster > 0)
//   {
//     // Monster attack
//     hero -= monsterDamage;
//     Console.WriteLine($"Hero was damaged and lost {monsterDamage} health. Hero health: {hero}");
//   }

//   if (hero <= 0)
//     Console.WriteLine("Monster Wins!");
//   else if (monster <= 0)
//     Console.WriteLine("Hero Wins!");
  
// }

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// Random random = new Random();
// int current = random.Next(1, 11);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// Fizz Buzz

// for (int i=1; i <= 100; i++)
// {
//   if (i % 3 == 0 && i % 5 == 0)
//   {
//     Console.WriteLine($"{i} - FizzBuzz");
//   }
//   else if (i % 3 == 0)
//   {
//     Console.WriteLine($"{i} - Fizz");
//   }
//   else if (i % 5 == 0)
//   {
//     Console.WriteLine($"{i} - Buzz");
//   }
//   else
//   {
//     Console.WriteLine(i);
//   }
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One size fits all";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         // title = "Junior Associate";
//         // break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//   total += number;

//   if (number == 42)
//     found = true;
// }

// if (found) 
//   Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");

// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

// bool flag = true;
// if (flag)
//   Console.WriteLine(flag);

// bool flag = true;
// int value = 0;
// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }
// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// string permission = "Admin|Manager";
// int level = 58;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// string side = flip == 0 ? "heads" : "tails";
// Console.WriteLine($"You flipped a coin and it landed on {side}.");

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// /*
//    This code reverses a message, counts the number of times 
//    a particular character appears, then prints the results
//    to the console window.
// */

// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message) 
// { 
//   if (letter == 'o')
//   { 
//     letterCount++; 
//   }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// // Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// // Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
  // Random random = new Random();
  // string[] orderIDs = new string[5];

  // for (int i = 0; i < orderIDs.Length; i++)
  // {
  //     int prefixValue = random.Next(65, 70);
  //     string prefix = Convert.ToChar(prefixValue).ToString();
  //     string suffix = random.Next(1, 1000).ToString("000");
  //     orderIDs[i] = prefix + suffix;
  // }

  // foreach (var orderID in orderIDs)
  // {
  //     Console.WriteLine(orderID);
  // }

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

// string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

// foreach (string ID in orderIDs)
// {
//     if (ID.StartsWith('B'))
//     {
//         Console.WriteLine(ID);
//     }
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else
// {
//     if (daysUntilExpiration == 1)
//     {
//         discountPercentage = 20;
//         Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
//     }
//     else if (daysUntilExpiration <= 5)
//     {
//         discountPercentage = 10;
//         Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
//     }
//     else if (daysUntilExpiration <= 10)
//     {
//         Console.WriteLine("Your subscription will expire soon. Renew now!");
//     }
// }


// Your code goes here

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
// {
//     if ((roll1 == roll2 && roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }

//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
//     Console.WriteLine($"Total: {total}");
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine($"Diceroll:{roll}");

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);